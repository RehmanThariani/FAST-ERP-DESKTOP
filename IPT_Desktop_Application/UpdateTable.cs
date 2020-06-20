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
    public partial class UpdateTable : Form
    {
        // public static string SetValueForText1 = ;
        JobOpeningDb jobdbhelper;
        JobOpeningDb JobOpeningDBHelper = null;
        public static object obj1;

        public UpdateTable()
        {
            InitializeComponent();
            jobdbhelper = new JobOpeningDb();
            JobOpeningDBHelper = new JobOpeningDb();
        }

        private void UpdateTable_Load(object sender, EventArgs e)
        {

        }

        private void buttonClickToFatch_Click(object sender, EventArgs e)
        {
            JobOpenings obj =  jobdbhelper.GetJobById(int.Parse(VacanciesTable.SetValueForText1));
            obj1 = obj;
            textMinExperience.Text = (obj.MinExperience).ToString();
            textJobDiscription.Text = obj.JobDescription;
            textExpectedStartDate.Text = obj.ExpectedStartDate;
            textDesignation.Text = obj.Designation;
            textDepartment.Text = obj.Department;





        }

        private void buttonClickToUpdate_Click(object sender, EventArgs e)
        {
            JobOpenings job = new JobOpenings();

            job.JobID = int.Parse(VacanciesTable.SetValueForText1);
            job.MinExperience = int.Parse(textMinExperience.Text);
            job.JobDescription = textJobDiscription.Text;
            job.ExpectedStartDate = textExpectedStartDate.Text;
            job.Designation = textDesignation.Text;
            job.Department = textDepartment.Text;

            job.Department = textDepartment.Text;
            int result = JobOpeningDBHelper.UpdateJob(job);
            if (result > 0)
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}

