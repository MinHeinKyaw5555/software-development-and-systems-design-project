using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessProject
{
    public partial class frmMHKUserLogin : Form
    {
        int uid;
        string uname;
        public frmMHKUserLogin()
        {
            InitializeComponent();
        }

        public frmMHKFitnessActivities frmFitnessActivities
        {
            get => default;
            set
            {
            }
        }

        public frmMHKFitnessActivities frmOMKFitnessActivities
        {
            get => default;
            set
            {
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MHKUserClass user = new MHKUserClass();
            
            //input validation code
            if(txtUserName.Text=="" || txtPassword.Text=="")
            {
                MessageBox.Show("Please enter the required data");
                return;
            }

            user.Uname = txtUserName.Text;  
            uname =txtUserName.Text;
            user.Upassword = txtPassword.Text;

            uid=user.Login();
            if (uid != 0)
            {
                MessageBox.Show("Welcome! Login successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                btnFitness.Enabled = true;

            }
            else
            {
                MessageBox.Show("Login failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

         private void btnFitness_Click(object sender, EventArgs e)
        {
            frmMHKFitnessActivities frm   =new frmMHKFitnessActivities(uid,uname);
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
