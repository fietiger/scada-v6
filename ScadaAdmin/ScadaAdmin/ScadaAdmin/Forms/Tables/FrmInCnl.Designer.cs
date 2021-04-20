﻿
namespace Scada.Admin.App.Forms.Tables
{
    partial class FrmInCnl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageGeneral = new System.Windows.Forms.TabPage();
            this.dbDevice = new System.Windows.Forms.ComboBox();
            this.txtDeviceNum = new System.Windows.Forms.TextBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbObj = new System.Windows.Forms.ComboBox();
            this.txtObjNum = new System.Windows.Forms.TextBox();
            this.lblObj = new System.Windows.Forms.Label();
            this.cbCnlType = new System.Windows.Forms.ComboBox();
            this.lblCnlType = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDataLength = new System.Windows.Forms.Label();
            this.cbDataType = new System.Windows.Forms.ComboBox();
            this.lblDataType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCnlNum = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.pageArchives = new System.Windows.Forms.TabPage();
            this.pageEvents = new System.Windows.Forms.TabPage();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTagNum = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTagCode = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.chkFormulaEnabled = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.pageGeneral.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageGeneral);
            this.tabControl.Controls.Add(this.pageArchives);
            this.tabControl.Controls.Add(this.pageEvents);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 420);
            this.tabControl.TabIndex = 0;
            // 
            // pageGeneral
            // 
            this.pageGeneral.Controls.Add(this.comboBox2);
            this.pageGeneral.Controls.Add(this.lblUnit);
            this.pageGeneral.Controls.Add(this.comboBox1);
            this.pageGeneral.Controls.Add(this.lblQuantity);
            this.pageGeneral.Controls.Add(this.cbFormat);
            this.pageGeneral.Controls.Add(this.lblFormat);
            this.pageGeneral.Controls.Add(this.textBox5);
            this.pageGeneral.Controls.Add(this.chkFormulaEnabled);
            this.pageGeneral.Controls.Add(this.lblFormula);
            this.pageGeneral.Controls.Add(this.textBox4);
            this.pageGeneral.Controls.Add(this.lblTagCode);
            this.pageGeneral.Controls.Add(this.textBox3);
            this.pageGeneral.Controls.Add(this.lblTagNum);
            this.pageGeneral.Controls.Add(this.dbDevice);
            this.pageGeneral.Controls.Add(this.txtDeviceNum);
            this.pageGeneral.Controls.Add(this.lblDevice);
            this.pageGeneral.Controls.Add(this.cbObj);
            this.pageGeneral.Controls.Add(this.txtObjNum);
            this.pageGeneral.Controls.Add(this.lblObj);
            this.pageGeneral.Controls.Add(this.cbCnlType);
            this.pageGeneral.Controls.Add(this.lblCnlType);
            this.pageGeneral.Controls.Add(this.textBox2);
            this.pageGeneral.Controls.Add(this.lblDataLength);
            this.pageGeneral.Controls.Add(this.cbDataType);
            this.pageGeneral.Controls.Add(this.lblDataType);
            this.pageGeneral.Controls.Add(this.txtName);
            this.pageGeneral.Controls.Add(this.lblName);
            this.pageGeneral.Controls.Add(this.textBox1);
            this.pageGeneral.Controls.Add(this.lblCnlNum);
            this.pageGeneral.Controls.Add(this.chkActive);
            this.pageGeneral.Location = new System.Drawing.Point(4, 24);
            this.pageGeneral.Name = "pageGeneral";
            this.pageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.pageGeneral.Size = new System.Drawing.Size(476, 392);
            this.pageGeneral.TabIndex = 0;
            this.pageGeneral.Text = "General";
            this.pageGeneral.UseVisualStyleBackColor = true;
            // 
            // dbDevice
            // 
            this.dbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbDevice.FormattingEnabled = true;
            this.dbDevice.Location = new System.Drawing.Point(114, 222);
            this.dbDevice.Name = "dbDevice";
            this.dbDevice.Size = new System.Drawing.Size(354, 23);
            this.dbDevice.TabIndex = 16;
            // 
            // txtDeviceNum
            // 
            this.txtDeviceNum.Location = new System.Drawing.Point(8, 222);
            this.txtDeviceNum.Name = "txtDeviceNum";
            this.txtDeviceNum.ReadOnly = true;
            this.txtDeviceNum.Size = new System.Drawing.Size(100, 23);
            this.txtDeviceNum.TabIndex = 15;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(5, 204);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(42, 15);
            this.lblDevice.TabIndex = 14;
            this.lblDevice.Text = "Device";
            // 
            // cbObj
            // 
            this.cbObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObj.FormattingEnabled = true;
            this.cbObj.Location = new System.Drawing.Point(114, 178);
            this.cbObj.Name = "cbObj";
            this.cbObj.Size = new System.Drawing.Size(354, 23);
            this.cbObj.TabIndex = 13;
            // 
            // txtObjNum
            // 
            this.txtObjNum.Location = new System.Drawing.Point(8, 178);
            this.txtObjNum.Name = "txtObjNum";
            this.txtObjNum.ReadOnly = true;
            this.txtObjNum.Size = new System.Drawing.Size(100, 23);
            this.txtObjNum.TabIndex = 12;
            // 
            // lblObj
            // 
            this.lblObj.AutoSize = true;
            this.lblObj.Location = new System.Drawing.Point(5, 160);
            this.lblObj.Name = "lblObj";
            this.lblObj.Size = new System.Drawing.Size(42, 15);
            this.lblObj.TabIndex = 11;
            this.lblObj.Text = "Object";
            // 
            // cbCnlType
            // 
            this.cbCnlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCnlType.FormattingEnabled = true;
            this.cbCnlType.Location = new System.Drawing.Point(8, 134);
            this.cbCnlType.Name = "cbCnlType";
            this.cbCnlType.Size = new System.Drawing.Size(460, 23);
            this.cbCnlType.TabIndex = 10;
            // 
            // lblCnlType
            // 
            this.lblCnlType.AutoSize = true;
            this.lblCnlType.Location = new System.Drawing.Point(5, 116);
            this.lblCnlType.Name = "lblCnlType";
            this.lblCnlType.Size = new System.Drawing.Size(77, 15);
            this.lblCnlType.TabIndex = 9;
            this.lblCnlType.Text = "Channel type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // lblDataLength
            // 
            this.lblDataLength.AutoSize = true;
            this.lblDataLength.Location = new System.Drawing.Point(365, 72);
            this.lblDataLength.Name = "lblDataLength";
            this.lblDataLength.Size = new System.Drawing.Size(68, 15);
            this.lblDataLength.TabIndex = 7;
            this.lblDataLength.Text = "Data length";
            // 
            // cbDataType
            // 
            this.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataType.FormattingEnabled = true;
            this.cbDataType.Location = new System.Drawing.Point(8, 90);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(354, 23);
            this.cbDataType.TabIndex = 6;
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(5, 72);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(57, 15);
            this.lblDataType.TabIndex = 5;
            this.lblDataType.Text = "Data type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 23);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(111, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lblCnlNum
            // 
            this.lblCnlNum.AutoSize = true;
            this.lblCnlNum.Location = new System.Drawing.Point(5, 28);
            this.lblCnlNum.Name = "lblCnlNum";
            this.lblCnlNum.Size = new System.Drawing.Size(51, 15);
            this.lblCnlNum.TabIndex = 1;
            this.lblCnlNum.Text = "Number";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(8, 6);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(59, 19);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // pageArchives
            // 
            this.pageArchives.Location = new System.Drawing.Point(4, 24);
            this.pageArchives.Name = "pageArchives";
            this.pageArchives.Padding = new System.Windows.Forms.Padding(3);
            this.pageArchives.Size = new System.Drawing.Size(476, 392);
            this.pageArchives.TabIndex = 1;
            this.pageArchives.Text = "Archives";
            this.pageArchives.UseVisualStyleBackColor = true;
            // 
            // pageEvents
            // 
            this.pageEvents.Location = new System.Drawing.Point(4, 24);
            this.pageEvents.Name = "pageEvents";
            this.pageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.pageEvents.Size = new System.Drawing.Size(476, 392);
            this.pageEvents.TabIndex = 2;
            this.pageEvents.Text = "Events";
            this.pageEvents.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 420);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(484, 41);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(397, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(316, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblTagNum
            // 
            this.lblTagNum.AutoSize = true;
            this.lblTagNum.Location = new System.Drawing.Point(5, 248);
            this.lblTagNum.Name = "lblTagNum";
            this.lblTagNum.Size = new System.Drawing.Size(70, 15);
            this.lblTagNum.TabIndex = 17;
            this.lblTagNum.Text = "Tag number";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 18;
            // 
            // lblTagCode
            // 
            this.lblTagCode.AutoSize = true;
            this.lblTagCode.Location = new System.Drawing.Point(111, 248);
            this.lblTagCode.Name = "lblTagCode";
            this.lblTagCode.Size = new System.Drawing.Size(54, 15);
            this.lblTagCode.TabIndex = 19;
            this.lblTagCode.Text = "Tag code";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 266);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(354, 23);
            this.textBox4.TabIndex = 20;
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(5, 292);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(51, 15);
            this.lblFormula.TabIndex = 21;
            this.lblFormula.Text = "Formula";
            // 
            // chkFormulaEnabled
            // 
            this.chkFormulaEnabled.AutoSize = true;
            this.chkFormulaEnabled.Location = new System.Drawing.Point(8, 314);
            this.chkFormulaEnabled.Name = "chkFormulaEnabled";
            this.chkFormulaEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkFormulaEnabled.TabIndex = 22;
            this.chkFormulaEnabled.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(439, 23);
            this.textBox5.TabIndex = 23;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(5, 336);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(45, 15);
            this.lblFormat.TabIndex = 24;
            this.lblFormat.Text = "Format";
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(8, 354);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(150, 23);
            this.cbFormat.TabIndex = 25;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(161, 336);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 26;
            this.lblQuantity.Text = "Quantity";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 23);
            this.comboBox1.TabIndex = 27;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(317, 336);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 15);
            this.lblUnit.TabIndex = 28;
            this.lblUnit.Text = "Unit";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(320, 354);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 23);
            this.comboBox2.TabIndex = 29;
            // 
            // FrmInCnl
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInCnl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Channel Properties";
            this.tabControl.ResumeLayout(false);
            this.pageGeneral.ResumeLayout(false);
            this.pageGeneral.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageGeneral;
        private System.Windows.Forms.TabPage pageArchives;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TabPage pageEvents;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCnlNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbDataType;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDataLength;
        private System.Windows.Forms.ComboBox cbCnlType;
        private System.Windows.Forms.Label lblCnlType;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.TextBox txtObjNum;
        private System.Windows.Forms.ComboBox cbObj;
        private System.Windows.Forms.ComboBox dbDevice;
        private System.Windows.Forms.TextBox txtDeviceNum;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTagNum;
        private System.Windows.Forms.Label lblTagCode;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.CheckBox chkFormulaEnabled;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblUnit;
    }
}