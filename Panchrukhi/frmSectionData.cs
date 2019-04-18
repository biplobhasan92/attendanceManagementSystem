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
    public partial class frmSectionData : Form
    {
        public frmSectionData()
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
        int getSecID=0;





        // Slot Form Close Button
        private void btnFrmSlotClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnSaveAndUpdate_Click(object sender, EventArgs e)
        {

            if (getSecID == 0)
            {

                string cmdText = " insert into TBLSECTION (" +
                                     "NSECID,  " +
                                     "VSECTION " +
                                   ")" +
                                 " values (" +
                                     "(select CASE WHEN max(NSECID) >= 0 THEN max(NSECID) +1 ELSE 1 END FROM TBLSECTION), '" +
                                     txtSectionName.Text +
                                 "') ";

                if (txtSectionName.Text != "")
                {
                    DBConn.ExecutionQuery(cmdText);
                    MessageBox.Show("Insert Succeed !");
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
                string cmdText = "  UPDATE TBLSECTION " +
                                 "  set VSECTION =   '" + txtSectionName.Text +
                                 "' where NSECID =    " + getSecID;

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
            txtSectionName.Text = ""; btnSaveAndUpdate.Text = "Save";
            getSecID = 0;
        }




        // Load Data From SQlite Database
        private void LoadData()
        {
            DBConn.SetConnection();
            DBConn.sql_conn.Open();
            sql_cmd = DBConn.sql_conn.CreateCommand();
            string CommandText = "Select * from TBLSECTION";
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridData.DataSource = DT;
            DBConn.sql_conn.Close();
        }



      

        private void FrmData_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;

        }




        private void DataGridData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSaveAndUpdate.Text = "Update";
            getSecID           = Convert.ToInt32(dataGridData.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtSectionName.Text    = dataGridData.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        
        private void DataGridData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridData.SelectedRows.Count == 0 || dataGridData.SelectedRows[0].Index == dataGridData.Rows.Count) return;
            btnSaveAndUpdate.Text = "Update";
            getSecID           = Convert.ToInt32(dataGridData[0, dataGridData.SelectedRows[0].Index].Value.ToString());
            txtSectionName.Text    = dataGridData[1, dataGridData.SelectedRows[0].Index].Value.ToString();
        }





        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool checkDataBeforeDelete = DBConn.checkDataIfItUsedOtherTable("TBLPERSON", "NSECID", getSecID);
            if (! txtSectionName.Text.Equals("N/A") && !checkDataBeforeDelete && DBConn.DeleteTableRowInt("TBLSECTION", "NSECID", getSecID))
            {
                MessageBox.Show("Row Deleted !");
                ClearData();
                LoadData();
            }
            else
            {
                MessageBox.Show("", "Unable to delete !!!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSectionData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void txtSectionName_TextChanged(object sender, EventArgs e)
        {
            if (txtSectionName.Text.Equals("N/A"))
            {
                txtSectionName.Enabled = false;
            }
            else
            {
                txtSectionName.Enabled = true;
            }
        }
    }
}