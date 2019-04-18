using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panchrukhi
{
    public partial class frmAppStarter : Form
    {
        public frmAppStarter()
        {
            InitializeComponent();
        }


        int countMax = 0;
        private void tmrProgresBar_Tick(object sender, EventArgs e)
        {
            //tmrProgresBar.Enabled = false;
            pgrsbrAppStarter.Increment(1);
            lblPgrsPersent.Text = pgrsbrAppStarter.Value.ToString() + " %";
            if (pgrsbrAppStarter.Value == pgrsbrAppStarter.Maximum)
            {
                tmrProgresBar.Stop();
                this.Close();
                
            }

        }

   

        private void frmAppStarter_Load(object sender, EventArgs e)
        {
            
            tmrProgresBar.Start();
        }

        private void frmAppStarter_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
