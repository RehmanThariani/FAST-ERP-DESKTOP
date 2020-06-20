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
    public partial class EmployeeLogin : Form
    {
        EmployeeDb empdbhelper;
        public EmployeeLogin()
        {
            InitializeComponent();
            empdbhelper = new EmployeeDb();
        }

        private void labelEmployeeLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<Employee> AllEmployee = empdbhelper.GetAllEmployee();
            int flag = 0;
            foreach (Employee item in AllEmployee)
            {
                if (item.Email == textEmail.Text && item.Epassword == textPassword.Text)
                {

                    flag = 1;
                    break;
                }

            }
            if (flag == 1)
            {
                this.Hide();
                EmployeePanel jobopen = new EmployeePanel();
                jobopen.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid login");
                EmployeeLogin cd = new EmployeeLogin();
                this.Hide();
                cd.ShowDialog();
            }
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index id= new Index();
            id.Show();
        }
    }
}
