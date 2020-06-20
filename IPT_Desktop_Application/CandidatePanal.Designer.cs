namespace IPT_Desktop_Application
{
    partial class CandidatePanal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatePanal));
            this.buttonShowAllVacancies = new System.Windows.Forms.Button();
            this.buttonScheduleExamination = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowAllVacancies
            // 
            this.buttonShowAllVacancies.BackColor = System.Drawing.Color.Tomato;
            this.buttonShowAllVacancies.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAllVacancies.ForeColor = System.Drawing.Color.Transparent;
            this.buttonShowAllVacancies.Location = new System.Drawing.Point(162, 185);
            this.buttonShowAllVacancies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowAllVacancies.Name = "buttonShowAllVacancies";
            this.buttonShowAllVacancies.Size = new System.Drawing.Size(546, 78);
            this.buttonShowAllVacancies.TabIndex = 3;
            this.buttonShowAllVacancies.Text = "Show All Vacancies";
            this.buttonShowAllVacancies.UseVisualStyleBackColor = false;
            this.buttonShowAllVacancies.Click += new System.EventHandler(this.buttonShowAllVacancies_Click);
            // 
            // buttonScheduleExamination
            // 
            this.buttonScheduleExamination.BackColor = System.Drawing.Color.Tomato;
            this.buttonScheduleExamination.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleExamination.ForeColor = System.Drawing.Color.Transparent;
            this.buttonScheduleExamination.Location = new System.Drawing.Point(162, 272);
            this.buttonScheduleExamination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonScheduleExamination.Name = "buttonScheduleExamination";
            this.buttonScheduleExamination.Size = new System.Drawing.Size(546, 78);
            this.buttonScheduleExamination.TabIndex = 4;
            this.buttonScheduleExamination.Text = "Scheduled Test";
            this.buttonScheduleExamination.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(614, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CandidatePanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonScheduleExamination);
            this.Controls.Add(this.buttonShowAllVacancies);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CandidatePanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidatePanal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonShowAllVacancies;
        private System.Windows.Forms.Button buttonScheduleExamination;
        private System.Windows.Forms.Button button1;
    }
}