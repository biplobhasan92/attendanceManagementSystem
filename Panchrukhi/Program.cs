using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panchrukhi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmMainWindow(1));
             Application.Run(new frmLogIn());
            // Application.Run(new frmAppStarter());
            // Application.Run(new frmPData());
            // Application.Run(new frmSlotData());
            // Application.Run(new frmCategory());
            // Application.Run(new frmDesigData());
            // Application.Run(new frmClassData());
            // Application.Run(new frmAttendanceData());
            // Application.Run(new frmSectionData());
            // Application.Run(new frmAddNewMachine());
            // Application.Run(new IPStatusCheck());
            // Application.Run(new SecondSystem());
            // Application.Run(new frmAttendanceProcess());
            // Application.Run(new frmReportPersonalInfo());
            //  Application.Run(new frmPersonalPromotion());
        }
    }
}
