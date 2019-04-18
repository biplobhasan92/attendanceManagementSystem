namespace Panchrukhi
{
    partial class frmDesigData
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
            this.txtDesigName = new System.Windows.Forms.TextBox();
            this.lblDesigName = new System.Windows.Forms.Label();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.colNDESIGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVDESIGNATIONNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(364, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(364, 64);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnSaveAndUpdate.TabIndex = 71;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.BtnSaveAndUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(364, 142);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFrmSlotClose_Click);
            // 
            // txtDesigName
            // 
            this.txtDesigName.Location = new System.Drawing.Point(100, 29);
            this.txtDesigName.Name = "txtDesigName";
            this.txtDesigName.Size = new System.Drawing.Size(258, 20);
            this.txtDesigName.TabIndex = 96;
            this.txtDesigName.TextChanged += new System.EventHandler(this.txtDesigName_TextChanged);
            // 
            // lblDesigName
            // 
            this.lblDesigName.AutoSize = true;
            this.lblDesigName.Location = new System.Drawing.Point(13, 32);
            this.lblDesigName.Name = "lblDesigName";
            this.lblDesigName.Size = new System.Drawing.Size(63, 13);
            this.lblDesigName.TabIndex = 95;
            this.lblDesigName.Text = "Designation";
            // 
            // dataGridData
            // 
            this.dataGridData.AllowUserToAddRows = false;
            this.dataGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNDESIGID,
            this.colVDESIGNATIONNAME});
            this.dataGridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridData.Location = new System.Drawing.Point(18, 65);
            this.dataGridData.MultiSelect = false;
            this.dataGridData.Name = "dataGridData";
            this.dataGridData.Size = new System.Drawing.Size(340, 332);
            this.dataGridData.TabIndex = 97;
            this.dataGridData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridData_RowHeaderMouseClick);
            this.dataGridData.SelectionChanged += new System.EventHandler(this.DataGridData_SelectionChanged);
            // 
            // colNDESIGID
            // 
            this.colNDESIGID.DataPropertyName = "NDESIGID";
            this.colNDESIGID.HeaderText = "ID";
            this.colNDESIGID.Name = "colNDESIGID";
            this.colNDESIGID.ReadOnly = true;
            // 
            // colVDESIGNATIONNAME
            // 
            this.colVDESIGNATIONNAME.DataPropertyName = "VDESIGNATIONNAME";
            this.colVDESIGNATIONNAME.HeaderText = "Designation";
            this.colVDESIGNATIONNAME.Name = "colVDESIGNATIONNAME";
            this.colVDESIGNATIONNAME.Width = 170;
            // 
            // frmDesigData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 409);
            this.Controls.Add(this.dataGridData);
            this.Controls.Add(this.txtDesigName);
            this.Controls.Add(this.lblDesigName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Name = "frmDesigData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Designation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDesigData_FormClosed);
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
        private System.Windows.Forms.TextBox txtDesigName;
        private System.Windows.Forms.Label lblDesigName;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNDESIGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVDESIGNATIONNAME;
    }
}