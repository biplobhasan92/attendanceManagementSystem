using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panchrukhi.DAO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Panchrukhi
{
    public partial class frmPersonalPromotion : Form
    {

        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet   DS;
        private DataTable DT;
        private SQLiteDataAdapter DA;
        CheckBox headerCkbx = null;
        int presents, absents,holidays;




        /*
         * #########################################################################################################################################################
         * ################################### --  Person Tab All Operation --   ###################################################################################
         * #########################################################################################################################################################
         */


        public frmPersonalPromotion()
        {
            InitializeComponent();
            
            
            //dtpFstDate.Format = dtpLstDate.Format = DateTimePickerFormat.Custom;
            //dtpFstDate.CustomFormat = dtpFstDate.CustomFormat = "dd/MM/yyyy";
        }


        // private method for Person tab ..
        void LoadPersonGenderCombo()
        {
            
        }


        void ClearPrsnForm()
        {
            cmbCategory.Text = cmbClass.Text = cmbDesig.Text = cmbGender.Text = cmbSection.Text = "";
        }

        private void btnPrsnReset_Click(object sender, EventArgs e)
        {
            ClearPrsnForm();
            LoadDefaultComboValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonalPromotion_Load(object sender, EventArgs e)
        {
            //LoadData();
            LoadCatCombo();
            LoadDesigCombo();
            LoadClassCombo();
            LoadSectionCombo();
            this.Owner.Enabled = false;
            txtMultID.Enabled  = false;
            gbxPromotion.Visible = false;
            LoadDefaultComboValue();
        }


        private void LoadDefaultComboValue()
        {

            cmbClassTo.SelectedIndex =  cmbClass.SelectedIndex = cmbClass.MaxLength;
            cmbDesigTo.SelectedIndex = cmbDesig.SelectedIndex = cmbDesig.MaxLength;
            cmbSectionTo.SelectedIndex =  cmbSection.SelectedIndex = cmbSection.MaxLength;
        }

        // Load Data From SQlite Database
        private void LoadData(bool isDataForPrint)
        {


            string AndConditions = "";


            if (cmbCategory.Text.Length > 0)
            {
                AndConditions += " AND NCATID = " + (cmbCategory.SelectedItem as dynamic).Value + " ";
            }

            if (cmbDesig.Text.Length > 0)
            {
                AndConditions += " AND NDESIGID = " + (cmbDesig.SelectedItem as dynamic).Value + " ";
            }

            if (cmbGender.Text.Length > 0)
            {
                AndConditions += " AND VGENDER = '" + cmbGender.Text + "' ";
            }

            if (cmbClass.Text.Length > 0)
            {
                AndConditions += " AND NCLASSID = '" + (cmbClass.SelectedItem as dynamic).Value + "' ";
            }

            if (cmbSection.Text.Length > 0)
            {
                AndConditions += " AND NSECID = '" + (cmbSection.SelectedItem as dynamic).Value + "' ";
            }

            if (ckbxSearchID.Checked)
            {
                string TmpStr = "";
                foreach (string id in txtMultID.Text.Split(',')) TmpStr += "'" + Convert.ToInt32(id).ToString() + "',";
                TmpStr = TmpStr.Remove(TmpStr.LastIndexOf(','), 1);
                AndConditions += " AND PERSONID IN (" + TmpStr + ") ";
            }

            string CommandText =  "SELECT PERSONID ID, VNAME NAME,  " +
                                      "  (select VCATEGORY from TBLCATEGORY where TBLPERSON.NCATID = TBLCATEGORY.NCATID) as CATEGORY,   " +
                                      "  (SELECT VCLASSNAME FROM TBLCLASS   TC WHERE TC.NCLASSID = TBLPERSON.NCLASSID) as CLASS,  " +
                                      "  (SELECT VSLOTNAME || \" (\" || VINTIME ||\" - \"||  VOUTTIME || \")\"  FROM TBLATTENSLOT where (TBLATTENSLOT.NSLOTID = TBLPERSON.NSLOTID))   as SLOT, " +
                                      "  (select VDESIGNATIONNAME from TBLDESIGNATION where TBLDESIGNATION.NDESIGID = TBLPERSON.NDESIGID ) as DESIGNATION, " +
              
                                      "  (SELECT VSECTION   FROM TBLSECTION TS WHERE TS.NSECID   = TBLPERSON.NSECID) as SECTION, " +
                                      "   VGENDER GENDER, VADDRESS ADDRESS, VMOBLE MOBILE, VEMAIL EMAIL" +
                                " FROM TBLPERSON";
            CommandText += " WHERE  NSTATUS == 1 " + AndConditions + " ORDER BY ID;";

            DBConn.ExecutionQuery(CommandText);
            DA = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DS.Reset();
            DA.Fill(DS);
            DT = DS.Tables[0];
            dataGridView.DataSource = DT;



            btnExcelExporter.Enabled = true;
        }



        public void ConditionalRowBackgroundColor()
        {
            
            //List<string> getIdList = new List<string>();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                bool absentCounted = false;
                string getID = dataGridView.Rows[i].Cells[0].Value.ToString();
                string strIntime   = dataGridView.Rows[i].Cells[2].Value.ToString(); //Intime
                string strOuttime  = dataGridView.Rows[i].Cells[3].Value.ToString(); //OutTime
                bool getHolidayDays = DBConn.checkDataIfItUsedOtherTableStr("TBL_HOLIDAY", "DDATE", dataGridView.Rows[i].Cells[1].Value.ToString());


                // Make Pink Color the row of report data grid when Person is Absent.
                // Cell TimeIn=="" And TimeOut== ""   And when date is not holiday AND not Weekend

                //else if (val.Equals("") && val2.Equals("") && !getHolidayDays && !getWeekends(dataGridView.Rows[i].Cells[1].Value.ToString()))
                
                if (strIntime.Equals("") && strOuttime.Equals(""))
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    absents++; absentCounted = true;
                }
                else presents++;

                if (getHolidayDays || getWeekends(dataGridView.Rows[i].Cells[1].Value.ToString(), getID))
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DarkGreen;
                    dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    if (absentCounted) absents--;
                    holidays++;
                }
                
                
            }
        }

        // Get Weekends for make absent disable. 
        public bool getWeekends(string attendDate, string  PersonID)
        {
            List<string> getHolidayName = new List<string>();
            string[] dayName  = { "Friday", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };
            string getGeneralHoliday =  checkGeneralWeekend(PersonID); // Get value of General Holiday string from database.


            // if General Holiday index val not equals to '0' 
            // add holiday in getHolidayName list for that index from 'dayName' static array
            for (int i = 0; i < getGeneralHoliday.Length; i++)
            {
                if (getGeneralHoliday[i] != '0')
                {
                    getHolidayName.Add(dayName[i]);
                }
            }
            
            DateTime dt = Convert.ToDateTime(attendDate);
            for (int i = 0; i < getHolidayName.Count; i++)
            {
                
                if (dt.DayOfWeek.ToString().Equals(getHolidayName[i].ToString()))
                     {return true;}
            }
            return false;
        }




        // To Load Category Combo in Person Form. calling from Load Form.
        private void LoadCatCombo()
        {
            string CommandText = "SELECT * from TBLCATEGORY";
            DS = new DataSet();
            DT = new DataTable();
            DBConn.ExecutionQuery(CommandText);
            DA = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DA.Fill(DS);
            DT = DS.Tables[0];
            cmbCategory.DisplayMember = "Text";
            cmbCategory.ValueMember   = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbCategory.Items.Add(new { Text = dr["VCATEGORY"].ToString(), Value = dr["NCATID"].ToString() });
            }
        }





        // To Load Designation Combo in Person Form. calling from Load Form.
        private void LoadDesigCombo()
        {
            string CommandText = "SELECT * from TBLDESIGNATION";
            DS = new DataSet();
            DT = new DataTable();
            DBConn.ExecutionQuery(CommandText);
            DA = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DA.Fill(DS);
            DT = DS.Tables[0];
            cmbDesigTo.DisplayMember = cmbDesig.DisplayMember = "Text";
            cmbDesigTo.ValueMember   = cmbDesig.ValueMember   = "Value";
            foreach (DataRow dr in DT.Rows)
            {
                cmbDesig.Items.Add(new { Text = dr["VDESIGNATIONNAME"].ToString(), Value = dr["NDESIGID"].ToString() });
                cmbDesigTo.Items.Add(new { Text = dr["VDESIGNATIONNAME"].ToString(), Value = dr["NDESIGID"].ToString() });
            }
        }





        // To Load Class Combo in CLASS Form. calling from Load Form.
        private void LoadClassCombo()
        {
            string CommandText = "SELECT * from TBLCLASS";
            DS = new DataSet();
            DT = new DataTable();
            DBConn.ExecutionQuery(CommandText);
            DA = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DA.Fill(DS);
            DT = DS.Tables[0];
            cmbClassTo.DisplayMember   =  cmbClass.DisplayMember = "Text";
            cmbClassTo.ValueMember     =  cmbClass.ValueMember   = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbClass.Items.Add(new     { Text = dr["VCLASSNAME"].ToString(), Value = dr["NCLASSID"].ToString() });
                cmbClassTo.Items.Add(new   { Text = dr["VCLASSNAME"].ToString(), Value = dr["NCLASSID"].ToString() });
            }
        }






        // To Load Section Combo in Slot Form. calling from Load Form.
        private void LoadSectionCombo()
        {
            string CommandText = "SELECT * from TBLSECTION";
            DS = new DataSet();
            DT = new DataTable();
            DBConn.ExecutionQuery(CommandText);
            DA = new SQLiteDataAdapter(CommandText, DBConn.sql_conn);
            DA.Fill(DS);
            DT = DS.Tables[0];
            cmbSectionTo.DisplayMember = cmbSection.DisplayMember = "Text";
            cmbSectionTo.ValueMember   = cmbSection.ValueMember   = "Value";

            foreach (DataRow dr in DT.Rows)
            {
                cmbSection.Items.Add(new { Text = dr["VSECTION"].ToString(), Value = dr["NSECID"].ToString() });
                cmbSectionTo.Items.Add(new { Text = dr["VSECTION"].ToString(), Value = dr["NSECID"].ToString() });
            }
        }






        private void frmPersonalPromotion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            btnExcelExporter.Enabled = true;
            presents = absents = holidays = 0;
            LoadData(false);
            

            if (dataGridView.Rows.Count > 0)
                gbxPromotion.Visible = true;
        }

        
        private void AddHeaderCheckBox() {
            headerCkbx = new CheckBox();
            headerCkbx.Size = new Size(18,18);
            this.dataGridView.Controls.Add(headerCkbx);
        }




        string ConvertDays(int BinVal)
        {
            string Days = "FSSMTWT";
            string binText = Convert.ToString(BinVal, 2).PadLeft(7, '0');
            string tmpStr = "";
            for (int i = 0; i < binText.Length; i++)
            {
                if (binText[i] != '0') tmpStr += Days[i];
                else tmpStr += '0';
            }
            return tmpStr;
        }







        public string checkGeneralWeekend(string PersonID)
        {
            string returnVal = "";
            try
            {
                DataSet dsTemp = new DataSet();
                DataSet DS = new DataSet();

                string cmdText = "select VDAYSFLAG from TBL_WEEKEND where  VSPECIALID = '" + PersonID + "' ";
                DBConn.ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, DBConn.sql_conn);
                DA.Fill(dsTemp);

                if (dsTemp.Tables[0].Rows.Count > 0)
                    DS = dsTemp;
                else
                {
                    cmdText = "select VDAYSFLAG from TBL_WEEKEND where  VSPECIALID = 'GENERAL' ";
                    DBConn.ExecutionQuery(cmdText);
                    DA = new SQLiteDataAdapter(cmdText, DBConn.sql_conn);
                    DA.Fill(DS);
                }

                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach ( DataRow dr in DS.Tables[0].Rows)
                    {
                        returnVal = ConvertDays(Convert.ToInt32(dr["VDAYSFLAG"]));
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + " - Problem checkDataIfItUsedOtherTable()");
            }
            return returnVal;
        }








        private void ckbxSearchID_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxSearchID.Checked)
            {
                txtMultID.Enabled = true;
                gbxSearchByDetails.Enabled = false;
                ClearPrsnForm();
            }
            else {
                gbxSearchByDetails.Enabled = true;
                txtMultID.Enabled = false;
            }
        }

        private void btnExcelExporter_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
                ExtractDataToCSV(dataGridView);
            else
                MessageBox.Show("", "Data Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void cbxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxSelectAll.Checked)
                foreach (DataGridViewRow Row in dataGridView.Rows ) {
                    Row.Cells[0].Value = true;
                }
            else
                foreach (DataGridViewRow Row in dataGridView.Rows)
                {
                    Row.Cells[0].Value = false;
                }
        }

        private void cbxEnablePromotion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPromotionApply_Click(object sender, EventArgs e)
        {
            string cmdText = "";
            string cmdTxtUpdate = "";
            foreach (DataGridViewRow dgvr in dataGridView.Rows)
            {

                if (Convert.ToBoolean(dgvr.Cells[colCheckBox.Index].Value))
                {

                    cmdText += " INSERT INTO TBL_PROMOTION_LOG (" +
                                     "ID,      " +
                                     "INDATE,  " +
                                     "FCLASS,  " +
                                     "TCLASS,  " +
                                     "FSEC,    " +
                                     "TSEC,    " +
                                     "FDESIG,  " +
                                     "FDESIG   " +
                                     ")" +
                                " values (" +
                                    " '" + dgvr.Cells[1].Value.ToString() + "', " +
                                    " (SELECT DATE('now')), " +
                                    " '" + dgvr.Cells[4].Value.ToString() + "', " +
                                    " '" + cmbClassTo.Text.ToString()     + "', " +
                                    " '" + dgvr.Cells[7].Value.ToString() + "', " +
                                    " '" + cmbSectionTo.Text.ToString()   + "', " +
                                    " '" + dgvr.Cells[6].Value.ToString() + "', " +
                                    " '" + cmbDesigTo.Text.ToString()     + "' " +
                              "); ";


                    cmdTxtUpdate += " UPDATE TBLPERSON SET " +
                                        " NCLASSID = IFNULL(" + (cmbClassTo.SelectedItem as dynamic).Value  + ", 1), " +
                                        " NSECID   = IFNULL(" + (cmbSectionTo.SelectedItem as dynamic).Value+ ", 1), " +
                                        " NDESIGID = IFNULL(" + (cmbDesigTo.SelectedItem as dynamic).Value  + ", 1)  " +
                                    " WHERE  " +
                                           " PERSONID = '" + dgvr.Cells[1].Value.ToString() + "' ; ";
                }
            }


            if (DBConn.ExecutionQuery(cmdText))
            {
                if(DBConn.ExecutionQuery(cmdTxtUpdate))
                    MessageBox.Show("Insert Success !");
            }
            else {
                MessageBox.Show("Insert Falied !");
            }
            
            ClearPrsnForm();
            LoadData(false);
            LoadDefaultComboValue();
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
            sfd.FileName = "SaveAttendanceData";
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
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
                MessageBox.Show("", "Data Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return; 
        }
    }
}
