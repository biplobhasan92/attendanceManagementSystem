namespace Panchrukhi
{
    partial class IPStatusCheck
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvfrmMachines = new System.Windows.Forms.DataGridView();
            this.ColSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoundTripTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblms = new System.Windows.Forms.Label();
            this.txtPing = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.chkRange = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnZK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvfrmMachines);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 384);
            this.panel1.TabIndex = 0;
            // 
            // dgvfrmMachines
            // 
            this.dgvfrmMachines.AllowUserToAddRows = false;
            this.dgvfrmMachines.AllowUserToDeleteRows = false;
            this.dgvfrmMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfrmMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSL,
            this.ColIPAddress,
            this.colLocation,
            this.ColStatus,
            this.ColRoundTripTimes,
            this.colPCName});
            this.dgvfrmMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfrmMachines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvfrmMachines.Location = new System.Drawing.Point(0, 0);
            this.dgvfrmMachines.Name = "dgvfrmMachines";
            this.dgvfrmMachines.ReadOnly = true;
            this.dgvfrmMachines.Size = new System.Drawing.Size(801, 384);
            this.dgvfrmMachines.TabIndex = 0;
            // 
            // ColSL
            // 
            this.ColSL.HeaderText = "SL";
            this.ColSL.Name = "ColSL";
            this.ColSL.ReadOnly = true;
            this.ColSL.Width = 30;
            // 
            // ColIPAddress
            // 
            this.ColIPAddress.HeaderText = "IP Address";
            this.ColIPAddress.Name = "ColIPAddress";
            this.ColIPAddress.ReadOnly = true;
            this.ColIPAddress.Width = 120;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 200;
            // 
            // ColRoundTripTimes
            // 
            this.ColRoundTripTimes.HeaderText = "Round Trip Times";
            this.ColRoundTripTimes.Name = "ColRoundTripTimes";
            this.ColRoundTripTimes.ReadOnly = true;
            this.ColRoundTripTimes.Width = 200;
            // 
            // colPCName
            // 
            this.colPCName.HeaderText = "Host Name";
            this.colPCName.Name = "colPCName";
            this.colPCName.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblms);
            this.panel2.Controls.Add(this.txtPing);
            this.panel2.Controls.Add(this.txtTo);
            this.panel2.Controls.Add(this.txtfrom);
            this.panel2.Controls.Add(this.chkRange);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnZK);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Location = new System.Drawing.Point(12, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 103);
            this.panel2.TabIndex = 1;
            // 
            // lblms
            // 
            this.lblms.AutoSize = true;
            this.lblms.Location = new System.Drawing.Point(776, 54);
            this.lblms.Name = "lblms";
            this.lblms.Size = new System.Drawing.Size(20, 13);
            this.lblms.TabIndex = 13;
            this.lblms.Text = "ms";
            // 
            // txtPing
            // 
            this.txtPing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPing.Location = new System.Drawing.Point(725, 49);
            this.txtPing.Name = "txtPing";
            this.txtPing.Size = new System.Drawing.Size(45, 20);
            this.txtPing.TabIndex = 12;
            this.txtPing.Text = "500";
            this.txtPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTo
            // 
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTo.Enabled = false;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(123, 35);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(45, 20);
            this.txtTo.TabIndex = 11;
            this.txtTo.Text = "254";
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfrom
            // 
            this.txtfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfrom.Enabled = false;
            this.txtfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.Location = new System.Drawing.Point(72, 35);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(45, 20);
            this.txtfrom.TabIndex = 10;
            this.txtfrom.Text = "1";
            this.txtfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkRange
            // 
            this.chkRange.AutoSize = true;
            this.chkRange.Location = new System.Drawing.Point(9, 37);
            this.chkRange.Name = "chkRange";
            this.chkRange.Size = new System.Drawing.Size(58, 17);
            this.chkRange.TabIndex = 9;
            this.chkRange.Text = "Range";
            this.chkRange.UseVisualStyleBackColor = true;
            this.chkRange.CheckedChanged += new System.EventHandler(this.chkRange_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(95, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnZK
            // 
            this.btnZK.Location = new System.Drawing.Point(4, 4);
            this.btnZK.Name = "btnZK";
            this.btnZK.Size = new System.Drawing.Size(85, 23);
            this.btnZK.TabIndex = 6;
            this.btnZK.Text = "Load ZK IP";
            this.btnZK.UseVisualStyleBackColor = true;
            this.btnZK.Click += new System.EventHandler(this.btnZK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(648, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(343, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Start....";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(111, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(538, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(725, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(648, 47);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(71, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Ping";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // IPStatusCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IPStatusCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Addess Check";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IPStatusCheck_FormClosed);
            this.Load += new System.EventHandler(this.IPStatusCheck_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvfrmMachines;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnZK;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.CheckBox chkRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoundTripTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPCName;
        private System.Windows.Forms.Label lblms;
        private System.Windows.Forms.TextBox txtPing;
    }
}

