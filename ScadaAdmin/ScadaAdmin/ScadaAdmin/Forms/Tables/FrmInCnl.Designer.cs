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
            this.gbLim = new System.Windows.Forms.GroupBox();
            this.txtDeadband = new System.Windows.Forms.TextBox();
            this.lblDeadband = new System.Windows.Forms.Label();
            this.txtHiHi = new System.Windows.Forms.TextBox();
            this.lblHiHi = new System.Windows.Forms.Label();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.lblHigh = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.lblLow = new System.Windows.Forms.Label();
            this.txtLoLo = new System.Windows.Forms.TextBox();
            this.lblLoLo = new System.Windows.Forms.Label();
            this.chkShared = new System.Windows.Forms.CheckBox();
            this.cbLim = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.chkFormulaEnabled = new System.Windows.Forms.CheckBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.txtTagCode = new System.Windows.Forms.TextBox();
            this.lblTagCode = new System.Windows.Forms.Label();
            this.txtTagNum = new System.Windows.Forms.TextBox();
            this.lblTagNum = new System.Windows.Forms.Label();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.txtDeviceNum = new System.Windows.Forms.TextBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbObj = new System.Windows.Forms.ComboBox();
            this.txtObjNum = new System.Windows.Forms.TextBox();
            this.lblObj = new System.Windows.Forms.Label();
            this.cbCnlType = new System.Windows.Forms.ComboBox();
            this.lblCnlType = new System.Windows.Forms.Label();
            this.txtDataLen = new System.Windows.Forms.TextBox();
            this.lblDataLen = new System.Windows.Forms.Label();
            this.cbDataType = new System.Windows.Forms.ComboBox();
            this.lblDataType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCnlNum = new System.Windows.Forms.TextBox();
            this.lblCnlNum = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.pageArchives = new System.Windows.Forms.TabPage();
            this.pageEvents = new System.Windows.Forms.TabPage();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.pageGeneral.SuspendLayout();
            this.gbLim.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(484, 548);
            this.tabControl.TabIndex = 0;
            // 
            // pageGeneral
            // 
            this.pageGeneral.Controls.Add(this.gbLim);
            this.pageGeneral.Controls.Add(this.cbUnit);
            this.pageGeneral.Controls.Add(this.lblUnit);
            this.pageGeneral.Controls.Add(this.cbQuantity);
            this.pageGeneral.Controls.Add(this.lblQuantity);
            this.pageGeneral.Controls.Add(this.cbFormat);
            this.pageGeneral.Controls.Add(this.lblFormat);
            this.pageGeneral.Controls.Add(this.txtFormula);
            this.pageGeneral.Controls.Add(this.chkFormulaEnabled);
            this.pageGeneral.Controls.Add(this.lblFormula);
            this.pageGeneral.Controls.Add(this.txtTagCode);
            this.pageGeneral.Controls.Add(this.lblTagCode);
            this.pageGeneral.Controls.Add(this.txtTagNum);
            this.pageGeneral.Controls.Add(this.lblTagNum);
            this.pageGeneral.Controls.Add(this.cbDevice);
            this.pageGeneral.Controls.Add(this.txtDeviceNum);
            this.pageGeneral.Controls.Add(this.lblDevice);
            this.pageGeneral.Controls.Add(this.cbObj);
            this.pageGeneral.Controls.Add(this.txtObjNum);
            this.pageGeneral.Controls.Add(this.lblObj);
            this.pageGeneral.Controls.Add(this.cbCnlType);
            this.pageGeneral.Controls.Add(this.lblCnlType);
            this.pageGeneral.Controls.Add(this.txtDataLen);
            this.pageGeneral.Controls.Add(this.lblDataLen);
            this.pageGeneral.Controls.Add(this.cbDataType);
            this.pageGeneral.Controls.Add(this.lblDataType);
            this.pageGeneral.Controls.Add(this.txtName);
            this.pageGeneral.Controls.Add(this.lblName);
            this.pageGeneral.Controls.Add(this.txtCnlNum);
            this.pageGeneral.Controls.Add(this.lblCnlNum);
            this.pageGeneral.Controls.Add(this.chkActive);
            this.pageGeneral.Location = new System.Drawing.Point(4, 24);
            this.pageGeneral.Name = "pageGeneral";
            this.pageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.pageGeneral.Size = new System.Drawing.Size(476, 520);
            this.pageGeneral.TabIndex = 0;
            this.pageGeneral.Text = "General";
            this.pageGeneral.UseVisualStyleBackColor = true;
            // 
            // gbLim
            // 
            this.gbLim.Controls.Add(this.txtDeadband);
            this.gbLim.Controls.Add(this.lblDeadband);
            this.gbLim.Controls.Add(this.txtHiHi);
            this.gbLim.Controls.Add(this.lblHiHi);
            this.gbLim.Controls.Add(this.txtHigh);
            this.gbLim.Controls.Add(this.lblHigh);
            this.gbLim.Controls.Add(this.txtLow);
            this.gbLim.Controls.Add(this.lblLow);
            this.gbLim.Controls.Add(this.txtLoLo);
            this.gbLim.Controls.Add(this.lblLoLo);
            this.gbLim.Controls.Add(this.chkShared);
            this.gbLim.Controls.Add(this.cbLim);
            this.gbLim.Location = new System.Drawing.Point(8, 386);
            this.gbLim.Name = "gbLim";
            this.gbLim.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gbLim.Size = new System.Drawing.Size(460, 127);
            this.gbLim.TabIndex = 30;
            this.gbLim.TabStop = false;
            this.gbLim.Text = "Limits";
            // 
            // txtDeadband
            // 
            this.txtDeadband.Location = new System.Drawing.Point(365, 91);
            this.txtDeadband.Name = "txtDeadband";
            this.txtDeadband.ReadOnly = true;
            this.txtDeadband.Size = new System.Drawing.Size(82, 23);
            this.txtDeadband.TabIndex = 11;
            // 
            // lblDeadband
            // 
            this.lblDeadband.AutoSize = true;
            this.lblDeadband.Location = new System.Drawing.Point(362, 73);
            this.lblDeadband.Name = "lblDeadband";
            this.lblDeadband.Size = new System.Drawing.Size(61, 15);
            this.lblDeadband.TabIndex = 10;
            this.lblDeadband.Text = "Deadband";
            // 
            // txtHiHi
            // 
            this.txtHiHi.Location = new System.Drawing.Point(277, 91);
            this.txtHiHi.Name = "txtHiHi";
            this.txtHiHi.ReadOnly = true;
            this.txtHiHi.Size = new System.Drawing.Size(82, 23);
            this.txtHiHi.TabIndex = 9;
            // 
            // lblHiHi
            // 
            this.lblHiHi.AutoSize = true;
            this.lblHiHi.Location = new System.Drawing.Point(274, 73);
            this.lblHiHi.Name = "lblHiHi";
            this.lblHiHi.Size = new System.Drawing.Size(86, 15);
            this.lblHiHi.TabIndex = 8;
            this.lblHiHi.Text = "Extremely high";
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(189, 91);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.ReadOnly = true;
            this.txtHigh.Size = new System.Drawing.Size(82, 23);
            this.txtHigh.TabIndex = 7;
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(186, 73);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(33, 15);
            this.lblHigh.TabIndex = 6;
            this.lblHigh.Text = "High";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(101, 91);
            this.txtLow.Name = "txtLow";
            this.txtLow.ReadOnly = true;
            this.txtLow.Size = new System.Drawing.Size(82, 23);
            this.txtLow.TabIndex = 5;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(98, 73);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(29, 15);
            this.lblLow.TabIndex = 4;
            this.lblLow.Text = "Low";
            // 
            // txtLoLo
            // 
            this.txtLoLo.Location = new System.Drawing.Point(13, 91);
            this.txtLoLo.Name = "txtLoLo";
            this.txtLoLo.ReadOnly = true;
            this.txtLoLo.Size = new System.Drawing.Size(82, 23);
            this.txtLoLo.TabIndex = 3;
            // 
            // lblLoLo
            // 
            this.lblLoLo.AutoSize = true;
            this.lblLoLo.Location = new System.Drawing.Point(10, 73);
            this.lblLoLo.Name = "lblLoLo";
            this.lblLoLo.Size = new System.Drawing.Size(81, 15);
            this.lblLoLo.TabIndex = 2;
            this.lblLoLo.Text = "Extremely low";
            // 
            // chkShared
            // 
            this.chkShared.AutoSize = true;
            this.chkShared.Location = new System.Drawing.Point(13, 51);
            this.chkShared.Name = "chkShared";
            this.chkShared.Size = new System.Drawing.Size(151, 19);
            this.chkShared.TabIndex = 1;
            this.chkShared.Text = "Show only shared limits";
            this.chkShared.UseVisualStyleBackColor = true;
            this.chkShared.CheckedChanged += new System.EventHandler(this.chkShared_CheckedChanged);
            // 
            // cbLim
            // 
            this.cbLim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLim.FormattingEnabled = true;
            this.cbLim.Location = new System.Drawing.Point(13, 22);
            this.cbLim.Name = "cbLim";
            this.cbLim.Size = new System.Drawing.Size(434, 23);
            this.cbLim.TabIndex = 0;
            this.cbLim.SelectedIndexChanged += new System.EventHandler(this.cbLim_SelectedIndexChanged);
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(320, 354);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(148, 23);
            this.cbUnit.TabIndex = 29;
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
            // cbQuantity
            // 
            this.cbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Location = new System.Drawing.Point(164, 354);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(150, 23);
            this.cbQuantity.TabIndex = 27;
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
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(8, 354);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(150, 23);
            this.cbFormat.TabIndex = 25;
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
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(29, 310);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(439, 23);
            this.txtFormula.TabIndex = 23;
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
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(5, 292);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(51, 15);
            this.lblFormula.TabIndex = 21;
            this.lblFormula.Text = "Formula";
            // 
            // txtTagCode
            // 
            this.txtTagCode.Location = new System.Drawing.Point(114, 266);
            this.txtTagCode.Name = "txtTagCode";
            this.txtTagCode.Size = new System.Drawing.Size(354, 23);
            this.txtTagCode.TabIndex = 20;
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
            // txtTagNum
            // 
            this.txtTagNum.Location = new System.Drawing.Point(8, 266);
            this.txtTagNum.Name = "txtTagNum";
            this.txtTagNum.Size = new System.Drawing.Size(100, 23);
            this.txtTagNum.TabIndex = 18;
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
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(114, 222);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(354, 23);
            this.cbDevice.TabIndex = 16;
            this.cbDevice.SelectedIndexChanged += new System.EventHandler(this.cbDevice_SelectedIndexChanged);
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
            this.cbObj.SelectedIndexChanged += new System.EventHandler(this.cbObj_SelectedIndexChanged);
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
            // txtDataLen
            // 
            this.txtDataLen.Location = new System.Drawing.Point(368, 90);
            this.txtDataLen.Name = "txtDataLen";
            this.txtDataLen.Size = new System.Drawing.Size(100, 23);
            this.txtDataLen.TabIndex = 8;
            // 
            // lblDataLen
            // 
            this.lblDataLen.AutoSize = true;
            this.lblDataLen.Location = new System.Drawing.Point(365, 72);
            this.lblDataLen.Name = "lblDataLen";
            this.lblDataLen.Size = new System.Drawing.Size(68, 15);
            this.lblDataLen.TabIndex = 7;
            this.lblDataLen.Text = "Data length";
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
            // txtCnlNum
            // 
            this.txtCnlNum.Location = new System.Drawing.Point(8, 46);
            this.txtCnlNum.Name = "txtCnlNum";
            this.txtCnlNum.Size = new System.Drawing.Size(100, 23);
            this.txtCnlNum.TabIndex = 2;
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
            this.pageArchives.Size = new System.Drawing.Size(476, 520);
            this.pageArchives.TabIndex = 1;
            this.pageArchives.Text = "Archives";
            this.pageArchives.UseVisualStyleBackColor = true;
            // 
            // pageEvents
            // 
            this.pageEvents.Location = new System.Drawing.Point(4, 24);
            this.pageEvents.Name = "pageEvents";
            this.pageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.pageEvents.Size = new System.Drawing.Size(476, 520);
            this.pageEvents.TabIndex = 2;
            this.pageEvents.Text = "Events";
            this.pageEvents.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 548);
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
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmInCnl
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 589);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInCnl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Channel Properties";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInCnl_FormClosed);
            this.Load += new System.EventHandler(this.FrmInCnl_Load);
            this.tabControl.ResumeLayout(false);
            this.pageGeneral.ResumeLayout(false);
            this.pageGeneral.PerformLayout();
            this.gbLim.ResumeLayout(false);
            this.gbLim.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCnlNum;
        private System.Windows.Forms.Label lblCnlNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbDataType;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.TextBox txtDataLen;
        private System.Windows.Forms.Label lblDataLen;
        private System.Windows.Forms.ComboBox cbCnlType;
        private System.Windows.Forms.Label lblCnlType;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.TextBox txtObjNum;
        private System.Windows.Forms.ComboBox cbObj;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.TextBox txtDeviceNum;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox txtTagNum;
        private System.Windows.Forms.Label lblTagNum;
        private System.Windows.Forms.Label lblTagCode;
        private System.Windows.Forms.TextBox txtTagCode;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.CheckBox chkFormulaEnabled;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.GroupBox gbLim;
        private System.Windows.Forms.ComboBox cbLim;
        private System.Windows.Forms.CheckBox chkShared;
        private System.Windows.Forms.TextBox txtHiHi;
        private System.Windows.Forms.Label lblHiHi;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.TextBox txtLoLo;
        private System.Windows.Forms.Label lblLoLo;
        private System.Windows.Forms.TextBox txtDeadband;
        private System.Windows.Forms.Label lblDeadband;
    }
}