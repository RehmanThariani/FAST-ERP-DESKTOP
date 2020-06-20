namespace IPT_Desktop_Application
{
    partial class VacanciesTable
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
            this.textJobIdToUpdate = new System.Windows.Forms.TextBox();
            this.labelAddJobIDtoupdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JobsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // JobsGridView
            // 
            this.JobsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobsGridView.Location = new System.Drawing.Point(22, 59);
            this.JobsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobsGridView.Name = "JobsGridView";
            this.JobsGridView.Size = new System.Drawing.Size(1142, 413);
            this.JobsGridView.TabIndex = 0;
            // 
            // buttonFecthData
            // 
            this.buttonFecthData.Location = new System.Drawing.Point(22, 14);
            this.buttonFecthData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFecthData.Name = "buttonFecthData";
            this.buttonFecthData.Size = new System.Drawing.Size(219, 35);
            this.buttonFecthData.TabIndex = 1;
            this.buttonFecthData.Text = "Fetch Current Data";
            this.buttonFecthData.UseVisualStyleBackColor = true;
            this.buttonFecthData.Click += new System.EventHandler(this.button1_Click);
            // 
            // textJobIdToUpdate
            // 
            this.textJobIdToUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJobIdToUpdate.Location = new System.Drawing.Point(486, 505);
            this.textJobIdToUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textJobIdToUpdate.Name = "textJobIdToUpdate";
            this.textJobIdToUpdate.Size = new System.Drawing.Size(238, 62);
            this.textJobIdToUpdate.TabIndex = 2;
            this.textJobIdToUpdate.TextChanged += new System.EventHandler(this.textJobIdToUpdate_TextChanged);
            // 
            // labelAddJobIDtoupdate
            // 
            this.labelAddJobIDtoupdate.AutoSize = true;
            this.labelAddJobIDtoupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddJobIDtoupdate.Location = new System.Drawing.Point(124, 524);
            this.labelAddJobIDtoupdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddJobIDtoupdate.Name = "labelAddJobIDtoupdate";
            this.labelAddJobIDtoupdate.Size = new System.Drawing.Size(303, 37);
            this.labelAddJobIDtoupdate.TabIndex = 4;
            this.labelAddJobIDtoupdate.Text = "Enter Valid JOB ID";
            this.labelAddJobIDtoupdate.Click += new System.EventHandler(this.labelAddIDtoupdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(786, 543);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 585);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(786, 586);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VacanciesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 670);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAddJobIDtoupdate);
            this.Controls.Add(this.textJobIdToUpdate);
            this.Controls.Add(this.buttonFecthData);
            this.Controls.Add(this.JobsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VacanciesTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VacanciesTable";
            this.Load += new System.EventHandler(this.VacanciesTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JobsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JobsGridView;
        private System.Windows.Forms.Button buttonFecthData;
        private System.Windows.Forms.TextBox textJobIdToUpdate;
        private System.Windows.Forms.Label labelAddJobIDtoupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}