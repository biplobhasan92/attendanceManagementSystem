using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Panchrukhi.DAO;

namespace Panchrukhi
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet    DS     = new DataSet();
        private DataTable  DT     = new DataTable();
        
        private SQLiteConnection  sql_conn;
        private SQLiteCommand     sql_cmd;
        private SQLiteDataAdapter DB;
        int getCatId = 0;


        private void frmPrsnCategoryData_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearData();
            this.Owner.Enabled = false;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool checkDataBeforeDelete = DBConn.checkDataIfItUsedOtherTable("TBLPERSON", "NCATID", getCatId);
            if ( !txtCtgryName.Text.Equals("N/A") && !checkDataBeforeDelete && DBConn.DeleteTableRowInt("TBLCATEGORY", "NCATID", getCatId))
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



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }



        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            if (getCatId == 0)
            {

                string cmdText = " insert into TBLCATEGORY (" +
                        "NCATID, " +
                        "VCATEGORY " +
                    ") " +
                     " values (" +
                         "(select CASE WHEN max(NCATID) >= 0 THEN max(NCATID) +1 ELSE 1 END FROM TBLCATEGORY), '" +
                         txtCtgryName.Text.Trim() +
                     "') ";

                if (DBConn.ExecutionQuery(cmdText))
                {
                    MessageBox.Show("Insert Succeed !");
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

                string cmdText = "update TBLCATEGORY " +
                    "set VCATEGORY = '" +
                    txtCtgryName.Text +
                    "'  where NCATID =" + getCatId;

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






        // Form Clear Method
        void ClearData()
        {
            txtCtgryName.Text = ""; btnSaveAndUpdate.Text = "Save";
            getCatId = 0;
        }




        // Load Data From SQlite Database
        private void LoadData()
        {
            string CommandText = "Select * from TBLCATEGORY";
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridCategory.DataSource = DT;
            DBConn.sql_conn.Close();
        }

        private void dataGridCategory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // if (dataGridCategory.RowCount > 1) return;
            
        }

        private void dataGridCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCategory.SelectedRows.Count == 0 || dataGridCategory.SelectedRows[0].Index == dataGridCategory.Rows.Count) return;
            btnSaveAndUpdate.Text = "Update";
            getCatId = Convert.ToInt32(dataGridCategory[0, dataGridCategory.SelectedRows[0].Index].Value.ToString());
            txtCtgryName.Text = dataGridCategory[1, dataGridCategory.SelectedRows[0].Index].Value.ToString();
        }

        private void dataGridCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSaveAndUpdate.Text = "Update";
            getCatId = Convert.ToInt32(dataGridCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCtgryName.Text = dataGridCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void frmCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void txtCtgryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCtgryName.Text.Equals("N/A"))
            {
                txtCtgryName.Enabled = false;
            }
            else {
                txtCtgryName.Enabled = true;
            }
        }
    }
}
