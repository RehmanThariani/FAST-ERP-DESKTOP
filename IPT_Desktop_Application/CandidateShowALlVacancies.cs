using IPT_Desktop_Application.DbOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPT_Desktop_Application
{
    public partial class CandidateShowALlVacancies : Form
    {
        static int flag;
        JobOpeningDb jobdbhelper;
        CandidateDb candidatedbhelper;
        EcandidateApplicationDb eapplicationhelper;
        DataTable dt = new DataTable();
        public CandidateShowALlVacancies()
        {
            InitializeComponent();
            jobdbhelper = new JobOpeningDb();
            candidatedbhelper = new CandidateDb();
            eapplicationhelper = new EcandidateApplicationDb();
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("JobID", typeof(int)), new DataColumn("MinExperience", typeof(int)), new DataColumn("Job Description", typeof(string)), new DataColumn("Date Posted", typeof(string)), new DataColumn("Expected Start Date", typeof(string)), new DataColumn("Designation", typeof(string)), new DataColumn("Department", typeof(string)) });
        }

        private void buttonFecthData_Click(object sender, EventArgs e)
        {
            //this.JobsGridView.DataSource  = null;
            //this.JobsGridView.Rows.Clear();
            dt.Rows.Clear(); // If dgv is bound to datatable
            try
            {
                List<JobOpenings> AllJobs = jobdbhelper.GetAllJobs();
                foreach (JobOpenings item in AllJobs)
                {
                    dt.Rows.Add(item.JobID, item.MinExperience, item.JobDescription, item.DatePosted, item.ExpectedStartDate, item.Designation, item.Department);
                }
                this.JobsGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // If dgv is bound to datatable
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }

                return true;
            }
            if (IsDigitsOnly(textBoxJobID.Text) && textBoxJobID.Text != "")
            {
                int result=0;
                int msg = 0;
                
                List<EcandidateApplication> AllEcan = eapplicationhelper.GetAllApplications();
                if(AllEcan.Count!=0)
                {
                    foreach (EcandidateApplication item in AllEcan)
                    {
                        if (item.EcandidateID == CandidateLogin.LoginID)
                        {
                            msg = 1;
                        }
                    }
                    if(msg==1)
                    {
                        MessageBox.Show("Already Applied");
                    }
                }
                else
                {
                    EcandidateApplication ecan = new EcandidateApplication();
                    ecan.JobID = int.Parse(textBoxJobID.Text);
                    ecan.EcandidateID = CandidateLogin.LoginID;
                    result = eapplicationhelper.AddEcandidateApplication(ecan);
                }
                if (result==1)
                {
                    MessageBox.Show("Applied");
                }
                else if(result==0)
                {
                    MessageBox.Show("Error Applying");
                }
            }
            else
            {
                label1.Text = "* please enter a number";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CandidatePanal cd = new CandidatePanal();
            cd.Show();
        }

        private void JobsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
