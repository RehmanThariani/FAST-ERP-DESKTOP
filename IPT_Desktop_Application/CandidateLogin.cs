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
    public partial class CandidateLogin : Form
    {
        public static int LoginID;
        LoginDb logindbhelper = null;
        CandidateDb candidatedbhelper = null;
        public CandidateLogin()
        {
            InitializeComponent();
            logindbhelper = new LoginDb();
            candidatedbhelper = new CandidateDb();
        }

        private void labelCandidateLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login job = new Login();
            job.Username =textUserName.Text;
            job.Password = textPassword.Text;

            List<CandidateEmployee> AllCandidate = candidatedbhelper.GetAllCandidates();
            int count = 0;
            foreach (CandidateEmployee item in AllCandidate)
            {
                if (item.Email == job.Username && item.Epassword==job.Password)
                {
                    LoginID = item.ECandidateID;
                     count = 1;
                    this.Hide();
                    CandidatePanal jobopen = new CandidatePanal();
                    jobopen.Show();
                }
                
            }
            if(count!=1)
            {
                MessageBox.Show("invalid login");
                CandidateLogin cd = new CandidateLogin();
                this.Hide();
                cd.Show();
            }
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateSignup jobopen = new CandidateSignup();
            jobopen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index id = new Index();
            id.Show();
        }
    }
}
