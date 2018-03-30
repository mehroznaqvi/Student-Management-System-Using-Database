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
    public partial class ByName : Form
    {
        StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
        BindingSource source = new BindingSource();
        public ByName()
        {
            InitializeComponent();
        }

        private void ByName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet3.StudentManagementSystem' table. You can move, or remove it, as needed.
            this.studentManagementSystemTableAdapter.Fill(this.studentManagementSystemDataSet3.StudentManagementSystem);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
            StudentManagementSystem searching = new StudentManagementSystem();
            string name = (txtName.Text.ToString());
            source.DataSource = db.StudentManagementSystems.Where(x => x.studentName == name).SingleOrDefault();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
