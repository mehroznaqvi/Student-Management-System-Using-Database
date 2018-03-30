namespace mehroz_assignment
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.btnId = new System.Windows.Forms.Button();
            this.byName = new System.Windows.Forms.Button();
            this.btnSemester = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.SpringGreen;
            this.btnId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnId.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnId.Location = new System.Drawing.Point(120, 164);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(112, 23);
            this.btnId.TabIndex = 0;
            this.btnId.Text = "By Enrollment";
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // byName
            // 
            this.byName.BackColor = System.Drawing.Color.SpringGreen;
            this.byName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byName.Font = new System.Drawing.Font("Corbel", 10F);
            this.byName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.byName.Location = new System.Drawing.Point(120, 199);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(112, 23);
            this.byName.TabIndex = 1;
            this.byName.Text = "By Name";
            this.byName.UseVisualStyleBackColor = false;
            this.byName.Click += new System.EventHandler(this.byName_Click);
            // 
            // btnSemester
            // 
            this.btnSemester.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemester.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSemester.Location = new System.Drawing.Point(120, 235);
            this.btnSemester.Name = "btnSemester";
            this.btnSemester.Size = new System.Drawing.Size(112, 23);
            this.btnSemester.TabIndex = 2;
            this.btnSemester.Text = "By Semester";
            this.btnSemester.UseVisualStyleBackColor = false;
            this.btnSemester.Click += new System.EventHandler(this.btnSemester_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the method from which\r\nyou want to search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(336, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(358, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSemester);
            this.Controls.Add(this.byName);
            this.Controls.Add(this.btnId);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.Button byName;
        private System.Windows.Forms.Button btnSemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}