using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace universitysystem
{
    public partial class Unvan : Form
    {
        public Unvan()
        {
            InitializeComponent();
        }

        private void Unvan_Load(object sender, EventArgs e)
        {
            unvanekleHeaderPanel.Size = new Size(this.Width, 80);
            unvanekleContentPanel.Size = new Size(this.Width, this.Height - 80);
            unvangetir();
        }

        private void unvaneklebtn_Click(object sender, EventArgs e)
        {
            if (unvanaditxt.Text != "" && unvandurumcbx.SelectedIndex != -1)
            {
                Form1 frm = new();
                frm.baglanti.Open();
                string sorgu = "insert into Unvan(UnvanAd,Durum) values('" + unvanaditxt.Text + "','" + unvandurumcbx.SelectedIndex + "')";

                SqlCommand unvanekle = new SqlCommand(sorgu, frm.baglanti);
                unvanekle.ExecuteNonQuery();
                MessageBox.Show("Unvan Ekleme Başarılı");

                unvanaditxt.Clear();
                unvandurumcbx.SelectedIndex = -1;
                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }
        }

        private void unvanekleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void unvangetir()
        {


            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select * from Unvan";
            DataTable tablo = new DataTable();

            SqlDataAdapter unvangetir = new SqlDataAdapter(sorgu, frm.baglanti);

            unvangetir.Fill(tablo);

            unvandgv.DataSource = tablo;

            frm.baglanti.Close();
        }
    }
}

