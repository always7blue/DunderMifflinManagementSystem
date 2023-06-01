using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DunderMifflinManagementSystem
{
    public partial class Splash : Form
    {
        // Gdi32.dll'den CreateRoundRectRgn fonksiyonunu kullanmak i�in d��ar�dan bir y�ntem �a�r�s� yap�l�yor
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int RightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Splash()
        {
            InitializeComponent();

            // Formun k��elerini yuvarlamak i�in CreateRoundRectRgn y�ntemi kullan�l�yor
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Splash formu y�klendi�inde �al��acak kodlar
        private void Splash_Load(object sender, EventArgs e)
        {
            // �lerleme �ubu�unun minimum, maksimum ve ba�lang�� de�erleri ayarlan�yor
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Value = 0;
        }

        // Timer nesnesi her tetiklendi�inde �al��acak kodlar
        private void timer1_Tick(object sender, EventArgs e)
        {
            // �lerleme �ubu�unun de�eri 1 art�r�l�yor
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            // �lerleme �ubu�unun de�eri 100'e ula�t���nda
            if (circularProgressBar1.Value == 100)
            {
                // �lerleme �ubu�unun de�eri s�f�rlan�yor
                circularProgressBar1.Value = 0;

                // Timer durduruluyor
                timer1.Stop();

                // Splash formu gizleniyor
                this.Hide();

                // Login formunun olu�turulmas� ve g�sterilmesi
                Login log = new Login();
                log.Show();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }



}
