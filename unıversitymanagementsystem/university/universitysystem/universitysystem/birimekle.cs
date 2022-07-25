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
    public partial class birimekle : Form
    {
        public birimekle()
        {
            InitializeComponent();
        }

        private void birimekleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void birimekle_Load(object sender, EventArgs e)
        {
            birimekleHeaderPanel.Size= new Size(this.Width, 80);
            birimekleContentPanel.Size= new Size(this.Width, this.Height - 80);
            birimtablodoldur();

        }

        private void birimeklebtn_Click(object sender, EventArgs e)
        {
            if(birimaditxt.Text!="" && birimdurumcbx.SelectedIndex != -1)
            {

                Form1 frm = new Form1();
                frm.baglanti.Open();
                string sorgu = "insert into Birim(BirimAd,Durum) values('" + birimaditxt.Text + "', " + birimdurumcbx.SelectedIndex + ")";

                SqlCommand birimekle = new SqlCommand(sorgu, frm.baglanti);
                birimekle.ExecuteNonQuery();

                MessageBox.Show("Birim Ekleme Başarılı");

                birimaditxt.Clear();
                birimdurumcbx.SelectedIndex = -1;

                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }
        }
        public void birimtablodoldur()
        {

            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select * from Birim";
            DataTable tablo = new DataTable();

            SqlDataAdapter birimgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            birimgetir.Fill(tablo);

            birimdgv.DataSource = tablo;

            frm.baglanti.Close();
        }
    }
}
