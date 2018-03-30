using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mehroz_assignment
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlScreen std = new ControlScreen();
            std.Show();
            this.Hide();
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            ByEnrollment enr = new ByEnrollment();
            enr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void byName_Click(object sender, EventArgs e)
        {
            ByName name = new ByName();
            name.Show();
            this.Hide();

        }

        private void btnSemester_Click(object sender, EventArgs e)
        {
            BySemester semester = new BySemester();
            semester.Show();
            this.Hide();
        }
    }
}
