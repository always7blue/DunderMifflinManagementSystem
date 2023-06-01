using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Schema;

namespace DunderMifflinManagementSystem
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cansu\OneDrive\Belgeler\MyEmp.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();                            // uygulamadan çıkmak için kullanılır
        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {
            Home home = new Home();                      //anasayfaya dönmek için kullanılır
            home.Show();
            this.Hide();
        }

        private void FetchEmpData()
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter Employee Id");
            }
            else
            {
                Con.Open();
                string query = " SELECT * FROM EmployeeTable WHERE EmpId = '" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // Veritabanından alınan verileri ilgili metin kutularına yerleştir
                    EmpNameTb.Text = dr["EmpName"].ToString();

                    EmpPosTb.Text = dr["EmpPos"].ToString();

                }
                Con.Close();                         // Veritabanı bağlantısını kapat
            }
        }

        private void FetchData_Click_1(object sender, EventArgs e)
        {
            FetchEmpData();
        }

        int DailyBase, total;
        private void button2_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();                                   // Belgeyi yazdır
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpPosTb.Text == "")
                {
                    MessageBox.Show("Select An Employee");                              // Bir çalışan seçilmelidir.
                }
                else if (WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 28)
                {
                    throw new Exception("Enter a Valid Number of Days");            // Geçerli bir gün sayısı girilmelidir.
                }
                else
                {
                    // Pozisyona göre günlük maaşı ayarla
                    if (EmpPosTb.Text == "Regional Manager")
                    {
                        DailyBase = 300;
                    }
                    else if (EmpPosTb.Text == "Salesman")
                    {
                        DailyBase = 270;
                    }
                    else if (EmpPosTb.Text == "Accountant")
                    {
                        DailyBase = 250;
                    }
                    else if (EmpPosTb.Text == "Human Resources")
                    {
                        DailyBase = 200;
                    }
                    else if (EmpPosTb.Text == "Receptionist")
                    {
                        DailyBase = 180;
                    }
                    else if (EmpPosTb.Text == "Warehouse worker")
                    {
                        DailyBase = 170;
                    }

                    total = DailyBase * Convert.ToInt32(WorkedTb.Text);

                    // Maaş bordrosunu oluştur
                    SalarySlip.Text = "Employee Id:  " + EmpIdTb.Text + "\n" + "Employee Name:  " + EmpNameTb.Text + "\n" + "Employee Position:  " + EmpPosTb.Text + "\n" + "Days Worked:  " + WorkedTb.Text + "\n" + "Daily Salary $:  " + DailyBase + "\n" + "Total Amount $:  " + total;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Enter a valid number of days");    // Kullanıcı geçerli bir gün sayısı girmelidir.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                        // Hata mesajını kullanıcıya göster.
            }

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Maaş belgesinin başlığını ve içeriğini çizdirir

            // Çalışan bilgileri
            e.Graphics.DrawString("SALARY DOCUMENT", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.DarkGreen, new Point(180));
            e.Graphics.DrawString("Employee Id: " + EmpIdTb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Position: " + EmpPosTb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Worked Days: " + WorkedTb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Daily Pay: " + DailyBase, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Total Salary: " + total, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 260));
        }

    }
}
