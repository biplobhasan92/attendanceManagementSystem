namespace Panchrukhi
{
    partial class frmPersonalPromotion
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
            this.gbxPromotion = new System.Windows.Forms.GroupBox();
            this.btnPromotionApply = new System.Windows.Forms.Button();
            this.cmbDesigTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSectionTo = new System.Windows.Forms.ComboBox();
            this.cmbClassTo = new System.Windows.Forms.ComboBox();
            this.lblSectionPromo = new System.Windows.Forms.Label();
            this.lblClassPromo = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbxSelectAll = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitParent = new System.Windows.Forms.SplitContainer();
            this.btnExcelExporter = new System.Windows.Forms.Button();
            this.gbxSearchByID = new System.Windows.Forms.GroupBox();
            this.ckbxSearchID = new System.Windows.Forms.CheckBox();
            this.txtMultID = new System.Windows.Forms.TextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnPrsnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxSearchByDetails = new System.Windows.Forms.GroupBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblPrsnGender = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbDesig = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDesig = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbxPromotion.SuspendLayout();
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
            // gbxPromotion
            // 
            this.gbxPromotion.Controls.Add(this.btnPromotionApply);
            this.gbxPromotion.Controls.Add(this.cmbDesigTo);
            this.gbxPromotion.Controls.Add(this.label1);
            this.gbxPromotion.Controls.Add(this.cmbSectionTo);
            this.gbxPromotion.Controls.Add(this.cmbClassTo);
            this.gbxPromotion.Controls.Add(this.lblSectionPromo);
            this.gbxPromotion.Controls.Add(this.lblClassPromo);
            this.gbxPromotion.Controls.Add(this.lblTo);
            this.gbxPromotion.Controls.Add(this.cbxSelectAll);
            this.gbxPromotion.Location = new System.Drawing.Point(12, 10);
            this.gbxPromotion.Name = "gbxPromotion";
            this.gbxPromotion.Size = new System.Drawing.Size(728, 162);
            this.gbxPromotion.TabIndex = 97;
            this.gbxPromotion.TabStop = false;
            this.gbxPromotion.Text = "Promotion Bar";
            // 
            // btnPromotionApply
            // 
            this.btnPromotionApply.Location = new System.Drawing.Point(556, 107);
            this.btnPromotionApply.Name = "btnPromotionApply";
            this.btnPromotionApply.Size = new System.Drawing.Size(153, 42);
            this.btnPromotionApply.TabIndex = 143;
            this.btnPromotionApply.Text = "Apply";
            this.btnPromotionApply.UseVisualStyleBackColor = true;
            this.btnPromotionApply.Click += new System.EventHandler(this.btnPromotionApply_Click);
            // 
            // cmbDesigTo
            // 
            this.cmbDesigTo.FormattingEnabled = true;
            this.cmbDesigTo.Location = new System.Drawing.Point(556, 53);
            this.cmbDesigTo.Name = "cmbDesigTo";
            this.cmbDesigTo.Size = new System.Drawing.Size(153, 21);
            this.cmbDesigTo.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 140;
            this.label1.Text = "Designation";
            // 
            // cmbSectionTo
            // 
            this.cmbSectionTo.FormattingEnabled = true;
            this.cmbSectionTo.Location = new System.Drawing.Point(381, 53);
            this.cmbSectionTo.Name = "cmbSectionTo";
            this.cmbSectionTo.Size = new System.Drawing.Size(153, 21);
            this.cmbSectionTo.TabIndex = 139;
            // 
            // cmbClassTo
            // 
            this.cmbClassTo.FormattingEnabled = true;
            this.cmbClassTo.Location = new System.Drawing.Point(199, 54);
            this.cmbClassTo.Name = "cmbClassTo";
            this.cmbClassTo.Size = new System.Drawing.Size(153, 21);
            this.cmbClassTo.TabIndex = 137;
            // 
            // lblSectionPromo
            // 
            this.lblSectionPromo.AutoSize = true;
            this.lblSectionPromo.Location = new System.Drawing.Point(381, 16);
            this.lblSectionPromo.Name = "lblSectionPromo";
            this.lblSectionPromo.Size = new System.Drawing.Size(43, 13);
            this.lblSectionPromo.TabIndex = 136;
            this.lblSectionPromo.Text = "Section";
            // 
            // lblClassPromo
            // 
            this.lblClassPromo.AutoSize = true;
            this.lblClassPromo.Location = new System.Drawing.Point(199, 16);
            this.lblClassPromo.Name = "lblClassPromo";
            this.lblClassPromo.Size = new System.Drawing.Size(32, 13);
            this.lblClassPromo.TabIndex = 135;
            this.lblClassPromo.Text = "Class";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(144, 58);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "TO :";
            // 
            // cbxSelectAll
            // 
            this.cbxSelectAll.AutoSize = true;
            this.cbxSelectAll.Location = new System.Drawing.Point(11, 132);
            this.cbxSelectAll.Name = "cbxSelectAll";
            this.cbxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbxSelectAll.TabIndex = 0;
            this.cbxSelectAll.Text = "Select All";
            this.cbxSelectAll.UseVisualStyleBackColor = true;
            this.cbxSelectAll.CheckedChanged += new System.EventHandler(this.cbxSelectAll_CheckedChanged);
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
            this.splitParent.Panel1.Controls.Add(this.btnExcelExporter);
            this.splitParent.Panel1.Controls.Add(this.gbxSearchByID);
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
            this.splitParent.Size = new System.Drawing.Size(1032, 594);
            this.splitParent.SplitterDistance = 276;
            this.splitParent.TabIndex = 147;
            // 
            // btnExcelExporter
            // 
            this.btnExcelExporter.Enabled = false;
            this.btnExcelExporter.Location = new System.Drawing.Point(57, 491);
            this.btnExcelExporter.Name = "btnExcelExporter";
            this.btnExcelExporter.Size = new System.Drawing.Size(156, 55);
            this.btnExcelExporter.TabIndex = 158;
            this.btnExcelExporter.Text = "Export";
            this.btnExcelExporter.UseVisualStyleBackColor = true;
            this.btnExcelExporter.Click += new System.EventHandler(this.btnExcelExporter_Click);
            // 
            // gbxSearchByID
            // 
            this.gbxSearchByID.Controls.Add(this.ckbxSearchID);
            this.gbxSearchByID.Controls.Add(this.txtMultID);
            this.gbxSearchByID.Location = new System.Drawing.Point(15, 225);
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
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(180, 411);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(82, 32);
            this.btnLoadData.TabIndex = 149;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnPrsnReset
            // 
            this.btnPrsnReset.Location = new System.Drawing.Point(92, 411);
            this.btnPrsnReset.Name = "btnPrsnReset";
            this.btnPrsnReset.Size = new System.Drawing.Size(78, 32);
            this.btnPrsnReset.TabIndex = 150;
            this.btnPrsnReset.Text = "Reset";
            this.btnPrsnReset.UseVisualStyleBackColor = true;
            this.btnPrsnReset.Click += new System.EventHandler(this.btnPrsnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(10, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 32);
            this.btnClose.TabIndex = 151;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxSearchByDetails
            // 
            this.gbxSearchByDetails.Controls.Add(this.cmbClass);
            this.gbxSearchByDetails.Controls.Add(this.lblClass);
            this.gbxSearchByDetails.Controls.Add(this.cmbGender);
            this.gbxSearchByDetails.Controls.Add(this.lblPrsnGender);
            this.gbxSearchByDetails.Controls.Add(this.cmbSection);
            this.gbxSearchByDetails.Controls.Add(this.cmbDesig);
            this.gbxSearchByDetails.Controls.Add(this.cmbCategory);
            this.gbxSearchByDetails.Controls.Add(this.lblCategory);
            this.gbxSearchByDetails.Controls.Add(this.lblDesig);
            this.gbxSearchByDetails.Controls.Add(this.label2);
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
            this.cmbClass.Location = new System.Drawing.Point(83, 50);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(153, 21);
            this.cmbClass.TabIndex = 135;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(8, 53);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 134;
            this.lblClass.Text = "Class";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbGender.Location = new System.Drawing.Point(83, 136);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(153, 21);
            this.cmbGender.TabIndex = 126;
            // 
            // lblPrsnGender
            // 
            this.lblPrsnGender.AutoSize = true;
            this.lblPrsnGender.Location = new System.Drawing.Point(8, 139);
            this.lblPrsnGender.Name = "lblPrsnGender";
            this.lblPrsnGender.Size = new System.Drawing.Size(42, 13);
            this.lblPrsnGender.TabIndex = 125;
            this.lblPrsnGender.Text = "Gender";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(83, 78);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(153, 21);
            this.cmbSection.TabIndex = 133;
            // 
            // cmbDesig
            // 
            this.cmbDesig.FormattingEnabled = true;
            this.cmbDesig.Location = new System.Drawing.Point(83, 108);
            this.cmbDesig.Name = "cmbDesig";
            this.cmbDesig.Size = new System.Drawing.Size(153, 21);
            this.cmbDesig.TabIndex = 97;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(82, 19);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(153, 21);
            this.cmbCategory.TabIndex = 95;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 94;
            this.lblCategory.Text = "Category";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Location = new System.Drawing.Point(8, 111);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(34, 13);
            this.lblDesig.TabIndex = 96;
            this.lblDesig.Text = "Desig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Section";
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
            this.splitRight.Panel1.Controls.Add(this.gbxPromotion);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.dataGridView);
            this.splitRight.Size = new System.Drawing.Size(752, 594);
            this.splitRight.SplitterDistance = 187;
            this.splitRight.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(752, 403);
            this.dataGridView.TabIndex = 95;
            // 
            // colCheckBox
            // 
            this.colCheckBox.FillWeight = 30F;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.ReadOnly = true;
            // 
            // frmPersonalPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 594);
            this.Controls.Add(this.splitParent);
            this.Name = "frmPersonalPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotion Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonalPromotion_FormClosed);
            this.Load += new System.EventHandler(this.frmPersonalPromotion_Load);
            this.gbxPromotion.ResumeLayout(false);
            this.gbxPromotion.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxPromotion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer splitParent;
        private System.Windows.Forms.GroupBox gbxSearchByID;
        private System.Windows.Forms.CheckBox ckbxSearchID;
        private System.Windows.Forms.TextBox txtMultID;
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
        private System.Windows.Forms.Label lblDesig;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.Button btnExcelExporter;
        private System.Windows.Forms.CheckBox cbxSelectAll;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblClassPromo;
        private System.Windows.Forms.Label lblSectionPromo;
        private System.Windows.Forms.ComboBox cmbClassTo;
        private System.Windows.Forms.ComboBox cmbSectionTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDesigTo;
        private System.Windows.Forms.Button btnPromotionApply;
    }
}