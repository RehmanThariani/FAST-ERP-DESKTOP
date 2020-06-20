namespace IPT_Desktop_Application
{
    partial class CandidateShowALlVacancies
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
            this.JobsGridView = new System.Windows.Forms.DataGridView();
            this.buttonFecthData = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxJobID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JobsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // JobsGridView
            // 
            this.JobsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobsGridView.Location = new System.Drawing.Point(12, 57);
            this.JobsGridView.Name = "JobsGridView";
            this.JobsGridView.RowTemplate.Height = 28;
            this.JobsGridView.Size = new System.Drawing.Size(1242, 351);
            this.JobsGridView.TabIndex = 0;
            this.JobsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobsGridView_CellContentClick);
            // 
            // buttonFecthData
            // 
            this.buttonFecthData.Location = new System.Drawing.Point(530, 14);
            this.buttonFecthData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFecthData.Name = "buttonFecthData";
            this.buttonFecthData.Size = new System.Drawing.Size(219, 35);
            this.buttonFecthData.TabIndex = 2;
            this.buttonFecthData.Text = "Fetch NUCES Vacancies";
            this.buttonFecthData.UseVisualStyleBackColor = true;
            this.buttonFecthData.Click += new System.EventHandler(this.buttonFecthData_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(428, 437);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(260, 71);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "APPLY";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxJobID
            // 
            this.textBoxJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJobID.Location = new System.Drawing.Point(273, 448);
            this.textBoxJobID.Name = "textBoxJobID";
            this.textBoxJobID.Size = new System.Drawing.Size(128, 53);
            this.textBoxJobID.TabIndex = 4;
            this.textBoxJobID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "JOB ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CandidateShowALlVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJobID);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonFecthData);
            this.Controls.Add(this.JobsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateShowALlVacancies";
            this.Text = "CandidateShowALlVacancies";
            ((System.ComponentModel.ISupportInitialize)(this.JobsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JobsGridView;
        private System.Windows.Forms.Button buttonFecthData;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxJobID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}