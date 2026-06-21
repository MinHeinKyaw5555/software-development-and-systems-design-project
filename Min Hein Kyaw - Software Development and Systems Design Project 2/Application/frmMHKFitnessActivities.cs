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
    public partial class frmMHKFitnessActivities : Form
    {
        int userId;
        int aid; //activity id 
        string uname;
        
        public frmMHKFitnessActivities(int uid, string uname)
        {
            InitializeComponent();
            this.userId = uid;
            this.uname = uname;
        }

        internal MHKFitnessClass FitnessClass
        {
            get => default;
            set
            {
            }
        }

        internal MHKFitnessClass MHKFitnessClass
        {
            get => default;
            set
            {
            }
        }

        private void frmFitnessActivities_Load(object sender, EventArgs e)
        {
            lblUserId.Text = "Welcome " + this.uname;
            lblDate.Text = "Today Date = " + DateTime.Now.ToShortDateString();    

            MHKFitnessClass fc = new MHKFitnessClass();
            lblGoal.Text = "Goal Calorie = " +fc.GetGoalCalorie(this.userId).ToString();
        }

        private void rdoWalking_CheckedChanged(object sender, EventArgs e)
        {
            aid = 1;
            var choices = new Dictionary<string, string>();
            choices["2.8"] = "Walking – slow pace (≤3 km/h)";
            choices["3.3"] = "Walking – normal pace (4 km/h)";
            choices["4.3"] = "Walking – brisk pace (5.5 km/h)";
            choices["5.0"] = "Walking – very brisk / uphill";

            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";

            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\1. Walking.gif";

        }

        private void rdoSwimming_CheckedChanged(object sender, EventArgs e)
        {
            aid = 2;
            var choices = new Dictionary<string, string>();
            choices["5.8"] = "Swimming – recreational / slow";
            choices["6.8"] = "Swimming – moderate effort";
            choices["8.3"] = "Swimming – vigorous effort";
            choices["9.5"] = "Swimming – laps / competitive";

            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";

            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\2. Swimming.gif";

        }

        private void rdoHiking_CheckedChanged_1(object sender, EventArgs e)
        {
            aid = 3;
            var choices = new Dictionary<string, string>();
            choices["5.3"] = "Hiking – flat terrain (easy pace)";
            choices["6.5"] = "Hiking – hills or uneven terrain";
            choices["7.3"] = "Hiking – uphill / cross-country";
            choices["8.5"] = "Hiking – heavy backpack (≥10 kg)";
            choices["9.1"] = "Hiking – mountain / steep trails";

            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";

            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\3. Hiking.gif";

        }

        private void rdoWeightLifting_CheckedChanged(object sender, EventArgs e)
        {
            aid = 4;
            var choices = new Dictionary<string, string>();
            choices["3.0"] = "Weight lifting – light effort";
            choices["3.5"] = "Weight lifting – moderate effort";
            choices["6.0"] = "Weight lifting – vigorous / heavy";
            choices["8.0"] = "Weight lifting – circuit training";

            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";

            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\4. Weight Lifting.gif";
        }

        private void rdoCycling_CheckedChanged(object sender, EventArgs e)
        {
            aid = 5;
            var choices = new Dictionary<string, string>();
            choices["4.0"] = "Cycling – leisure (<16 km/h)";
            choices["6.8"] = "Cycling – moderate (16–19 km/h)";
            choices["8.0"] = "Cycling – fast (20–22 km/h)";
            choices["10.0"] = "Cycling – racing / very fast";

            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";

            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\5. Cycling.gif";
        }

        private void rdoRunning_CheckedChanged(object sender, EventArgs e)
        {
            aid = 6;
            var choices = new Dictionary<string, string>();
            choices["8.3"] = "Running – jogging (8 km/h)";
            choices["9.8"] = "Running – 6 mph (9.7 km/h)";
            choices["11.0"] = "Running – 7 mph (11.3 km/h)";
            choices["11.8"] = "Running – 8 mph (12.9 km/h)";
            choices["14.5"] = "Running – 10 mph (16 km/h)";

            cboMetric3.DataSource = new BindingSource(choices, null);
            cboMetric3.DisplayMember = "Value";
            cboMetric3.ValueMember = "Key";

            pictureBox1.ImageLocation = Application.StartupPath + "\\images\\6. Running.gif";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtMetric1 is weight

            float weight = float.Parse(txtMetric1.Text);

            //txtMetric2 is time
            float time=float.Parse(txtMetric2.Text);

            //cboMetric3 is MET
            float MET = float.Parse(cboMetric3.SelectedValue.ToString());

            //calculate calorie
            float toDaycalorie = time * weight * MET;
            lblTodayCalorie.Text = "Today calorie burnt = " + toDaycalorie.ToString();
            
            MHKFitnessClass fc = new MHKFitnessClass();
            fc.InsertMetric(this.userId, aid, toDaycalorie, DateTime.Now);

            double totalCalorie;
            totalCalorie =fc.GetTotalCalorie(this.userId);
            lblTotalCalorie.Text = "Total Calorie = " + totalCalorie.ToString();

            double goalCalorie;
            goalCalorie = fc.GetGoalCalorie(this.userId);
            
            double remain= goalCalorie - totalCalorie;
            if (remain <= 0) lblStatus.Text = "Congratulations! You’ve reached your goal";
            else lblStatus.Text = remain.ToString() + " remaining";

            UpdateCalorieProgress(goalCalorie,totalCalorie);
        }


        private void UpdateCalorieProgress(double goalCalories, double totalCalories)
        {
            if (goalCalories <= 0)
            {
                progressBar1.Value = 0;
                return;
            }

            // Calculate progress percentage
            int progress = (int)Math.Round((double)totalCalories / goalCalories * 100);
            progress = Math.Min(progress, 100); // Cap at 100%
            progressBar1.Value = progress;

        }
                  
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            frmMHKShowHistory frmShow = new frmMHKShowHistory(this.userId);
            frmShow.ShowDialog();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            frmMHKShowHistory frmHistory = new frmMHKShowHistory(this.userId);
            frmHistory.ShowDialog();
        }
    }
}
