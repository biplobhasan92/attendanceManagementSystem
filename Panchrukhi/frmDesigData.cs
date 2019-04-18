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
    public partial class frmDesigData : Form
    {
        public frmDesigData()
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
        int getDesigId=0;





        // Slot Form Close Button
        private void btnFrmSlotClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnSaveAndUpdate_Click(object sender, EventArgs e)
        {

            if (getDesigId == 0)
            {

                string cmdText = " insert into TBLDESIGNATION (" +
                        "NDESIGID,   " +
                        "VDESIGNATIONNAME  " +
                    ") " +
                     " values (" +
                         "(select CASE WHEN max(NDESIGID) >= 0 THEN max(NDESIGID) +1 ELSE 1 END FROM TBLDESIGNATION), '" +
                         txtDesigName.Text.Trim() + 
                         "' ) ";

                if (DBConn.ExecutionQuery(cmdText))
                {
                    MessageBox.Show("Desig Insert Succeed !");
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

                string cmdText = "update TBLDESIGNATION " +
                    "set VDESIGNATIONNAME = '" + 
                    txtDesigName.Text +
                    "'  where NDESIGID =" + getDesigId;

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
            txtDesigName.Text = ""; btnSaveAndUpdate.Text = "Save";
            getDesigId = 0;
        }




        // Load Data From SQlite Database
        private void LoadData()
        {
            DBConn.SetConnection();
            DBConn.sql_conn.Open();
            sql_cmd = DBConn.sql_conn.CreateCommand();
            string CommandText = "Select * from TBLDESIGNATION";
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
            getDesigId           = Convert.ToInt32(dataGridData.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDesigName.Text    = dataGridData.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        
        private void DataGridData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridData.SelectedRows.Count == 0 || dataGridData.SelectedRows[0].Index == dataGridData.Rows.Count) return;
            btnSaveAndUpdate.Text = "Update";
            getDesigId           = Convert.ToInt32(dataGridData[0, dataGridData.SelectedRows[0].Index].Value.ToString());
            txtDesigName.Text    = dataGridData[1, dataGridData.SelectedRows[0].Index].Value.ToString();
        }





        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool checkDataBeforeDelete = DBConn.checkDataIfItUsedOtherTable("TBLPERSON", "NDESIGID", getDesigId);
            if (!txtDesigName.Text.Equals("N/A") && !checkDataBeforeDelete && DBConn.DeleteTableRowInt("TBLDESIGNATION", "NDESIGID", getDesigId))
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


        private void frmDesigData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void txtDesigName_TextChanged(object sender, EventArgs e)
        {
            if (txtDesigName.Text.Equals("N/A"))
            {
                txtDesigName.Enabled = false;
            }
            else
            {
                txtDesigName.Enabled = true;
            }
        }
    }
}