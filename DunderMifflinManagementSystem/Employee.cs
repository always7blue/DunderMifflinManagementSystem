using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DunderMifflinManagementSystem
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cansu\OneDrive\Belgeler\MyEmp.mdf;Integrated Security=True;Connect Timeout=30");



        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (Con.State != ConnectionState.Open)         //bağlantının zaten açık olup olmadığını kontrol etmek için kullanılır.
                                                                   //Bağlantı zaten açıksa, tekrar açmaya çalışmadan doğrudan işlemlere devam edebilirsiniz.
                       
                        Con.Open();                                 //Con nesnesini kullanarak veritabanına bir bağlantı açmayı sağlar
                    // Sayısal girişleri kontrol etmek için long tipinde değişkenler tanımlanır
                    long empId = 0;
                    long empPho = 0;

                    // ID'nin sadece rakamlardan oluştuğunu kontrol etmek için TryParse yöntemini kullanırız
                    if (!long.TryParse(EmpIdTb.Text, out empId))
                    {
                        throw new Exception("Invalid ID. Enter a numeric value.");
                    }

                    // Telefon numarasının sadece rakamlardan oluştuğunu kontrol etmek için TryParse yöntemini kullanırız
                    if (!long.TryParse(EmpPhoTb.Text, out empPho))
                    {
                        throw new Exception("Invalid Phone Number. Enter a numeric value.");
                    }

                    // ID'nin 11 haneli olması gerektiği kontrol edilir
                    if (EmpIdTb.Text.Length != 11)
                    {
                        throw new Exception("Invalid ID. ID must be 11 digits long.");
                    }

                    // Telefon numarasının 10 haneli olması gerektiği kontrol edilir
                    if (EmpPhoTb.Text.Length != 10)
                    {
                        throw new Exception("Invalid Phone Number. Phone number must be 10 digits long.");
                    }

                    // İsim kısmı için sayısal değeri kontrol etmek
                    if (ContainsNumeric(EmpNameTb.Text))
                    {
                        throw new Exception("Invalid Name. Name cannot contain numeric values.");
                    }

                    // Adres kısmı için sayısal değeri kontrol etmek
                    if (ContainsNumeric(EmpAddTb.Text))
                    {
                        throw new Exception("Invalid Address. Address cannot contain numeric values.");
                    }

                    string query = "INSERT INTO EmployeeTable VALUES ('" + empId + "','" + EmpNameTb.Text + "','" + EmpEduCb.SelectedItem.ToString() + "','" + EmpPosCb.SelectedItem.ToString() + "','" + EmpAddTb.Text + "','" + EmpDOB.Value.Date + "','" + empPho + "','" + EmpGendCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    Con.Close();                //SqlConnection nesnesini kullanarak açık olan bir veritabanı bağlantısını kapatmayı sağlar

                    populate();                 //bir veri kaynağından verileri çekip kullanıcı arabirimine doldurmak için kullanılır

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool ContainsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (char.IsDigit(c))         // Karakterin bir sayısal karakter olup olmadığını kontrol et
                {
                    return true;
                }
            }
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();                            // uygulamadan çıkmak için kullanılır
        }
        private void populate()
        {
            Con.Open(); // Veritabanı bağlantısını aç

            string query = "SELECT * from EmployeeTable"; // Sorguyu oluştur
            SqlDataAdapter sda = new SqlDataAdapter(query, Con); // SqlDataAdapter ile sorguyu çalıştır ve sonuçları al
            SqlCommandBuilder builder = new SqlCommandBuilder(sda); // SqlCommandBuilder ile otomatik olarak güncelleme komutlarını oluştur
            var ds = new DataSet(); // Yeni bir DataSet oluştur
            sda.Fill(ds); // Sonuçları DataSet'e doldur
            EmpDGV.DataSource = ds.Tables[0]; // DataSet'teki ilk tabloyu DataGridView'e ata

            Con.Close(); // Veritabanı bağlantısını kapat
        }


        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter the Employee Id");
            }
            else
            {
                try
                {
                    Con.Open(); // Veritabanı bağlantısını aç

                    string query = "DELETE FROM EmployeeTable WHERE EmpId='" + EmpIdTb.Text + "';"; // Silme sorgusunu oluştur
                    SqlCommand cmd = new SqlCommand(query, Con); // SqlCommand nesnesini oluştur
                    cmd.ExecuteNonQuery(); // Sorguyu çalıştırarak kaydı sil
                    MessageBox.Show("Employee Deleted Successfully"); // Başarılı bir şekilde silindiğine dair mesaj göster

                    Con.Close(); // Veritabanı bağlantısını kapat

                    populate(); // Yeniden verileri alarak DataGridView'i güncelle
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message); // Hata mesajını göster
                }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen satırdaki hücre değerlerini ilgili kontrollere aktar

            EmpIdTb.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpEduCb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpPosCb.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpDOB.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpPhoTb.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmpGendCb.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");        // Eksik bilgi varsa hata mesajı gösterilir
            }
            else
            {
                try
                {
                    if (Con.State != ConnectionState.Open)  //bağlantının zaten açık olup olmadığını kontrol etmek için kullanılır. Bağlantı zaten açıksa, tekrar açmaya çalışmadan doğrudan işlemlere devam edebilirsiniz.
                        Con.Open();                         //Con nesnesini kullanarak veritabanına bir bağlantı açmayı sağlar

                    long empId = 0;
                    long empPho = 0;

                    // ID'nin sadece rakamlardan oluştuğunu kontrol etmek için TryParse yöntemini kullanırız
                    if (!long.TryParse(EmpIdTb.Text, out empId))
                    {
                        throw new Exception("Invalid ID. Enter a numeric value.");
                    }

                    // Telefon numarasının sadece rakamlardan oluştuğunu kontrol etmek için TryParse yöntemini kullanırız
                    if (!long.TryParse(EmpPhoTb.Text, out empPho))
                    {
                        throw new Exception("Invalid Phone Number. Enter a numeric value.");
                    }

                    // ID'nin 11 haneli olması gerektiği kontrol edilir
                    if (EmpIdTb.Text.Length != 11)
                    {
                        throw new Exception("Invalid ID. ID must be 11 digits long.");
                    }

                    // Telefon numarasının 10 haneli olması gerektiği kontrol edilir
                    if (EmpPhoTb.Text.Length != 10)
                    {
                        throw new Exception("Invalid Phone Number. Phone number must be 10 digits long.");
                    }

                    // İsim kısmı için sayısal değeri kontrol etmek
                    if (ContainsNumeric(EmpNameTb.Text))
                    {
                        throw new Exception("Invalid Name. Name cannot contain numeric values.");
                    }

                    // Adres kısmı için sayısal değeri kontrol etmek
                    if (ContainsNumeric(EmpAddTb.Text))
                    {
                        throw new Exception("Invalid Address. Address cannot contain numeric values.");
                    }

                    string query = "UPDATE EmployeeTable SET EMPNAME = '" + EmpNameTb.Text + "', EMPEDU = '" + EmpEduCb.SelectedItem.ToString() + "',EMPPOS = '" + EmpPosCb.SelectedItem.ToString() + "',EMPADD = '" + EmpAddTb.Text + "',EMPDOB = '" + EmpDOB.Value.Date + "',EMPPHO = '" + empPho + "',EMPGEND = '" + EmpGendCb.SelectedItem.ToString() + "' WHERE EMPID = '" + EmpIdTb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();          // Güncelleme sorgusunu çalıştırır
                    MessageBox.Show("Employee Updated Successfully");   // Başarılı bir şekilde güncellendiğine dair mesaj gösterilir
                    Con.Close();                                        // Veritabanı bağlantısını kapat

                    populate();                                         // Yeniden verileri alarak DataGridView'i güncelle
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();                      // Ana sayfayı oluştur ve göster, mevcut formu gizle
            home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            populate();
        }
        private void ClearTextBoxes()
        {
            EmpIdTb.Text = "";
            EmpNameTb.Text = "";
            EmpPhoTb.Text = "";
            EmpAddTb.Text = "";
            EmpEduCb.SelectedIndex = -1;
            EmpPosCb.SelectedIndex = -1;
            EmpGendCb.SelectedIndex = -1;
            EmpDOB.Value = DateTime.Now;
        }
    }
}
