namespace İf_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi == 5)
            {
                label1.Text = "Doğru";
            }
            else
            {
                label1.Text = "Yanlış";
            }

            if (sayi % 2 == 0)
            {
                label2.Text = "Çift";
            }
            else
            {
                label2.Text = "Tek";
            }

            if (sayi % 2 == 0 && sayi >= 10)
            {
                label3.Text = "10 dan büyük ve çift";
            }
            else
            {
                label3.Text = "10 dan büyük değil yada çift değil";

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String durum;
            double s1, s2, ort, proje;
            s1 = Convert.ToDouble(textBox2.Text);
            s2 = Convert.ToDouble(textBox3.Text);
            proje = Convert.ToDouble(textBox4.Text);
            ort = (s1 + s2 + proje) / 3;

            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            textBox5.Text = ort.ToString("0.00") + " / " + durum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox6.Text);
            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label10.Text = toplam + " TL";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label10.Text = toplam + " TL";
            }
            if(kitapadet >= 41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label10.Text = toplam + " TL";
            }
        }
    }
}