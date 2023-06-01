namespace DunderMifflinManagementSystem
{
    partial class Meeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meeting));
            panel1 = new Panel();
            button1 = new Button();
            HomeBttn = new Button();
            MeetingDGV = new DataGridView();
            txtMeetingId = new TextBox();
            label5 = new Label();
            CreateBttn = new Button();
            txtAttendees = new TextBox();
            label4 = new Label();
            ClearBttn = new Button();
            txtTitle = new TextBox();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            EditBttn_Click = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MeetingDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(EditBttn_Click);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(HomeBttn);
            panel1.Controls.Add(MeetingDGV);
            panel1.Controls.Add(txtMeetingId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CreateBttn);
            panel1.Controls.Add(txtAttendees);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ClearBttn);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 561);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(318, 359);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 51;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomeBttn
            // 
            HomeBttn.BackColor = Color.Black;
            HomeBttn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBttn.ForeColor = SystemColors.Control;
            HomeBttn.Location = new Point(247, 440);
            HomeBttn.Name = "HomeBttn";
            HomeBttn.Size = new Size(113, 49);
            HomeBttn.TabIndex = 50;
            HomeBttn.Text = "HOME";
            HomeBttn.UseVisualStyleBackColor = false;
            HomeBttn.Click += HomeBttn_Click;
            // 
            // MeetingDGV
            // 
            MeetingDGV.BackgroundColor = SystemColors.Control;
            MeetingDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MeetingDGV.Location = new Point(473, 0);
            MeetingDGV.Name = "MeetingDGV";
            MeetingDGV.RowHeadersWidth = 51;
            MeetingDGV.RowTemplate.Height = 29;
            MeetingDGV.Size = new Size(776, 561);
            MeetingDGV.TabIndex = 49;
            MeetingDGV.CellContentClick += MeetingDGV_CellContentClick;
            // 
            // txtMeetingId
            // 
            txtMeetingId.Location = new Point(37, 117);
            txtMeetingId.Name = "txtMeetingId";
            txtMeetingId.Size = new Size(171, 27);
            txtMeetingId.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 60);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 47;
            label5.Text = "Meeting Id";
            // 
            // CreateBttn
            // 
            CreateBttn.BackColor = Color.Black;
            CreateBttn.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBttn.ForeColor = SystemColors.Control;
            CreateBttn.Location = new Point(37, 359);
            CreateBttn.Name = "CreateBttn";
            CreateBttn.Size = new Size(116, 47);
            CreateBttn.TabIndex = 46;
            CreateBttn.Text = "CREATE";
            CreateBttn.UseVisualStyleBackColor = false;
            CreateBttn.Click += CreateBttn_Click;
            // 
            // txtAttendees
            // 
            txtAttendees.Location = new Point(263, 262);
            txtAttendees.Name = "txtAttendees";
            txtAttendees.Size = new Size(171, 27);
            txtAttendees.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(263, 201);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 44;
            label4.Text = "Attendees";
            // 
            // ClearBttn
            // 
            ClearBttn.BackColor = Color.Black;
            ClearBttn.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ClearBttn.ForeColor = SystemColors.Control;
            ClearBttn.Location = new Point(92, 442);
            ClearBttn.Name = "ClearBttn";
            ClearBttn.Size = new Size(116, 47);
            ClearBttn.TabIndex = 43;
            ClearBttn.Text = "CLEAR";
            ClearBttn.UseVisualStyleBackColor = false;
            ClearBttn.Click += ClearBttn_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(263, 117);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(171, 27);
            txtTitle.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(263, 60);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 41;
            label3.Text = "Meeting Title";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(37, 262);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(194, 27);
            dtpDate.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 201);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 39;
            label2.Text = "Meeting Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 64);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 11;
            label1.Text = "MEETINGS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1216, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // EditBttn_Click
            // 
            EditBttn_Click.BackColor = Color.Black;
            EditBttn_Click.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBttn_Click.ForeColor = SystemColors.Control;
            EditBttn_Click.Location = new Point(182, 359);
            EditBttn_Click.Name = "EditBttn_Click";
            EditBttn_Click.Size = new Size(113, 49);
            EditBttn_Click.TabIndex = 52;
            EditBttn_Click.Text = "EDIT";
            EditBttn_Click.UseVisualStyleBackColor = false;
            EditBttn_Click.Click += EditBttn_Click_Click;
            // 
            // Meeting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1253, 704);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Meeting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meeting";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MeetingDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCreateMeeting_Click;
        private Label label2;
        private DateTimePicker dtpDate;
        private Label label3;
        private TextBox txtTitle;
        private Button ClearBttn;
        private TextBox txtAttendees;
        private Label label4;
        private Button CreateBttn;
        private PictureBox pictureBox2;
        private TextBox txtMeetingId;
        private Label label5;
        private DataGridView MeetingDGV;
        private Button HomeBttn;
        private Button button1;
        private Button EditBttn_Click;
    }
}