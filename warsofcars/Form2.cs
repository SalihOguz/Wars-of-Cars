using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace warsofcars
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        int xz = 420;//Baş. koordinat (hız belirlemedeki)
        int yz = 620;//Son koordinat (hız belirlemedeki)
        int vites = 0;//Seçilen vites
        int hiz = 0;//Seçilen hız
        int secim = 1;//Radiobutton secimi, sayı tutma
        int turbo = 0;
        public int  l1, l2, l3, l4, l5, l6, g1, g2, g3, g4, g5, g6 , a1, a2, a3, a4, a5, a6; //arabaların leftleri, gitme hızları, hız artışları
        public int gitme;//Gitme hızı
        int say = 0;//Turbo kullanımını belirtiyor. Basıldıysa 1, basılmadıysa 0
        int sıralama=6;
        public double puan;
        public double sırakamaks;//Sıralamanın puana katılan katsayısı
        public int cubukvalues; //Oyun bittiğinde dolan çubuğun değeri
        public string zorder;//Zorluk Derecesi
        bool durum = false;//Kazanıp, kaybetme

        private void timer1_Tick(object sender, EventArgs e)//Vitesi belirleyen timer
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            while (vites == 6)//vites altıyı geçmesin diye
                vites = 0;

            vites++;

            if (vites == 1) { label1.Visible = true; }
            if (vites == 2) { label2.Visible = true; }
            if (vites == 3) { label3.Visible = true; }
            if (vites == 4) { label4.Visible = true; }
            if (vites == 5) { label5.Visible = true; }
            if (vites == 6) { label6.Visible = true; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)//Vites Seç
        {
            timer1.Stop();
            timer2.Start();
            button6.Visible = true;
            button1.Visible = false;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)//Hız Skalası
        {
            Graphics sekil = this.CreateGraphics();
            Pen kalem = new Pen(Color.Blue, 2);
            Pen kalem2 = new Pen(Color.Black, 40);
            Pen kalem3 = new Pen(Color.DarkRed, 20);
            Pen kalem4 = new Pen(Color.DarkOrange, 20);
            Pen kalem5 = new Pen(Color.Yellow, 20);
            Pen kalem6 = new Pen(Color.Wheat, 20);

            //Renklendirmeler
            sekil.DrawLine(kalem6, 610, 480, 610, 550);//50
            sekil.DrawLine(kalem5, 590, 480, 590, 550);//55
            sekil.DrawLine(kalem4, 570, 480, 570, 550);//60
            sekil.DrawLine(kalem3, 550, 480, 550, 550);//65
            sekil.DrawLine(kalem2, 520, 480, 520, 550);//70
            sekil.DrawLine(kalem3, 490, 480, 490, 550);//65
            sekil.DrawLine(kalem4, 470, 480, 470, 550);//60
            sekil.DrawLine(kalem5, 450, 480, 450, 550);//55
            sekil.DrawLine(kalem6, 430, 480, 430, 550);//50

            //Çerçeve
            sekil.DrawLine(kalem, 420, 480, 420, 550);//Sol dik
            sekil.DrawLine(kalem, 420, 480, 620, 480);//Üst
            sekil.DrawLine(kalem, 620, 480, 620, 550);//Sağ Dik
            sekil.DrawLine(kalem, 420, 550, 620, 550);//Alt

            int xa = 420;//Ara çizgilerin ilki


            for (int i = 0; i < 11; i++)
            {
                sekil.DrawLine(kalem, xa, 480, xa, 550);//Ara çizgiler
                xa += 20;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)//Ok sağa
        {
            timer3.Stop();//sola götüren timer'ı durduruyor

            while (xz == 620)//Timer durduktan sonra 620 olarak kalan xz'yi başa yani okun bulunduğu kısma alıyor
            {
                xz = 420;
            }

            xz = xz + 10;//xz'yi artırıyor

            if (xz == 620)//Ok sona gelmişse timer'ı durduruyor
            {
                timer3.Start();
            }
            else
                pictureBox8.Left = xz;//Okun leftine xz'yi atıyor
        }

        private void timer3_Tick(object sender, EventArgs e)//Ok sola
        {
            timer2.Stop();//sağa götüren timer'ı durduruyor

            while (yz == 420)//Timer durduktan sonra 420 olarak kalan yz'yi sona yani okun bulunduğu kısma alıyor
            {
                yz = 620;
            }

            yz = yz - 10;//yz'yi azaltıyor

            if (yz == 420)//Ok başa gelmişse timer'ı durduruyor
            {
                timer2.Start();
            }
            else
                pictureBox8.Left = yz;//Okun leftine yz'yi atıyor
        }

        private void button7_Click(object sender, EventArgs e)//Turbo Belirleme
        {
            groupBox1.Enabled = false;
            button7.Visible = false;
            button4.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            Random uret = new Random();
            int tutulan;
            int gecici=0;
            tutulan = uret.Next(1, 11);//PC tarafından random sayı tutuluyor

            //Oyuncunun seçimi
            if (radioButton1.Checked == true) { secim = 1; }
            if (radioButton2.Checked == true) { secim = 2; }
            if (radioButton3.Checked == true) { secim = 3; }
            if (radioButton4.Checked == true) { secim = 4; }
            if (radioButton5.Checked == true) { secim = 5; }
            if (radioButton6.Checked == true) { secim = 6; }
            if (radioButton7.Checked == true) { secim = 7; }
            if (radioButton8.Checked == true) { secim = 8; }
            if (radioButton9.Checked == true) { secim = 9; }
            if (radioButton10.Checked == true) { secim = 10; }

            //Sonucun negatif çıkmması için if kullanıyoruz
            if(tutulan>=secim) 
            {
                gecici=(tutulan-secim);
            }
            if (tutulan < secim)
            {
                gecici = (secim - tutulan);
            }

            if(gecici==0) {turbo=10;}
            if (gecici == 1) { turbo = 9; }
            if (gecici == 2) { turbo = 8; }
            if (gecici == 3) { turbo = 7; }
            if (gecici == 4) { turbo = 6; }
            if (gecici == 5) { turbo = 5; }
            if (gecici == 6) { turbo = 4; }
            if (gecici == 7) { turbo = 3; }
            if (gecici == 8) { turbo = 2; }
            if (gecici == 9) { turbo = 1; }

            label19.Text = turbo.ToString();
            label21.Text = tutulan.ToString();
        }

        private void button6_Click(object sender, EventArgs e) //Araba Hızı Belirleme
        {
            timer2.Stop();
            timer3.Stop();
            button7.Visible = true;
            button6.Visible = false;
            radioButton1.Checked = true;
            groupBox1.Enabled = true;
            int a1 = pictureBox8.Left;

            if (vites == 1)//1. viteste hızlar 50-70
            {
                if (a1 >= 420 && a1 < 440) { hiz = 50; label17.Text = hiz.ToString(); }
                if (a1 >= 440 && a1 < 460) { hiz = 55; label17.Text = hiz.ToString(); }
                if (a1 >= 460 && a1 < 480) { hiz = 60; label17.Text = hiz.ToString(); }
                if (a1 >= 480 && a1 < 500) { hiz = 65; label17.Text = hiz.ToString(); }
                if (a1 >= 500 && a1 < 520) { hiz = 70; label17.Text = hiz.ToString(); }
                if (a1 >= 520 && a1 < 540) { hiz = 70; label17.Text = hiz.ToString(); }
                if (a1 >= 540 && a1 < 560) { hiz = 65; label17.Text = hiz.ToString(); }
                if (a1 >= 560 && a1 < 580) { hiz = 60; label17.Text = hiz.ToString(); }
                if (a1 >= 580 && a1 < 600) { hiz = 55; label17.Text = hiz.ToString(); }
                if (a1 >= 600 && a1 < 620) { hiz = 50; label17.Text = hiz.ToString(); }
            }
            if (vites == 2)//2. viteste hızlar 60 - 80
            {
                if (a1 >= 420 && a1 < 440) { hiz = 60; label17.Text = hiz.ToString(); }
                if (a1 >= 440 && a1 < 460) { hiz = 65; label17.Text = hiz.ToString(); }
                if (a1 >= 460 && a1 < 480) { hiz = 70; label17.Text = hiz.ToString(); }
                if (a1 >= 480 && a1 < 500) { hiz = 75; label17.Text = hiz.ToString(); }
                if (a1 >= 500 && a1 < 520) { hiz = 80; label17.Text = hiz.ToString(); }
                if (a1 >= 520 && a1 < 540) { hiz = 80; label17.Text = hiz.ToString(); }
                if (a1 >= 540 && a1 < 560) { hiz = 75; label17.Text = hiz.ToString(); }
                if (a1 >= 560 && a1 < 580) { hiz = 70; label17.Text = hiz.ToString(); }
                if (a1 >= 580 && a1 < 600) { hiz = 65; label17.Text = hiz.ToString(); }
                if (a1 >= 600 && a1 < 620) { hiz = 60; label17.Text = hiz.ToString(); }
            }
            if (vites == 3)//3. viteste hızlar 70 - 90
            {
                if (a1 >= 420 && a1 < 440) { hiz = 70; label17.Text = hiz.ToString(); }
                if (a1 >= 440 && a1 < 460) { hiz = 75; label17.Text = hiz.ToString(); }
                if (a1 >= 460 && a1 < 480) { hiz = 80; label17.Text = hiz.ToString(); }
                if (a1 >= 480 && a1 < 500) { hiz = 85; label17.Text = hiz.ToString(); }
                if (a1 >= 500 && a1 < 520) { hiz = 90; label17.Text = hiz.ToString(); }
                if (a1 >= 520 && a1 < 540) { hiz = 90; label17.Text = hiz.ToString(); }
                if (a1 >= 540 && a1 < 560) { hiz = 85; label17.Text = hiz.ToString(); }
                if (a1 >= 560 && a1 < 580) { hiz = 80; label17.Text = hiz.ToString(); }
                if (a1 >= 580 && a1 < 600) { hiz = 75; label17.Text = hiz.ToString(); }
                if (a1 >= 600 && a1 < 620) { hiz = 70; label17.Text = hiz.ToString(); }
            }
            if (vites == 4)//4. viteste hızlar 80 - 100
            {
                if (a1 >= 420 && a1 < 440) { hiz = 80; label17.Text = hiz.ToString(); }
                if (a1 >= 440 && a1 < 460) { hiz = 85; label17.Text = hiz.ToString(); }
                if (a1 >= 460 && a1 < 480) { hiz = 90; label17.Text = hiz.ToString(); }
                if (a1 >= 480 && a1 < 500) { hiz = 95; label17.Text = hiz.ToString(); }
                if (a1 >= 500 && a1 < 520) { hiz = 100; label17.Text = hiz.ToString(); }
                if (a1 >= 520 && a1 < 540) { hiz = 100; label17.Text = hiz.ToString(); }
                if (a1 >= 540 && a1 < 560) { hiz = 95; label17.Text = hiz.ToString(); }
                if (a1 >= 560 && a1 < 580) { hiz = 90; label17.Text = hiz.ToString(); }
                if (a1 >= 580 && a1 < 600) { hiz = 85; label17.Text = hiz.ToString(); }
                if (a1 >= 600 && a1 < 620) { hiz = 80; label17.Text = hiz.ToString(); }
            }
            if (vites == 5)//5. viteste hızlar 90 - 110
            {
                if (a1 >= 420 && a1 < 440) { hiz = 90; label17.Text = hiz.ToString(); }
                if (a1 >= 440 && a1 < 460) { hiz = 95; label17.Text = hiz.ToString(); }
                if (a1 >= 460 && a1 < 480) { hiz = 100; label17.Text = hiz.ToString(); }
                if (a1 >= 480 && a1 < 500) { hiz = 105; label17.Text = hiz.ToString(); }
                if (a1 >= 500 && a1 < 520) { hiz = 110; label17.Text = hiz.ToString(); }
                if (a1 >= 520 && a1 < 540) { hiz = 110; label17.Text = hiz.ToString(); }
                if (a1 >= 540 && a1 < 560) { hiz = 105; label17.Text = hiz.ToString(); }
                if (a1 >= 560 && a1 < 580) { hiz = 100; label17.Text = hiz.ToString(); }
                if (a1 >= 580 && a1 < 600) { hiz = 95; label17.Text = hiz.ToString(); }
                if (a1 >= 600 && a1 < 620) { hiz = 90; label17.Text = hiz.ToString(); }
            }
            if (vites == 6)//6. viteste hızlar 100 - 120
            {
                if (a1 >= 420 && a1 < 440) { hiz = 100; label17.Text = hiz.ToString(); }
                if (a1 >= 440 && a1 < 460) { hiz = 105; label17.Text = hiz.ToString(); }
                if (a1 >= 460 && a1 < 480) { hiz = 110; label17.Text = hiz.ToString(); }
                if (a1 >= 480 && a1 < 500) { hiz = 115; label17.Text = hiz.ToString(); }
                if (a1 >= 500 && a1 < 520) { hiz = 120; label17.Text = hiz.ToString(); }
                if (a1 >= 520 && a1 < 540) { hiz = 120; label17.Text = hiz.ToString(); }
                if (a1 >= 540 && a1 < 560) { hiz = 115; label17.Text = hiz.ToString(); }
                if (a1 >= 560 && a1 < 580) { hiz = 110; label17.Text = hiz.ToString(); }
                if (a1 >= 580 && a1 < 600) { hiz = 105; label17.Text = hiz.ToString(); }
                if (a1 >= 600 && a1 < 620) { hiz = 100; label17.Text = hiz.ToString(); }

                gitme = hiz / 10;//her dönüşte gideceği miktar
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
            pictureBox9.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = false;
            label21.Visible = false;
            button5.Visible = false;
            pictureBox7.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label7.Visible = true;
            timer4.Start();

            //Diğer arabaların hızları
            Random uret = new Random();
            g2 = uret.Next(4, 12);
            do
            {
                g3 = uret.Next(4, 12);
            }
            while (g3 == g2);
            do
            {
                g4 = uret.Next(4, 12);
            } while (g3 == g4 || g2 == g4);
            do
            {
                g5 = uret.Next(4, 12);
            }
            while (g4 == g5 || g3 == g5 || g2 == g5);
            do
            {
                g6 = uret.Next(4, 12);
            }
            while (g5 == g6 || g4 == g6 || g3 == g6 || g2 == g6);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random uret = new Random();
            pictureBox7.Left = l1;
            pictureBox2.Left = l2;
            pictureBox3.Left = l3;
            pictureBox4.Left = l4;
            pictureBox5.Left = l5;
            pictureBox6.Left = l6;

            int tdenonce, tdensonra;//Turbodanönceki ve sonraki hızlar

            //Arabaların Hız artışları, her birisi farklı hız artışlarına sahip
            a1 = uret.Next(0, 7);
            a2 = uret.Next(0, 7);
            do
            {
                a3 = uret.Next(0, 7);
            }
            while (a3 == a2);
            do
            {
                a4 = uret.Next(0, 7);
            } while (a3 == a4 || a2 == a4);
            do
            {
                a5 = uret.Next(0, 7);
            }
            while (a4 == a5 || a3 == a5 || a2 == a5);
            do
            {
                a6 = uret.Next(0, 7);
            }
            while (a5 == a6 || a4 == a6 || a3 == a6 || a2 == a6);


            label17.Text = (gitme*5).ToString();//Hız göstergesi

            //Turbo Çalışması, 2sn çalışması için 10'a kadar devam ediyor. Çünkü timer4'ün Intervali 200
            if (say == 1|| say == 2 || say == 3 || say == 4 || say==5 || say == 6|| say == 7 || say == 8 || say == 9 || say==10)
            {
                l1 += (gitme / 2) + (turbo);//bizim arbanın hızına turboyu ekliyor.
                say++;
            }
            else
              l1 += gitme/2;//Turbo kullanılmamışsa normal hızda devam eder

            if (say < 1)//Turbodan önceki hızı yazdırmak
            {
                tdenonce = (gitme * 5);
                label24.Text = tdenonce.ToString();
                
            }
            if (say == 10)//Turbodan sonraki hızı yazdırmak
            {
                tdensonra = ((gitme+turbo)*5);
                label25.Text = tdensonra.ToString();
            }
            if (say >= 1)
            {
                label22.Visible = true;
                label24.Visible = true;
            }
            if (say > 10)
            {
                label23.Visible = true;
                label25.Visible = true;
            }

                //Diğer arabalar ilerliyor
                l2 += g2 / 2;
                l3 += g3 / 2;
                l4 += g4 / 2;
                l5 += g5 / 2;
                l6 += g6 / 2;

                //Arabaların Hızları artıyor
                gitme += a1 / 2;
                g2 += a2 / 2;
                g3 += a3 / 2;
                g4 += a4 / 2;
                g5 += a5 / 2;
                g6 += a6 / 2;

                //Kazanma
                if (pictureBox7.Right >= 1240 && pictureBox2.Right < 1240 && pictureBox3.Right < 1240 && pictureBox4.Right < 1240 && pictureBox5.Right < 1240 && pictureBox6.Right < 1240)
                {
                    timer4.Stop();
                    durum = true;
                    kazanmakaybetme();
                    ekle();
                }

                //Kaybtme
                if (pictureBox7.Right < 1240 && pictureBox2.Right >= 1240 || pictureBox3.Right >= 1240 || pictureBox4.Right >= 1240 || pictureBox5.Right >= 1240 || pictureBox6.Right >= 1240)
                {
                    timer4.Stop();
                    durum = false;
                    kazanmakaybetme();
                    ekle();
                }
          }

        void kazanmakaybetme()
        {
            //Veritabanına kaydetmek için zorluğu belirliyor
            if (Form1.zorluk == 1)
                zorder = "Kolay";
            if (Form1.zorluk == 2)
                zorder = "Orta";
            if (Form1.zorluk == 3)
                zorder = "Zor";

            sıralamahesap();
            puan = (vites * hiz * sırakamaks * pictureBox7.Right)/5000; //Puan hesapla
            puan = Math.Round(puan, 1);//ondalıklı bölmü yuvarlama

            if (durum == true)
            {
                label10.Text = puan.ToString();//Kazandınız yazısı
                label8.Visible = true;
            }

            if (durum == false)
            {
                label11.Text = puan.ToString();//Kazandınız yazısı
                label9.Visible = true;
            }
                cubuk.Start();
        }

        void sıralamahesap()
        {
            //Arabamız geçildikçe sıra düşüyor
            if (pictureBox7.Right > pictureBox2.Right)
                sıralama --;
            if (pictureBox7.Right > pictureBox3.Right)
                sıralama--;
            if (pictureBox7.Right > pictureBox4.Right)
                sıralama --;
            if (pictureBox7.Right > pictureBox5.Right)
                sıralama--;
            if (pictureBox7.Right > pictureBox6.Right)
                sıralama--;

            if (sıralama == 1)//Kazandınız Yazısı
            {
                label8.Visible = true;
                label10.Visible = true;
                label10.Text = puan.ToString();//Kazandınız yazısı
            }
            if (sıralama != 1)//Kaybettiniz Yazısı
            {
                label9.Visible = true;
                label11.Text = puan.ToString();//Kazandınız yazısı
                label11.Visible = true;
            }

            //Sıralama Yazısı
            label12.Visible = true;
            label27.Visible = true;
            label27.Text = sıralama.ToString();

            //Sıralamanın puana katılan katsayısı hesabı
            if (sıralama == 1)
                sırakamaks = 50;
            if (sıralama == 2)
                sırakamaks = 40;
            if (sıralama == 3)
                sırakamaks = 30;
            if (sıralama == 4)
                sırakamaks = 20;
            if (sıralama == 5)
                sırakamaks = 10;
            if (sıralama == 6)
                sırakamaks = 1;

        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt1.accdb");

        void ekle()
        {
            string oyuncuad = Form1.oyuncu.ToString();
            conn.Open();
            OleDbCommand kom = new OleDbCommand("INSERT INTO TABLO (OYUNCU_ADI,PUAN,SIRA,ZORLUK) VALUES ('"+oyuncuad+"','"+puan+"','"+sıralama+"','"+zorder+"')", conn);
            kom.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)//Turbo Kullan
        {
            say = 1;//Turbo kullanıldığını belirtiyor
            button3.Visible = false;
            label26.Visible = true;
        }

        private void cubuk_Tick(object sender, EventArgs e)
        {
            if (cubukvalues > 99)
            {
                button2.Visible = true;
                pictureBox7.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                label7.Visible = false;
                label28.Text = "Puanınız Kaydedildi";
                cubuk.Stop();
            }
            progressBar1.Visible = true;
            label28.Visible = true;
            cubukvalues += 5;

            if(cubukvalues<101)
            progressBar1.Value = cubukvalues;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}