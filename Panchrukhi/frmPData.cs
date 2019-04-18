using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panchrukhi.DAO;
using System.Data.SQLite;

namespace Panchrukhi
{
    public partial class frmPData : Form
    {
        public frmPData()
        {
            InitializeComponent();
            txtPDOJ.Format = txtPDOB.Format = DateTimePickerFormat.Custom;
            txtPDOJ.CustomFormat = txtPDOB.CustomFormat = "dd/MM/yyyy";
            
        }

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet    DS     = new DataSet();
        private DataTable  DT     = new DataTable();


        //private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        int getEMPID        = 0;



        // Slot Form Close Button
        private void BtnFrmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        private void BtnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            // Regular
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            
            // First time if any combo box table is null .
            if (!DBConn.checkIfTableIsReturnNull("TBLCATEGORY"))    { MessageBox.Show("CATEGORY NOT FOUND", "Add some Category and first add N/A ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!DBConn.checkIfTableIsReturnNull("TBLCLASS"))       { MessageBox.Show("CLASS NOT FOUND", "Add some CLASS and first add N/A ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!DBConn.checkIfTableIsReturnNull("TBLDESIGNATION")) { MessageBox.Show("DESIGNATION NOT FOUND", "Add some DESIGNATION and first add N/A ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!DBConn.checkIfTableIsReturnNull("TBLSECTION"))     { MessageBox.Show("SECTION NOT FOUND", "Add some SECTION and first add N/A ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!DBConn.checkIfTableIsReturnNull("TBLATTENSLOT"))   { MessageBox.Show("SHIFT NOT FOUND", "Add SHIFT and first add N/A ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (string.IsNullOrEmpty(txtPID.Text))     { errorProviderPData.SetError(txtPID, errorProviderPData.Icon.ToString()); return; } else { errorProviderPData.Clear();  }
            if (string.IsNullOrEmpty(txtPName.Text))   { errorProviderPData.SetError(txtPName, errorProviderPData.Icon.ToString()); return; } else { errorProviderPData.Clear();}
            if (!string.IsNullOrEmpty(txtPEmail.Text)) { if (!regex.IsMatch(txtPEmail.Text.Trim())) { errorProviderPData.SetError(txtPEmail, errorProviderPData.Icon.ToString()); return;}}
            

            if (getEMPID == 0) // NEMPID
            {
                if (txtPID.Text != "")
                {
                    if (DBConn.checkDataIfItUsedOtherTableStr("TBLPERSON", "PERSONID", txtPID.Text)) { MessageBox.Show("", "Duplicate ID Not Allowed !", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                    string cmdText = "INSERT INTO TBLPERSON "+
                                     "  (          "+
                                     "    NEMPID,  "+
                                     "    PERSONID,"+
                                     "    VNAME,   "+
                                     "    VGENDER, "+
                                     "    VADDRESS,"+
                                     "    DDOB,    "+
                                     "    VMOBLE,  "+
                                     "    VEMAIL,  "+
                                     "    NSTATUS, "+
                                     "    DDOJ,    "+
                                     "    NCATID,  "+
                                     "    NDESIGID,"+
                                     "    NSALARY, "+
                                     "    NSLOTID, "+
                                     "    NCLASSID,"+
                                     "    NSECID,  "+
                                     "    VFATHER_NAME,  " +
                                     "    VMOTHER_NAME,  " +
                                     "    VEMERGENCY_CONTRACT   " +
                                     "  )          " +
                                     "  values     " +
                                     "  (          " +
                                           "(select CASE WHEN max(NEMPID) >= 0 THEN max(NEMPID) + 1 ELSE 1 END FROM TBLPERSON), "+
                                           "  '"+txtPID.Text+"',     "+
                                           "  '"+txtPName.Text.Trim()+"',   "+
                                           "  IFNULL('"+cmbGender.SelectedItem.ToString()+"', 'MALE'), "+
                                           "  '"+txtPAddress.Text.Trim()+"',"+
                                           "  '"+txtPDOB.Text+"',    "+
                                           "  '"+txtPMobile.Text+"', "+
                                           "  '"+txtPEmail.Text+"',  "+
                                           "  IFNULL("+cmbStatus.SelectedIndex+", 1)," +
                                           "  '"+txtPDOJ.Text+"',    "+
                                           " IFNULL("+ (cmbCat.SelectedItem as dynamic).Value  + ", 1), "+
                                           " IFNULL("+ (cmbDesig.SelectedItem as dynamic).Value+ ", 1), "+
                                           " '"+txtPSalary.Text+"',  "+
                                           " IFNULL("+ (cmbSlot.SelectedItem as dynamic).Value   +", 1), "+
                                           " IFNULL("+ (cmbClass.SelectedItem as dynamic).Value  +", 1), "+
                                           " IFNULL("+ (cmbSection.SelectedItem as dynamic).Value+", 1), "+
                                           "  '" + txtFather.Text + "',  " +
                                           "  '" + txtMother.Text + "',  " +
                                           "  '" + txtEmergencyContact.Text + "'  " +
                                    " ) ";


                    DBConn.ExecutionQuery(cmdText);
                    // MessageBox.Show("Person Insertion Succeeded!");
                    // BDConnectionClass.LoadDate("TBLPERSON", "PERSONID");
                    ClearData();
                    LoadData();
                    LoadDefaultComboValue();
                }
                else
                {
                    MessageBox.Show("Something is wrong ??? !");
                }
            }
            else
            {

                string cmdText = "UPDATE "+
                                           " TBLPERSON "+
                                   " set "+
                                           " PERSONID = '"+txtPID.Text+"',     " +
                                           " VNAME    = '"+txtPName.Text+"',   " +
                                           " VGENDER  = IFNULL('"+cmbGender.SelectedItem +"', 'MALE'), " +
                                           " VADDRESS = '"+txtPAddress.Text+"', "+
                                           " DDOB     = '"+txtPDOB.Text+"',     "+
                                           " VMOBLE   = '"+txtPMobile.Text+"',  "+ 
                                           " VEMAIL   = '"+txtPEmail.Text+"',   "+
                                           " NSTATUS  = IFNULL("+cmbStatus.SelectedIndex+", 1), " +
                                           " DDOJ     = '"+txtPDOJ.Text + "',   "+
                                           " NCATID   = IFNULL("+(cmbCat.SelectedItem as dynamic).Value+   ", 1),    "+
                                           " NDESIGID = IFNULL("+(cmbDesig.SelectedItem as dynamic).Value+ ", 1),    "+
                                           " NSALARY  = "+txtPSalary.Text+",    "+
                                           " NSLOTID  = IFNULL("+(cmbSlot.SelectedItem as dynamic).Value+",  1),     "+
                                           " NCLASSID = IFNULL("+(cmbClass.SelectedItem as dynamic).Value+", 1),     "+
                                           " NSECID   = IFNULL("+(cmbSection.SelectedItem as dynamic).Value+", 1),   "+
                                           " VFATHER_NAME        = '" + txtFather.Text + "',   " +
                                           " VMOTHER_NAME        = '" + txtMother.Text + "',   " +
                                           " VEMERGENCY_CONTRACT = '" + txtEmergencyContact.Text + "'   " +
                                    " where  " +
                                           " NEMPID ="+getEMPID;// NEMPID

                if (DBConn.ExecutionQuery(cmdText))
                {
                    MessageBox.Show("Data Update Succeed !");
                    LoadData();
                    ClearData();
                    LoadDefaultComboValue();
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
            txtFather.Text= txtMother.Text = txtEmergencyContact.Text = txtPID.Text = txtPName.Text = cmbGender.Text = txtPAddress.Text = txtPDOB.Text = txtPMobile.Text = 
                txtPEmail.Text = cmbStatus.Text = txtPDOJ.Text = cmbCat.Text = cmbDesig.Text = txtPSalary.Text = cmbSection.Text = cmbClass.Text = cmbSlot.Text = "";
            getEMPID = 0; btnSaveAndUpdate.Text = "Save";
            LoadDefaultComboValue();
        }


        // Load Data From SQlite Database
        private void LoadData()
        {
            string CommandText = "SELECT *, " +
              "  (select VCATEGORY from TBLCATEGORY where TBLPERSON.NCATID = TBLCATEGORY.NCATID) as CATEGORY,   "+
              "  (SELECT VSLOTNAME || \" (\" || VINTIME ||\" - \"||  VOUTTIME || \")\"  FROM TBLATTENSLOT where (TBLATTENSLOT.NSLOTID = TBLPERSON.NSLOTID))   as SLOT, " +
              "  (select VDESIGNATIONNAME from TBLDESIGNATION where TBLDESIGNATION.NDESIGID = TBLPERSON.NDESIGID ) as DESIGNATION, "+
              "  (SELECT VCLASSNAME FROM TBLCLASS   TC WHERE TC.NCLASSID = TBLPERSON.NCLASSID) as CLASS,  " +
              "  (SELECT VSECTION   FROM TBLSECTION TS WHERE TS.NSECID   = TBLPERSON.NSECID) as SECTION, " +
              "  CASE TBLPERSON.NSTATUS WHEN 1 THEN 'ACTIVE' ELSE 'INACTIVE' END STATUS" +
            " FROM TBLPERSON";
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView.DataSource = DT;
            btnExcelExporter.Enabled = true;
        }

      

        private void FrmData_Load(object sender, EventArgs e)
        {
            LoadSlotCombo();
            LoadClassCombo();
            LoadSectionCombo();
            LoadDesigCombo();
            LoadCatCombo();
            LoadData();
            this.Owner.Enabled = false;
            LoadDefaultComboValue();
        }


        // To Load Category Combo in Person Form. calling from Load Form.
        private void LoadCatCombo() {
            string CommandText = "SELECT * from TBLCATEGORY";
            DataSet dsSLOT = new DataSet();
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DB.Fill(dsSLOT);
            DT = dsSLOT.Tables[0];
            cmbCat.DisplayMember = "Text";
            cmbCat.ValueMember = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbCat.Items.Add(new { Text = dr["VCATEGORY"].ToString(), Value = dr["NCATID"].ToString() });//NCATID
            }
        }

        private void LoadDefaultComboValue() {
            cmbGender.SelectedIndex  = cmbCat.MaxLength;
            cmbCat.SelectedIndex     = cmbCat.MaxLength;
            cmbClass.SelectedIndex   = cmbClass.MaxLength;
            cmbDesig.SelectedIndex   = cmbDesig.MaxLength;
            cmbSection.SelectedIndex = cmbSection.MaxLength;
            cmbSlot.SelectedIndex    = cmbSlot.MaxLength;
        }


            // To Load Designation Combo in Person Form. calling from Load Form.
            private void LoadDesigCombo()
            {
                string CommandText = "SELECT * from TBLDESIGNATION";
                DataSet dsSLOT = new DataSet();
                DBConn.ExecutionQuery(CommandText);
                DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
                DB.Fill(dsSLOT);
                DT = dsSLOT.Tables[0];
                cmbDesig.DisplayMember = "Text";
                cmbDesig.ValueMember = "Value";
                foreach (DataRow dr in DT.Rows)
                {
                    cmbDesig.Items.Add(new { Text = dr["VDESIGNATIONNAME"].ToString(), Value = dr["NDESIGID"].ToString() });
                }
            }


        private void DataGridData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            btnSaveAndUpdate.Text = "Update";
            getEMPID         = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPID.Text      = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPName.Text    = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbGender.Text   = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPAddress.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPDOB.Text     = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            txtPMobile.Text  = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPEmail.Text   = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbStatus.Text   = dataGridView.Rows[e.RowIndex].Cells[24].Value.ToString();
            txtPDOJ.Text     = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString().Trim();
            txtFather.Text   = dataGridView.Rows[e.RowIndex].Cells[16].Value.ToString().Trim();
            txtMother.Text   = dataGridView.Rows[e.RowIndex].Cells[17].Value.ToString().Trim();
            txtEmergencyContact.Text = dataGridView.Rows[e.RowIndex].Cells[18].Value.ToString().Trim();
            cmbCat.Text      = dataGridView.Rows[e.RowIndex].Cells[19].Value.ToString();
            cmbDesig.Text    = dataGridView.Rows[e.RowIndex].Cells[21].Value.ToString();
            txtPSalary.Text  = dataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmbClass.Text    = dataGridView.Rows[e.RowIndex].Cells[22].Value.ToString();
            cmbSection.Text  = dataGridView.Rows[e.RowIndex].Cells[23].Value.ToString();
            cmbSlot.Text     = dataGridView.Rows[e.RowIndex].Cells[20].Value.ToString();
            //txtFather.Text = dataGridView.Rows[e.RowIndex].Cells[22].Value.ToString();*/
        }


        private void DataGridData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 || dataGridView.SelectedRows[0].Index == dataGridView.Rows.Count) return;

            btnSaveAndUpdate.Text = "Update";
            getEMPID         = Convert.ToInt32(dataGridView[0, dataGridView.SelectedRows[0].Index].Value.ToString());
            txtPID.Text      = dataGridView[1, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtPName.Text    = dataGridView[2, dataGridView.SelectedRows[0].Index].Value.ToString();
            cmbGender.Text   = dataGridView[3, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtPAddress.Text = dataGridView[4, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtPDOB.Text     = dataGridView[5, dataGridView.SelectedRows[0].Index].Value.ToString().Trim();
            txtPMobile.Text  = dataGridView[6, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtPEmail.Text   = dataGridView[7, dataGridView.SelectedRows[0].Index].Value.ToString();
            cmbStatus.Text   = dataGridView[24,dataGridView.SelectedRows[0].Index].Value.ToString();
            txtPDOJ.Text     = dataGridView[9, dataGridView.SelectedRows[0].Index].Value.ToString().Trim();
            cmbCat.Text      = dataGridView[19,dataGridView.SelectedRows[0].Index].Value.ToString();
            cmbDesig.Text    = dataGridView[21,dataGridView.SelectedRows[0].Index].Value.ToString();
            txtPSalary.Text  = dataGridView[12,dataGridView.SelectedRows[0].Index].Value.ToString();
            cmbClass.Text    = dataGridView[22,dataGridView.SelectedRows[0].Index].Value.ToString();
            cmbSection.Text  = dataGridView[23,dataGridView.SelectedRows[0].Index].Value.ToString();
            cmbSlot.Text     = dataGridView[20,dataGridView.SelectedRows[0].Index].Value.ToString();
            txtFather.Text   = dataGridView[16, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtMother.Text   = dataGridView[17, dataGridView.SelectedRows[0].Index].Value.ToString();
            txtEmergencyContact.Text = dataGridView[18, dataGridView.SelectedRows[0].Index].Value.ToString();
        }





        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool r = DBConn.DeleteTableRowInt("TBLPERSON", "NEMPID", getEMPID);
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





        // To Load Class Combo in CLASS Form. calling from Load Form.
        private void LoadClassCombo()
        {
            string CommandText = "SELECT * from TBLCLASS";
            DataSet dsSLOT = new DataSet();
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DB.Fill(dsSLOT);
            DT = dsSLOT.Tables[0];
            cmbClass.DisplayMember = "Text";
            cmbClass.ValueMember = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbClass.Items.Add(new { Text = dr["VCLASSNAME"].ToString(), Value = dr["NCLASSID"].ToString() });//NCATID
            }
        }


        // To Load Slot Combo in Slot Form. calling from LoadForm().
        private void LoadSlotCombo()
        {

            string CommandText = "SELECT * from TBLATTENSLOT";
            DataSet dsSLOT = new DataSet();
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DB.Fill(dsSLOT);
            DT = dsSLOT.Tables[0];
            cmbSlot.DisplayMember = "Text";
            cmbSlot.ValueMember = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbSlot.Items.Add(new { Text = dr["VSLOTNAME"].ToString(), Value = dr["NSLOTID"].ToString() });//NCATID
            }
        }




        // To Load Section Combo in Slot Form. calling from Load Form.
        private void LoadSectionCombo()
        {
            string CommandText = "SELECT * from TBLSECTION";
            DataSet dsSLOT = new DataSet();
            DBConn.ExecutionQuery(CommandText);
            DB = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DB.Fill(dsSLOT);
            DT = dsSLOT.Tables[0];
            cmbSection.DisplayMember = "Text";
            cmbSection.ValueMember = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbSection.Items.Add(new { Text = dr["VSECTION"].ToString(), Value = dr["NSECID"].ToString() }); //NCATID
            }
        }

        private void frmPData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }


        private void btnSaveAndUpdate_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                DataRow dr = DBConn.getCompanyNameAndAddress();
                if (dr == null) return;
                crptPersonalInfo rptObj = new crptPersonalInfo();
                rptObj.SetDataSource(DS.Tables[0]);
                rptObj.SetParameterValue(0, dr["VCOMPANY_NAME"]);
                rptObj.SetParameterValue(1, dr["VCOMPANY_ADDRESS"]);
                frmCrystalReportViewer crpt = new frmCrystalReportViewer();
                crpt.crptViewer.ReportSource = null;
                crpt.crptViewer.ReportSource = rptObj;
                crpt.Show();
            }
            else
            {
                MessageBox.Show("", "Data Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtPSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNumber(e);
        }



        public void validateNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void btnExcelExporter_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
                ExtractDataToCSV(dataGridView);
            else
                MessageBox.Show("", "Data Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
        }


        private void ExtractDataToCSV(DataGridView dgv)
        {

            // Don't save if no data is returned
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            // Column headers
            string columnsHeader = "";
            for (int i = 0; i < dgv.Columns.Count; i++)
            {

                columnsHeader += dgv.Columns[i].HeaderText + ",";
            }
            sb.Append(columnsHeader + Environment.NewLine);
            // Go through each cell in the datagridview
            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                // Make sure it's not an empty row.
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        // Append the cells data followed by a comma to delimit.
                        sb.Append(dgvRow.Cells[c].Value + ",");
                    }
                    // Add a new line in the text file.
                    sb.Append(Environment.NewLine);
                }
            }
            // Load up the save file dialog with the default option as saving as a .csv file.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "SaveAllPerson";
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // If they've selected a save location...
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false))
                {
                    // Write the stringbuilder text to the the file.
                    sw.WriteLine(sb.ToString());
                }
            }
            // Confirm to the user it has been completed.
        }


    }
}