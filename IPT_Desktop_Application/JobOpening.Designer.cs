namespace IPT_Desktop_Application
{
    partial class JobOpening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobOpening));
            this.DepartmentName = new System.Windows.Forms.Label();
            this.DesignationName = new System.Windows.Forms.Label();
            this.textMinExperience = new System.Windows.Forms.TextBox();
            this.MinExperience = new System.Windows.Forms.Label();
            this.textJobDescription = new System.Windows.Forms.TextBox();
            this.JobDiscription = new System.Windows.Forms.Label();
            this.textExpectedStartDate = new System.Windows.Forms.TextBox();
            this.ExpectedStartDate = new System.Windows.Forms.Label();
            this.comboDepartmentName = new System.Windows.Forms.ComboBox();
            this.comboDesignationName = new System.Windows.Forms.ComboBox();
            this.AddJob = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.FastLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FastLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSize = true;
            this.DepartmentName.Location = new System.Drawing.Point(108, 265);
            this.DepartmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(140, 20);
            this.DepartmentName.TabIndex = 1;
            this.DepartmentName.Text = "Department Name";
            this.DepartmentName.Click += new System.EventHandler(this.DepartmentName_Click);
            // 
            // DesignationName
            // 
            this.DesignationName.AutoSize = true;
            this.DesignationName.Location = new System.Drawing.Point(108, 300);
            this.DesignationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DesignationName.Name = "DesignationName";
            this.DesignationName.Size = new System.Drawing.Size(140, 20);
            this.DesignationName.TabIndex = 3;
            this.DesignationName.Text = "Designation Name";
            // 
            // textMinExperience
            // 
            this.textMinExperience.Location = new System.Drawing.Point(288, 340);
            this.textMinExperience.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMinExperience.Name = "textMinExperience";
            this.textMinExperience.Size = new System.Drawing.Size(301, 26);
            this.textMinExperience.TabIndex = 6;
            this.textMinExperience.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // MinExperience
            // 
            this.MinExperience.AutoSize = true;
            this.MinExperience.Location = new System.Drawing.Point(108, 340);
            this.MinExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinExperience.Name = "MinExperience";
            this.MinExperience.Size = new System.Drawing.Size(117, 20);
            this.MinExperience.TabIndex = 5;
            this.MinExperience.Text = "Min Experience";
            // 
            // textJobDescription
            // 
            this.textJobDescription.Location = new System.Drawing.Point(288, 380);
            this.textJobDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textJobDescription.Name = "textJobDescription";
            this.textJobDescription.Size = new System.Drawing.Size(301, 26);
            this.textJobDescription.TabIndex = 8;
            // 
            // JobDiscription
            // 
            this.JobDiscription.AutoSize = true;
            this.JobDiscription.Location = new System.Drawing.Point(108, 380);
            this.JobDiscription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobDiscription.Name = "JobDiscription";
            this.JobDiscription.Size = new System.Drawing.Size(113, 20);
            this.JobDiscription.TabIndex = 7;
            this.JobDiscription.Text = "Job Discription";
            // 
            // textExpectedStartDate
            // 
            this.textExpectedStartDate.Location = new System.Drawing.Point(288, 420);
            this.textExpectedStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textExpectedStartDate.Name = "textExpectedStartDate";
            this.textExpectedStartDate.Size = new System.Drawing.Size(301, 26);
            this.textExpectedStartDate.TabIndex = 10;
            // 
            // ExpectedStartDate
            // 
            this.ExpectedStartDate.AutoSize = true;
            this.ExpectedStartDate.Location = new System.Drawing.Point(108, 420);
            this.ExpectedStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpectedStartDate.Name = "ExpectedStartDate";
            this.ExpectedStartDate.Size = new System.Drawing.Size(154, 20);
            this.ExpectedStartDate.TabIndex = 9;
            this.ExpectedStartDate.Text = "Expected Start Date";
            // 
            // comboDepartmentName
            // 
            this.comboDepartmentName.FormattingEnabled = true;
            this.comboDepartmentName.Location = new System.Drawing.Point(288, 252);
            this.comboDepartmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDepartmentName.Name = "comboDepartmentName";
            this.comboDepartmentName.Size = new System.Drawing.Size(301, 28);
            this.comboDepartmentName.TabIndex = 11;
            this.comboDepartmentName.SelectedIndexChanged += new System.EventHandler(this.comboDepartmentName_SelectedIndexChanged);
            // 
            // comboDesignationName
            // 
            this.comboDesignationName.FormattingEnabled = true;
            this.comboDesignationName.Location = new System.Drawing.Point(288, 294);
            this.comboDesignationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDesignationName.Name = "comboDesignationName";
            this.comboDesignationName.Size = new System.Drawing.Size(301, 28);
            this.comboDesignationName.TabIndex = 12;
            // 
            // AddJob
            // 
            this.AddJob.AutoSize = true;
            this.AddJob.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJob.Location = new System.Drawing.Point(278, 163);
            this.AddJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddJob.Name = "AddJob";
            this.AddJob.Size = new System.Drawing.Size(288, 61);
            this.AddJob.TabIndex = 13;
            this.AddJob.Text = "Adding Job";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add.Location = new System.Drawing.Point(478, 478);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 35);
            this.Add.TabIndex = 14;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Submit_Click);
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonBackToHome.Location = new System.Drawing.Point(288, 478);
            this.buttonBackToHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(180, 35);
            this.buttonBackToHome.TabIndex = 15;
            this.buttonBackToHome.Text = "Edit / Delete";
            this.buttonBackToHome.UseVisualStyleBackColor = false;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // FastLogo
            // 
            this.FastLogo.BackColor = System.Drawing.Color.Transparent;
            this.FastLogo.Image = ((System.Drawing.Image)(resources.GetObject("FastLogo.Image")));
            this.FastLogo.Location = new System.Drawing.Point(152, 18);
            this.FastLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FastLogo.Name = "FastLogo";
            this.FastLogo.Size = new System.Drawing.Size(522, 125);
            this.FastLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FastLogo.TabIndex = 0;
            this.FastLogo.TabStop = false;
            // 
            // JobOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 580);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddJob);
            this.Controls.Add(this.comboDesignationName);
            this.Controls.Add(this.comboDepartmentName);
            this.Controls.Add(this.textExpectedStartDate);
            this.Controls.Add(this.ExpectedStartDate);
            this.Controls.Add(this.textJobDescription);
            this.Controls.Add(this.JobDiscription);
            this.Controls.Add(this.textMinExperience);
            this.Controls.Add(this.MinExperience);
            this.Controls.Add(this.DesignationName);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.FastLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JobOpening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobOpening";
            this.Load += new System.EventHandler(this.JobOpening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FastLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FastLogo;
        private System.Windows.Forms.Label DepartmentName;
        private System.Windows.Forms.Label DesignationName;
        private System.Windows.Forms.TextBox textMinExperience;
        private System.Windows.Forms.Label MinExperience;
        private System.Windows.Forms.TextBox textJobDescription;
        private System.Windows.Forms.Label JobDiscription;
        private System.Windows.Forms.TextBox textExpectedStartDate;
        private System.Windows.Forms.Label ExpectedStartDate;
        private System.Windows.Forms.ComboBox comboDepartmentName;
        private System.Windows.Forms.ComboBox comboDesignationName;
        private System.Windows.Forms.Label AddJob;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button buttonBackToHome;
    }
}

