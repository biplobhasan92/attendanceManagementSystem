namespace Panchrukhi
{
    partial class frmSectionData
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
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.colNSECID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVSECTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(364, 81);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(364, 55);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnSaveAndUpdate.TabIndex = 71;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.BtnSaveAndUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(364, 133);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFrmSlotClose_Click);
            // 
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(86, 12);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(248, 20);
            this.txtSectionName.TabIndex = 96;
            this.txtSectionName.TextChanged += new System.EventHandler(this.txtSectionName_TextChanged);
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Location = new System.Drawing.Point(10, 15);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(74, 13);
            this.lblSectionName.TabIndex = 95;
            this.lblSectionName.Text = "Section Name";
            // 
            // dataGridData
            // 
            this.dataGridData.AllowUserToAddRows = false;
            this.dataGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNSECID,
            this.colVSECTION});
            this.dataGridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridData.Location = new System.Drawing.Point(13, 48);
            this.dataGridData.MultiSelect = false;
            this.dataGridData.Name = "dataGridData";
            this.dataGridData.Size = new System.Drawing.Size(345, 253);
            this.dataGridData.TabIndex = 97;
            this.dataGridData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridData_RowHeaderMouseClick);
            this.dataGridData.SelectionChanged += new System.EventHandler(this.DataGridData_SelectionChanged);
            // 
            // colNSECID
            // 
            this.colNSECID.DataPropertyName = "NSECID";
            this.colNSECID.HeaderText = "Section ID";
            this.colNSECID.Name = "colNSECID";
            this.colNSECID.ReadOnly = true;
            this.colNSECID.Visible = false;
            // 
            // colVSECTION
            // 
            this.colVSECTION.DataPropertyName = "VSECTION";
            this.colVSECTION.HeaderText = "Section";
            this.colVSECTION.Name = "colVSECTION";
            this.colVSECTION.ReadOnly = true;
            this.colVSECTION.Width = 200;
            // 
            // frmSectionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 313);
            this.Controls.Add(this.dataGridData);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.lblSectionName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Name = "frmSectionData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Section";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSectionData_FormClosed);
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
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSECID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVSECTION;
    }
}