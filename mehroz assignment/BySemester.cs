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
    public partial class BySemester : Form
    {
        StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
        BindingSource source = new BindingSource();
        public BySemester()
        {
            InitializeComponent();
        }

        private void BySemester_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet4.StudentManagementSystem' table. You can move, or remove it, as needed.
            this.studentManagementSystemTableAdapter.Fill(this.studentManagementSystemDataSet4.StudentManagementSystem);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
            StudentManagementSystem searching = new StudentManagementSystem();
            int sSemester = int.Parse(txtSemester.Text.ToString());
            source.DataSource = db.StudentManagementSystems.Where(x => x.studentSemester == sSemester).SingleOrDefault();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }
    }
}
