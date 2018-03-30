namespace mehroz_assignment
{
    partial class ControlScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlScreen));
            this.userControl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnrollStudent = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnTop3 = new System.Windows.Forms.Button();
            this.userControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userControl
            // 
            this.userControl.BackColor = System.Drawing.Color.DodgerBlue;
            this.userControl.Controls.Add(this.label2);
            this.userControl.Controls.Add(this.pictureBox2);
            this.userControl.Controls.Add(this.label1);
            this.userControl.Location = new System.Drawing.Point(0, 0);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(419, 448);
            this.userControl.TabIndex = 0;
            this.userControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Corbel", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(191, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "&Logout";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(397, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME\r\nMEHROZ NAQVI!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEnrollStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollStudent.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnEnrollStudent.ForeColor = System.Drawing.Color.White;
            this.btnEnrollStudent.Location = new System.Drawing.Point(131, 138);
            this.btnEnrollStudent.Name = "btnEnrollStudent";
            this.btnEnrollStudent.Size = new System.Drawing.Size(180, 32);
            this.btnEnrollStudent.TabIndex = 1;
            this.btnEnrollStudent.Text = "Enroll Student";
            this.btnEnrollStudent.UseVisualStyleBackColor = false;
            this.btnEnrollStudent.Click += new System.EventHandler(this.btnEnrollStudent_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(131, 182);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(131, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(132, 275);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(180, 32);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Mark Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnTop3
            // 
            this.btnTop3.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTop3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop3.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnTop3.ForeColor = System.Drawing.Color.White;
            this.btnTop3.Location = new System.Drawing.Point(131, 321);
            this.btnTop3.Name = "btnTop3";
            this.btnTop3.Size = new System.Drawing.Size(180, 32);
            this.btnTop3.TabIndex = 5;
            this.btnTop3.Text = "Top 3 CGPA Holder";
            this.btnTop3.UseVisualStyleBackColor = false;
            // 
            // ControlScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 442);
            this.Controls.Add(this.btnTop3);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEnrollStudent);
            this.Controls.Add(this.userControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlScreen";
            this.Text = "ControlScreen";
            this.Load += new System.EventHandler(this.ControlScreen_Load);
            this.userControl.ResumeLayout(false);
            this.userControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnrollStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnTop3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}