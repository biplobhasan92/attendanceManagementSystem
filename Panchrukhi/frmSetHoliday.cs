using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panchrukhi.DAO;
using System.Data.SQLite;

namespace Panchrukhi
{
    public partial class frmSetHoliday : Form
    {
        public frmSetHoliday()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize    = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            ClearData();
            LoadData();
            dtPkrFormDate.Format = dtPkrToDate.Format = DateTimePickerFormat.Custom;
            dtPkrFormDate.CustomFormat = dtPkrToDate.CustomFormat = "dd/MM/yyyy";
        }

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet DS;
        private DataTable DT;


        //private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        int getHID=0;





        // Slot Form Close Button
        private void btnFrmSlotClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnSaveAndUpdate_Click(object sender, EventArgs e)
        {

            if (getHID == 0)
            {

                string cmdText = "";

                for (DateTime date = Convert.ToDateTime(dtPkrFormDate.Text); date.Date <= Convert.ToDateTime(dtPkrToDate.Text); date = date.AddDays(1))
                {
                    foreach (DataGridViewRow dr in dataGridView.Rows)
                    {
                        if(Convert.ToDateTime(dr.Cells[colHDate.Index].Value)== date)
                        {
                            DialogResult dResult = MessageBox.Show(this, "Date conflicts on " + date.ToString() + ". Do you still want to update?", "Date conflict", MessageBoxButtons.YesNo);
                            if (dResult == DialogResult.No) return;  
                        } 
                    }
                }

                for (DateTime date = Convert.ToDateTime(dtPkrFormDate.Text); date.Date <= Convert.ToDateTime(dtPkrToDate.Text); date = date.AddDays(1))
                {
                    cmdText += "Delete from TBL_HOLIDAY where DDATE between '"+ dtPkrFormDate.Text + "' and '"+ dtPkrToDate.Text + "'; ";
                }


                for (DateTime date = Convert.ToDateTime(dtPkrFormDate.Text); date.Date <= Convert.ToDateTime(dtPkrToDate.Text); date = date.AddDays(1))
                {
                    cmdText += " INSERT INTO TBL_HOLIDAY(NHID, DDATE, N_HCATID) " +
                               " VALUES(  " +
                               "   (select CASE WHEN max(NHID) >= 0 THEN max(NHID)+1 ELSE 1 END FROM TBL_HOLIDAY)," +
                               " '"+date.ToShortDateString()+ "', " +
                               " IFNULL(" + (cmbHolidayCat.SelectedItem as dynamic).Value + ", 1) " +
                               ");  ";
                }

                if (DBConn.ExecutionQuery(cmdText))
                {
                    MessageBox.Show("Holidays Insert Succeed !");
                    ClearData();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Something is wrong ??? !");
                }

            }
            else
            {
                
            }
        }




        
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }





        // Form Clear Method
        void ClearData()
        {
            cmbHolidayCat.Text = dtPkrFormDate.Text = dtPkrToDate.Text = "";
            getHID = 0;
        }

        // Load Data From SQlite Database
        private void LoadData()
        {
            DT = new DataTable();
            DS = new DataSet();
            string CommandText = "Select TH.*, (select TC.VDESCRIPTION from TBL_HOLIDAY_CATEGORY TC where (TC.N_HCATID = TH.N_HCATID) ) CATEGORY from TBL_HOLIDAY TH";
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DBConn.ExecutionQuery(CommandText);
            DS.Reset();
            DB.Fill(DS);
            //DT = DS.Tables[0];
            //dataGridView.DataSource = DT;
            dataGridView.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in DS.Tables[0].Rows)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colNHID.Index].Value = dataGridView.Rows.Count;
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colHDate.Index].Value     = dr["DDATE"].ToString();
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colHCategory.Index].Value = dr["CATEGORY"].ToString();
                    // dgvfrmMachines.Rows[dgvfrmMachines.Rows.Count - 1].Cells[colLocation.Index].Value = dr["vLocation"].ToString();
                }
            }
        }



      

        private void FrmData_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            LoadHolyDayCatCombo();
        }




        private void DataGridData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            getHID                = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtPkrFormDate.Text    = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbHolidayCat.Text    = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        
        private void DataGridData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 || dataGridView.SelectedRows[0].Index == dataGridView.Rows.Count) return;
            getHID             = Convert.ToInt32(dataGridView[0, dataGridView.SelectedRows[0].Index].Value.ToString());
            dtPkrFormDate.Text = dataGridView[1, dataGridView.SelectedRows[0].Index].Value.ToString();
            cmbHolidayCat.Text = dataGridView[2, dataGridView.SelectedRows[0].Index].Value.ToString();
        }

        // To Load Class Combo in CLASS Form. calling from Load Form.
        private void LoadHolyDayCatCombo()
        {
            string CommandText = "SELECT * from TBL_HOLIDAY_CATEGORY";
            DataSet dsSLOT = new DataSet();
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DB.Fill(dsSLOT);
            DT = dsSLOT.Tables[0];
            cmbHolidayCat.DisplayMember = "Text";
            cmbHolidayCat.ValueMember   = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbHolidayCat.Items.Add(new { Text = dr["VDESCRIPTION"].ToString(), Value = dr["N_HCATID"].ToString() });//NCATID
            }
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            if (DBConn.DeleteTableRowInt("TBL_HOLIDAY", "NHID", getHID))
            {
                MessageBox.Show("Row Deleted !");
                ClearData();
                LoadData();
            }
            else
            {
                MessageBox.Show("", "Unable to delete!!!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSetHolyDay_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}