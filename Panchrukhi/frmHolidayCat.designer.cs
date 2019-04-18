namespace Panchrukhi
{
    partial class frmHolidayCat
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
            this.txtHolyDCat = new System.Windows.Forms.TextBox();
            this.lblHolyDCat = new System.Windows.Forms.Label();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.colN_HCATID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(344, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(344, 48);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnSaveAndUpdate.TabIndex = 71;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.BtnSaveAndUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFrmSlotClose_Click);
            // 
            // txtHolyDCat
            // 
            this.txtHolyDCat.Location = new System.Drawing.Point(85, 12);
            this.txtHolyDCat.Name = "txtHolyDCat";
            this.txtHolyDCat.Size = new System.Drawing.Size(248, 20);
            this.txtHolyDCat.TabIndex = 96;
            this.txtHolyDCat.TextChanged += new System.EventHandler(this.txtHolyDCat_TextChanged);
            // 
            // lblHolyDCat
            // 
            this.lblHolyDCat.AutoSize = true;
            this.lblHolyDCat.Location = new System.Drawing.Point(7, 15);
            this.lblHolyDCat.Name = "lblHolyDCat";
            this.lblHolyDCat.Size = new System.Drawing.Size(63, 13);
            this.lblHolyDCat.TabIndex = 95;
            this.lblHolyDCat.Text = "Hloliday Cat";
            // 
            // dataGridData
            // 
            this.dataGridData.AllowUserToAddRows = false;
            this.dataGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colN_HCATID,
            this.colVDESCRIPTION});
            this.dataGridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridData.Location = new System.Drawing.Point(12, 48);
            this.dataGridData.MultiSelect = false;
            this.dataGridData.Name = "dataGridData";
            this.dataGridData.Size = new System.Drawing.Size(321, 391);
            this.dataGridData.TabIndex = 97;
            this.dataGridData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridData_RowHeaderMouseClick);
            this.dataGridData.SelectionChanged += new System.EventHandler(this.DataGridData_SelectionChanged);
            // 
            // colN_HCATID
            // 
            this.colN_HCATID.DataPropertyName = "N_HCATID";
            this.colN_HCATID.HeaderText = "ID";
            this.colN_HCATID.Name = "colN_HCATID";
            this.colN_HCATID.ReadOnly = true;
            this.colN_HCATID.Visible = false;
            // 
            // colVDESCRIPTION
            // 
            this.colVDESCRIPTION.DataPropertyName = "VDESCRIPTION";
            this.colVDESCRIPTION.HeaderText = "Holiday Category";
            this.colVDESCRIPTION.Name = "colVDESCRIPTION";
            this.colVDESCRIPTION.ReadOnly = true;
            this.colVDESCRIPTION.Width = 200;
            // 
            // frmHolidayCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 451);
            this.Controls.Add(this.dataGridData);
            this.Controls.Add(this.txtHolyDCat);
            this.Controls.Add(this.lblHolyDCat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Name = "frmHolidayCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Holiday Category";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHolyDayCat_FormClosed);
            this.Load += new System.EventHandler(this.FrmData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtHolyDCat;
        private System.Windows.Forms.Label lblHolyDCat;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN_HCATID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVDESCRIPTION;
    }
}