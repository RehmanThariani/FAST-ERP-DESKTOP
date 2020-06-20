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
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void buttonShowAllVacancies_Click(object sender, EventArgs e)
        {
            this.Hide();
            VacanciesTable vc = new VacanciesTable();
            vc.Show();
        }

        private void buttonScheduleExamination_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicantsTable AP = new ApplicantsTable();
            AP.Show();
        }

        private void buttonAddJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobOpening jobopen = new JobOpening();
            jobopen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index id = new Index();
            id.Show();
        }
    }
}
