﻿/*
 * Copyright 2022 Rapid Software LLC
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
 * Module   : ScadaServerCommon
 * Summary  : Represents the base class for historical data archive logic
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2020
 * Modified : 2021
 */

using Scada.Data.Models;
using Scada.Server.Config;
using System;
using System.Collections.Generic;

namespace Scada.Server.Archives
{
    /// <summary>
    /// Represents the base class for historical data archive logic.
    /// <para>Представляет базовый класс логики архива исторических данных.</para>
    /// </summary>
    public abstract class HistoricalArchiveLogic : ArchiveLogic
    {
        /// <summary>
        /// Represents a method that determines whether two CnlData instances are the same.
        /// </summary>
        protected delegate bool CnlDataEqualsDelegate(CnlData x, CnlData y);


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public HistoricalArchiveLogic(IArchiveContext archiveContext, ArchiveConfig archiveConfig, int[] cnlNums)
            : base(archiveContext, archiveConfig, cnlNums)
        {
        }


        /// <summary>
        /// Gets the archive options.
        /// </summary>
        protected virtual HistoricalArchiveOptions2 ArchiveOptions => null;


        /// <summary>
        /// Gets the trends one by one and merges them.
        /// </summary>
        protected TrendBundle MergeTrends(TimeRange timeRange, int[] cnlNums)
        {
            int cnlCnt = cnlNums.Length;
            Trend[] trends = new Trend[cnlCnt];

            for (int i = 0; i < cnlCnt; i++)
            {
                trends[i] = GetTrend(timeRange, cnlNums[i]);
            }

            return TrendHelper.MergeTrends(trends);
        }

        /// <summary>
        /// Determines whether two CnlData instances are the same.
        /// </summary>
        protected bool CnlDataEquals1(CnlData x, CnlData y)
        {
            return x == y;
        }

        /// <summary>
        /// Determines whether two CnlData instances are considered the same, 
        /// comparing absolute values and taking into account a deadband.
        /// </summary>
        protected bool CnlDataEquals2(CnlData x, CnlData y)
        {
            return ArchiveOptions != null && x.Stat == y.Stat && (
                x.Val.Equals(y.Val) || 
                Math.Abs(x.Val - y.Val) <= ArchiveOptions.Deadband);
        }

        /// <summary>
        /// Determines whether two CnlData instances are considered the same,
        /// comparing the ratio of values and taking into account a deadband.
        /// </summary>
        protected bool CnlDataEquals3(CnlData x, CnlData y)
        {
            return ArchiveOptions != null && x.Stat == y.Stat && (
                x.Val.Equals(y.Val) ||
                x.Val != 0 && Math.Abs((x.Val - y.Val) / x.Val / 100) <= ArchiveOptions.Deadband);
        }

        /// <summary>
        /// Selects a method for comparing channel data depending on the archive options.
        /// </summary>
        protected CnlDataEqualsDelegate SelectCnlDataEquals()
        {
            if (ArchiveOptions == null)
                throw new InvalidOperationException("ArchiveOptions must not be null.");

            if (ArchiveOptions.Deadband <= 0)
                return CnlDataEquals1;
            else if (ArchiveOptions.DeadbandUnit == DeadbandUnit.Absolute)
                return CnlDataEquals2;
            else
                return CnlDataEquals3;
        }

        /// <summary>
        /// Gets the trends of the specified channels.
        /// </summary>
        public abstract TrendBundle GetTrends(TimeRange timeRange, int[] cnlNums);

        /// <summary>
        /// Gets the trend of the specified channel.
        /// </summary>
        public abstract Trend GetTrend(TimeRange timeRange, int cnlNum);

        /// <summary>
        /// Gets the available timestamps.
        /// </summary>
        public abstract List<DateTime> GetTimestamps(TimeRange timeRange);

        /// <summary>
        /// Gets the slice of the specified channels at the timestamp.
        /// </summary>
        public abstract Slice GetSlice(DateTime timestamp, int[] cnlNums);

        /// <summary>
        /// Gets the channel data.
        /// </summary>
        public abstract CnlData GetCnlData(DateTime timestamp, int cnlNum);

        /// <summary>
        /// Processes new data.
        /// </summary>
        /// <remarks>Returns true if the data has been written to the archive.</remarks>
        public abstract bool ProcessData(ICurrentData curData);

        /// <summary>
        /// Accepts or rejects data with the specified timestamp.
        /// </summary>
        /// <remarks>The timestamp can be adjusted by the archive.</remarks>
        public abstract bool AcceptData(ref DateTime timestamp);

        /// <summary>
        /// Maintains performance when data is written one at a time.
        /// </summary>
        public abstract void BeginUpdate(DateTime timestamp, int deviceNum);

        /// <summary>
        /// Completes the update operation.
        /// </summary>
        public abstract void EndUpdate(DateTime timestamp, int deviceNum);

        /// <summary>
        /// Writes the channel data.
        /// </summary>
        public abstract void WriteCnlData(DateTime timestamp, int cnlNum, CnlData cnlData);
    }
}
