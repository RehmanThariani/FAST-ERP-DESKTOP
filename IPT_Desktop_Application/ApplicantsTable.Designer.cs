namespace IPT_Desktop_Application
{
    partial class ApplicantsTable
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
            this.ApplicantsGridView = new System.Windows.Forms.DataGridView();
            this.buttonfetchdata = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicantsGridView
            // 
            this.ApplicantsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicantsGridView.Location = new System.Drawing.Point(12, 59);
            this.ApplicantsGridView.Name = "ApplicantsGridView";
            this.ApplicantsGridView.RowTemplate.Height = 28;
            this.ApplicantsGridView.Size = new System.Drawing.Size(1246, 468);
            this.ApplicantsGridView.TabIndex = 0;
            // 
            // buttonfetchdata
            // 
            this.buttonfetchdata.Location = new System.Drawing.Point(363, 12);
            this.buttonfetchdata.Name = "buttonfetchdata";
            this.buttonfetchdata.Size = new System.Drawing.Size(273, 41);
            this.buttonfetchdata.TabIndex = 1;
            this.buttonfetchdata.Text = "FETCH DATA";
            this.buttonfetchdata.UseVisualStyleBackColor = true;
            this.buttonfetchdata.Click += new System.EventHandler(this.buttonfetchdata_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplicantsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonfetchdata);
            this.Controls.Add(this.ApplicantsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicantsTable";
            this.Text = "ApplicantsTable";
            this.Load += new System.EventHandler(this.ApplicantsTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ApplicantsGridView;
        private System.Windows.Forms.Button buttonfetchdata;
        private System.Windows.Forms.Button button1;
    }
}