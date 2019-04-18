using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panchrukhi.DAO;
using System.Windows.Forms;

namespace Panchrukhi
{
    public partial class frmLogIn : Form
    {
        DatabaseConnection DBConn = new DatabaseConnection();
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();


        public frmLogIn()
        {
            frmAppStarter st = new frmAppStarter();
            st.ShowDialog(this);
            InitializeComponent();
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2);
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2);

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            DataRow dr = DBConn.getCompanyNameAndAddress();
            lblCompanyName.Text = dr["VCOMPANY_NAME"].ToString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int loginType = DBConn.checkUserToLogIn(txtUserName.Text, txtPassword.Text);
            if (loginType == 0)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
                lblLogInError.Text = "User or password are not matched !!";
                return;
            }
            else {
                this.Hide();
                frmMainWindow fr = new frmMainWindow(loginType);
                fr.ShowDialog();
                this.Close();
            }



        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnLogin_Click(this,null);
        }
    }
}
