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
    public partial class ApplicantsTable : Form
    {
        EcandidateApplicationDb dbhelper;
        DataTable dt = new DataTable();
        public ApplicantsTable()
        {
            InitializeComponent();
            dbhelper = new EcandidateApplicationDb();
        }

        private void ApplicantsTable_Load(object sender, EventArgs e)
        {
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("RefID", typeof(int)), new DataColumn("QualifiedStatus", typeof(string)), new DataColumn("ApplyDate", typeof(string)), new DataColumn("TestDate", typeof(string)), new DataColumn("EcandidateID", typeof(int)), new DataColumn("JobID", typeof(int))});
        }

        private void buttonfetchdata_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear(); // If dgv is bound to datatable
            try
            {
                List<EcandidateApplication> AllJobs = dbhelper.GetAllApplications();
                foreach (EcandidateApplication item in AllJobs)
                {
                    dt.Rows.Add(item.RefID, item.QualifiedStatus, item.ApplyDate, item.TestDate, item.EcandidateID, item.JobID);
                }
                this.ApplicantsGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePanel emp = new EmployeePanel();
            emp.Show();
        }
    }
}
