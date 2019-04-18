namespace Panchrukhi
{
    partial class frmSlotData
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblSlotInTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSlotName = new System.Windows.Forms.TextBox();
            this.lblSlotName = new System.Windows.Forms.Label();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.NSLOTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VSLOTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVINTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVOUTTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSlotInTime = new System.Windows.Forms.DateTimePicker();
            this.txtSlotOutTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(360, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(360, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(360, 27);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnSaveAndUpdate.TabIndex = 71;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.BtnSaveAndUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Out Time";
            // 
            // lblSlotInTime
            // 
            this.lblSlotInTime.AutoSize = true;
            this.lblSlotInTime.Location = new System.Drawing.Point(71, 70);
            this.lblSlotInTime.Name = "lblSlotInTime";
            this.lblSlotInTime.Size = new System.Drawing.Size(42, 13);
            this.lblSlotInTime.TabIndex = 68;
            this.lblSlotInTime.Text = "In Time";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 105);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFrmSlotClose_Click);
            // 
            // txtSlotName
            // 
            this.txtSlotName.Location = new System.Drawing.Point(143, 40);
            this.txtSlotName.Name = "txtSlotName";
            this.txtSlotName.Size = new System.Drawing.Size(191, 20);
            this.txtSlotName.TabIndex = 96;
            this.txtSlotName.TextChanged += new System.EventHandler(this.txtSlotName_TextChanged);
            // 
            // lblSlotName
            // 
            this.lblSlotName.AutoSize = true;
            this.lblSlotName.Location = new System.Drawing.Point(55, 43);
            this.lblSlotName.Name = "lblSlotName";
            this.lblSlotName.Size = new System.Drawing.Size(59, 13);
            this.lblSlotName.TabIndex = 95;
            this.lblSlotName.Text = "Shift Name";
            // 
            // dataGridData
            // 
            this.dataGridData.AllowUserToAddRows = false;
            this.dataGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NSLOTID,
            this.VSLOTNAME,
            this.colVINTIME,
            this.colVOUTTIME});
            this.dataGridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridData.Location = new System.Drawing.Point(27, 149);
            this.dataGridData.MultiSelect = false;
            this.dataGridData.Name = "dataGridData";
            this.dataGridData.Size = new System.Drawing.Size(422, 271);
            this.dataGridData.TabIndex = 97;
            this.dataGridData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridData_RowHeaderMouseClick);
            this.dataGridData.SelectionChanged += new System.EventHandler(this.DataGridData_SelectionChanged);
            // 
            // NSLOTID
            // 
            this.NSLOTID.DataPropertyName = "NSLOTID";
            this.NSLOTID.HeaderText = "Slot ID";
            this.NSLOTID.Name = "NSLOTID";
            this.NSLOTID.ReadOnly = true;
            this.NSLOTID.Visible = false;
            // 
            // VSLOTNAME
            // 
            this.VSLOTNAME.DataPropertyName = "VSLOTNAME";
            this.VSLOTNAME.HeaderText = "Slot Name";
            this.VSLOTNAME.Name = "VSLOTNAME";
            this.VSLOTNAME.ReadOnly = true;
            this.VSLOTNAME.Width = 120;
            // 
            // colVINTIME
            // 
            this.colVINTIME.DataPropertyName = "VINTIME";
            this.colVINTIME.HeaderText = "IN Time";
            this.colVINTIME.MinimumWidth = 6;
            this.colVINTIME.Name = "colVINTIME";
            this.colVINTIME.ReadOnly = true;
            this.colVINTIME.Width = 120;
            // 
            // colVOUTTIME
            // 
            this.colVOUTTIME.DataPropertyName = "VOUTTIME";
            this.colVOUTTIME.HeaderText = "OUT Time";
            this.colVOUTTIME.Name = "colVOUTTIME";
            this.colVOUTTIME.ReadOnly = true;
            this.colVOUTTIME.Width = 120;
            // 
            // txtSlotInTime
            // 
            this.txtSlotInTime.Location = new System.Drawing.Point(144, 67);
            this.txtSlotInTime.Name = "txtSlotInTime";
            this.txtSlotInTime.Size = new System.Drawing.Size(190, 20);
            this.txtSlotInTime.TabIndex = 108;
            // 
            // txtSlotOutTime
            // 
            this.txtSlotOutTime.Location = new System.Drawing.Point(143, 96);
            this.txtSlotOutTime.Name = "txtSlotOutTime";
            this.txtSlotOutTime.Size = new System.Drawing.Size(190, 20);
            this.txtSlotOutTime.TabIndex = 109;
            // 
            // frmSlotData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 432);
            this.Controls.Add(this.txtSlotOutTime);
            this.Controls.Add(this.txtSlotInTime);
            this.Controls.Add(this.dataGridData);
            this.Controls.Add(this.txtSlotName);
            this.Controls.Add(this.lblSlotName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSlotInTime);
            this.Name = "frmSlotData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSlotData_FormClosed);
            this.Load += new System.EventHandler(this.FrmData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSlotInTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSlotName;
        private System.Windows.Forms.Label lblSlotName;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSLOTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VSLOTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVINTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVOUTTIME;
        private System.Windows.Forms.DateTimePicker txtSlotInTime;
        private System.Windows.Forms.DateTimePicker txtSlotOutTime;
    }
}