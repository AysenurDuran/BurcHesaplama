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
                burc = Burclar.Ko�;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 4 & dogumGun >= 21) || (dogumAy == 5 & dogumGun <= 20))
            {
                burc = Burclar.Bo�a;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 5 & dogumGun >= 21) || (dogumAy == 6 & dogumGun <= 21))
            {
                burc = Burclar.�kizler;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 6 & dogumGun >= 22) || (dogumAy == 7 & dogumGun <= 22))
            {
                burc = Burclar.Yenge�;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 7 & dogumGun >= 23) || (dogumAy == 8 & dogumGun <= 23))
            {
                burc = Burclar.Aslan;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 8 & dogumGun >= 24) || (dogumAy == 9 & dogumGun <= 23))
            {
                burc = Burclar.Ba�ak;
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
                burc = Burclar.O�lak;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 1 & dogumGun >= 21) || (dogumAy == 2 & dogumGun <= 19))
            {
                burc = Burclar.Kova;
                textBox3.Text = burc.ToString();
            }
            if ((dogumAy == 2 & dogumGun >= 19) || (dogumAy == 3 & dogumGun <= 20))
            {
                burc = Burclar.Bal�k;
                textBox3.Text = burc.ToString();
            }


        }
        enum Burclar
        {
            Ko�, //21 Mart- 20 Nisan
            Bo�a,//21 Nisan � 20 May�s
            �kizler,//21 May�s � 21 Haziran
            Yenge�,//22 Haziran � 22 Temmuz
            Aslan,//23 Temmuz � 23 A�ustos
            Ba�ak,//24 A�ustos � 23 Eyl�l
            Terazi,//24 Eyl�l � 23 Ekim
            Akrep,//24 Ekim � 22 Kas�m
            Yay,//23 Kas�m � 21 Aral�k
            O�lak,//22 Aral�k � 20 Ocak
            Kova,//21 Ocak � 19 �ubat
            Bal�k//20 �ubat � 20 Mart
        }
    }
}