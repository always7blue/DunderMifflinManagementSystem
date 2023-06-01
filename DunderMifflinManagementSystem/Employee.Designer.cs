namespace DunderMifflinManagementSystem
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            EmpDGV = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            EmpAddTb = new TextBox();
            EmpPhoTb = new TextBox();
            EmpNameTb = new TextBox();
            EmpIdTb = new TextBox();
            EmpPosCb = new ComboBox();
            EmpEduCb = new ComboBox();
            EmpGendCb = new ComboBox();
            EmpDOB = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(EmpPhoTb);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(EmpIdTb);
            panel1.Controls.Add(EmpPosCb);
            panel1.Controls.Add(EmpEduCb);
            panel1.Controls.Add(EmpGendCb);
            panel1.Controls.Add(EmpDOB);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 561);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(90, 498);
            button5.Name = "button5";
            button5.Size = new Size(113, 49);
            button5.TabIndex = 25;
            button5.Text = "CLEAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(250, 498);
            button4.Name = "button4";
            button4.Size = new Size(113, 49);
            button4.TabIndex = 24;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // EmpDGV
            // 
            EmpDGV.BackgroundColor = SystemColors.Control;
            EmpDGV.ColumnHeadersHeight = 29;
            EmpDGV.Location = new Point(477, 0);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersWidth = 51;
            EmpDGV.Size = new Size(860, 561);
            EmpDGV.TabIndex = 0;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(318, 431);
            button3.Name = "button3";
            button3.Size = new Size(113, 49);
            button3.TabIndex = 23;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(167, 431);
            button2.Name = "button2";
            button2.Size = new Size(113, 49);
            button2.TabIndex = 22;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(21, 431);
            button1.Name = "button1";
            button1.Size = new Size(113, 49);
            button1.TabIndex = 21;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmpAddTb
            // 
            EmpAddTb.Location = new Point(21, 281);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(182, 27);
            EmpAddTb.TabIndex = 20;
            // 
            // EmpPhoTb
            // 
            EmpPhoTb.Location = new Point(21, 373);
            EmpPhoTb.Name = "EmpPhoTb";
            EmpPhoTb.Size = new Size(182, 27);
            EmpPhoTb.TabIndex = 19;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(254, 88);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(190, 27);
            EmpNameTb.TabIndex = 18;
            // 
            // EmpIdTb
            // 
            EmpIdTb.Location = new Point(21, 88);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(179, 27);
            EmpIdTb.TabIndex = 17;
            // 
            // EmpPosCb
            // 
            EmpPosCb.FormattingEnabled = true;
            EmpPosCb.Items.AddRange(new object[] { "Regional Manager", "Salesman", "Accountant", "Human Resources", "Receptionist", "Warehouse Worker", "Temp" });
            EmpPosCb.Location = new Point(254, 177);
            EmpPosCb.Name = "EmpPosCb";
            EmpPosCb.Size = new Size(190, 28);
            EmpPosCb.TabIndex = 16;
            // 
            // EmpEduCb
            // 
            EmpEduCb.FormattingEnabled = true;
            EmpEduCb.Items.AddRange(new object[] { "Associate Degree", "Bachelors Degree", "Masters Degree", "Doctoral Degree" });
            EmpEduCb.Location = new Point(21, 177);
            EmpEduCb.Name = "EmpEduCb";
            EmpEduCb.Size = new Size(182, 28);
            EmpEduCb.TabIndex = 15;
            // 
            // EmpGendCb
            // 
            EmpGendCb.FormattingEnabled = true;
            EmpGendCb.Items.AddRange(new object[] { "Woman", "Men", "Other" });
            EmpGendCb.Location = new Point(251, 373);
            EmpGendCb.Name = "EmpGendCb";
            EmpGendCb.Size = new Size(194, 28);
            EmpGendCb.TabIndex = 14;
            // 
            // EmpDOB
            // 
            EmpDOB.Location = new Point(254, 281);
            EmpDOB.Name = "EmpDOB";
            EmpDOB.Size = new Size(194, 27);
            EmpDOB.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(251, 233);
            label9.Name = "label9";
            label9.Size = new Size(221, 25);
            label9.TabIndex = 11;
            label9.Text = "Employee Birth Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(250, 327);
            label8.Name = "label8";
            label8.Size = new Size(191, 25);
            label8.TabIndex = 10;
            label8.Text = "Employee Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 327);
            label7.Name = "label7";
            label7.Size = new Size(179, 25);
            label7.TabIndex = 9;
            label7.Text = "Employee Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(250, 136);
            label6.Name = "label6";
            label6.Size = new Size(194, 25);
            label6.TabIndex = 8;
            label6.Text = "Employee Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(254, 49);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 7;
            label5.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 136);
            label4.Name = "label4";
            label4.Size = new Size(223, 25);
            label4.TabIndex = 6;
            label4.Text = "Employee Education ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 233);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 5;
            label3.Text = "Employee Adress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 49);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 4;
            label2.Text = "Employee Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 50);
            label1.Name = "label1";
            label1.Size = new Size(311, 32);
            label1.TabIndex = 1;
            label1.Text = "MANAGE EMPLOYEE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1298, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1337, 704);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox EmpAddTb;
        private TextBox EmpPhoTb;
        private TextBox EmpNameTb;
        private TextBox EmpIdTb;
        private ComboBox EmpPosCb;
        private ComboBox EmpEduCb;
        private ComboBox EmpGendCb;
        private DateTimePicker EmpDOB;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView EmpDGV;
        private Button button4;
        private Button button5;
    }
}