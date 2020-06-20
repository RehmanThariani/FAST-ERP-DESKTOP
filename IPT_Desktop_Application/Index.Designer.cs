namespace IPT_Desktop_Application
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCandidateLogin = new System.Windows.Forms.Button();
            this.buttonEmployeeLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCandidateLogin
            // 
            this.buttonCandidateLogin.BackColor = System.Drawing.Color.Tomato;
            this.buttonCandidateLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCandidateLogin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCandidateLogin.Location = new System.Drawing.Point(317, 234);
            this.buttonCandidateLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCandidateLogin.Name = "buttonCandidateLogin";
            this.buttonCandidateLogin.Size = new System.Drawing.Size(454, 78);
            this.buttonCandidateLogin.TabIndex = 2;
            this.buttonCandidateLogin.Text = "Candidate Login";
            this.buttonCandidateLogin.UseVisualStyleBackColor = false;
            this.buttonCandidateLogin.Click += new System.EventHandler(this.buttonCandidateLogin_Click);
            // 
            // buttonEmployeeLogin
            // 
            this.buttonEmployeeLogin.BackColor = System.Drawing.Color.Tomato;
            this.buttonEmployeeLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeLogin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEmployeeLogin.Location = new System.Drawing.Point(317, 322);
            this.buttonEmployeeLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEmployeeLogin.Name = "buttonEmployeeLogin";
            this.buttonEmployeeLogin.Size = new System.Drawing.Size(454, 78);
            this.buttonEmployeeLogin.TabIndex = 3;
            this.buttonEmployeeLogin.Text = "Employee Login";
            this.buttonEmployeeLogin.UseVisualStyleBackColor = false;
            this.buttonEmployeeLogin.Click += new System.EventHandler(this.buttonEmployeeLogin_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1102, 542);
            this.Controls.Add(this.buttonEmployeeLogin);
            this.Controls.Add(this.buttonCandidateLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCandidateLogin;
        private System.Windows.Forms.Button buttonEmployeeLogin;
    }
}