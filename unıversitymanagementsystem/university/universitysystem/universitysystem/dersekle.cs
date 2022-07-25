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
    public partial class dersekle : Form
    {
        public dersekle()
        {
            InitializeComponent();
        }

        private void dersekleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dersekle_Load(object sender, EventArgs e)
        {
            dersekleHeaderPanel.Size = new Size(this.Width, 80);
            dersekleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultegetir();
            bolumgetir();
            akademikpersonelgetir();
            derstablodoldur();


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

            fakulteadicb.DisplayMember = "FakülteAd";
            fakulteadicb.ValueMember = "Id";
            fakulteadicb.DataSource = tablo;

            frm.baglanti.Close();
        }

        public void bolumgetir()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            DataTable tablo = new DataTable("bolum");
            string sorgu = "select * from bolum where Durum=1";
            SqlCommand bolumgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader bolumoku = bolumgetir.ExecuteReader();
            tablo.Load(bolumoku);

            fakultebolumadicb.DisplayMember = "BolumAd";
            fakultebolumadicb.ValueMember = "Id";
            fakultebolumadicb.DataSource = tablo;

            frm.baglanti.Close();

        }
        public void derstablodoldur()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select * from Ders";
            DataTable tablo = new DataTable();

            SqlDataAdapter dersgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            dersgetir.Fill(tablo);

            dersekledgv.DataSource = tablo;

            frm.baglanti.Close();

        }

        public void akademikpersonelgetir()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            DataTable tablo = new DataTable("AkademikPersonel");
            string sorgu = "select Id,(Ad+' '+Soyad)as Ad from AkademikPersonel where Durum=1 ";
            SqlCommand akademikpersonelgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader akademikpersoneloku = akademikpersonelgetir.ExecuteReader();
            tablo.Load(akademikpersoneloku);

            akademikpersoneladcb.DisplayMember = "Ad";
            //personeladsoyadcb.DisplayMember = "Soyad";
            akademikpersoneladcb.ValueMember = "Id";
            //personeladsoyadcb.DisplayMember = "Soyad";
            //personeladsoyadcb.ValueMember = "Id";
            akademikpersoneladcb.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void derseklebtn_Click(object sender, EventArgs e)
        {
            if (fakulteadicb.SelectedIndex != -1 && fakultebolumadicb.SelectedIndex != -1 && fakultebolumderstxt.Text != "" && fakultedersdurumcb.SelectedIndex != -1)
            {

                Form1 frm = new();
                frm.baglanti.Open();
                string sorgu = "insert into Ders(DersAd,FakülteId,BölümId,Kredi,AkademikPersonelId,Durum,AkademikPersonel) values ('" + fakultebolumderstxt.Text + "'," + Convert.ToInt32(fakulteadicb.SelectedValue) + "," + Convert.ToInt32(fakultebolumadicb.SelectedValue) + "," + Convert.ToInt32(derskredinud.Value) + "," + Convert.ToInt32(akademikpersoneladcb.SelectedValue) + "," + fakultedersdurumcb.SelectedIndex + ",'" + akademikpersoneladcb.Text + "' )";
                SqlCommand dersekle = new SqlCommand(sorgu, frm.baglanti);

                dersekle.ExecuteNonQuery();
                MessageBox.Show("Ders Ekleme Başarılı");

                fakultebolumderstxt.Clear();
                fakulteadicb.SelectedIndex = -1;
                fakultebolumadicb.SelectedIndex = -1;
                derskredinud.Value = 1;
                fakultedersdurumcb.SelectedIndex = -1;
                akademikpersoneladcb.SelectedIndex = -1;

                frm.baglanti.Close();

            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }

        }

        private void dersekledgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dersekleduzenle ded = new();
            ded.dersId = Convert.ToInt32(dersekledgv.CurrentRow.Cells["Id"].Value);
            ded.ShowDialog();
        }

        private void aramatemizlebtn_Click(object sender, EventArgs e)
        {
            derstablodoldur();
            fakulteadicb.SelectedIndex = -1;
            fakultebolumadicb.SelectedIndex = -1;
            fakultebolumderstxt.Clear();
            akademikpersoneladcb.SelectedIndex = -1;
            fakultedersdurumcb.SelectedIndex = -1;

        }

        private void dersArabtn_Click(object sender, EventArgs e)
        {
            string dersadı = "";
            string akademikpersoneladı = "";

            if (dersadıtxt.Text == "" && akademikpersoneladtxt.Text == "")
            {
                derstablodoldur();
                dersadıtxt.Clear();
                akademikpersoneladtxt.Clear();

            }

            else
            {
                if (dersadıtxt.Text != "")
                {
                    dersadı = dersadıtxt.Text;
                }
                if (akademikpersoneladtxt.Text != "")
                {
                    akademikpersoneladı = akademikpersoneladtxt.Text;
                }

                Form1 frm = new();
                frm.baglanti.Open();

                string sorgu = "select DersAd,FakülteId,BölümId,Kredi,AkademikPersonelId,Durum,AkademikPersonel from Ders  where DersAd='" + dersadı + "' or AkademikPersonel='" + akademikpersoneladı + "' ";

                DataTable tablo = new DataTable();

                SqlDataAdapter dersgetir = new SqlDataAdapter(sorgu, frm.baglanti);

                dersgetir.Fill(tablo);

                dersekledgv.DataSource = tablo;

                frm.baglanti.Close();
            }
        }
    }
}
