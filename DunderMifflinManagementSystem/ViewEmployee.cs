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


namespace DunderMifflinManagementSystem
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cansu\OneDrive\Belgeler\MyEmp.mdf;Integrated Security=True;Connect Timeout=30");
        private void FetchEmpData()
        {
            try
            {
                if (Con.State != ConnectionState.Open)      //bağlantının zaten açık olup olmadığını kontrol etmek için kullanılır. Bağlantı zaten açıksa, tekrar açmaya çalışmadan doğrudan işlemlere devam edebilirsiniz.
                    Con.Open();                             //Con nesnesini kullanarak veritabanına bir bağlantı açmayı sağlar
                string empId = EmpIdTb.Text;

                // Girilen EmpId değerinin harf içerip içermediğini kontrol et
                if (HasLetters(empId))
                {
                    // Hata mesajı göster
                    MessageBox.Show("EmpId should only contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT * FROM EmployeeTable WHERE EmpId = '" + empId + "'";     // Sorgu oluştur
                SqlCommand cmd = new SqlCommand(query, Con);    // SqlCommand nesnesini oluştur
                DataTable dt = new DataTable();             // DataTable oluştur
                SqlDataAdapter sda = new SqlDataAdapter(cmd);   // SqlDataAdapter ile sorguyu çalıştır ve sonuçları DataTable'a doldur
                sda.Fill(dt);


                foreach (DataRow dr in dt.Rows)
                {
                    EmpIdLbl.Text = dr["EmpId"].ToString();
                    EmpNameLbl.Text = dr["EmpName"].ToString();
                    EmpEduLbl.Text = dr["EmpEdu"].ToString();
                    EmpPosLbl.Text = dr["EmpPos"].ToString();
                    EmpAddLbl.Text = dr["EmpAdd"].ToString();
                    EmpDOBLbl.Text = dr["EmpDOB"].ToString();
                    EmpPhoLbl.Text = dr["EmpPho"].ToString();
                    EmpGendLbl.Text = dr["EmpGend"].ToString();
                    // Etiketleri görünür yapar
                    EmpIdLbl.Visible = true;
                    EmpNameLbl.Visible = true;
                    EmpEduLbl.Visible = true;
                    EmpPosLbl.Visible = true;
                    EmpAddLbl.Visible = true;
                    EmpDOBLbl.Visible = true;
                    EmpPhoLbl.Visible = true;
                    EmpGendLbl.Visible = true;

                    // ID numarası bulundu, bu yüzden işlemi sonlandır ve metottan çık
                    return;
                }

                // Döngüye hiç girilmedi ve DataTable boş ise, ID numarası sistemde bulunmuyor
                MessageBox.Show("ID number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Con.Close();                // Veritabanı bağlantısını kapat
            }
            catch (SqlException ex)
            {
                // Hata mesajı göster
                MessageBox.Show("An error occurred while fetching employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasLetters(string input)
        {
            foreach (char c in input)       // Girilen girişin her bir karakteri için döngüye girer
            {
                if (char.IsLetter(c))       // Karakterin harf olup olmadığını kontrol eder
                {
                    return true;            // Eğer karakter harf ise true döner ve işlev sonlanır
                }
            }
            return false;                   // Döngü tamamlandığında hiçbir karakter harf değilse false döner
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();         //anasayfaya dönmek için kullanılır
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();             // uygulamadan çıkmak için kullanılır
        }

        private void RefreshBttn_Click(object sender, EventArgs e)
        {
            FetchEmpData();
        }
    }
}
