namespace IPT_Desktop_Application
{
    partial class EmployeePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePanel));
            this.buttonViewApplicants = new System.Windows.Forms.Button();
            this.buttonViewActiveVacancies = new System.Windows.Forms.Button();
            this.buttonAddJob = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewApplicants
            // 
            this.buttonViewApplicants.BackColor = System.Drawing.Color.Tomato;
            this.buttonViewApplicants.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewApplicants.ForeColor = System.Drawing.Color.Transparent;
            this.buttonViewApplicants.Location = new System.Drawing.Point(228, 389);
            this.buttonViewApplicants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonViewApplicants.Name = "buttonViewApplicants";
            this.buttonViewApplicants.Size = new System.Drawing.Size(546, 78);
            this.buttonViewApplicants.TabIndex = 6;
            this.buttonViewApplicants.Text = "View Applications";
            this.buttonViewApplicants.UseVisualStyleBackColor = false;
            this.buttonViewApplicants.Click += new System.EventHandler(this.buttonScheduleExamination_Click);
            // 
            // buttonViewActiveVacancies
            // 
            this.buttonViewActiveVacancies.BackColor = System.Drawing.Color.Tomato;
            this.buttonViewActiveVacancies.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewActiveVacancies.ForeColor = System.Drawing.Color.Transparent;
            this.buttonViewActiveVacancies.Location = new System.Drawing.Point(228, 228);
            this.buttonViewActiveVacancies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonViewActiveVacancies.Name = "buttonViewActiveVacancies";
            this.buttonViewActiveVacancies.Size = new System.Drawing.Size(546, 129);
            this.buttonViewActiveVacancies.TabIndex = 5;
            this.buttonViewActiveVacancies.Text = "EDIT/DELETE ACTIVE JOBS";
            this.buttonViewActiveVacancies.UseVisualStyleBackColor = false;
            this.buttonViewActiveVacancies.Click += new System.EventHandler(this.buttonShowAllVacancies_Click);
            // 
            // buttonAddJob
            // 
            this.buttonAddJob.BackColor = System.Drawing.Color.Tomato;
            this.buttonAddJob.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddJob.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddJob.Location = new System.Drawing.Point(228, 114);
            this.buttonAddJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddJob.Name = "buttonAddJob";
            this.buttonAddJob.Size = new System.Drawing.Size(546, 78);
            this.buttonAddJob.TabIndex = 7;
            this.buttonAddJob.Text = "ADD A JOB";
            this.buttonAddJob.UseVisualStyleBackColor = false;
            this.buttonAddJob.Click += new System.EventHandler(this.buttonAddJob_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(765, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 72);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddJob);
            this.Controls.Add(this.buttonViewApplicants);
            this.Controls.Add(this.buttonViewActiveVacancies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewApplicants;
        private System.Windows.Forms.Button buttonViewActiveVacancies;
        private System.Windows.Forms.Button buttonAddJob;
        private System.Windows.Forms.Button button1;
    }
}