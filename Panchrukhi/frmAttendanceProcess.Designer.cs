namespace Panchrukhi
{
    partial class frmAttendanceProcess
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
            this.gpIPList = new System.Windows.Forms.GroupBox();
            this.pnlBODY = new System.Windows.Forms.Panel();
            this.dgvfrmMachines = new System.Windows.Forms.DataGridView();
            this.colCHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInOutCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBOTTOM = new System.Windows.Forms.Panel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.pnlTOP = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblLoad = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colSLLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIOType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachineIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblstartTime = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblTotalData = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chkDateCorrection = new System.Windows.Forms.CheckBox();
            this.dtpAlterDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpIPList.SuspendLayout();
            this.pnlBODY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).BeginInit();
            this.pnlBOTTOM.SuspendLayout();
            this.pnlTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpIPList
            // 
            this.gpIPList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpIPList.Controls.Add(this.pnlBODY);
            this.gpIPList.Controls.Add(this.pnlBOTTOM);
            this.gpIPList.Controls.Add(this.pnlTOP);
            this.gpIPList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpIPList.Location = new System.Drawing.Point(4, 12);
            this.gpIPList.Name = "gpIPList";
            this.gpIPList.Size = new System.Drawing.Size(339, 711);
            this.gpIPList.TabIndex = 11;
            this.gpIPList.TabStop = false;
            this.gpIPList.Text = "Machine Information";
            // 
            // pnlBODY
            // 
            this.pnlBODY.Controls.Add(this.dgvfrmMachines);
            this.pnlBODY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBODY.Location = new System.Drawing.Point(3, 45);
            this.pnlBODY.Name = "pnlBODY";
            this.pnlBODY.Size = new System.Drawing.Size(333, 630);
            this.pnlBODY.TabIndex = 5;
            // 
            // dgvfrmMachines
            // 
            this.dgvfrmMachines.AllowUserToAddRows = false;
            this.dgvfrmMachines.AllowUserToDeleteRows = false;
            this.dgvfrmMachines.BackgroundColor = System.Drawing.Color.White;
            this.dgvfrmMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfrmMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCHK,
            this.colSL,
            this.colIP,
            this.colLocation,
            this.colInOut,
            this.colStatus,
            this.colPort,
            this.colCode,
            this.colInOutCode,
            this.colStatusCode});
            this.dgvfrmMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfrmMachines.Location = new System.Drawing.Point(0, 0);
            this.dgvfrmMachines.Name = "dgvfrmMachines";
            this.dgvfrmMachines.RowHeadersVisible = false;
            this.dgvfrmMachines.Size = new System.Drawing.Size(333, 630);
            this.dgvfrmMachines.TabIndex = 2;
            // 
            // colCHK
            // 
            this.colCHK.HeaderText = "";
            this.colCHK.Name = "colCHK";
            this.colCHK.Width = 30;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Width = 50;
            // 
            // colIP
            // 
            this.colIP.HeaderText = "IP";
            this.colIP.Name = "colIP";
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            // 
            // colInOut
            // 
            this.colInOut.HeaderText = "InOut";
            this.colInOut.Name = "colInOut";
            this.colInOut.Width = 50;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colPort
            // 
            this.colPort.HeaderText = "Port";
            this.colPort.Name = "colPort";
            this.colPort.Width = 40;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Width = 30;
            // 
            // colInOutCode
            // 
            this.colInOutCode.HeaderText = "I/O";
            this.colInOutCode.Name = "colInOutCode";
            // 
            // colStatusCode
            // 
            this.colStatusCode.HeaderText = "STATUS_CODE";
            this.colStatusCode.Name = "colStatusCode";
            // 
            // pnlBOTTOM
            // 
            this.pnlBOTTOM.Controls.Add(this.chkSelectAll);
            this.pnlBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBOTTOM.Location = new System.Drawing.Point(3, 675);
            this.pnlBOTTOM.Name = "pnlBOTTOM";
            this.pnlBOTTOM.Size = new System.Drawing.Size(333, 33);
            this.pnlBOTTOM.TabIndex = 4;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(10, 8);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 0;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // pnlTOP
            // 
            this.pnlTOP.Controls.Add(this.dtpDate);
            this.pnlTOP.Controls.Add(this.btnReload);
            this.pnlTOP.Controls.Add(this.btnConnect);
            this.pnlTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTOP.Location = new System.Drawing.Point(3, 16);
            this.pnlTOP.Name = "pnlTOP";
            this.pnlTOP.Size = new System.Drawing.Size(333, 29);
            this.pnlTOP.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(189, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(115, 20);
            this.dtpDate.TabIndex = 14;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(10, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(108, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLoad.Location = new System.Drawing.Point(201, 3);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(23, 13);
            this.lblLoad.TabIndex = 12;
            this.lblLoad.Text = "....";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLLog,
            this.colID,
            this.colTime,
            this.colDate,
            this.colIO,
            this.colIOType,
            this.colMachineIP});
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 32);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.Size = new System.Drawing.Size(369, 612);
            this.dgvLog.TabIndex = 13;
            // 
            // colSLLog
            // 
            this.colSLLog.HeaderText = "SL";
            this.colSLLog.Name = "colSLLog";
            this.colSLLog.Width = 30;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 50;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.Width = 60;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Width = 75;
            // 
            // colIO
            // 
            this.colIO.HeaderText = "IO";
            this.colIO.Name = "colIO";
            this.colIO.Visible = false;
            this.colIO.Width = 25;
            // 
            // colIOType
            // 
            this.colIOType.HeaderText = "Type";
            this.colIOType.Name = "colIOType";
            this.colIOType.Width = 40;
            // 
            // colMachineIP
            // 
            this.colMachineIP.HeaderText = "Machine";
            this.colMachineIP.Name = "colMachineIP";
            this.colMachineIP.Width = 90;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndTime.Location = new System.Drawing.Point(166, 7);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(19, 13);
            this.lblEndTime.TabIndex = 16;
            this.lblEndTime.Text = "....";
            // 
            // lblstartTime
            // 
            this.lblstartTime.AutoSize = true;
            this.lblstartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblstartTime.Location = new System.Drawing.Point(10, 7);
            this.lblstartTime.Name = "lblstartTime";
            this.lblstartTime.Size = new System.Drawing.Size(19, 13);
            this.lblstartTime.TabIndex = 15;
            this.lblstartTime.Text = "....";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(6, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 17;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblTotalData
            // 
            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalData.Location = new System.Drawing.Point(190, 8);
            this.lblTotalData.Name = "lblTotalData";
            this.lblTotalData.Size = new System.Drawing.Size(19, 13);
            this.lblTotalData.TabIndex = 18;
            this.lblTotalData.Text = "....";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvLog);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(382, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 708);
            this.panel1.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.chkDateCorrection);
            this.panel10.Controls.Add(this.dtpAlterDate);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 644);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(369, 31);
            this.panel10.TabIndex = 14;
            // 
            // chkDateCorrection
            // 
            this.chkDateCorrection.AutoSize = true;
            this.chkDateCorrection.Location = new System.Drawing.Point(142, 8);
            this.chkDateCorrection.Name = "chkDateCorrection";
            this.chkDateCorrection.Size = new System.Drawing.Size(103, 17);
            this.chkDateCorrection.TabIndex = 16;
            this.chkDateCorrection.Text = "Date Correction:";
            this.chkDateCorrection.UseVisualStyleBackColor = true;
            this.chkDateCorrection.CheckedChanged += new System.EventHandler(this.chkDateCorrection_CheckedChanged);
            // 
            // dtpAlterDate
            // 
            this.dtpAlterDate.CustomFormat = "dd/MM/yyyy";
            this.dtpAlterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlterDate.Location = new System.Drawing.Point(251, 5);
            this.dtpAlterDate.Name = "dtpAlterDate";
            this.dtpAlterDate.Size = new System.Drawing.Size(115, 20);
            this.dtpAlterDate.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalData);
            this.panel3.Controls.Add(this.btnProcess);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 675);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 31);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblstartTime);
            this.panel2.Controls.Add(this.lblEndTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 32);
            this.panel2.TabIndex = 0;
            // 
            // frmAttendanceProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.gpIPList);
            this.Name = "frmAttendanceProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process System Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAttendanceProcess_FormClosed);
            this.Load += new System.EventHandler(this.frmAttendanceProcess_Load);
            this.gpIPList.ResumeLayout(false);
            this.pnlBODY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmMachines)).EndInit();
            this.pnlBOTTOM.ResumeLayout(false);
            this.pnlBOTTOM.PerformLayout();
            this.pnlTOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpIPList;
        private System.Windows.Forms.Panel pnlBODY;
        private System.Windows.Forms.DataGridView dgvfrmMachines;
        private System.Windows.Forms.Panel pnlBOTTOM;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Panel pnlTOP;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Button btnConnect;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblstartTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInOutCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusCode;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblTotalData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIOType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachineIP;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtpAlterDate;
        private System.Windows.Forms.CheckBox chkDateCorrection;
    }
}