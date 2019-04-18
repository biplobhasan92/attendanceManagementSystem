using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
//using ERP.ModuleManagement;
using System.Net;
using Panchrukhi.DAO;
using System.Data.SQLite;
using System.Net.Sockets;

namespace Panchrukhi
{
    public partial class IPStatusCheck : Form
    {
       // ITaskManager objTask = ModuleManagers.GetTaskManager();
        public string ZKorLocal = "";
        // public  string hostName = "";



        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet DS;
        private DataTable DT = new DataTable();
        private SQLiteDataAdapter DB;

        public IPStatusCheck()
        {
            InitializeComponent();

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged +=new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted +=new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void IPStatusCheck_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        /*
         * string CommandText = "select NID, VMACHINEIP, VLOCATION, VMACHINEPORT, NIN_OUT_STATUS, CASE NIN_OUT_STATUS WHEN 0 then 'Both' WHEN 1 then 'In' WHEN 5 then 'Out' ELSE 'NA' END as INOUT from TBL_ATTEN_DEVICE  order by NID";
                DBConn.ExecutionQuery(CommandText);
                DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
         * 
         * 
         * */






        private void LoadMachineInfo()
        {
            try
            {
                var Query = "";
                Query = "select NID, VMACHINEIP, VLOCATION, VMACHINEPORT, NIN_OUT_STATUS, CASE NIN_OUT_STATUS WHEN 0 then 'Both' WHEN 1 then 'In' WHEN 5 then 'Out' ELSE 'NA' END as INOUT from TBL_ATTEN_DEVICE  order by NID";
                DataSet dsLoad = new DataSet();
                DBConn.ExecutionQuery(Query);
                DB = new SQLiteDataAdapter(Query, DBConn.sql_conn);
                dsLoad.Reset();
                DB.Fill(dsLoad);
                dgvfrmMachines.Rows.Clear();
                if (dsLoad.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsLoad.Tables[0].Rows)
                    {
                        dgvfrmMachines.Rows.Add();
                        dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[ColSL.Index].Value = dgvfrmMachines.Rows.Count;
                        dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[ColIPAddress.Index].Value = dr["VMACHINEIP"].ToString();
                        dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colLocation.Index].Value =  dr["VLOCATION"].ToString();
                        //dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colLocation.Index].Value = dr["vLocation"].ToString();
                        //dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colPort.Index].Value = dr["vmachinePort"].ToString();
                        //dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colInOut.Index].Value = dr["INOUT"].ToString();
                        //dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colCode.Index].Value = dr["nID"].ToString();
                        //dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colInOutCode.Index].Value = dr["nin_out_status"].ToString();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + " database connectivity problem");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
            btnCancel.Enabled = true;
            
            backgroundWorker1.RunWorkerAsync();                     
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            string pcName="";
            //dataGridView1.Rows.Clear();
            foreach (DataGridViewRow dRow in dgvfrmMachines.Rows)
            {

                var ipAddress = dRow.Cells["ColIPAddress"].Value;
                if (ZKorLocal == "LOCAL")
                    pcName = GetPCName(ipAddress.ToString());
                if (ipAddress == "192.168.10.157")
                {
 
                }
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(ipAddress.ToString(), Convert.ToInt32(txtPing.Text));
                var address = pingReply.Address;
                var roundTripTimes = pingReply.RoundtripTime;
                var status = pingReply.Status;
                dRow.Cells[colPCName.Index].Value = pcName.ToString();
                if (status.ToString() == "Success")
                {
                    dRow.Cells[ColStatus.Index].Value = status.ToString();
                    //dRow.DefaultCellStyle.BackColor = Color.LightBlue;
                    dRow.DefaultCellStyle.ForeColor = Color.Blue;

                    //dataGridView1.Columns[ColStatus.Index].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dRow.Cells[ColStatus.Index].Value = status.ToString();
                    dRow.DefaultCellStyle.ForeColor = Color.Red;
                    //dataGridView1.Columns[ColStatus.Index].DefaultCellStyle.BackColor = Color.Red;
                }
                dRow.Cells[ColRoundTripTimes.Index].Value = roundTripTimes.ToString() + " ms ";
                backgroundWorker1.ReportProgress(i);

                i++;

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            backgroundWorker1.ReportProgress(100);
        }
        private string GetPCName(string _IP)
        {

            string _PCName = "NA";
            try
            {
                IPHostEntry ip = Dns.GetHostByAddress(_IP);
                _PCName = ip.HostName.ToString();
            }
            catch (Exception a)
            {
                return _PCName;
             //   _PCName = "NA";
            }

            return _PCName;
        }
        //private  string FindLocalIPAddress()
        //{
        //    try
        //    {
        //        //IPHostEntry host;
        //        var localIP = "?";
        //      var   host = Dns.GetHostEntry(Dns.GetHostName());
                
        //        foreach (IPAddress ip in host.AddressList)
        //        {
        //            //if (ip.AddressFamily.ToString() == "InterNetwork")                  
        //            if (ip.AddressFamily.ToString() == AddressFamily.InterNetwork.ToString())
        //            {
        //                localIP = ip.ToString();
        //            }
        //        }
        //        return localIP;
        //    }
        //    catch (SocketException se)
        //    {
        //        return null;
        //    }

        //}

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = "Processing......" + progressBar1.Value.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Text = "Task cancelled";
            }
            else if (e.Error != null)
            {
                lblStatus.Text = "Error while performing background operation.";
            }
            else
            {
                lblStatus.Text = "Task Completed...";
            }
            btnCheck.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnZK_Click(object sender, EventArgs e)
        {
            ZKorLocal = "ZK";
            LoadMachineInfo();      
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            ZKorLocal = "LOCAL";
            LoadLocalIP();
        }
        private void LoadLocalIP()
        {
            dgvfrmMachines.Rows.Clear();
            int fid = 1;
            int lid = 254;
            if (chkRange.Checked && txtfrom.Text.Trim()!="" && txtTo.Text.Trim()!="")
            {
                fid = Convert.ToInt32(this.txtfrom.Text);
                lid = Convert.ToInt32(this.txtTo.Text);
 
            }
            for (int ip = fid; ip <=lid; ip++)
            {
                dgvfrmMachines.Rows.Add();
                dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[ColSL.Index].Value = dgvfrmMachines.Rows.Count;
                dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[ColIPAddress.Index].Value ="192.168.100."+ip.ToString() ;
                dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colLocation.Index].Value = "Local";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvfrmMachines.Rows.Clear();
            progressBar1.Value = 0;
        }

        private void chkRange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRange.Checked)
            {
                this.txtTo.Enabled = true;
                this.txtfrom.Enabled = true;
            }
            else
            {
                this.txtTo.Enabled = false;
                this.txtfrom.Enabled = false;
 
            }
        }

        private void IPStatusCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
