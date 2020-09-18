﻿/*
 * Copyright 2020 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaData
 * Summary  : Represents a mechanism to read and write trend tables
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2020
 * Modified : 2020
 */

using Scada.Data.Models;
using Scada.Data.Tables;
using System;
using System.IO;
using System.Text;
using static Scada.BinaryConverter;

namespace Scada.Data.Adapters
{
    /// <summary>
    /// Represents a mechanism to read and write trend tables.
    /// <para>Представляет механизм для чтения и записи таблиц трендов.</para>
    /// </summary>
    public class TrendTableAdapter : Adapter
    {
        /// <summary>
        /// The major version number.
        /// </summary>
        protected const ushort MajorVersion = 1;
        /// <summary>
        /// The minor version number.
        /// </summary>
        protected const ushort MinorVersion = 0;
        /// <summary>
        /// The header size in a file.
        /// </summary>
        protected const int HeaderSize = 50;


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public TrendTableAdapter()
            : base()
        {
            ParentDirectory = null;
            ArchiveCode = "";
            CnlNumCache = null;
        }


        /// <summary>
        /// Hides the FileName property.
        /// </summary>
        private new string FileName { get; set; }

        /// <summary>
        /// Hides the Stream property.
        /// </summary>
        private new Stream Stream { get; set; }

        /// <summary>
        /// Gets or sets the parent directory of the table.
        /// </summary>
        public string ParentDirectory { get; set; }

        /// <summary>
        /// Gets or sets the archive code.
        /// </summary>
        public string ArchiveCode { get; set;  }

        /// <summary>
        /// Gets or sets the cache containing lists of channel numbers accessed by list IDs.
        /// </summary>
        public MemoryCache<long, CnlNumList> CnlNumCache { get; set; }


        /// <summary>
        /// Reads metadata using the specified reader.
        /// </summary>
        protected TrendTableMeta ReadMetadata(BinaryReader reader, byte[] buffer)
        {
            int bytesRead = reader.Read(buffer, 0, HeaderSize);

            if (bytesRead == 0) // table is empty
            {
                return null;
            }
            else
            {
                if (bytesRead < HeaderSize)
                    throw new ScadaException("Unexpected end of stream.");

                int index = 0;
                if (GetUInt16(buffer, ref index) != TableType.TrendTable)
                    throw new ScadaException("Invalid table type.");

                if (GetUInt16(buffer, ref index) != MajorVersion)
                    throw new ScadaException("Incompatible format version.");

                index += 2; // skip minor version
                return new TrendTableMeta
                {
                    MinTimestamp = GetTime(buffer, ref index),
                    MaxTimestamp = GetTime(buffer, ref index),
                    WritingPeriod = GetInt32(buffer, ref index),
                    PageCapacity = GetInt32(buffer, ref index)
                };
            }
        }

        /// <summary>
        /// Reads metadata from the file.
        /// </summary>
        protected TrendTableMeta ReadMetadata(string fileName, byte[] buffer)
        {
            if (!File.Exists(FileName))
                return null;

            using (FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, false))
                {
                    return ReadMetadata(reader, buffer);
                }
            }
        }

        /// <summary>
        /// Writes the metadata using the specified writer.
        /// </summary>
        protected void WriteMetadata(BinaryWriter writer, TrendTableMeta meta)
        {
            writer.Write(TableType.TrendTable);
            writer.Write(MajorVersion);
            writer.Write(MinorVersion);
            writer.Write(meta.MinTimestamp.Ticks);
            writer.Write(meta.MaxTimestamp.Ticks);
            writer.Write(meta.WritingPeriod);
            writer.Write(meta.PageCapacity);
            writer.Write(ReserveBuffer, 0, 20);
        }

        /// <summary>
        /// Writes the metadata to the file.
        /// </summary>
        protected void WriteMetadata(string fileName, TrendTableMeta meta)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FileName));

            using (FileStream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                using (BinaryWriter writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    WriteMetadata(writer, meta);
                }
            }
        }

        /// <summary>
        /// Reads channel numbers.
        /// </summary>
        protected CnlNumList ReadCnlNums(BinaryReader reader, bool useCache)
        {
            long listID = reader.ReadInt64();
            CnlNumList cnlNumList = useCache && CnlNumCache != null ? CnlNumCache.Get(listID) : null;

            if (cnlNumList == null)
            {
                int cnlCnt = reader.ReadInt32();
                int bufferLength = cnlCnt * 4 + 4;
                byte[] buffer = new byte[bufferLength];
                ReadData(reader, buffer, 0, bufferLength, true);
                uint crc = BitConverter.ToUInt32(buffer, bufferLength - 4);

                if (ScadaUtils.CRC32(buffer, 0, bufferLength - 4) != crc)
                    throw new ScadaException("Channel list CRC error.");

                int[] cnlNums = new int[cnlCnt];
                Buffer.BlockCopy(buffer, 0, cnlNums, 0, bufferLength);
                cnlNumList = new CnlNumList(listID, cnlNums, crc);

                if (useCache && CnlNumCache != null)
                    CnlNumCache.Add(listID, cnlNumList);
            }

            return cnlNumList;
        }

        /// <summary>
        /// Writes the channel numbers.
        /// </summary>
        protected void WriteCnlNums(BinaryWriter writer, CnlNumList cnlNumList)
        {
            int bufferLength = cnlNumList.CnlNums.Length * 4 + 16;
            byte[] buffer = new byte[bufferLength];

            int index = 0;
            CopyInt64(cnlNumList.ListID, buffer, ref index);
            CopyIntArray(cnlNumList.CnlNums, buffer, ref index);
            CopyInt32((int)cnlNumList.CRC, buffer, ref index);
            writer.Write(buffer, 0, bufferLength);
        }

        /// <summary>
        /// Allocates a new page on disk.
        /// </summary>
        protected void AllocateNewPage(Stream stream, BinaryWriter writer, TrendTablePage page)
        {
            if (page.Metadata == null)
                throw new ScadaException("Page metadata must not be null.");

            if (page.CnlNumList == null)
                throw new ScadaException("Page channel numbers must not be null.");

            int capacity = page.Metadata.PageCapacity;
            int cnlCnt = page.CnlNumList.CnlNums.Length;
            long flagsPosition = HeaderSize + cnlCnt * 4 + 16;
            long pageSize = flagsPosition + capacity * (cnlCnt * 10 + 1);
            stream.SetLength(pageSize);
            WriteMetadata(writer, page.Metadata);
            WriteCnlNums(writer, page.CnlNumList);
            writer.Write(new byte[capacity], 0, capacity); // data availability flags
        }


        /// <summary>
        /// Reads metadata from the file.
        /// </summary>
        public TrendTableMeta ReadMetadata(string fileName)
        {
            return File.Exists(FileName) ? ReadMetadata(fileName, new byte[HeaderSize]) : null;
        }

        /// <summary>
        /// Reads channel numbers.
        /// </summary>
        public CnlNumList ReadCnlNums(string fileName)
        {
            if (!File.Exists(FileName))
                return null;

            using (FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, false))
                {
                    stream.Position = HeaderSize;
                    return ReadCnlNums(reader, false);
                }
            }
        }

        /// <summary>
        /// Writes the specified slice to the trend table.
        /// </summary>
        public void WriteSlice(TrendTable trendTable, Slice slice)
        {
            if (trendTable == null)
                throw new ArgumentNullException("trendTable");

            if (slice == null)
                throw new ArgumentNullException("slice");

            // validate table date
            DateTime tableDate = trendTable.TableDate;

            if (tableDate == DateTime.MinValue)
                tableDate = slice.Timestamp.Date;
            else if (tableDate != slice.Timestamp.Date)
                throw new ScadaException("Table date mismatch.");

            // make table ready
            byte[] buffer = new byte[HeaderSize];

            if (!trendTable.IsReady)
            {
                string metaFileName = Path.Combine(ParentDirectory, 
                    GetTableDirectory(ArchiveCode, tableDate), GetMetaFileName(ArchiveCode, tableDate));
                TrendTableMeta tableMeta = ReadMetadata(metaFileName, buffer);

                if (trendTable.Metadata == null)
                {
                    if (tableMeta == null)
                        throw new ScadaException("Unable to get table metadata.");
                    else
                        trendTable.SetMetadata(tableMeta);
                }
                else
                {
                    if (tableMeta == null)
                        WriteMetadata(metaFileName, trendTable.Metadata);
                    else if (!trendTable.Metadata.Equals(tableMeta))
                        throw new ScadaException("Invalid table metadata.");
                }

                trendTable.IsReady = true;
            }

            // get page for writing
            if (trendTable.GetDataPosition(slice.Timestamp, out TrendTablePage page, out int indexWithinPage))
            {
                Stream stream = null;
                BinaryReader reader = null;
                BinaryWriter writer = null;

                try
                {
                    string pageFileName = GetPagePath(page);
                    stream = new FileStream(pageFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    reader = new BinaryReader(stream, Encoding.UTF8, false);
                    writer = new BinaryWriter(stream, Encoding.UTF8, false);

                    // make page ready
                    if (!page.IsReady)
                    {
                        TrendTableMeta pageMeta = ReadMetadata(reader, buffer);

                        if (pageMeta == null)
                        {
                            page.CnlNumList = trendTable.CnlNumList;
                            AllocateNewPage(stream, writer, page);
                        }
                        else if (page.Metadata.Equals(pageMeta))
                        {
                            page.CnlNumList = ReadCnlNums(reader, true);
                        }
                        else
                        {
                            throw new ScadaException("Invalid page metadata.");
                        }

                        trendTable.IsReady = true;
                    }

                    if (page.Metadata == null)
                        throw new ScadaException("Page metadata must not be null.");

                    if (page.CnlNumList == null)
                        throw new ScadaException("Page channel numbers must not be null.");

                    // write data availability flag
                    long flagsPosition = HeaderSize + page.CnlNumList.CnlNums.Length * 4 + 16;
                    stream.Position = flagsPosition + indexWithinPage;
                    writer.Write(true);

                    // write channel data
                    int pageCapacity = page.Metadata.PageCapacity;
                    long dataPosition = flagsPosition + pageCapacity;

                    void WriteCnlData(int cnlIndex, CnlData cnlData)
                    {
                        stream.Position = dataPosition + 10 * (pageCapacity * cnlIndex + indexWithinPage);
                        writer.Write(cnlData.Val);
                        writer.Write((ushort)cnlData.Stat);
                    }

                    if (slice.CnlNums == page.CnlNumList.CnlNums)
                    {
                        for (int i = 0, cnlCnt = slice.CnlNums.Length; i < cnlCnt; i++)
                        {
                            WriteCnlData(i, slice.CnlData[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0, cnlCnt = slice.CnlNums.Length; i < cnlCnt; i++)
                        {
                            if (page.CnlNumList.CnlIndices.TryGetValue(slice.CnlNums[i], out int cnlIndex))
                                WriteCnlData(cnlIndex, slice.CnlData[i]);
                        }
                    }
                }
                finally
                {
                    reader?.Close();
                    writer?.Close();
                }
            }
            else
            {
                throw new ScadaException("Failed to get data position.");
            }
        }

        /// <summary>
        /// Writes the input channel data to the trend table.
        /// </summary>
        public void WriteCnlData(TrendTable trendTable, int cnlNum, DateTime timestamp, CnlData cnlData)
        {
            if (trendTable == null)
                throw new ArgumentNullException("trendTable");
        }

        /// <summary>
        /// Updates the table structure on disk according to the specified table and copies the existing table data.
        /// </summary>
        public void UpdateTableStructure(TrendTable trendTable)
        {
            if (trendTable == null)
                throw new ArgumentNullException("trendTable");

            if (trendTable.Metadata == null)
                throw new ScadaException("Table metadata must not be null.");

            //WriteMetadata(metaFileName, trendTable.Metadata);
        }

        /// <summary>
        /// Updates the page structure on disk according to the specified page and copies the existing page data.
        /// </summary>
        public void UpdatePageStructure(TrendTablePage page)
        {

        }

        /// <summary>
        /// Gets the full path of the trend table.
        /// </summary>
        protected string GetTablePath(TrendTable trendTable)
        {
            if (trendTable == null)
                throw new ArgumentNullException("trendTable");

            if (string.IsNullOrEmpty(ParentDirectory) || string.IsNullOrEmpty(ArchiveCode))
                throw new ScadaException("Failed to get the trend table path.");

            return Path.Combine(ParentDirectory, GetTableDirectory(ArchiveCode, trendTable.TableDate));
        }

        /// <summary>
        /// Gets the full path of the metadata file.
        /// </summary>
        public string GetMetaPath(TrendTable trendTable)
        {
            return Path.Combine(GetTablePath(trendTable), GetMetaFileName(ArchiveCode, trendTable.TableDate));
        }

        /// <summary>
        /// Gets the full path of the page file.
        /// </summary>
        public string GetPagePath(TrendTablePage page)
        {
            if (page == null)
                throw new ArgumentNullException("page");

            return Path.Combine(GetTablePath(page.TrendTable), 
                GetPageFileName(ArchiveCode, page.TrendTable.TableDate, page.PageNumber));
        }

        /// <summary>
        /// Gets the trend table directory corresponding to the specified archive and date.
        /// </summary>
        public static string GetTableDirectory(string archiveCode, DateTime tableDate)
        {
            return archiveCode + tableDate.ToString("yyyyMMdd");
        }

        /// <summary>
        /// Gets the metadata file name corresponding to the specified archive and date.
        /// </summary>
        public static string GetMetaFileName(string archiveCode, DateTime tableDate)
        {
            return archiveCode.ToLowerInvariant() + tableDate.ToString("yyyyMMdd") + "_meta.dat";
        }

        /// <summary>
        /// Gets the page file name corresponding to the specified archive, date and page number.
        /// </summary>
        public static string GetPageFileName(string archiveCode, DateTime tableDate, int pageNumber)
        {
            return archiveCode.ToLowerInvariant() + tableDate.ToString("yyyyMMdd") + 
                "_" + pageNumber.ToString("D4") + ".dat";
        }
    }
}
