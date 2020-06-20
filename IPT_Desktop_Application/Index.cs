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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void buttonAddJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobOpening jobopen = new JobOpening();
            jobopen.ShowDialog();
        }

        private void buttonCandidateLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateLogin jobopen = new CandidateLogin();
            jobopen.ShowDialog();
        }

        private void buttonEmployeeLogin_Click(object sender, EventArgs e)
        {
            EmployeeLogin EmpLogin = new EmployeeLogin();
            this.Hide();
            EmpLogin.Show();

        }
    }
}
