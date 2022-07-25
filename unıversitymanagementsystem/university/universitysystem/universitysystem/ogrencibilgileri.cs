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
    public partial class ogrencibilgileri : Form
    {

        string ogrenciId;
        public ogrencibilgileri()
        {
            InitializeComponent();
        }

        private void ogrencibilgileriCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ogrencibilgileri_Load(object sender, EventArgs e)
        {
            ogrencibilgileriHeaderPanel.Size = new Size(this.Width, 80);
            ogrencibilgilericontentpanel.Size = new Size(this.Width, this.Height - 80);
            fakultegetir();
            bolumgetir();
            ogrencitablodoldur();
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

            ogrencifakulteadcb.DisplayMember = "FakülteAd";
            ogrencifakulteadcb.ValueMember = "Id";
            ogrencifakulteadcb.DataSource = tablo;

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

            ogrencifakultebolumcb.DisplayMember = "BolumAd";
            ogrencifakultebolumcb.ValueMember = "Id";
            ogrencifakultebolumcb.DataSource = tablo;

            frm.baglanti.Close();

        }

        public void ogrencitablodoldur()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select * from OgrenciBilgileri";
            DataTable tablo = new DataTable();

            SqlDataAdapter ogrencigetir = new SqlDataAdapter(sorgu, frm.baglanti);

            ogrencigetir.Fill(tablo);

            ogrenciDgv.DataSource = tablo;

            frm.baglanti.Close();

        }

        private void ogrencikayıtbtn_Click(object sender, EventArgs e)
        {
            if (ogrenciadtxt.Text != "" && ogrencisoyadtxt.Text != "" && ogrencitcnotxt.Text != "" && ogrencidogumtarihidtp.Value != DateTime.Now && ogrencifakulteadcb.SelectedIndex != -1 && ogrencifakultebolumcb.SelectedIndex != -1 && ogrenciemailtxt.Text != "" && ogrencitelefontxt.Text != "" && ogrencidurumcb.SelectedIndex != -1 && ogrencinotxt.Text != "" && ogrenciadresrtb.Text != "")
            {
                Form1 frm = new();
                frm.baglanti.Open();

                //string sorgu = "insert into OgrenciBilgileri(Ad,Soyad,Fakülte,Bölüm,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,ÖğrenciNo,BölümId)" +
                //    " values('" + ogrenciadtxt.Text + "','" + ogrencisoyadtxt.Text + "'," + ogrencifakulteadcb.SelectedIndex + "," + ogrencifakultebolumcb.SelectedIndex + " , '" + ogrenciemailtxt.Text + "','" + ogrencitelefontxt.Text + "','" + ogrenciadresrtb.Text + "', " + ogrencidurumcb.SelectedIndex + ","+1+",'" + ogrencitcnotxt.Text + "','" + ogrencidogumtarihidtp.Value + "', '" + ogrencinotxt.Text + "',"+1+") ";

                string sorgu = "insert into OgrenciBilgileri(Ad,Soyad,Fakülte,Bölüm,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,ÖğrenciNo,BölümId,FakülteId,KullanıcıAd,Sifre)" +
                    " values('" + ogrenciadtxt.Text + "','" + ogrencisoyadtxt.Text + "','" + ogrencifakulteadcb.Text + "','" + ogrencifakultebolumcb.Text + "' , '" + ogrenciemailtxt.Text + "','" + ogrencitelefontxt.Text + "','" + ogrenciadresrtb.Text + "', " + ogrencidurumcb.SelectedIndex + "," + 1 + ",'" + ogrencitcnotxt.Text + "','" + ogrencidogumtarihidtp.Value + "', '" + ogrencinotxt.Text + "'," + Convert.ToInt32(ogrencifakultebolumcb.SelectedValue) + "," + Convert.ToInt32(ogrencifakulteadcb.SelectedValue) + ",'"+ ogrencikullaniciadtxt.Text+"','" + ogrencisifretxt.Text+ "') ";

                SqlCommand ogrenciekle = new SqlCommand(sorgu, frm.baglanti);
                ogrenciekle.ExecuteNonQuery();

                MessageBox.Show("Öğrenci Ekleme Başarılı");


                ogrenciadtxt.Clear();
                ogrencisoyadtxt.Clear();
                ogrencitcnotxt.Clear();
                ogrencifakulteadcb.SelectedIndex = -1;
                ogrencifakultebolumcb.SelectedIndex = -1;
                ogrenciemailtxt.Clear();
                ogrencitelefontxt.Clear();
                ogrencidurumcb.SelectedIndex = -1;
                ogrencinotxt.Clear();
                ogrenciadresrtb.Clear();

                frm.baglanti.Close();


                frm.baglanti.Open();

                string sorgu3 = "select Id from OgrenciBilgileri where KullanıcıAd='" + ogrencikullaniciadtxt.Text + "' ";
                SqlCommand ogrenciIdgetir = new SqlCommand(sorgu3, frm.baglanti);
                SqlDataReader ogrenciIdoku = ogrenciIdgetir.ExecuteReader();
                if (ogrenciIdoku.Read())
                {
                    ogrenciId = ogrenciIdoku["Id"].ToString();
                    //MessageBox.Show(akademikpersonelId);

                }

                frm.baglanti.Close();

                frm.baglanti.Open();

                string sorgu2 = "insert into Kullanicilar(KullaniciAd,Sifre,YetkiId,Durum,ogrenciId) values('" + ogrencikullaniciadtxt.Text + "','" + ogrencisifretxt.Text + "'," + 1 + ",'" + ogrencidurumcb.SelectedIndex + "'," + ogrenciId + ")";

                SqlCommand ogrenciIdekle = new SqlCommand(sorgu2, frm.baglanti);
                ogrenciIdekle.ExecuteNonQuery();

                frm.baglanti.Close();

            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }

        }

        private void ogrenciArabtn_Click(object sender, EventArgs e)
        {
            string ogrenciad = "";
            string ogrencisoyad = "";
            string ogrencitc = "";
            string ogrencifakulte = "";
            if(ogrenciadaramatxt.Text=="" && ogrencisoyadaramatxt.Text=="" && ogrencitcaramatxt.Text=="" && ogrencifakultearamatxt.Text == "")
            {
                ogrencitablodoldur();
                ogrenciadaramatxt.Clear();
                ogrencisoyadaramatxt.Clear();
                ogrencitcaramatxt.Clear();
                ogrencifakultearamatxt.Clear();
            }
            else
            {
                if (ogrenciadaramatxt.Text != "")
                {
                    ogrenciad = ogrenciadaramatxt.Text;
                }
                if (ogrencisoyadaramatxt.Text != "")
                {
                    ogrencisoyad = ogrencisoyadaramatxt.Text;
                }
                if (ogrencitcaramatxt.Text != "")
                {
                    ogrencitc = ogrencitcaramatxt.Text;
                }
                if (ogrencifakultearamatxt.Text != "")
                {
                    ogrencifakulte = ogrencifakultearamatxt.Text;
                }

                Form1 frm = new();
                frm.baglanti.Open();

                string sorgu = "select Ad,Soyad,Fakülte,Bölüm,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,ÖğrenciNo,BölümId,FakülteId from OgrenciBilgileri  where Ad='" + ogrenciad + "' or Soyad='" + ogrencisoyad + "' or TC= '" + ogrencitc + "' or Fakülte='" + ogrencifakulte + "'  ";

                DataTable tablo = new DataTable();

                SqlDataAdapter ogrencigetir = new SqlDataAdapter(sorgu, frm.baglanti);

                ogrencigetir.Fill(tablo);

                ogrenciDgv.DataSource = tablo;

                frm.baglanti.Close();

            }
        }

        private void aramatemizlebtn_Click(object sender, EventArgs e)
        {
            ogrencitablodoldur();
            ogrenciadaramatxt.Clear();
            ogrencisoyadaramatxt.Clear();
            ogrencitcaramatxt.Clear();
            ogrencifakultearamatxt.Clear();
        }

        private void ogrenciDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ogrencibilgileriduzenle obd = new();
            obd.ogrenciId = Convert.ToInt32(ogrenciDgv.CurrentRow.Cells["Id"].Value);
            obd.ShowDialog();
        }
    }
}
