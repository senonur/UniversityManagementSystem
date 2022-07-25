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
    public partial class bolumekle : Form
    {
        public bolumekle()
        {
            InitializeComponent();
        }

        private void bolumekleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bolumekle_Load(object sender, EventArgs e)
        {
            bolumekleHeaderPanel.Size = new Size(this.Width, 80);
            bolumekleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultegetir();
            bolumtablodoldur();
        }

        public void fakultegetir()
        {

            Form1 frm = new();

            frm.baglanti.Open();

            DataTable tablo = new DataTable("fakulte");
            string sorgu = "select * from fakulte where Durum=1";
            SqlCommand fakultegetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader fakulteoku = fakultegetir.ExecuteReader();
            tablo.Load(fakulteoku);

            fakultebolumcb.DisplayMember = "FakülteAd";
            fakultebolumcb.ValueMember = "Id";
            fakultebolumcb.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void bolumeklebtn_Click(object sender, EventArgs e)
        {
            if(fakultebolumcb.SelectedIndex!=-1 && fakultebolumadıtxt.Text!="" && fakultebolumdurumcb.SelectedIndex != -1)
            {

                Form1 frm = new();
                frm.baglanti.Open();
                string sorgu ="insert into bolum(FakülteId,BolumAd,Durum) values(" + Convert.ToInt32(fakultebolumcb.SelectedValue)+ ",'" + fakultebolumadıtxt.Text + "'," + fakultebolumdurumcb.SelectedIndex +  ")";
                SqlCommand bolumekle = new SqlCommand(sorgu, frm.baglanti);
                bolumekle.ExecuteNonQuery();

                MessageBox.Show("Bölüm Ekleme Başarılı");

                fakultebolumcb.SelectedIndex = -1;
                fakultebolumadıtxt.Clear();
                fakultebolumdurumcb.SelectedIndex = -1;

                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }
        }
        public void bolumtablodoldur()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select fakulte.FakülteAd as 'Fakülte Adı',bolum.BolumAd as 'Bölüm Adı', bolum.Durum as 'Durum' from fakulte inner join bolum on (fakulte.Id=bolum.FakülteId) ";
            DataTable tablo = new DataTable();

            SqlDataAdapter bolumgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            bolumgetir.Fill(tablo);

            bolumdgv.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void bolumdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bolumekleduzenle bed = new();
            bed.bolumId= Convert.ToInt32(bolumdgv.CurrentRow.Cells["Id"].Value);
            bed.ShowDialog();
        }

        private void aramatemizlebtn_Click(object sender, EventArgs e)
        {
            bolumtablodoldur();
            fakulteadaramatxt.Clear();
            bölümadaramatxt.Clear();
        }


        private void bolumArabtn_Click_1(object sender, EventArgs e)
        {
            string fakultead = "";
            string bolumad = "";


            if (fakulteadaramatxt.Text == "" && bölümadaramatxt.Text == "")
            {
                bolumtablodoldur();
                fakulteadaramatxt.Clear();
                bölümadaramatxt.Clear();
            }

            else
            {

                if (fakulteadaramatxt.Text != "")
                {
                    fakultead = fakulteadaramatxt.Text;
                }
                if (bölümadaramatxt.Text != "")
                {
                    bolumad = bölümadaramatxt.Text;
                }

                Form1 frm = new();
                frm.baglanti.Open();

                string sorgu = "select fakulte.FakülteAd as 'FakülteAdı',bolum.BolumAd as 'BölümAdı', bolum.Durum as 'Durum' fakulte inner join bolum on (fakulte.Id=bolum.FakülteId) where FakülteAdı='" + fakultead + "' or BölümAdı='" + bolumad + "'  ";

                DataTable tablo = new DataTable();

                SqlDataAdapter bolumgetir = new SqlDataAdapter(sorgu, frm.baglanti);

                bolumgetir.Fill(tablo);

                bolumdgv.DataSource = tablo;

                frm.baglanti.Close();
            }
        }
    }
}
