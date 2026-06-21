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
    public partial class frmMHKMain : Form
    {
        public frmMHKMain()
        {
            InitializeComponent();
        }

        public frmMHKRegisterUser frmRegisterUser
        {
            get => default;
            set
            {
            }
        }

        public frmMHKUserLogin frmUserLogin
        {
            get => default;
            set
            {
            }
        }

        public frmMHKUserLogin frmOMKUserLogin
        {
            get => default;
            set
            {
            }
        }

        public frmMHKRegisterUser frmOMKRegisterUser
        {
            get => default;
            set
            {
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmMHKRegisterUser frmreg=new frmMHKRegisterUser();
            frmreg.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMHKUserLogin login = new frmMHKUserLogin();
            login.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            this.MinimumSize = new Size(0, 0);
        }
    }
}
