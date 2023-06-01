namespace DunderMifflinManagementSystem
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            EmpGendLbl = new Label();
            EmpDOBLbl = new Label();
            EmpPosLbl = new Label();
            EmpNameLbl = new Label();
            EmpPhoLbl = new Label();
            EmpAddLbl = new Label();
            EmpEduLbl = new Label();
            EmpIdLbl = new Label();
            RefreshBttn = new Button();
            EmpIdTb = new TextBox();
            label10 = new Label();
            HomeBttn = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 51);
            label1.Name = "label1";
            label1.Size = new Size(304, 32);
            label1.TabIndex = 3;
            label1.Text = "EMPLOYEE DETAILS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1213, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(EmpGendLbl);
            panel1.Controls.Add(EmpDOBLbl);
            panel1.Controls.Add(EmpPosLbl);
            panel1.Controls.Add(EmpNameLbl);
            panel1.Controls.Add(EmpPhoLbl);
            panel1.Controls.Add(EmpAddLbl);
            panel1.Controls.Add(EmpEduLbl);
            panel1.Controls.Add(EmpIdLbl);
            panel1.Controls.Add(RefreshBttn);
            panel1.Controls.Add(EmpIdTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(HomeBttn);
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
            panel1.Size = new Size(1254, 561);
            panel1.TabIndex = 6;
            // 
            // EmpGendLbl
            // 
            EmpGendLbl.AutoSize = true;
            EmpGendLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpGendLbl.ForeColor = Color.Navy;
            EmpGendLbl.Location = new Point(902, 333);
            EmpGendLbl.Name = "EmpGendLbl";
            EmpGendLbl.Size = new Size(191, 25);
            EmpGendLbl.TabIndex = 35;
            EmpGendLbl.Text = "Employee Gender";
            // 
            // EmpDOBLbl
            // 
            EmpDOBLbl.AutoSize = true;
            EmpDOBLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpDOBLbl.ForeColor = Color.Navy;
            EmpDOBLbl.Location = new Point(899, 266);
            EmpDOBLbl.Name = "EmpDOBLbl";
            EmpDOBLbl.Size = new Size(221, 25);
            EmpDOBLbl.TabIndex = 34;
            EmpDOBLbl.Text = "Employee Birth Date";
            // 
            // EmpPosLbl
            // 
            EmpPosLbl.AutoSize = true;
            EmpPosLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpPosLbl.ForeColor = Color.Navy;
            EmpPosLbl.Location = new Point(899, 194);
            EmpPosLbl.Name = "EmpPosLbl";
            EmpPosLbl.Size = new Size(194, 25);
            EmpPosLbl.TabIndex = 33;
            EmpPosLbl.Text = "Employee Position";
            // 
            // EmpNameLbl
            // 
            EmpNameLbl.AutoSize = true;
            EmpNameLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpNameLbl.ForeColor = Color.Navy;
            EmpNameLbl.Location = new Point(902, 123);
            EmpNameLbl.Name = "EmpNameLbl";
            EmpNameLbl.Size = new Size(174, 25);
            EmpNameLbl.TabIndex = 32;
            EmpNameLbl.Text = "Employee Name";
            // 
            // EmpPhoLbl
            // 
            EmpPhoLbl.AutoSize = true;
            EmpPhoLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpPhoLbl.ForeColor = Color.Navy;
            EmpPhoLbl.Location = new Point(359, 333);
            EmpPhoLbl.Name = "EmpPhoLbl";
            EmpPhoLbl.Size = new Size(179, 25);
            EmpPhoLbl.TabIndex = 31;
            EmpPhoLbl.Text = "Employee Phone";
            // 
            // EmpAddLbl
            // 
            EmpAddLbl.AutoSize = true;
            EmpAddLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpAddLbl.ForeColor = Color.Navy;
            EmpAddLbl.Location = new Point(359, 266);
            EmpAddLbl.Name = "EmpAddLbl";
            EmpAddLbl.Size = new Size(182, 25);
            EmpAddLbl.TabIndex = 30;
            EmpAddLbl.Text = "Employee Adress";
            // 
            // EmpEduLbl
            // 
            EmpEduLbl.AutoSize = true;
            EmpEduLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpEduLbl.ForeColor = Color.Navy;
            EmpEduLbl.Location = new Point(359, 194);
            EmpEduLbl.Name = "EmpEduLbl";
            EmpEduLbl.Size = new Size(223, 25);
            EmpEduLbl.TabIndex = 29;
            EmpEduLbl.Text = "Employee Education ";
            // 
            // EmpIdLbl
            // 
            EmpIdLbl.AutoSize = true;
            EmpIdLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmpIdLbl.ForeColor = Color.Navy;
            EmpIdLbl.Location = new Point(359, 123);
            EmpIdLbl.Name = "EmpIdLbl";
            EmpIdLbl.Size = new Size(137, 25);
            EmpIdLbl.TabIndex = 28;
            EmpIdLbl.Text = "Employee Id";
            // 
            // RefreshBttn
            // 
            RefreshBttn.BackColor = Color.Black;
            RefreshBttn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshBttn.ForeColor = SystemColors.Control;
            RefreshBttn.Location = new Point(714, 29);
            RefreshBttn.Name = "RefreshBttn";
            RefreshBttn.Size = new Size(113, 49);
            RefreshBttn.TabIndex = 27;
            RefreshBttn.Text = "REFRESH";
            RefreshBttn.UseVisualStyleBackColor = false;
            RefreshBttn.Click += RefreshBttn_Click;
            // 
            // EmpIdTb
            // 
            EmpIdTb.Location = new Point(511, 41);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(180, 27);
            EmpIdTb.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(359, 43);
            label10.Name = "label10";
            label10.Size = new Size(137, 25);
            label10.TabIndex = 25;
            label10.Text = "Employee Id";
            // 
            // HomeBttn
            // 
            HomeBttn.BackColor = Color.Black;
            HomeBttn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBttn.ForeColor = SystemColors.Control;
            HomeBttn.Location = new Point(545, 449);
            HomeBttn.Name = "HomeBttn";
            HomeBttn.Size = new Size(113, 49);
            HomeBttn.TabIndex = 24;
            HomeBttn.Text = "HOME";
            HomeBttn.UseVisualStyleBackColor = false;
            HomeBttn.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(636, 266);
            label9.Name = "label9";
            label9.Size = new Size(221, 25);
            label9.TabIndex = 11;
            label9.Text = "Employee Birth Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(636, 333);
            label8.Name = "label8";
            label8.Size = new Size(191, 25);
            label8.TabIndex = 10;
            label8.Text = "Employee Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(103, 333);
            label7.Name = "label7";
            label7.Size = new Size(179, 25);
            label7.TabIndex = 9;
            label7.Text = "Employee Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(633, 194);
            label6.Name = "label6";
            label6.Size = new Size(194, 25);
            label6.TabIndex = 8;
            label6.Text = "Employee Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(636, 123);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 7;
            label5.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(103, 194);
            label4.Name = "label4";
            label4.Size = new Size(223, 25);
            label4.TabIndex = 6;
            label4.Text = "Employee Education ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 266);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 5;
            label3.Text = "Employee Adress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 123);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 4;
            label2.Text = "Employee Id";
            // 
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1253, 704);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEmployee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button HomeBttn;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Button RefreshBttn;
        private TextBox EmpIdTb;
        private Label EmpGendLbl;
        private Label EmpDOBLbl;
        private Label EmpPosLbl;
        private Label EmpNameLbl;
        private Label EmpPhoLbl;
        private Label EmpAddLbl;
        private Label EmpEduLbl;
        private Label EmpIdLbl;
    }
}