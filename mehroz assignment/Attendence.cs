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
    public partial class Attendence : Form
    {
        StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
        BindingSource source = new BindingSource();
        public Attendence()
        {
            InitializeComponent();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentManagementSystemEntities1 db = new StudentManagementSystemEntities1();
            Attendance markAttendance;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                markAttendance = new Attendance();
                
                markAttendance.studentId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(null))
                {
                    markAttendance.attendanceStatus = "false";
                }
                else
                {
                    markAttendance.attendanceStatus = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    MessageBox.Show("Attendacen marked!!");
                
                }
                db.Attendances.Add(markAttendance);
            }
            db.SaveChanges();
            
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet.StudentManagementSystem' table. You can move, or remove it, as needed.
            this.studentManagementSystemTableAdapter.Fill(this.studentManagementSystemDataSet.StudentManagementSystem);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet2.StudentManagementSystem' table. You can move, or remove it, as needed.

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserControl controlMenu = new UserControl();
            controlMenu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AttendanceStatus status = new AttendanceStatus();
            status.Show();
            this.Hide();
        }
    }
}
