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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt1.accdb");
        int i = 0;

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void baglan()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        void listele()
        {
            baglan();
            DataTable dt = new DataTable();
            DataTable dtt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM TABLO ORDER BY PUAN ASC", conn);
            OleDbDataAdapter add = new OleDbDataAdapter("SELECT * FROM TABLO ORDER BY PUAN DESC", conn);
            ad.Fill(dt);
            add.Fill(dtt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dtt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.tABLOTableAdapter1.Fill(this.vt1DataSet2.TABLO);
            this.tABLOTableAdapter.Fill(this.vt1DataSet1.TABLO);
            listele();
            i = dataGridView1.RowCount;
            label8.Text = (i-1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)//Arama
        {
            baglan();
            DataTable dt = new DataTable();
            DataTable dtt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM TABLO WHERE OYUNCU_ADI= '"+ textBox1.Text +"'", conn);
            ad.Fill(dt);
            ad.Fill(dtt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dtt;
        }

        private void button2_Click(object sender, EventArgs e)//Silme
        {
            baglan();
            OleDbCommand kom = new OleDbCommand("DELETE FROM TABLO WHERE OYUNCU_ADI='" + textBox2.Text + "'", conn);
            kom.ExecuteNonQuery();
            listele();
            i--;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("UPDATE TABLO SET OYUNCU_ADI='" + textBox3.Text + "' Where PUAN ='" + textBox4.Text + "'", conn);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            listele();
            conn.Close();
        }
    }
}
