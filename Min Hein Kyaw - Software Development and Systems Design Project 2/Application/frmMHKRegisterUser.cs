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

namespace FitnessProject
{
    public partial class frmMHKRegisterUser : Form
    {
        public frmMHKRegisterUser()
        {
            InitializeComponent();
        }

        internal MHKUserClass OKUserClass
        {
            get => default;
            set
            {
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MHKUserClass user = new MHKUserClass();
            //presece check
            if (txtUserName.Text == "" | txtPassword.Text == "" | txtGoalCalorie.Text == "")
            {
                MessageBox.Show("Please complete all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //format checks
            Regex regeCap = new Regex("[A-Z]");
            Regex regeSmall = new Regex("[a-z]");
            Regex regeNum = new Regex("[0-9]");

            if ( !regeSmall.IsMatch(txtUserName.Text))

            {
                MessageBox.Show("Username should include letters or numbers only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!regeCap.IsMatch(txtPassword.Text)
                 | !regeSmall.IsMatch(txtPassword.Text)
                  | txtPassword.Text.Length != 12)
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, and be exactly 12 characters long!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.Uname = txtUserName.Text;
            user.Upassword = txtPassword.Text;

            try
            {
                user.GoalCal = double.Parse(txtGoalCalorie.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Format error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //check if goal cal is  goalCal<=300 and goalCal>=100000


            user.GoalCal = double.Parse(txtGoalCalorie.Text);

            //check if user name already existed
            if (user.CheckExisitingUser(user.Uname) != 0)
            {
                MessageBox.Show("The username is already taken " + txtUserName.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int uid = user.Registration();
            if (uid != 0)
            {
                MessageBox.Show("Registration completed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
