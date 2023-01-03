namespace BurcHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas, dogumGun, dogumAy;
            Burclar burc;
            TimeSpan yasadigiGun;
            DateTime dogumTarihi = dateTimePicker1.Value;
            DateTime bugun = DateTime.Now;
            // DateTime bugunGun = dateTimePicker1.Value;
            dogumGun = Convert.ToInt32(dateTimePicker1.Value.Day);
            dogumAy = Convert.ToInt32(dateTimePicker1.Value.Month);
            yas = bugun.Year - dogumTarihi.Year;
            textBox1.Text = yas.ToString();
            yasadigiGun = bugun - dogumTarihi;
            textBox2.Text = yasadigiGun.Days.ToString();


            if ((dogumAy == 3 & dogumGun >= 21) || (dogumAy == 4 & dogumGun <= 20))
            {
                burc = Burclar.Koç;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 4 & dogumGun >= 21) || (dogumAy == 5 & dogumGun <= 20))
            {
                burc = Burclar.Boða;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 5 & dogumGun >= 21) || (dogumAy == 6 & dogumGun <= 21))
            {
                burc = Burclar.Ýkizler;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 6 & dogumGun >= 22) || (dogumAy == 7 & dogumGun <= 22))
            {
                burc = Burclar.Yengeç;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 7 & dogumGun >= 23) || (dogumAy == 8 & dogumGun <= 23))
            {
                burc = Burclar.Aslan;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 8 & dogumGun >= 24) || (dogumAy == 9 & dogumGun <= 23))
            {
                burc = Burclar.Baþak;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 9 & dogumGun >= 24) || (dogumAy == 10 & dogumGun <= 23))
            {
                burc = Burclar.Terazi;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 10 & dogumGun >= 24) || (dogumAy == 11 & dogumGun <= 22))
            {
                burc = Burclar.Akrep;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 11 & dogumGun >= 23) || (dogumAy == 12 & dogumGun <= 21))
            {
                burc = Burclar.Yay;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 12 & dogumGun >= 22) || (dogumAy == 1 & dogumGun <= 20))
            {
                burc = Burclar.Oðlak;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 1 & dogumGun >= 21) || (dogumAy == 2 & dogumGun <= 19))
            {
                burc = Burclar.Kova;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 2 & dogumGun >= 19) || (dogumAy == 3 & dogumGun <= 20))
            {
                burc = Burclar.Balýk;
                textBox3.Text = burc.ToString();
            }


        }
        enum Burclar
        {
            Koç, //21 Mart- 20 Nisan
            Boða,//21 Nisan – 20 Mayýs
            Ýkizler,//21 Mayýs – 21 Haziran
            Yengeç,//22 Haziran – 22 Temmuz
            Aslan,//23 Temmuz – 23 Aðustos
            Baþak,//24 Aðustos – 23 Eylül
            Terazi,//24 Eylül – 23 Ekim
            Akrep,//24 Ekim – 22 Kasým
            Yay,//23 Kasým – 21 Aralýk
            Oðlak,//22 Aralýk – 20 Ocak
            Kova,//21 Ocak – 19 Þubat
            Balýk//20 Þubat – 20 Mart
        }
    }
}