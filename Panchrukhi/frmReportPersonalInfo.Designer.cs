namespace Panchrukhi
{
    partial class frmReportPersonalInfo
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
            this.components = new System.ComponentModel.Container();
            this.gbxAddColumn = new System.Windows.Forms.GroupBox();
            this.cbxEmergencyNum = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcelExporter = new System.Windows.Forms.Button();
            this.ckbxSection = new System.Windows.Forms.CheckBox();
            this.ckbxClass = new System.Windows.Forms.CheckBox();
            this.ckbxGNDR = new System.Windows.Forms.CheckBox();
            this.ckbxSlot = new System.Windows.Forms.CheckBox();
            this.ckbxDesig = new System.Windows.Forms.CheckBox();
            this.ckbxName = new System.Windows.Forms.CheckBox();
            this.ckbxCategory = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitParent = new System.Windows.Forms.SplitContainer();
            this.gbxSearchByID = new System.Windows.Forms.GroupBox();
            this.ckbxSearchID = new System.Windows.Forms.CheckBox();
            this.txtMultID = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpLstDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFstDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnPrsnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxSearchByDetails = new System.Windows.Forms.GroupBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblPrsnGender = new System.Windows.Forms.Label();
            this.cmbDesig = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gbxAddColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitParent)).BeginInit();
            this.splitParent.Panel1.SuspendLayout();
            this.splitParent.Panel2.SuspendLayout();
            this.splitParent.SuspendLayout();
            this.gbxSearchByID.SuspendLayout();
            this.gbxSearchByDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddColumn
            // 
            this.gbxAddColumn.Controls.Add(this.cbxEmergencyNum);
            this.gbxAddColumn.Controls.Add(this.btnPrint);
            this.gbxAddColumn.Controls.Add(this.btnExcelExporter);
            this.gbxAddColumn.Controls.Add(this.ckbxSection);
            this.gbxAddColumn.Controls.Add(this.ckbxClass);
            this.gbxAddColumn.Controls.Add(this.ckbxGNDR);
            this.gbxAddColumn.Controls.Add(this.ckbxSlot);
            this.gbxAddColumn.Controls.Add(this.ckbxDesig);
            this.gbxAddColumn.Controls.Add(this.ckbxName);
            this.gbxAddColumn.Controls.Add(this.ckbxCategory);
            this.gbxAddColumn.Location = new System.Drawing.Point(12, 14);
            this.gbxAddColumn.Name = "gbxAddColumn";
            this.gbxAddColumn.Size = new System.Drawing.Size(681, 69);
            this.gbxAddColumn.TabIndex = 97;
            this.gbxAddColumn.TabStop = false;
            this.gbxAddColumn.Text = "Check to add column(s) ";
            // 
            // cbxEmergencyNum
            // 
            this.cbxEmergencyNum.AutoSize = true;
            this.cbxEmergencyNum.Location = new System.Drawing.Point(13, 46);
            this.cbxEmergencyNum.Name = "cbxEmergencyNum";
            this.cbxEmergencyNum.Size = new System.Drawing.Size(119, 17);
            this.cbxEmergencyNum.TabIndex = 158;
            this.cbxEmergencyNum.Text = "Emergency Number";
            this.cbxEmergencyNum.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(583, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 29);
            this.btnPrint.TabIndex = 157;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcelExporter
            // 
            this.btnExcelExporter.Enabled = false;
            this.btnExcelExporter.Location = new System.Drawing.Point(481, 15);
            this.btnExcelExporter.Name = "btnExcelExporter";
            this.btnExcelExporter.Size = new System.Drawing.Size(91, 29);
            this.btnExcelExporter.TabIndex = 156;
            this.btnExcelExporter.Text = "Export";
            this.btnExcelExporter.UseVisualStyleBackColor = true;
            this.btnExcelExporter.Click += new System.EventHandler(this.btnExcelExporter_Click);
            // 
            // ckbxSection
            // 
            this.ckbxSection.AutoSize = true;
            this.ckbxSection.Location = new System.Drawing.Point(409, 21);
            this.ckbxSection.Name = "ckbxSection";
            this.ckbxSection.Size = new System.Drawing.Size(62, 17);
            this.ckbxSection.TabIndex = 7;
            this.ckbxSection.Text = "Section";
            this.ckbxSection.UseVisualStyleBackColor = true;
            // 
            // ckbxClass
            // 
            this.ckbxClass.AutoSize = true;
            this.ckbxClass.Location = new System.Drawing.Point(350, 20);
            this.ckbxClass.Name = "ckbxClass";
            this.ckbxClass.Size = new System.Drawing.Size(51, 17);
            this.ckbxClass.TabIndex = 6;
            this.ckbxClass.Text = "Class";
            this.ckbxClass.UseVisualStyleBackColor = true;
            // 
            // ckbxGNDR
            // 
            this.ckbxGNDR.AutoSize = true;
            this.ckbxGNDR.Location = new System.Drawing.Point(277, 20);
            this.ckbxGNDR.Name = "ckbxGNDR";
            this.ckbxGNDR.Size = new System.Drawing.Size(61, 17);
            this.ckbxGNDR.TabIndex = 4;
            this.ckbxGNDR.Text = "Gender";
            this.ckbxGNDR.UseVisualStyleBackColor = true;
            // 
            // ckbxSlot
            // 
            this.ckbxSlot.AutoSize = true;
            this.ckbxSlot.Location = new System.Drawing.Point(224, 20);
            this.ckbxSlot.Name = "ckbxSlot";
            this.ckbxSlot.Size = new System.Drawing.Size(47, 17);
            this.ckbxSlot.TabIndex = 3;
            this.ckbxSlot.Text = "Shift";
            this.ckbxSlot.UseVisualStyleBackColor = true;
            // 
            // ckbxDesig
            // 
            this.ckbxDesig.AutoSize = true;
            this.ckbxDesig.Location = new System.Drawing.Point(139, 20);
            this.ckbxDesig.Name = "ckbxDesig";
            this.ckbxDesig.Size = new System.Drawing.Size(82, 17);
            this.ckbxDesig.TabIndex = 2;
            this.ckbxDesig.Text = "Designation";
            this.ckbxDesig.UseVisualStyleBackColor = true;
            // 
            // ckbxName
            // 
            this.ckbxName.AutoSize = true;
            this.ckbxName.Location = new System.Drawing.Point(81, 20);
            this.ckbxName.Name = "ckbxName";
            this.ckbxName.Size = new System.Drawing.Size(54, 17);
            this.ckbxName.TabIndex = 1;
            this.ckbxName.Text = "Name";
            this.ckbxName.UseVisualStyleBackColor = true;
            // 
            // ckbxCategory
            // 
            this.ckbxCategory.AutoSize = true;
            this.ckbxCategory.Location = new System.Drawing.Point(13, 21);
            this.ckbxCategory.Name = "ckbxCategory";
            this.ckbxCategory.Size = new System.Drawing.Size(68, 17);
            this.ckbxCategory.TabIndex = 0;
            this.ckbxCategory.Text = "Category";
            this.ckbxCategory.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitParent
            // 
            this.splitParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitParent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitParent.IsSplitterFixed = true;
            this.splitParent.Location = new System.Drawing.Point(0, 0);
            this.splitParent.Name = "splitParent";
            // 
            // splitParent.Panel1
            // 
            this.splitParent.Panel1.Controls.Add(this.gbxSearchByID);
            this.splitParent.Panel1.Controls.Add(this.lblDate);
            this.splitParent.Panel1.Controls.Add(this.dtpLstDate);
            this.splitParent.Panel1.Controls.Add(this.dtpFstDate);
            this.splitParent.Panel1.Controls.Add(this.btnLoadData);
            this.splitParent.Panel1.Controls.Add(this.btnPrsnReset);
            this.splitParent.Panel1.Controls.Add(this.btnClose);
            this.splitParent.Panel1.Controls.Add(this.gbxSearchByDetails);
            this.splitParent.Panel1.Controls.Add(this.lbl_emp_name);
            this.splitParent.Panel1MinSize = 276;
            // 
            // splitParent.Panel2
            // 
            this.splitParent.Panel2.Controls.Add(this.splitRight);
            this.splitParent.Size = new System.Drawing.Size(1008, 729);
            this.splitParent.SplitterDistance = 276;
            this.splitParent.TabIndex = 147;
            // 
            // gbxSearchByID
            // 
            this.gbxSearchByID.Controls.Add(this.ckbxSearchID);
            this.gbxSearchByID.Controls.Add(this.txtMultID);
            this.gbxSearchByID.Location = new System.Drawing.Point(15, 221);
            this.gbxSearchByID.Name = "gbxSearchByID";
            this.gbxSearchByID.Size = new System.Drawing.Size(247, 156);
            this.gbxSearchByID.TabIndex = 155;
            this.gbxSearchByID.TabStop = false;
            this.gbxSearchByID.Text = "Search By ID";
            // 
            // ckbxSearchID
            // 
            this.ckbxSearchID.AutoSize = true;
            this.ckbxSearchID.Location = new System.Drawing.Point(11, 26);
            this.ckbxSearchID.Name = "ckbxSearchID";
            this.ckbxSearchID.Size = new System.Drawing.Size(74, 17);
            this.ckbxSearchID.TabIndex = 1;
            this.ckbxSearchID.Text = "Search ID";
            this.ckbxSearchID.UseVisualStyleBackColor = true;
            this.ckbxSearchID.CheckedChanged += new System.EventHandler(this.ckbxSearchID_CheckedChanged);
            // 
            // txtMultID
            // 
            this.txtMultID.Location = new System.Drawing.Point(6, 53);
            this.txtMultID.Multiline = true;
            this.txtMultID.Name = "txtMultID";
            this.txtMultID.Size = new System.Drawing.Size(235, 94);
            this.txtMultID.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(123, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(22, 13);
            this.lblDate.TabIndex = 154;
            this.lblDate.Text = "TO";
            // 
            // dtpLstDate
            // 
            this.dtpLstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLstDate.Location = new System.Drawing.Point(147, 12);
            this.dtpLstDate.Name = "dtpLstDate";
            this.dtpLstDate.Size = new System.Drawing.Size(78, 20);
            this.dtpLstDate.TabIndex = 153;
            // 
            // dtpFstDate
            // 
            this.dtpFstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFstDate.Location = new System.Drawing.Point(44, 12);
            this.dtpFstDate.Name = "dtpFstDate";
            this.dtpFstDate.Size = new System.Drawing.Size(78, 20);
            this.dtpFstDate.TabIndex = 152;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(180, 456);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(69, 23);
            this.btnLoadData.TabIndex = 149;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnPrsnReset
            // 
            this.btnPrsnReset.Location = new System.Drawing.Point(96, 456);
            this.btnPrsnReset.Name = "btnPrsnReset";
            this.btnPrsnReset.Size = new System.Drawing.Size(78, 23);
            this.btnPrsnReset.TabIndex = 150;
            this.btnPrsnReset.Text = "Reset";
            this.btnPrsnReset.UseVisualStyleBackColor = true;
            this.btnPrsnReset.Click += new System.EventHandler(this.btnPrsnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(23, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 23);
            this.btnClose.TabIndex = 151;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxSearchByDetails
            // 
            this.gbxSearchByDetails.Controls.Add(this.cmbClass);
            this.gbxSearchByDetails.Controls.Add(this.lblClass);
            this.gbxSearchByDetails.Controls.Add(this.cmbSection);
            this.gbxSearchByDetails.Controls.Add(this.label2);
            this.gbxSearchByDetails.Controls.Add(this.cmbGender);
            this.gbxSearchByDetails.Controls.Add(this.lblPrsnGender);
            this.gbxSearchByDetails.Controls.Add(this.cmbDesig);
            this.gbxSearchByDetails.Controls.Add(this.label1);
            this.gbxSearchByDetails.Controls.Add(this.cmbCategory);
            this.gbxSearchByDetails.Controls.Add(this.lblCategory);
            this.gbxSearchByDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxSearchByDetails.Location = new System.Drawing.Point(15, 43);
            this.gbxSearchByDetails.Name = "gbxSearchByDetails";
            this.gbxSearchByDetails.Size = new System.Drawing.Size(247, 170);
            this.gbxSearchByDetails.TabIndex = 148;
            this.gbxSearchByDetails.TabStop = false;
            this.gbxSearchByDetails.Text = "Search By Details";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(88, 110);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(153, 21);
            this.cmbClass.TabIndex = 135;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(8, 113);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 134;
            this.lblClass.Text = "Class";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(88, 136);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(153, 21);
            this.cmbSection.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Section";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbGender.Location = new System.Drawing.Point(88, 83);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(153, 21);
            this.cmbGender.TabIndex = 126;
            // 
            // lblPrsnGender
            // 
            this.lblPrsnGender.AutoSize = true;
            this.lblPrsnGender.Location = new System.Drawing.Point(8, 86);
            this.lblPrsnGender.Name = "lblPrsnGender";
            this.lblPrsnGender.Size = new System.Drawing.Size(42, 13);
            this.lblPrsnGender.TabIndex = 125;
            this.lblPrsnGender.Text = "Gender";
            // 
            // cmbDesig
            // 
            this.cmbDesig.FormattingEnabled = true;
            this.cmbDesig.Location = new System.Drawing.Point(88, 55);
            this.cmbDesig.Name = "cmbDesig";
            this.cmbDesig.Size = new System.Drawing.Size(153, 21);
            this.cmbDesig.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Design";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(88, 29);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(153, 21);
            this.cmbCategory.TabIndex = 95;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(8, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 94;
            this.lblCategory.Text = "Category";
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.Location = new System.Drawing.Point(69, 216);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_emp_name.TabIndex = 147;
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.gbxAddColumn);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.dataGridView);
            this.splitRight.Size = new System.Drawing.Size(728, 729);
            this.splitRight.SplitterDistance = 93;
            this.splitRight.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(728, 632);
            this.dataGridView.TabIndex = 95;
            // 
            // frmReportPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitParent);
            this.Name = "frmReportPersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReportPersonalInfo_FormClosed);
            this.Load += new System.EventHandler(this.frmReportPersonalInfo_Load);
            this.gbxAddColumn.ResumeLayout(false);
            this.gbxAddColumn.PerformLayout();
            this.splitParent.Panel1.ResumeLayout(false);
            this.splitParent.Panel1.PerformLayout();
            this.splitParent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitParent)).EndInit();
            this.splitParent.ResumeLayout(false);
            this.gbxSearchByID.ResumeLayout(false);
            this.gbxSearchByID.PerformLayout();
            this.gbxSearchByDetails.ResumeLayout(false);
            this.gbxSearchByDetails.PerformLayout();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAddColumn;
        private System.Windows.Forms.CheckBox ckbxCategory;
        private System.Windows.Forms.CheckBox ckbxName;
        private System.Windows.Forms.CheckBox ckbxDesig;
        private System.Windows.Forms.CheckBox ckbxSlot;
        private System.Windows.Forms.CheckBox ckbxGNDR;
        private System.Windows.Forms.CheckBox ckbxClass;
        private System.Windows.Forms.CheckBox ckbxSection;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer splitParent;
        private System.Windows.Forms.GroupBox gbxSearchByID;
        private System.Windows.Forms.CheckBox ckbxSearchID;
        private System.Windows.Forms.TextBox txtMultID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpLstDate;
        private System.Windows.Forms.DateTimePicker dtpFstDate;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnPrsnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxSearchByDetails;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblPrsnGender;
        private System.Windows.Forms.ComboBox cmbDesig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnExcelExporter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox cbxEmergencyNum;
    }
}