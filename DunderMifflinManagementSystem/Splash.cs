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
        // Gdi32.dll'den CreateRoundRectRgn fonksiyonunu kullanmak için dýþarýdan bir yöntem çaðrýsý yapýlýyor
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int RightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Splash()
        {
            InitializeComponent();

            // Formun köþelerini yuvarlamak için CreateRoundRectRgn yöntemi kullanýlýyor
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Splash formu yüklendiðinde çalýþacak kodlar
        private void Splash_Load(object sender, EventArgs e)
        {
            // Ýlerleme çubuðunun minimum, maksimum ve baþlangýç deðerleri ayarlanýyor
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Value = 0;
        }

        // Timer nesnesi her tetiklendiðinde çalýþacak kodlar
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Ýlerleme çubuðunun deðeri 1 artýrýlýyor
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            // Ýlerleme çubuðunun deðeri 100'e ulaþtýðýnda
            if (circularProgressBar1.Value == 100)
            {
                // Ýlerleme çubuðunun deðeri sýfýrlanýyor
                circularProgressBar1.Value = 0;

                // Timer durduruluyor
                timer1.Stop();

                // Splash formu gizleniyor
                this.Hide();

                // Login formunun oluþturulmasý ve gösterilmesi
                Login log = new Login();
                log.Show();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }



}
