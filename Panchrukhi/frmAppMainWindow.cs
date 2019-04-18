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
    public partial class frmMainWindow : Form
    {
        int UserType;
        public frmMainWindow(int uType)
        {
            this.UserType = uType;            //values preserved after close                   
            InitializeComponent();
            if (UserType == 2)
            {
                personalDataToolStripMenuItem.Visible       = false;
                setHolyDayToolStripMenuItem.Visible         = false;
                basicSettingToolStripMenuItem.Visible       = false;
                attendanceSettingsToolStripMenuItem.Visible = false;
                promoteAndDemoteToolStripMenuItem.Visible   = false;
            }
            // dataToolStripMenuItem = this.personalDataToolStripMenuItem;
            
        }


        DatabaseConnection DBConn = new DatabaseConnection();




        /*
         * #########################################################################################################################################################
         * ################################### --  Person Tab All Operation --   ###################################################################################
         * #########################################################################################################################################################
         */



        // Form main window Load all this below function ...
        private void frmMainWindow_Load(object sender, EventArgs e)
        {

            LoadPersonGenderCombo();
            ClearPrsnForm();
        }




        private void btnPrsnSaveAndUpdate_Click(object sender, EventArgs e)
        {

        }

        // private method for Person tab ..
        void LoadPersonGenderCombo()
        {

        }


        void ClearPrsnForm()
        {

            //btnPrsnSaveAndUpdate.Enabled = false;
        }

        
        private void btnPrsnReset_Click(object sender, EventArgs e)
        {
            ClearPrsnForm();
        }


        /*
         * #########################################################################################################################################################
         * ################################### -- Add Category Tab All Operation --  ###############################################################################
         * #########################################################################################################################################################
         */



        // Category Tab Pannel Save And Update Button ..
        private void btnCtgrySaveAndUpdate_Click(object sender, EventArgs e)
        {



        }





        /*
         * #########################################################################################################################################################
         * ################################### -- Add Slot Tab All Operation --  ###################################################################################
         * #########################################################################################################################################################
         */

           


        private void btnSlotSaveAndUpdate_Click(object sender, EventArgs e)
        {


            DateTime time = DateTime.Now;             // Use current time.
            string format = "MMM ddd d HH:mm yyyy";   // Use this format.
            time.ToString(format); // Write to console.


            //MessageBox.Show(txtSlotID.Text+" "+ dtTimePcrSlotInTime.For + ""+dtTimePcrSlotOutTime.Text);
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesigData fDesig = new frmDesigData();
            fDesig.Owner = this;
            fDesig.Show();
        }

        private void tstripAddEditPerson_Click(object sender, EventArgs e)
        {
            frmPData fPerson = new frmPData();
            fPerson.Owner = this;
            fPerson.Show(this);
        }

        private void tstripSlots_Click(object sender, EventArgs e)
        {
            frmSlotData fSlot = new frmSlotData();
            fSlot.Owner = this;
            fSlot.Show();
        }

        private void tstripCategories_Click(object sender, EventArgs e)
        {
            frmCategory fCat = new frmCategory();
            fCat.Owner = this;
            fCat.Show();
        }

        private void tstripClasses_Click(object sender, EventArgs e)
        {
            frmClassData fClsData = new frmClassData();
            fClsData.Owner = this;
            fClsData.Show();
        }

        private void tstripSections_Click(object sender, EventArgs e)
        {
            frmSectionData fSdata = new frmSectionData();
            fSdata.Owner = this;
            fSdata.Show();
        }

        private void tstripManualAttendance(object sender, EventArgs e)
        {
            frmManualAttendance fAttndData = new frmManualAttendance();
            fAttndData.Owner = this;
            fAttndData.Show();
        }

        private void tstripAddNewMachine(object sender, EventArgs e)
        {
            frmAddNewMachine fAddM = new frmAddNewMachine();
            fAddM.Owner = this;
            fAddM.Show();
        }

        private void tstripCheckIPStatus(object sender, EventArgs e)
        {
            IPStatusCheck fIPCheck = new IPStatusCheck();
            fIPCheck.Owner = this;
            fIPCheck.Show();
        }

        private void systemAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendanceProcess fSys = new frmAttendanceProcess();
            fSys.Owner = this;
            fSys.Show();
        }

        private void frmMainWindow_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 1 ) {
                foreach (Form childForm in this.MdiChildren) {
                    if ( childForm != this.ActiveMdiChild ) {
                        childForm.Close();
                        return;
                    }
                }
            }
        }

        private void tstripPersonalInfo_Click(object sender, EventArgs e)
        {
            frmReportPersonalInfo fPrsnRprt = new frmReportPersonalInfo();
            fPrsnRprt.Owner = this;
            fPrsnRprt.Show();
        }

        private void addHolyCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHolidayCat fHcat = new frmHolidayCat();
            fHcat.Owner = this;
            fHcat.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetHoliday fSHDay = new frmSetHoliday();
            fSHDay.Owner = this;
            fSHDay.Show();
        }

        private void addWeekendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetWeekend fSWknd = new frmSetWeekend();
            fSWknd.Owner = this;
            fSWknd.Show();
        }

        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonalPromotion fpromot = new frmPersonalPromotion();
            fpromot.Show();
        }

        private void addNewMachineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNewMachine fAddM = new frmAddNewMachine();
            fAddM.Owner = this;
            fAddM.Show();
        }

        private void iPConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPStatusCheck fIPCheck = new IPStatusCheck();
            fIPCheck.Owner = this;
            fIPCheck.Show();
        }

        private void processAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendanceProcess fSys = new frmAttendanceProcess();
            fSys.Owner = this;
            fSys.Show();
        }

        private void manualAttendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManualAttendance fAttndData = new frmManualAttendance();
            fAttndData.Owner = this;
            fAttndData.Show();
        }

        private void promotionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPersonalPromotion fpreP = new frmPersonalPromotion();
            fpreP.Owner = this;
            fpreP.Show();
        }
    }
}
