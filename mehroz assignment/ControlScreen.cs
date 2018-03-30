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
    public partial class ControlScreen : Form
    {
        public ControlScreen()
        {
            InitializeComponent();
        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            formStudent std = new formStudent();
            std.Show();
            this.Hide();
        }

        private void ControlScreen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
         

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendence marking = new Attendence();
            marking.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
