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
    public partial class formStudent : Form
    {
        StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
        BindingSource source = new BindingSource();
        public formStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentManagementSystem getStudentDetails = new StudentManagementSystem();
            getStudentDetails.studentId = int.Parse(txtID.Text.ToString());
            getStudentDetails.studentName = txtName.Text.ToString();
            getStudentDetails.studentSemester = int.Parse(txtSemester.Text.ToString());
            getStudentDetails.studentCGPA = double.Parse(txtCGPA.Text.ToString());
            getStudentDetails.studentDepartment = cmbDepartment.Text;
            getStudentDetails.studentUniversity = txtUniversity.Text;
            db.StudentManagementSystems.Add(getStudentDetails);
            db.SaveChanges();
            MessageBox.Show("Data Save successfully");
            source.DataSource = db.StudentManagementSystems.ToList();
            dataGridView1.DataSource = source;
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet1.StudentManagementSystem' table. You can move, or remove it, as needed.
            this.studentManagementSystemTableAdapter.Fill(this.studentManagementSystemDataSet1.StudentManagementSystem);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet1.StudentManagementSystem' table. You can move, or remove it, as needed.
            //this.studentManagementSystemTableAdapter.Fill(this.studentManagementSystemDataSet.StudentManagementSystem);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
            StudentManagementSystem searching = new StudentManagementSystem();
            string userName = txtName.Text.ToString();
            int userID = int.Parse(txtID.Text.ToString());
           // int userSemester = int.Parse(txtSemester.Text.ToString());

            if (txtSemester.Text.Equals("") && txtName.Text.Equals("") && !txtID.Text.Equals("-1"))
            {
                source.DataSource = db.StudentManagementSystems.Where(x => x.studentId == userID).SingleOrDefault();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }

            else if (!txtName.Text.Equals("-1") && txtSemester.Text.Equals("") && txtName.Text.Equals(""))
            {
                source.DataSource = db.StudentManagementSystems.Where(x => x.studentName == userName).SingleOrDefault();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }

            //else if (txtName.Text.Equals("") && !txtSemester.Text.Equals("-1") && txtName.Text.Equals(""))
            //{
            //    source.DataSource = db.StudentManagementSystems.Where(x => x.studentSemester == userSemester).SingleOrDefault();
            //    dataGridView1.DataSource = null;
            //    dataGridView1.DataSource = source;
            //}

            else
            {
                MessageBox.Show("Invalid Data");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendence std = new Attendence();
            std.Show();
            this.Hide();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserControl userCotrol = new UserControl();
            userCotrol.Show();
            this.Hide();

        }
        private DialogResult deletePrompt()
        {
            return MessageBox.Show("Do you want to contine", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int rowIndex = e.RowIndex;
                int id = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                if (deletePrompt() == DialogResult.OK)
                {
                    StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
                    StudentManagementSystem ob = db.StudentManagementSystems.Where(x => x.studentId == id).SingleOrDefault();
                    db.StudentManagementSystems.Remove(ob);
                    db.SaveChanges();
                    source.DataSource = db.StudentManagementSystems.ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = source;
                }
            }
        }

       
    }
}
