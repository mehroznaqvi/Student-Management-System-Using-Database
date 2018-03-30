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
    public partial class ByEnrollment : Form
    {
        StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
        BindingSource source = new BindingSource();
        public ByEnrollment()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
            StudentManagementSystem searching = new StudentManagementSystem();
            int userID = int.Parse(txtID.Text.ToString());
            source.DataSource = db.StudentManagementSystems.Where(x => x.studentId == userID).SingleOrDefault();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        private void ByEnrollment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet2.StudentManagementSystem' table. You can move, or remove it, as needed.
            this.studentManagementSystemTableAdapter.Fill(this.studentManagementSystemDataSet2.StudentManagementSystem);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SearchForm Searching = new SearchForm();
            Searching.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
