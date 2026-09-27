using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;

namespace Sinema_Oto_Ece
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //A'dan E'ye kadar 5 satırımız var
            char[] satirlar = { 'A', 'B', 'C', 'D', 'E' };
            for (int d = 0; d < 5; d++)//5 Satır için döngü
            {
                for (int y = 0; y <= 10; y++)//10 Koltuk için döngü
                {
                    Button btnKoltuk = new Button();
                    btnKoltuk.Text = satirlar[d] + y.ToString();
                    btnKoltuk.Width = 50;
                    btnKoltuk.Height = 50;
                    btnKoltuk.Left = ((y - 1) * 52) + 12;
                    btnKoltuk.Top = (d * 52) + 12;
                    btnKoltuk.BackColor = Color.Pink;
                    btnKoltuk.Click += Koltuk_Tiklandi;
                    this.Controls.Add(btnKoltuk);
                }

            }
        }
        private void
            Koltuk_Tiklandi(object sender, EventArgs e)

        {
            Button basilanKoltuk = (Button)sender;
            if (basilanKoltuk.BackColor == Color.Pink)
                basilanKoltuk.BackColor = Color.Green;

            else if (basilanKoltuk.BackColor == Color.Green)
                basilanKoltuk.BackColor = Color.Pink;

            else if (basilanKoltuk.BackColor == Color.Red)
                basilanKoltuk.BackColor = Color.Orange;

            else if (basilanKoltuk.BackColor == Color.Orange)
                basilanKoltuk.BackColor = Color.Red;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control nesne = this.Controls[i];
                if (nesne is Button && nesne.Width == 50)
                {
                    if (nesne.BackColor == Color.Green)
                    {
                        nesne.BackColor = Color.Red;
                    }
                }


            }
            MessageBox.Show("Biletler başarıyla onaylandı!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control nesne = this.Controls[i];
                if (nesne is Button && nesne.Width == 50)
                {
                    if (nesne.BackColor == Color.Orange)
                    {
                        nesne.BackColor = Color.Pink;
                    }
                }


            }
        }

    }
}