using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;
using Panchrukhi.DAO;
//using ERP.ModuleManagement;
//using ERP.ModuleManagement;


namespace Panchrukhi
{
    public partial class frmAddNewMachine : Form
    {
        //ITaskManager objTask = ModuleManagers.GetTaskManager();

        public frmAddNewMachine()
        {
            InitializeComponent();
        }

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet    DS     = new DataSet();
        private DataTable  DT     = new DataTable();
        private SQLiteDataAdapter DB;
        int getIdOfMachine = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewMachine_Load(object sender, EventArgs e)
        {
            cmbMachinType.SelectedIndex = 0;
            LoadData();
            this.Owner.Enabled = false;
        }

   

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            DataSave();
        }

        private void DataSave()
        {
            int inOutSts  = 0;
            var Query     = "";
            int stsIntVal = 0;

            if (cmbMachinType.SelectedIndex == 0) { inOutSts = 1;} else if (cmbMachinType.SelectedIndex == 1) { inOutSts = 5; } else if (cmbMachinType.SelectedIndex == 2){ inOutSts = 0;}
            
            string statusValue = cmbStatus.SelectedItem.ToString();
            if (statusValue == "Active") { stsIntVal = 1; }

            if (btnSave.Text == "Save")
            {   
                Query = "insert into TBL_ATTEN_DEVICE(NID,VMACHINEIP,VLOCATION,VMACHINEPORT, NIN_OUT_STATUS, MACHINE_STATUS) values(" +
                        " (select CASE WHEN max(NID) >= 0 THEN max(NID) + 1 ELSE 1 END FROM TBL_ATTEN_DEVICE) ," +
                        "'" + txtMachineIP.Text   + "'," +
                        "'" + txtLocation.Text    + "'," +
                        "'" + txtMachinePort.Text + "'," +
                        " " + inOutSts + ", " +
                        " " + stsIntVal + "" +
                        ")"; 

            }
            else if (btnSave.Text == "Update")
            {
                Query = "UPDATE TBL_ATTEN_DEVICE set " +
                           "   VMACHINEIP     = '" + txtMachineIP.Text +
                           "', VLOCATION      = '" + txtLocation.Text  +
                           "', VMACHINEPORT   = '" + txtMachinePort.Text +
                           "', NIN_OUT_STATUS = "  + inOutSts  +
                           ",  MACHINE_STATUS = "  + stsIntVal +
                        " WHERE NID =" + getIdOfMachine;// NEMPID
            }
            

            if (DBConn.ExecutionQuery(Query))
            {
                MessageBox.Show("Machine information has been saved successfully", "Machine entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                resetFields();              
            }
        }



      


        // Load Data From SQlite Database
        private void LoadData()
        {
            string CommandText = " select NID, VMACHINEIP, VLOCATION, VMACHINEPORT, CASE NIN_OUT_STATUS WHEN 0 then 'Both' WHEN 1 then 'In' WHEN 5 then 'Out' ELSE 'NA' END as INOUT," +
                                 " CASE MACHINE_STATUS WHEN 1 then 'Active' ELSE 'Inactive' END as Status from TBL_ATTEN_DEVICE  order by NID";
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dgvfrmMachines.DataSource = DT;
            CellFornColor();
        } 
        
       



        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

      

        private void resetFields()
        {
            txtLocation.Text = "";
            txtMachineIP.Text = "";
            //txtMachinePort.Text = "";
            cmbStatus.SelectedItem = "";
            cmbMachinType.SelectedItem = "";
            btnSave.Text = "Save";
        }

        private void dgvfrmMachines_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            getIdOfMachine      = Convert.ToInt32(dgvfrmMachines.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtMachineIP.Text   = dgvfrmMachines.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLocation.Text    = dgvfrmMachines.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMachinePort.Text = dgvfrmMachines.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbMachinType.Text  = dgvfrmMachines.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbStatus.Text      = dgvfrmMachines.Rows[e.RowIndex].Cells[5].Value.ToString();
            btnSave.Text        = "Update";
        }

        private void dgvfrmMachines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvfrmMachines.SelectedRows.Count == 0 || dgvfrmMachines.SelectedRows[0].Index == dgvfrmMachines.Rows.Count) return;
            getIdOfMachine      = Convert.ToInt32(dgvfrmMachines[colSL.Index, dgvfrmMachines.SelectedRows[0].Index].Value.ToString());
            txtMachineIP.Text   = dgvfrmMachines[colIP.Index+1,       dgvfrmMachines.SelectedRows[0].Index].Value.ToString();
            txtLocation.Text    = dgvfrmMachines[colLocation.Index+2, dgvfrmMachines.SelectedRows[0].Index].Value.ToString();
            txtMachinePort.Text = dgvfrmMachines[colPort.Index + 3,   dgvfrmMachines.SelectedRows[0].Index].Value.ToString();
            cmbMachinType.Text  = dgvfrmMachines[colType.Index + 4,   dgvfrmMachines.SelectedRows[0].Index].Value.ToString();
            cmbStatus.Text      = dgvfrmMachines[colStatus.Index + 5, dgvfrmMachines.SelectedRows[0].Index].Value.ToString();
            btnSave.Text        = "Update";

            if (dgvfrmMachines[colStatus.Index + 5, dgvfrmMachines.SelectedRows[0].Index].Value.ToString() == "Active") {
                
            }
        }

        public void CellFornColor() {
            for (int i=0; i<dgvfrmMachines.Rows.Count; i++) {
                string val = dgvfrmMachines.Rows[i].Cells[5].Value.ToString();
                if (val == "Active") {
                    dgvfrmMachines.Rows[i].Cells[colIP.Index+1].Style.ForeColor = Color.ForestGreen;
                }
            }
        }

        private void frmAddNewMachine_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
