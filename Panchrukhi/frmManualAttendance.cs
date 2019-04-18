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
    public partial class frmManualAttendance : Form
    {
        public frmManualAttendance()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize    = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;


            txtAttendTime.Format = txtAttendDate.Format = DateTimePickerFormat.Custom;
            txtAttendDate.CustomFormat = "dd/MM/yyyy";
            txtAttendTime.CustomFormat = "HH:mm";
            txtAttendTime.ShowUpDown   = true;
        }

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet    DS     = new DataSet();
        private DataTable  DT     = new DataTable();


        //private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        int getAttendSl;
        int AMFlag      = 1;





        // Slot Form Close Button
        private void btnFrmSlotClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            if (getAttendSl == 0)
            {
                if (!DBConn.checkDataIfItUsedOtherTableStr("TBLPERSON", "PERSONID", txtEmpID.Text.Trim())) {
                    MessageBox.Show("", "ID is not authorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtEmpID.Text != "")
                {
                    try
                    {

                        string cmdText = " insert into TBLATTENDANCE_PROCESS_DATA (" +
                            "VEMPID,    " +
                            "DATTENDATE," +
                            "VINOUTTIME," +
                            "REMARKS,   " +
                            "NATTENTYPE," +
						    "NAMFLAG    " +
                        ") " +
                            " values ( '" +txtEmpID.Text.Trim() +
                                "', '" + txtAttendDate.Text     +
                                "', '" + txtAttendTime.Text     +
                                "', '" + txtRemarks.Text        +
                                "',  " + (rdoIN.Checked ? 1 : 5).ToString() +
                                ",  "  + AMFlag +
                            ") ";
                        
                        DBConn.ExecutionQuery(cmdText);
                        // MessageBox.Show("Insert Succeed !");
                        ClearData();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Something is wrong in Insert ??? !");
                    }

                }
            }
            else
            {
                try
                {
                    string cmdText = "update TBLATTENDANCE_PROCESS_DATA " +
                            "set VEMPID    = '" + txtEmpID.Text +
                            "', DATTENDATE = '" + txtAttendDate.Text +
                            "', VINOUTTIME = '" + txtAttendTime.Text +
                            "', REMARKS    = '" + txtRemarks.Text +
                            "', NAMFLAG    =  " + AMFlag +
                            ", NATTENTYPE  =  " + (rdoIN.Checked ? 1 : 5).ToString() +
                            "  where rowid =" + getAttendSl;

                    if (DBConn.ExecutionQuery(cmdText))
                    {
                        MessageBox.Show("Data Update Succeed");
                        ClearData();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Something is wrong in Insert ??? !");
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
            txtEmpID.Text = txtAttendTime.Text = txtAttendDate.Text = txtRemarks.Text ="";
            rdoIN.Checked = rdoOut.Checked = false; btnSaveAndUpdate.Text = "Save";
            getAttendSl = 0;
        }




        // Load Data From SQlite Database
        private void LoadData()
        {
            try
            {
                var Query = "";
                Query = " SELECT TA.rowid,TA.*, CASE TA.NATTENTYPE WHEN 1 THEN 'IN' ELSE 'OUT' END ATTENTYPE, " +
                        "CASE TA.NAMFLAG WHEN 1 THEN 'Manual' ELSE 'Auto' END AMFLAG FROM TBLATTENDANCE_PROCESS_DATA TA; ";
                DS = new DataSet();
                DBConn.ExecutionQuery(Query);
                DB = new SQLiteDataAdapter(Query, DBConn.sql_conn);
                DS.Reset();
                DB.Fill(DS);

                dataGridView.Rows.Clear();
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in DS.Tables[0].Rows)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colNATTENDSL.Index].Value  = dr["rowid"].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colVEMPID.Index].Value     = dr["VEMPID"].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colTINTIME.Index].Value    = dr["VINOUTTIME"].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colDATTENDATE.Index].Value = dr["DATTENDATE"].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colREMARKS.Index].Value    = dr["REMARKS"].ToString(); 
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colNATTENTYPE.Index].Value = dr["ATTENTYPE"].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[colNAMFLAG.Index].Value    = dr["AMFLAG"].ToString();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + " #== > problem");
            }
        }



      

        private void FrmData_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearData();
            this.Owner.Enabled = false;
        }




        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool r = DBConn.DeleteTableRowInt("TBLATTENDANCE_PROCESS_DATA", "rowid", getAttendSl);
            if (r)
            {
                MessageBox.Show("Row Deleted !");
                ClearData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Unable to delete !");
            }
        }



        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSaveAndUpdate.Text = "Update";
            getAttendSl        = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtEmpID.Text      = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAttendDate.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAttendTime.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRemarks.Text    = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() == "IN")
            {
                rdoIN.Checked = true;
            }
            else
            {
                rdoOut.Checked = true;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 || dataGridView.SelectedRows[0].Index == dataGridView.Rows.Count) return;
            getAttendSl        = Convert.ToInt32(dataGridView[0, dataGridView.SelectedRows[0].Index].Value.ToString());
            btnSaveAndUpdate.Text = "Update";
            txtEmpID.Text      = dataGridView[1, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtAttendDate.Text = dataGridView[2, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtAttendTime.Text = dataGridView[3, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtRemarks.Text    = dataGridView[5, dataGridView.SelectedRows[0].Index].Value.ToString();
            if (dataGridView[4, dataGridView.SelectedRows[0].Index].Value.ToString() == "IN")
            {
                rdoIN.Checked = true;
            }
            else
            {
                rdoOut.Checked = true;
            }
        }

        private void frmAttendanceData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
 