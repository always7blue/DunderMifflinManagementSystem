namespace DunderMifflinManagementSystem
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            panel1 = new Panel();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            button2 = new Button();
            SalarySlip = new RichTextBox();
            FetchData = new Button();
            button1 = new Button();
            HomeBttn = new Button();
            WorkedTb = new TextBox();
            EmpPosTb = new TextBox();
            EmpNameTb = new TextBox();
            EmpIdTb = new TextBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(SalarySlip);
            panel1.Controls.Add(FetchData);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(HomeBttn);
            panel1.Controls.Add(WorkedTb);
            panel1.Controls.Add(EmpPosTb);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(EmpIdTb);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 561);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 372);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 41;
            label3.Text = "Worked Days";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 273);
            label6.Name = "label6";
            label6.Size = new Size(194, 25);
            label6.TabIndex = 40;
            label6.Text = "Employee Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 163);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 39;
            label5.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 55);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 38;
            label2.Text = "Employee Id";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(839, 496);
            button2.Name = "button2";
            button2.Size = new Size(113, 49);
            button2.TabIndex = 37;
            button2.Text = "PRINT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SalarySlip
            // 
            SalarySlip.Location = new Point(466, 0);
            SalarySlip.Name = "SalarySlip";
            SalarySlip.Size = new Size(866, 490);
            SalarySlip.TabIndex = 11;
            SalarySlip.Text = "";
            // 
            // FetchData
            // 
            FetchData.BackColor = Color.Black;
            FetchData.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FetchData.ForeColor = SystemColors.Control;
            FetchData.Location = new Point(280, 83);
            FetchData.Name = "FetchData";
            FetchData.Size = new Size(160, 44);
            FetchData.TabIndex = 36;
            FetchData.Text = "FETCH DATA";
            FetchData.UseVisualStyleBackColor = false;
            FetchData.Click += FetchData_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(233, 476);
            button1.Name = "button1";
            button1.Size = new Size(113, 49);
            button1.TabIndex = 35;
            button1.Text = "VIEW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomeBttn
            // 
            HomeBttn.BackColor = Color.Black;
            HomeBttn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBttn.ForeColor = SystemColors.Control;
            HomeBttn.Location = new Point(72, 476);
            HomeBttn.Name = "HomeBttn";
            HomeBttn.Size = new Size(113, 49);
            HomeBttn.TabIndex = 34;
            HomeBttn.Text = "HOME";
            HomeBttn.UseVisualStyleBackColor = false;
            HomeBttn.Click += HomeBttn_Click;
            // 
            // WorkedTb
            // 
            WorkedTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            WorkedTb.Location = new Point(39, 417);
            WorkedTb.Name = "WorkedTb";
            WorkedTb.Size = new Size(174, 27);
            WorkedTb.TabIndex = 31;
            // 
            // EmpPosTb
            // 
            EmpPosTb.Enabled = false;
            EmpPosTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmpPosTb.Location = new Point(39, 317);
            EmpPosTb.Name = "EmpPosTb";
            EmpPosTb.Size = new Size(174, 27);
            EmpPosTb.TabIndex = 30;
            EmpPosTb.TextAlign = HorizontalAlignment.Right;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Enabled = false;
            EmpNameTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTb.Location = new Point(39, 209);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(174, 27);
            EmpNameTb.TabIndex = 29;
            EmpNameTb.TextAlign = HorizontalAlignment.Right;
            // 
            // EmpIdTb
            // 
            EmpIdTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdTb.Location = new Point(39, 100);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(174, 27);
            EmpIdTb.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(346, 55);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1300, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(138, 62);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 10;
            label1.Text = "SALARY";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1337, 704);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox EmpIdTb;
        private TextBox WorkedTb;
        private TextBox EmpPosTb;
        private TextBox EmpNameTb;
        private Button HomeBttn;
        private Button button1;
        private Button FetchData;
        private RichTextBox SalarySlip;
        private Button button2;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label6;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}