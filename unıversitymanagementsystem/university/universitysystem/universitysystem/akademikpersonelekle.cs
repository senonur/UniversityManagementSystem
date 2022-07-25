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
    public partial class akademikpersonelekle : Form
    {
        string akademikpersonelId;
        public akademikpersonelekle()
        {
            InitializeComponent();
        }

        private void akademikpersonelcikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void akademikpersonelekle_Load(object sender, EventArgs e)
        {
            akademikpersonelekleHeaderPanel.Size = new Size(this.Width, 80);
            akademikpersonelekleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultegetir();
            bolumgetir();
            unvangetir();
            akademikpersonelgetir();
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

            akademikpersonelFakultecb.DisplayMember = "FakülteAd";
            akademikpersonelFakultecb.ValueMember = "Id";
            akademikpersonelFakultecb.DataSource = tablo;

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

            akademikpersonelbolumcb.DisplayMember = "BolumAd";
            akademikpersonelbolumcb.ValueMember = "Id";
            akademikpersonelbolumcb.DataSource = tablo;

            frm.baglanti.Close();

        }
        public void unvangetir()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            DataTable tablo = new DataTable("Unvan");
            string sorgu = "select * from Unvan where Durum=1";
            SqlCommand unvangetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader unvanoku = unvangetir.ExecuteReader();
            tablo.Load(unvanoku);

            akademikpersonelunvancb.DisplayMember = "UnvanAd";
            akademikpersonelunvancb.ValueMember = "Id";
            akademikpersonelunvancb.DataSource = tablo;

            frm.baglanti.Close();

        }

        public void akademikpersonelgetir()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select * from AkademikPersonel";
            DataTable tablo = new DataTable();

            SqlDataAdapter akademikpersonelgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            akademikpersonelgetir.Fill(tablo);

            akademikpersoneldgv.DataSource = tablo;

            frm.baglanti.Close();

        }


        private void akademikpersonelkayitbtn_Click(object sender, EventArgs e)
        {
            if (akademikpersoneladtxt.Text != "" && akademikpersonelsoyadtxt.Text != "" && akademikpersonelunvancb.SelectedIndex != -1 && akademikpersonelTctxt.Text != "" && akademikpersonelFakultecb.SelectedIndex != -1 && akademikpersonelbolumcb.SelectedIndex != -1 && akademikpersoneldogumtarihidtp.Value != DateTime.Now && akademikpersoneldurumcb.SelectedIndex != -1 && akademikpersonelTelefontxt.Text != "" && akademikpersonelEmailtxt.Text != "" && akademikpersonelAdresrtb.Text != "")

            {
                Form1 frm = new();
                frm.baglanti.Open();

                //string sorgu = "insert into AkademikPersonel(Ad,Soyad,Unvan,Fakülte,Bölüm,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,FakülteId,BölümId,UnvanId) values('" + akademikpersoneladtxt.Text + "','" + akademikpersonelsoyadtxt.Text + "' , " + akademikpersonelunvancb.SelectedIndex + "," + akademikpersonelFakultecb.SelectedIndex + "," + akademikpersonelbolumcb.SelectedIndex + ", '" + akademikpersonelEmailtxt.Text + "','" + akademikpersonelTelefontxt.Text + "','" + akademikpersonelAdresrtb.Text + "', '" + akademikpersoneldurumcb.Text + "',3,'" + akademikpersonelTctxt.Text + "','" + akademikpersoneldogumtarihidtp.Value + "'," + 1 + "," + 1 + "," + 1 + ",  )";

                string sorgu = "insert into AkademikPersonel(Ad,Soyad,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,FakülteId,BölümId,UnvanId,Fakülte,Bölüm,Unvan,KullanıcıAd,Sifre) values('" + akademikpersoneladtxt.Text + "','" + akademikpersonelsoyadtxt.Text + "' , '" + akademikpersonelEmailtxt.Text + "','" + akademikpersonelTelefontxt.Text + "','" + akademikpersonelAdresrtb.Text + "', '" + akademikpersoneldurumcb.SelectedIndex + "'," + 3 + ",'" + akademikpersonelTctxt.Text + "','" + akademikpersoneldogumtarihidtp.Value + "', " + Convert.ToInt32(akademikpersonelFakultecb.SelectedValue) + " ," + Convert.ToInt32(akademikpersonelbolumcb.SelectedValue) + "," + Convert.ToInt32(akademikpersonelunvancb.SelectedValue) + ",'" + akademikpersonelFakultecb.Text + "','" + akademikpersonelbolumcb.Text + "', '" + akademikpersonelunvancb.Text + "','" + akademikpersonelkullanıcıadtxt.Text + "','" + akademikpersonelsifretxt.Text + "')";



                SqlCommand akademikpersonelekle = new SqlCommand(sorgu, frm.baglanti);
                akademikpersonelekle.ExecuteNonQuery();

                MessageBox.Show("Akademik Personel Ekleme Başarılı");
                akademikpersoneladtxt.Clear();
                akademikpersonelsoyadtxt.Clear();
                akademikpersonelEmailtxt.Clear();
                akademikpersonelTelefontxt.Clear();
                akademikpersonelAdresrtb.Clear();
                akademikpersoneldurumcb.SelectedIndex = -1;
                akademikpersonelTctxt.Clear();
                akademikpersonelFakultecb.SelectedIndex = -1;
                akademikpersonelbolumcb.SelectedIndex = -1;
                akademikpersonelunvancb.SelectedIndex = -1;

                frm.baglanti.Close();

                frm.baglanti.Open();

                string sorgu3 = "select Id from AkademikPersonel where KullanıcıAd='" + akademikpersonelkullanıcıadtxt.Text + "' ";
                SqlCommand akademikIdgetir = new SqlCommand(sorgu3, frm.baglanti);
                SqlDataReader ıdoku = akademikIdgetir.ExecuteReader();
                if (ıdoku.Read())
                {
                    akademikpersonelId = ıdoku["Id"].ToString();
                    //MessageBox.Show(akademikpersonelId);

                }
                frm.baglanti.Close();

                frm.baglanti.Open();

                //string sorgu2 = "insert into Kullanicilar(KullaniciAd,Sifre,YetkiId,Durum,AkademikPersonelId) values('" + akademikpersonelkullanıcıadtxt.Text + "','" + akademikpersonelsifretxt.Text + "'," + 3 + ",'" + akademikpersoneldurumcb.SelectedIndex + "')";

                string sorgu2 = "insert into Kullanicilar(KullaniciAd,Sifre,YetkiId,Durum,AkademikPersonelId) values('" + akademikpersonelkullanıcıadtxt.Text + "','" + akademikpersonelsifretxt.Text + "'," + 3 + ",'" + akademikpersoneldurumcb.SelectedIndex + "'," + akademikpersonelId+ ")";

                SqlCommand kullaniciekle = new SqlCommand(sorgu2, frm.baglanti);
                kullaniciekle.ExecuteNonQuery();

                frm.baglanti.Close();



            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }
        }

        private void personelArabtn_Click(object sender, EventArgs e)
        {
            string akademikpersonelad = "";
            string akademikpersonelsoyad = "";
            string akademikpersonelfakulte = "";
            string akademikpersonelbolum = "";

            if (akademikpersoneladaramatxt.Text == "" && akademikpersonelsoyadaramatxt.Text == "" && akademikpersonelfakultearamatxt.Text == "" && akademikpersonelbolumaramatxt.Text == "")
            {

                akademikpersonelgetir();
                akademikpersoneladaramatxt.Clear();
                akademikpersonelsoyadaramatxt.Clear();
                akademikpersonelfakultearamatxt.Clear();
                akademikpersonelbolumaramatxt.Clear();

            }
            else
            {
                if (akademikpersoneladaramatxt.Text != "")
                {
                    akademikpersonelad = akademikpersoneladaramatxt.Text;
                }
                if (akademikpersonelsoyadaramatxt.Text != "")
                {
                    akademikpersonelsoyad = akademikpersonelsoyadaramatxt.Text;
                }
                if (akademikpersonelfakultearamatxt.Text != "")
                {
                    akademikpersonelfakulte = akademikpersonelfakultearamatxt.Text;
                }
                if (akademikpersonelbolumaramatxt.Text != "")
                {
                    akademikpersonelbolum = akademikpersonelbolumaramatxt.Text;
                }


                Form1 frm = new();
                frm.baglanti.Open();

                string sorgu = "select Ad,Soyad,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,FakülteId,BölümId,UnvanId,Fakülte,Bölüm,Unvan from AkademikPersonel  where Ad='" + akademikpersonelad + "' or Soyad='" + akademikpersonelsoyad + "' or Fakülte= '" + akademikpersonelfakulte + "' or Bölüm='" + akademikpersonelbolum + "' ";

                DataTable tablo = new DataTable();

                SqlDataAdapter akademikpersonelgetir = new SqlDataAdapter(sorgu, frm.baglanti);

                akademikpersonelgetir.Fill(tablo);

                akademikpersoneldgv.DataSource = tablo;

                frm.baglanti.Close();
            }
        }

        private void aramatemizlebtn_Click(object sender, EventArgs e)
        {

            akademikpersonelgetir();
            akademikpersoneladaramatxt.Clear();
            akademikpersonelsoyadaramatxt.Clear();
            akademikpersonelfakultearamatxt.Clear();
            akademikpersonelbolumaramatxt.Clear();
        }

        private void akademikpersoneldgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            akademikpersoneldüzenle apd = new();
            apd.akademikpersonelId = Convert.ToInt32(akademikpersoneldgv.CurrentRow.Cells["Id"].Value);
            apd.ShowDialog();
        }
    }
}

