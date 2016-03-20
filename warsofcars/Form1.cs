using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace warsofcars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 fr2 = new Form2();
        public static int zorluk;
        public static string oyuncu;

        private void button1_Click(object sender, EventArgs e)//Başlat
        {
            fr2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            textBox1.Text = "Oyuncu1";
            oyuncu = textBox1.Text;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)//Kolay
        {
            fr2.timer1.Interval = 180;
            fr2.timer2.Interval = 30;
            fr2.timer3.Interval = 30;
            zorluk = 1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)//Orta
        {
            fr2.timer1.Interval = 120;
            fr2.timer2.Interval = 15;
            fr2.timer3.Interval = 15;
            zorluk = 2;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)//Zor
        {
            fr2.timer1.Interval = 80;
            fr2.timer2.Interval = 1;
            fr2.timer3.Interval = 1;
            zorluk = 3;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oyuncu = textBox1.Text;
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
