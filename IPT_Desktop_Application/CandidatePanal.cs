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
    public partial class CandidatePanal : Form
    {
        public CandidatePanal()
        {
            InitializeComponent();
        }

        private void buttonShowAllVacancies_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateShowALlVacancies csv = new CandidateShowALlVacancies();
            csv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index id = new Index();
            id.Show();
        }
    }
}
