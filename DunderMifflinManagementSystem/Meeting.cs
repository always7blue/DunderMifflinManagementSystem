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
    public partial class Meeting : Form
    {

        public Meeting()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cansu\OneDrive\Belgeler\MyEmp.mdf;Integrated Security=True;Connect Timeout=30");
        private void CreateBttn_Click(object sender, EventArgs e)
        {
            string meetingid = txtMeetingId.Text;
            string title = txtTitle.Text;
            DateTime date = dtpDate.Value;
            string attendees = txtAttendees.Text;

            try
            {
                // Toplantı kimliği için sayısal bir değer kontrolü yapılır
                if (!int.TryParse(meetingid, out _))
                {
                    throw new Exception("Invalid Meeting ID. Meeting ID must be a numeric value.");
                }

                // Katılımcılar için sayısal bir değer kontrolü yapılır
                if (ContainsNumeric(attendees))
                {
                    throw new Exception("Invalid Attendees. Attendees cannot contain numeric values.");
                }
                if (Con.State != ConnectionState.Open)

                    Con.Open();

                string query = "INSERT INTO Meetings (MeetingId, Title, Date, Attendees) VALUES (@MeetingId, @Title, @Date, @Attendees)";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@MeetingId", meetingid);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Attendees", attendees);
                command.ExecuteNonQuery();

                MessageBox.Show("The meeting was created successfully.");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        private void populate()
        {
            Con.Open();                      // Veritabanı bağlantısını aç
            string query = "SELECT * from Meetings";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MeetingDGV.DataSource = ds.Tables[0];
            Con.Close();                     // Veritabanı bağlantısını kapat
        }

        private void ClearBttn_Click(object sender, EventArgs e)        //TextBoxları temizlemek için buton
        {
            txtMeetingId.Text = "";
            txtTitle.Text = "";
            dtpDate.Value = DateTime.Now;
            txtAttendees.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();                         // uygulamadan çıkmak için kullanılır
        }

        private void MeetingDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMeetingId.Text = MeetingDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtTitle.Text = MeetingDGV.SelectedRows[0].Cells[1].Value.ToString();
            dtpDate.Text = MeetingDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtAttendees.Text = MeetingDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {
            Home home = new Home();                     //anasayfaya dönmek için kullanılır
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)  //Toplantıyı silme butonu
        {
            if (txtMeetingId.Text == "")
            {
                MessageBox.Show("Enter the Meeting Id");
            }
            else
            {
                try
                {
                    int meetingId;
                    if (!int.TryParse(txtMeetingId.Text, out meetingId))
                    {
                        throw new Exception("Invalid Meeting ID. Meeting ID must be a numeric value.");    // ID'nin sadece rakamlardan oluştuğunu kontrol etmek için TryParse yöntemini kullanırız
                    }

                    Con.Open();                          // Veritabanı bağlantısını aç
                    string query = "DELETE FROM Meetings WHERE MeetingId='" + txtMeetingId.Text + "';"; // Silme sorgusunu oluştur
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();              // Sorguyu veritabanında çalıştır
                    MessageBox.Show("Meeting Deleted Successfully");
                    Con.Close();                        // Veritabanı bağlantısını kapat
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBttn_Click_Click(object sender, EventArgs e)       // Toplantıyı düzenleme butonu
        {
            if (txtMeetingId.Text == "")
            {
                MessageBox.Show("Enter the Meeting Id");   // Eğer Toplantı Kimliği boş ise kullanıcıya bir hata mesajı göster
            }
            else
            {
                try
                {
                    int meetingId;
                    if (!int.TryParse(txtMeetingId.Text, out meetingId))
                    {
                        throw new Exception("Invalid Meeting ID. Meeting ID must be a numeric value.");     
                    }

                    Con.Open();                         // Veritabanı bağlantısını aç
                    string query = "UPDATE Meetings SET Title=@Title, Date=@Date, Attendees=@Attendees WHERE MeetingId=@MeetingId";    // Güncelleme sorgusu
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@Attendees", txtAttendees.Text);
                    cmd.Parameters.AddWithValue("@MeetingId", meetingId);
                    cmd.ExecuteNonQuery();              // Sorguyu veritabanında çalıştır
                    MessageBox.Show("Meeting Updated Successfully");
                    Con.Close();                        // Veritabanı bağlantısını kapat
                    populate();                         // Verileri yeniden yükle ve güncel listeyi görüntüle
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);        // Hata durumunda kullanıcıya hata mesajı göster
                }
            }
        }
    }
}
