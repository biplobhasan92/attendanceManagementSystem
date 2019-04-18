namespace Panchrukhi
{
    partial class frmClassData
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
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblSlotName = new System.Windows.Forms.Label();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.colNCLASSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVSLOTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(345, 76);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(345, 50);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnSaveAndUpdate.TabIndex = 71;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.BtnSaveAndUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(345, 128);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFrmSlotClose_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(86, 12);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(248, 20);
            this.txtClassName.TabIndex = 96;
            this.txtClassName.TextChanged += new System.EventHandler(this.txtClassName_TextChanged);
            // 
            // lblSlotName
            // 
            this.lblSlotName.AutoSize = true;
            this.lblSlotName.Location = new System.Drawing.Point(16, 15);
            this.lblSlotName.Name = "lblSlotName";
            this.lblSlotName.Size = new System.Drawing.Size(63, 13);
            this.lblSlotName.TabIndex = 95;
            this.lblSlotName.Text = "Class Name";
            // 
            // dataGridData
            // 
            this.dataGridData.AllowUserToAddRows = false;
            this.dataGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNCLASSID,
            this.colVSLOTNAME});
            this.dataGridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridData.Location = new System.Drawing.Point(19, 48);
            this.dataGridData.MultiSelect = false;
            this.dataGridData.Name = "dataGridData";
            this.dataGridData.Size = new System.Drawing.Size(315, 297);
            this.dataGridData.TabIndex = 97;
            this.dataGridData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridData_RowHeaderMouseClick);
            this.dataGridData.SelectionChanged += new System.EventHandler(this.DataGridData_SelectionChanged);
            // 
            // colNCLASSID
            // 
            this.colNCLASSID.DataPropertyName = "NCLASSID";
            this.colNCLASSID.HeaderText = "Class ID";
            this.colNCLASSID.Name = "colNCLASSID";
            this.colNCLASSID.ReadOnly = true;
            this.colNCLASSID.Visible = false;
            // 
            // colVSLOTNAME
            // 
            this.colVSLOTNAME.DataPropertyName = "VCLASSNAME";
            this.colVSLOTNAME.HeaderText = "Class Name";
            this.colVSLOTNAME.Name = "colVSLOTNAME";
            this.colVSLOTNAME.ReadOnly = true;
            this.colVSLOTNAME.Width = 200;
            // 
            // frmClassData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 357);
            this.Controls.Add(this.dataGridData);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblSlotName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Name = "frmClassData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Class";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClassData_FormClosed);
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
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblSlotName;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNCLASSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVSLOTNAME;
    }
}