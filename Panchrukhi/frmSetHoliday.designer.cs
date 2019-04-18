namespace Panchrukhi
{
    partial class frmSetHoliday
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveAndUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDateForm = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colNHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPkrFormDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtPkrToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHolidayCat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(388, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(388, 219);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnSaveAndUpdate.TabIndex = 71;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.BtnSaveAndUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(388, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFrmSlotClose_Click);
            // 
            // lblDateForm
            // 
            this.lblDateForm.AutoSize = true;
            this.lblDateForm.Location = new System.Drawing.Point(19, 20);
            this.lblDateForm.Name = "lblDateForm";
            this.lblDateForm.Size = new System.Drawing.Size(56, 13);
            this.lblDateForm.TabIndex = 95;
            this.lblDateForm.Text = "Date From";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNHID,
            this.colHDate,
            this.colHCategory});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(7, 96);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(375, 357);
            this.dataGridView.TabIndex = 97;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridData_RowHeaderMouseClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridData_SelectionChanged);
            // 
            // colNHID
            // 
            this.colNHID.HeaderText = "ID";
            this.colNHID.Name = "colNHID";
            this.colNHID.ReadOnly = true;
            this.colNHID.Width = 30;
            // 
            // colHDate
            // 
            this.colHDate.HeaderText = "Date";
            this.colHDate.Name = "colHDate";
            this.colHDate.ReadOnly = true;
            this.colHDate.Width = 150;
            // 
            // colHCategory
            // 
            this.colHCategory.HeaderText = "Category";
            this.colHCategory.Name = "colHCategory";
            this.colHCategory.Width = 150;
            // 
            // dtPkrFormDate
            // 
            this.dtPkrFormDate.Location = new System.Drawing.Point(101, 19);
            this.dtPkrFormDate.Name = "dtPkrFormDate";
            this.dtPkrFormDate.Size = new System.Drawing.Size(139, 20);
            this.dtPkrFormDate.TabIndex = 98;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(246, 20);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(20, 13);
            this.lblDateTo.TabIndex = 99;
            this.lblDateTo.Text = "To";
            // 
            // dtPkrToDate
            // 
            this.dtPkrToDate.Location = new System.Drawing.Point(273, 18);
            this.dtPkrToDate.Name = "dtPkrToDate";
            this.dtPkrToDate.Size = new System.Drawing.Size(139, 20);
            this.dtPkrToDate.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Holiday Cat";
            // 
            // cmbHolidayCat
            // 
            this.cmbHolidayCat.FormattingEnabled = true;
            this.cmbHolidayCat.Location = new System.Drawing.Point(101, 56);
            this.cmbHolidayCat.Name = "cmbHolidayCat";
            this.cmbHolidayCat.Size = new System.Drawing.Size(139, 21);
            this.cmbHolidayCat.TabIndex = 102;
            this.cmbHolidayCat.Text = "--- Select Type ---";
            // 
            // frmSetHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 465);
            this.Controls.Add(this.cmbHolidayCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPkrToDate);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtPkrFormDate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblDateForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Name = "frmSetHoliday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Holidays";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSetHolyDay_FormClosed);
            this.Load += new System.EventHandler(this.FrmData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDateForm;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dtPkrFormDate;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtPkrToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHolidayCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNHID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHCategory;
    }
}