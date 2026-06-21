namespace FitnessProject
{
    partial class frmMHKFitnessActivities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMHKFitnessActivities));
            this.lblUserId = new System.Windows.Forms.Label();
            this.rdoSwimming = new System.Windows.Forms.RadioButton();
            this.rdoWalking = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.cboMetric3 = new System.Windows.Forms.ComboBox();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.lblTodayCalorie = new System.Windows.Forms.Label();
            this.lblTotalCalorie = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblGoal = new System.Windows.Forms.Label();
            this.rdoHiking = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoRunning = new System.Windows.Forms.RadioButton();
            this.rdoCycling = new System.Windows.Forms.RadioButton();
            this.rdoWeightLifting = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDate = new System.Windows.Forms.Label();
            this.gpResult = new System.Windows.Forms.GroupBox();
            this.btnActivities = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.Color.Transparent;
            this.lblUserId.Font = new System.Drawing.Font("Engravers MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUserId.Location = new System.Drawing.Point(14, 18);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(215, 32);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "Welcome ";
            // 
            // rdoSwimming
            // 
            this.rdoSwimming.AutoSize = true;
            this.rdoSwimming.BackColor = System.Drawing.Color.Transparent;
            this.rdoSwimming.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSwimming.ForeColor = System.Drawing.Color.Snow;
            this.rdoSwimming.Location = new System.Drawing.Point(213, 70);
            this.rdoSwimming.Margin = new System.Windows.Forms.Padding(5);
            this.rdoSwimming.Name = "rdoSwimming";
            this.rdoSwimming.Size = new System.Drawing.Size(139, 27);
            this.rdoSwimming.TabIndex = 1;
            this.rdoSwimming.TabStop = true;
            this.rdoSwimming.Text = "Swimming";
            this.rdoSwimming.UseVisualStyleBackColor = false;
            this.rdoSwimming.CheckedChanged += new System.EventHandler(this.rdoSwimming_CheckedChanged);
            // 
            // rdoWalking
            // 
            this.rdoWalking.AutoSize = true;
            this.rdoWalking.BackColor = System.Drawing.Color.Transparent;
            this.rdoWalking.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rdoWalking.ForeColor = System.Drawing.Color.Snow;
            this.rdoWalking.Location = new System.Drawing.Point(63, 70);
            this.rdoWalking.Margin = new System.Windows.Forms.Padding(5);
            this.rdoWalking.Name = "rdoWalking";
            this.rdoWalking.Size = new System.Drawing.Size(116, 27);
            this.rdoWalking.TabIndex = 0;
            this.rdoWalking.TabStop = true;
            this.rdoWalking.Text = "Walking";
            this.rdoWalking.UseVisualStyleBackColor = false;
            this.rdoWalking.CheckedChanged += new System.EventHandler(this.rdoWalking_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMetric1);
            this.groupBox2.Controls.Add(this.lblMetric3);
            this.groupBox2.Controls.Add(this.txtMetric2);
            this.groupBox2.Controls.Add(this.cboMetric3);
            this.groupBox2.Controls.Add(this.lblMetric2);
            this.groupBox2.Controls.Add(this.lblMetric1);
            this.groupBox2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(37, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(571, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(242, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "(hr)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(242, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "(kg)";
            // 
            // txtMetric1
            // 
            this.txtMetric1.Location = new System.Drawing.Point(151, 49);
            this.txtMetric1.Margin = new System.Windows.Forms.Padding(5);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(83, 32);
            this.txtMetric1.TabIndex = 6;
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblMetric3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMetric3.Location = new System.Drawing.Point(37, 195);
            this.lblMetric3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(59, 23);
            this.lblMetric3.TabIndex = 5;
            this.lblMetric3.Text = "MET";
            // 
            // txtMetric2
            // 
            this.txtMetric2.Location = new System.Drawing.Point(151, 120);
            this.txtMetric2.Margin = new System.Windows.Forms.Padding(5);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(83, 32);
            this.txtMetric2.TabIndex = 4;
            // 
            // cboMetric3
            // 
            this.cboMetric3.FormattingEnabled = true;
            this.cboMetric3.Location = new System.Drawing.Point(151, 192);
            this.cboMetric3.Margin = new System.Windows.Forms.Padding(5);
            this.cboMetric3.Name = "cboMetric3";
            this.cboMetric3.Size = new System.Drawing.Size(325, 31);
            this.cboMetric3.TabIndex = 3;
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblMetric2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMetric2.Location = new System.Drawing.Point(35, 123);
            this.lblMetric2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(61, 23);
            this.lblMetric2.TabIndex = 2;
            this.lblMetric2.Text = "Time";
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblMetric1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMetric1.Location = new System.Drawing.Point(22, 52);
            this.lblMetric1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(83, 23);
            this.lblMetric1.TabIndex = 1;
            this.lblMetric1.Text = "Weight";
            // 
            // lblTodayCalorie
            // 
            this.lblTodayCalorie.AutoSize = true;
            this.lblTodayCalorie.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblTodayCalorie.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTodayCalorie.Location = new System.Drawing.Point(134, 138);
            this.lblTodayCalorie.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTodayCalorie.Name = "lblTodayCalorie";
            this.lblTodayCalorie.Size = new System.Drawing.Size(278, 23);
            this.lblTodayCalorie.TabIndex = 3;
            this.lblTodayCalorie.Text = "Calories Burned (Today) =";
            // 
            // lblTotalCalorie
            // 
            this.lblTotalCalorie.AutoSize = true;
            this.lblTotalCalorie.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCalorie.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotalCalorie.Location = new System.Drawing.Point(134, 179);
            this.lblTotalCalorie.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalCalorie.Name = "lblTotalCalorie";
            this.lblTotalCalorie.Size = new System.Drawing.Size(270, 23);
            this.lblTotalCalorie.TabIndex = 4;
            this.lblTotalCalorie.Text = "Calories Burned (Total) =";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblStatus.Location = new System.Drawing.Point(34, 230);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status =";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.BackgroundImage")));
            this.btnCalculate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.Snow;
            this.btnCalculate.Location = new System.Drawing.Point(200, 496);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(184, 94);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblGoal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblGoal.Location = new System.Drawing.Point(134, 97);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(178, 23);
            this.lblGoal.TabIndex = 7;
            this.lblGoal.Text = "Target Calorie =";
            // 
            // rdoHiking
            // 
            this.rdoHiking.AutoSize = true;
            this.rdoHiking.BackColor = System.Drawing.Color.Transparent;
            this.rdoHiking.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rdoHiking.ForeColor = System.Drawing.Color.Snow;
            this.rdoHiking.Location = new System.Drawing.Point(385, 70);
            this.rdoHiking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoHiking.Name = "rdoHiking";
            this.rdoHiking.Size = new System.Drawing.Size(101, 27);
            this.rdoHiking.TabIndex = 8;
            this.rdoHiking.TabStop = true;
            this.rdoHiking.Text = "Hiking";
            this.rdoHiking.UseVisualStyleBackColor = false;
            this.rdoHiking.CheckedChanged += new System.EventHandler(this.rdoHiking_CheckedChanged_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(1057, 683);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 52);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoRunning
            // 
            this.rdoRunning.AutoSize = true;
            this.rdoRunning.BackColor = System.Drawing.Color.Transparent;
            this.rdoRunning.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rdoRunning.ForeColor = System.Drawing.Color.Snow;
            this.rdoRunning.Location = new System.Drawing.Point(870, 70);
            this.rdoRunning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoRunning.Name = "rdoRunning";
            this.rdoRunning.Size = new System.Drawing.Size(117, 27);
            this.rdoRunning.TabIndex = 11;
            this.rdoRunning.TabStop = true;
            this.rdoRunning.Text = "Running";
            this.rdoRunning.UseVisualStyleBackColor = false;
            this.rdoRunning.CheckedChanged += new System.EventHandler(this.rdoRunning_CheckedChanged);
            // 
            // rdoCycling
            // 
            this.rdoCycling.AutoSize = true;
            this.rdoCycling.BackColor = System.Drawing.Color.Transparent;
            this.rdoCycling.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rdoCycling.ForeColor = System.Drawing.Color.Snow;
            this.rdoCycling.Location = new System.Drawing.Point(730, 70);
            this.rdoCycling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoCycling.Name = "rdoCycling";
            this.rdoCycling.Size = new System.Drawing.Size(107, 27);
            this.rdoCycling.TabIndex = 10;
            this.rdoCycling.TabStop = true;
            this.rdoCycling.Text = "Cycling";
            this.rdoCycling.UseVisualStyleBackColor = false;
            this.rdoCycling.CheckedChanged += new System.EventHandler(this.rdoCycling_CheckedChanged);
            // 
            // rdoWeightLifting
            // 
            this.rdoWeightLifting.AutoSize = true;
            this.rdoWeightLifting.BackColor = System.Drawing.Color.Transparent;
            this.rdoWeightLifting.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rdoWeightLifting.ForeColor = System.Drawing.Color.Snow;
            this.rdoWeightLifting.Location = new System.Drawing.Point(515, 70);
            this.rdoWeightLifting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoWeightLifting.Name = "rdoWeightLifting";
            this.rdoWeightLifting.Size = new System.Drawing.Size(181, 27);
            this.rdoWeightLifting.TabIndex = 9;
            this.rdoWeightLifting.TabStop = true;
            this.rdoWeightLifting.Text = "Weight Lifting";
            this.rdoWeightLifting.UseVisualStyleBackColor = false;
            this.rdoWeightLifting.CheckedChanged += new System.EventHandler(this.rdoWeightLifting_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(781, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar1.Location = new System.Drawing.Point(827, 371);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 11);
            this.progressBar1.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDate.Location = new System.Drawing.Point(34, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(174, 23);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Workout Date =";
            // 
            // gpResult
            // 
            this.gpResult.BackColor = System.Drawing.Color.Transparent;
            this.gpResult.Controls.Add(this.lblDate);
            this.gpResult.Controls.Add(this.lblGoal);
            this.gpResult.Controls.Add(this.lblStatus);
            this.gpResult.Controls.Add(this.lblTotalCalorie);
            this.gpResult.Controls.Add(this.lblTodayCalorie);
            this.gpResult.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.gpResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpResult.Location = new System.Drawing.Point(550, 388);
            this.gpResult.Name = "gpResult";
            this.gpResult.Size = new System.Drawing.Size(570, 276);
            this.gpResult.TabIndex = 16;
            this.gpResult.TabStop = false;
            this.gpResult.Text = "Result";
            this.gpResult.Enter += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.BackColor = System.Drawing.Color.Transparent;
            this.btnActivities.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActivities.BackgroundImage")));
            this.btnActivities.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnActivities.ForeColor = System.Drawing.Color.Snow;
            this.btnActivities.Location = new System.Drawing.Point(99, 683);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(397, 52);
            this.btnActivities.TabIndex = 17;
            this.btnActivities.Text = "Show User Activities";
            this.btnActivities.UseVisualStyleBackColor = false;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // frmMHKFitnessActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 747);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.gpResult);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rdoRunning);
            this.Controls.Add(this.rdoCycling);
            this.Controls.Add(this.rdoWeightLifting);
            this.Controls.Add(this.rdoHiking);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdoSwimming);
            this.Controls.Add(this.rdoWalking);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblUserId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMHKFitnessActivities";
            this.Text = "Fitness Activities";
            this.Load += new System.EventHandler(this.frmFitnessActivities_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpResult.ResumeLayout(false);
            this.gpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.RadioButton rdoSwimming;
        private System.Windows.Forms.RadioButton rdoWalking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.ComboBox cboMetric3;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.Label lblTodayCalorie;
        private System.Windows.Forms.Label lblTotalCalorie;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.RadioButton rdoHiking;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.RadioButton rdoRunning;
        private System.Windows.Forms.RadioButton rdoCycling;
        private System.Windows.Forms.RadioButton rdoWeightLifting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gpResult;
        private System.Windows.Forms.Button btnActivities;
    }
}