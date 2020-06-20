//using IptProject.Content.FacultyRecruitment.DbOperations;
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
    public partial class JobOpening : Form
    {
       // LoginDb logindbhelper = null;
        JobOpeningDb JobOpeningDBHelper = null;
        public JobOpening()
        {
            InitializeComponent();
            //logindbhelper = new LoginDb();
            JobOpeningDBHelper = new JobOpeningDb();

        }

        private void JobOpening_Load(object sender, EventArgs e)
        {
           List<Department> AllDepartments = JobOpeningDBHelper.GetAllDepartments();
            Dictionary<int,string> comboSource;
            comboSource=  new Dictionary<int,string>();
            foreach (Department item in AllDepartments)
            {
                comboSource.Add(item.DepartmentID, item.DepartmentName);

            }
            comboDepartmentName.DataSource = new BindingSource(comboSource, null);

            List<Designation> AllDesingation = JobOpeningDBHelper.GetAllDesignations();
            Dictionary<int, string> comboSource1;
            comboSource1 = new Dictionary<int, string>();
            foreach (Designation item in AllDesingation)
            {
                comboSource1.Add(item.DesignationID, item.DesignationTitle);

            }
            comboDesignationName.DataSource = new BindingSource(comboSource1, null);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentName_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            

            JobOpenings job = new JobOpenings();
            job.MinExperience = int.Parse(textMinExperience.Text);
            job.JobDescription = textJobDescription.Text;
            job.DatePosted =DateTime.Now.ToString("YYYY-mm-DD");
            job.ExpectedStartDate = textExpectedStartDate.Text;
            job.Designation = ((KeyValuePair<int,string>)comboDesignationName.SelectedItem).Value;
            job.Department = ((KeyValuePair<int, string>)comboDepartmentName.SelectedItem).Value;
            int result = JobOpeningDBHelper.AddJob(job);
            if(result>0)
            {
                MessageBox.Show("Data Added Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void comboDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            VacanciesTable cs  = new VacanciesTable();
            cs.Show();
        }
    }
}
