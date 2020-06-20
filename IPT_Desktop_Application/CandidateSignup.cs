using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPT_Desktop_Application.DbOperations;

namespace IPT_Desktop_Application
{
    
    public partial class CandidateSignup : Form
    {
        CandidateDb candidatedbhelper = null;
        public CandidateSignup()
        {
            InitializeComponent();
            candidatedbhelper = new CandidateDb();
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateLogin jobopen = new CandidateLogin();
            jobopen.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            CandidateEmployee obj = new CandidateEmployee();
            obj.EName = textEName.Text;
            obj.Email = textEmail.Text;
            obj.Epassword = textEpassword.Text;

            obj.ConfirmPassword = textConfirmPassword.Text;
            obj.MobileNumber = textMobileNumber.Text;
            obj.EducationalLevel = textEducationalLevel.Text;
            obj.ExperienceYears = int.Parse(textExperienceYears.Text);
            obj.CVPath = textCVPath.Text;
            obj.CoverLetterPath = textCoverLetterPath.Text;

            if(textEpassword.Text == textConfirmPassword.Text)
            {
                int result = candidatedbhelper.AddCandidate(obj);
                if (result > 0)
                {
                    MessageBox.Show("Registration Sucessfull");
                    this.Hide();
                    CandidateLogin jobopen = new CandidateLogin();
                    jobopen.ShowDialog();

                }
            }
            else
            {
                validations.Text = "* password and conform password do not match";
                textEName.Text = obj.EName;


            }



        }

        private void CandidateSignup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateLogin id = new CandidateLogin();
            id.Show();
        }
    }
}
