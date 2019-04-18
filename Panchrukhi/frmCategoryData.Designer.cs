namespace Panchrukhi
{
    partial class frmCategory
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
            this.txtCtgryName = new System.Windows.Forms.TextBox();
            this.lblCtgryName = new System.Windows.Forms.Label();
            this.dataGridCategory = new System.Windows.Forms.DataGridView();
            this.colNCATID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVCATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 23);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(291, 87);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 23);
            this.btnReset.TabIndex = 66;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(291, 58);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(69, 23);
            this.btnSaveAndUpdate.TabIndex = 65;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.btnSaveAndUpdate_Click);
            // 
            // txtCtgryName
            // 
            this.txtCtgryName.Location = new System.Drawing.Point(81, 22);
            this.txtCtgryName.Name = "txtCtgryName";
            this.txtCtgryName.Size = new System.Drawing.Size(174, 20);
            this.txtCtgryName.TabIndex = 64;
            this.txtCtgryName.TextChanged += new System.EventHandler(this.txtCtgryName_TextChanged);
            // 
            // lblCtgryName
            // 
            this.lblCtgryName.AutoSize = true;
            this.lblCtgryName.Location = new System.Drawing.Point(17, 25);
            this.lblCtgryName.Name = "lblCtgryName";
            this.lblCtgryName.Size = new System.Drawing.Size(49, 13);
            this.lblCtgryName.TabIndex = 62;
            this.lblCtgryName.Text = "Category";
            // 
            // dataGridCategory
            // 
            this.dataGridCategory.AllowUserToAddRows = false;
            this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNCATID,
            this.colVCATEGORY});
            this.dataGridCategory.Location = new System.Drawing.Point(12, 56);
            this.dataGridCategory.Name = "dataGridCategory";
            this.dataGridCategory.Size = new System.Drawing.Size(273, 246);
            this.dataGridCategory.TabIndex = 68;
            this.dataGridCategory.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCategory_ColumnHeaderMouseClick);
            this.dataGridCategory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCategory_RowHeaderMouseClick);
            this.dataGridCategory.SelectionChanged += new System.EventHandler(this.dataGridCategory_SelectionChanged);
            // 
            // colNCATID
            // 
            this.colNCATID.DataPropertyName = "NCATID";
            this.colNCATID.HeaderText = "CAT ID";
            this.colNCATID.Name = "colNCATID";
            this.colNCATID.Visible = false;
            // 
            // colVCATEGORY
            // 
            this.colVCATEGORY.DataPropertyName = "VCATEGORY";
            this.colVCATEGORY.HeaderText = "Category";
            this.colVCATEGORY.Name = "colVCATEGORY";
            this.colVCATEGORY.Width = 150;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 23);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 314);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Controls.Add(this.txtCtgryName);
            this.Controls.Add(this.lblCtgryName);
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCategory_FormClosed);
            this.Load += new System.EventHandler(this.frmPrsnCategoryData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.TextBox txtCtgryName;
        private System.Windows.Forms.Label lblCtgryName;
        private System.Windows.Forms.DataGridView dataGridCategory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNCATID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVCATEGORY;
    }
}