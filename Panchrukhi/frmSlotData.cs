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
    public partial class frmSlotData : Form
    {
        public frmSlotData()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize    = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            ClearData();
            LoadData();

             txtSlotOutTime.Format = txtSlotInTime.Format = DateTimePickerFormat.Custom;
            txtSlotInTime.CustomFormat = txtSlotOutTime.CustomFormat = "HH:mm";
            txtSlotOutTime.ShowUpDown = txtSlotInTime.ShowUpDown = true;

        }

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet    DS     = new DataSet();
        private DataTable  DT     = new DataTable();


        //private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        int getSlotId=0;





        // Slot Form Close Button
        private void btnFrmSlotClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnSaveAndUpdate_Click(object sender, EventArgs e)
        {

            if (getSlotId == 0)
            {
                if (txtSlotName.Text != "")
                {
                    string cmdText = " insert into TBLATTENSLOT (" +
                        "nslotid,   " +
                        "vslotname, " +
                        "vintime,   " +
                        "vouttime   " +
                    ") " +
                     " values (" +
                         "(select CASE WHEN max(nslotid) >= 0 THEN max(nslotid) +1 ELSE 1 END FROM TBLATTENSLOT), '" +
                         txtSlotName.Text +
                         "', '" + txtSlotInTime.Text  +
                         "', '" + txtSlotOutTime.Text + 
                     "') ";

                
                    DBConn.ExecutionQuery(cmdText);
                    MessageBox.Show("Slot Insert Succeed !");
                    //BDConnectionClass.LoadDate("TBLPERSON", "PERSONID");
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
                string cmdText = "update TBLATTENSLOT "          +
                    "   set vslotname = '" + txtSlotName.Text    +
                    "', vintime       = '" + txtSlotInTime.Text  + 
                    "', vouttime      = '" + txtSlotOutTime.Text + 
                    "'  where nslotid =  " + getSlotId;

                if (DBConn.ExecutionQuery(cmdText))
                {
                    MessageBox.Show("Data Update Succeed !");
                    ClearData();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Something is wrong in Update ??? !");
                }
            }
        }




        
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }





        // Form Clear Method
        void ClearData()
        {
            txtSlotName.Text = txtSlotInTime.Text = txtSlotOutTime.Text = ""; btnSaveAndUpdate.Text = "Save";
            getSlotId = 0;
        }




        // Load Data From SQlite Database
        private void LoadData()
        {
            string CommandText = "SELECT * FROM TBLATTENSLOT";
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridData.DataSource = DT;
            DBConn.sql_conn.Close();
        }



      

        private void FrmData_Load(object sender, EventArgs e)
        {
            LoadData();
            this.Owner.Enabled = false;
        }




        private void DataGridData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSaveAndUpdate.Text = "Update";
            getSlotId           = Convert.ToInt32(dataGridData.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtSlotName.Text    = dataGridData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSlotInTime.Text  = dataGridData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSlotOutTime.Text = dataGridData.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        
        private void DataGridData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridData.SelectedRows.Count == 0 || dataGridData.SelectedRows[0].Index == dataGridData.Rows.Count) return;
            btnSaveAndUpdate.Text = "Update";
            getSlotId           = Convert.ToInt32(dataGridData[0, dataGridData.SelectedRows[0].Index].Value.ToString());
            txtSlotName.Text    = dataGridData[1, dataGridData.SelectedRows[0].Index].Value.ToString();
            txtSlotInTime.Text  = dataGridData[2, dataGridData.SelectedRows[0].Index].Value.ToString();
            txtSlotOutTime.Text = dataGridData[3, dataGridData.SelectedRows[0].Index].Value.ToString();
        }





        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool checkDataBeforeDelete = DBConn.checkDataIfItUsedOtherTable("TBLPERSON", "NSLOTID", getSlotId);
            if (!txtSlotName.Text.Equals("N/A") && !checkDataBeforeDelete && DBConn.DeleteTableRowInt("TBLATTENSLOT", "NSLOTID", getSlotId))
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



        

        private void frmSlotData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void txtSlotName_TextChanged(object sender, EventArgs e)
        {
            if (txtSlotName.Text.Equals("N/A"))
            {
                txtSlotName.Enabled    = false;
                txtSlotInTime.Enabled  = false;
                txtSlotOutTime.Enabled = false; 
            }
            else
            {
                txtSlotName.Enabled    = true;
                txtSlotInTime.Enabled  = true;
                txtSlotOutTime.Enabled = true;
            }
        }
    }
}