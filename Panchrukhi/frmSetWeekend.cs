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
    public partial class frmSetWeekend : Form
    {
        public frmSetWeekend()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize    = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            ClearData();
            LoadData();          
        }

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet    DS     = new DataSet();
        private DataTable  DT     = new DataTable();


        //private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        int getNWKNDID = 0;


        // Slot Form Close Button
        private void btnFrmSlotClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            if (rdoID.Checked && txtID.Text == "Enter ID") {
                MessageBox.Show("Alert ! ","You Must Give ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DBConn.checkDataIfItUsedOtherTableStr("TBL_WEEKEND", "VSPECIALID", "GENERAL") && txtID.Text.Equals("GENERAL")) {
                MessageBox.Show("Alert ! ", "Only one Row is Allowed !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (getNWKNDID == 0)
            {
                int week = 0b0000000;
                if (chkFriday.Checked)      week = week | 0b1000000;
                if (chkSaturday.Checked)    week = week | 0b0100000;
                if (chkSunday.Checked)      week = week | 0b0010000;
                if (chkMonday.Checked)      week = week | 0b0001000;
                if (chkTuesday.Checked)     week = week | 0b0000100;
                if (chkWednesday.Checked)   week = week | 0b0000010;
                if (chkThursday.Checked)    week = week | 0b0000001;


                string cmdText = "INSERT INTO TBL_WEEKEND(NWKNDID, VDAYSFLAG, VSPECIALID)" +
                    " values (" +
                    " (select CASE WHEN max(NWKNDID) >= 0 THEN max(NWKNDID) + 1 ELSE 1 END FROM TBL_WEEKEND)," +
                    "  "+week+", '"+txtID.Text.Trim()+"' ) ";

                if (DBConn.ExecutionQuery(cmdText))
                {
                    MessageBox.Show("Weekend Insert Succeed !");
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
            getNWKNDID = 0;
            chkFriday.Checked = chkSaturday.Checked = chkSunday.Checked = chkMonday.Checked = chkTuesday.Checked = chkWednesday.Checked = false;
        }



        string ConvertDays(int BinVal)
        {
            string Days = "FSSMTWT";
            string binText = Convert.ToString(BinVal, 2).PadLeft(7,'0');
            string tmpStr = "";
            for(int i = 0; i < binText.Length; i++)
            {
                if (binText[i] != '0') tmpStr += Days[i];
                else tmpStr += '0';
            }
            return tmpStr;
        }
        
        // Load Data From SQlite Database
        private void LoadData()
        {

            string CommandText = "Select NWKNDID ID, VDAYSFLAG WEEKEND,VSPECIALID FOR_EMP from TBL_WEEKEND";
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DS.Reset();
            DB.Fill(DS);

            if (rdoGeneral.Checked && (DS.Tables[0].Select("FOR_EMP='GENERAL'").Length > 0))
            {
                DT = DS.Tables[0].Select("FOR_EMP='GENERAL'").CopyToDataTable();
            } 
            else if (rdoID.Checked && (DS.Tables[0].Select("FOR_EMP<>'GENERAL'").Length > 0))
            {
                DT = DS.Tables[0].Select("FOR_EMP <> 'GENERAL'").CopyToDataTable();
            }
            else
            {
                dataGridView.DataSource = null;
                dataGridView.Refresh();
                return;
            }


            foreach (DataRow r in DT.Rows)
            {
                r["WEEKEND"] = ConvertDays(Convert.ToInt32(r["WEEKEND"]));
            }
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            dataGridView.DataSource = DT;
        }



      

        private void FrmData_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
             txtID.Enabled = false; txtID.Text = "GENERAL";
            if (txtID.Text == ""){txtID.Text = "Enter ID";txtID.ForeColor = Color.Silver;   }
        }




        private void DataGridData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            getNWKNDID           = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txtClassName.Text    = dataGridData.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        
        private void DataGridData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 || dataGridView.SelectedRows[0].Index == dataGridView.Rows.Count) return;
            getNWKNDID           = Convert.ToInt32(dataGridView[0, dataGridView.SelectedRows[0].Index].Value.ToString());
        }





        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //bool checkDataBeforeDelete = DBConn.checkDataIfItUsedOtherTable("TBLATTENSLOT", "NCLASSID", getNWKNDID);
            if (DBConn.DeleteTableRowInt("TBL_WEEKEND", "NWKNDID", getNWKNDID))
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

        private void SetWeekend_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void rdoGeneral_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (rdoID.Checked) { txtID.Text = "Enter ID"; txtID.ForeColor = Color.Silver; } else { txtID.Text = "GENERAL";  }
            LoadData();
        }

        private void rdoID_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            LoadData();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {

            if (txtID.Text == "Enter ID") {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "") { txtID.Text = "Enter ID"; txtID.ForeColor = Color.Silver; }
        }
    }
}