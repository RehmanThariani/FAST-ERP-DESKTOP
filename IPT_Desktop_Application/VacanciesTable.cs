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
    public partial class VacanciesTable : Form
    {
        public static string SetValueForText1;
        JobOpeningDb jobdbhelper;
        DataTable dt = new DataTable();
        public VacanciesTable()
        {
            InitializeComponent();
            jobdbhelper = new JobOpeningDb();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void VacanciesTable_Load(object sender, EventArgs e)
        {
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("JobID", typeof(int)), new DataColumn("MinExperience", typeof(int)), new DataColumn("Job Description", typeof(string)), new DataColumn("Date Posted", typeof(string)), new DataColumn("Expected Start Date", typeof(string)), new DataColumn("Designation", typeof(string)), new DataColumn("Department", typeof(string)) });
        }

        private void labelAddIDtoupdate_Click(object sender, EventArgs e)
        {
           
        }

        private void textJobIdToDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            if(IsDigitsOnly(textJobIdToUpdate.Text) && textJobIdToUpdate.Text!="")
            {
               int result = jobdbhelper.DeleteJob(int.Parse(textJobIdToUpdate.Text));
                if(result > 0)
                {
                    MessageBox.Show("Suucessfully Deleted. Please Fetch again");
                }
                else
                {
                    label1.Text = "* ID doesn't exist";
                }
               
            }

            else
            {
                label1.Text = "* please enter a number";
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetValueForText1 = textJobIdToUpdate.Text;
            UpdateTable up = new UpdateTable();
            this.Hide();
            up.Show();
        }

        private void textJobIdToUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePanel em = new EmployeePanel();
            em.Show();
        }
    }
}
