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
    public partial class frmMHKShowHistory : Form
    {
        int userId;
        public frmMHKShowHistory(int userid)
        {
            InitializeComponent();
            this.userId = userid;
        }

        private void frmOMKShowHistory_Load(object sender, EventArgs e)
        {
            MHKFitnessClass ft = new MHKFitnessClass();
            dataGridView1.DataSource = ft.ShowUserActvities(this.userId);

           
        }
    }
}
