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
    public partial class idaripersonelekle : Form
    {

        string idaripersonelId;
        public idaripersonelekle()
        {
            InitializeComponent();
        }

        private void idaripersonelekleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idaripersoneleklebtn_Click(object sender, EventArgs e)
        {
            if (idaripersoneladtxt.Text != "" && idaripersonelsoyadtxt.Text != "" && idaripersonelbirimcb.SelectedIndex != -1 && idaripersonelemailtxt.Text != "" && idaripersoneltelefontxt.Text != "" && idaripersoneldurumcb.SelectedIndex != -1 && idaripersoneltctxt.Text != "" && idaripersoneldtp.Value != DateTime.Now && idaripersoneladresrtb.Text != "")
            {
                Form1 frm = new();
                frm.baglanti.Open();

                //string sorgu = "insert into idaripersonel(Ad,Soyad,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,BirimId) values ('" + idaripersoneladtxt.Text + "','" + idaripersonelsoyadtxt.Text + "','" + idaripersonelemailtxt.Text + "','" + idaripersoneltelefontxt.Text + "' , '" + idaripersoneladresrtb.Text + "'," + idaripersoneldurumcb.SelectedIndex + ",'" + idaripersoneltctxt.Text + "', '" + idaripersoneldtp.Value + "'," + 1 + ",)";

                //string sorgu = "insert into idaripersonel(Ad,Soyad,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,BirimId) values ('" + idaripersoneladtxt.Text + "','" + idaripersonelsoyadtxt.Text + "','" + idaripersonelemailtxt.Text + "','" + idaripersoneltelefontxt.Text + "' , '" + idaripersoneladresrtb.Text + "'," + Convert.ToInt32(idaripersoneldurumcb.SelectedValue) + "," + 2 + ",'" + idaripersoneltctxt.Text + "', '" + idaripersoneldtp.Value + "'," + idaripersonelbirimcb.SelectedIndex + ")";

                string sorgu = "insert into idaripersonel(Ad,Soyad,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,BirimId,Birim,KullanıcıAd,Sifre) values ('" + idaripersoneladtxt.Text + "','" + idaripersonelsoyadtxt.Text + "','" + idaripersonelemailtxt.Text + "','" + idaripersoneltelefontxt.Text + "' , '" + idaripersoneladresrtb.Text + "'," + idaripersoneldurumcb.SelectedIndex + "," + 2 + ",'" + idaripersoneltctxt.Text + "', '" + idaripersoneldtp.Value + "'," + Convert.ToInt32(idaripersonelbirimcb.SelectedValue) + ", '" + idaripersonelbirimcb.Text+"', '" + idaripersonelkullanıcıadtxt.Text+"','" + idaripersonelsifretxt.Text+"')";

                SqlCommand idaripersonelekle = new SqlCommand(sorgu, frm.baglanti);
                idaripersonelekle.ExecuteNonQuery();
                MessageBox.Show("İdari Personel Ekleme Başarılı");
                idaripersoneladtxt.Clear();
                idaripersonelsoyadtxt.Clear();
                idaripersonelemailtxt.Clear();
                idaripersoneltelefontxt.Clear();
                idaripersoneladresrtb.Clear();
                idaripersoneldurumcb.SelectedIndex = -1;
                idaripersoneltctxt.Clear();
                idaripersonelbirimcb.SelectedIndex = -1;

                frm.baglanti.Close();

                frm.baglanti.Open();

                string sorgu2= "select Id from idaripersonel where KullanıcıAd ='" + idaripersonelkullanıcıadtxt.Text+ "'  ";
                SqlCommand idariIdgetir = new SqlCommand(sorgu2, frm.baglanti);
                SqlDataReader idariIdoku = idariIdgetir.ExecuteReader();
                if (idariIdoku.Read())
                {
                    idaripersonelId = idariIdoku["Id"].ToString();
                }


                frm.baglanti.Close();

                frm.baglanti.Open();

                string sorgu3 = "insert into Kullanicilar(KullaniciAd,Sifre,YetkiId,Durum,idaripersonelId) values('" + idaripersonelkullanıcıadtxt.Text + "','" + idaripersonelsifretxt.Text + "'," + 2 + ",'" + idaripersoneldurumcb.SelectedIndex + "'," + idaripersonelId + ")";

                SqlCommand kullaniciekle = new SqlCommand(sorgu3, frm.baglanti);
                kullaniciekle.ExecuteNonQuery();

                frm.baglanti.Close();

            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }

        }
        public void birimgetir()
        {
            Form1 frm = new();
            frm.baglanti.Open();
            DataTable tablo = new DataTable("Birim");
            string sorgu = "select * from Birim where Durum=1";
            SqlCommand birimgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader birimoku = birimgetir.ExecuteReader();
            tablo.Load(birimoku);

            idaripersonelbirimcb.DisplayMember = "BirimAd";
            idaripersonelbirimcb.ValueMember = "Id";
            idaripersonelbirimcb.DataSource = tablo;
            frm.baglanti.Close();

        }

        public void idaripersoneltablodoldur()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select * from idaripersonel";
            DataTable tablo = new DataTable();

            SqlDataAdapter idaripersonelgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            idaripersonelgetir.Fill(tablo);

            idaripersoneldgv.DataSource = tablo;

            frm.baglanti.Close();

        }

        private void idaripersonelekle_Load(object sender, EventArgs e)
        {
            idaripersonelekleHeaderPanel.Size = new Size(this.Width, 80);
            idaripersonelekleContentPanel.Size = new Size(this.Width, this.Height - 80);
            birimgetir();
            idaripersoneltablodoldur();
        }

        private void idaripersonelarabtn_Click(object sender, EventArgs e)
        {
            string personelad = "";
            string personelsoyad = "";
            string personelbirim = "";

            if(idaripersoneladaramatxt.Text== "" && idaripersonelsoyadaramatxt.Text== "" && idaripersonelbirimaramatxt.Text == "")
            {
                idaripersoneltablodoldur();
                idaripersoneladaramatxt.Clear();
                idaripersonelsoyadaramatxt.Clear();
                idaripersonelbirimaramatxt.Clear();
            }

            else
            {

                if(idaripersoneladaramatxt.Text != "")
                {
                    personelad = idaripersoneladaramatxt.Text;
                }
                if(idaripersonelsoyadaramatxt.Text != "")
                {
                    personelsoyad = idaripersonelsoyadaramatxt.Text;
                }
                if(idaripersonelbirimaramatxt.Text != "")
                {
                    personelbirim = idaripersonelbirimaramatxt.Text;
                }

                Form1 frm = new();
                frm.baglanti.Open();

                string sorgu = "select Ad,Soyad,Email,Telefon,Adres,Durum,YetkiId,TC,DoğumTarihi,BirimId,Birim from idaripersonel  where Ad='" + personelad + "' or Soyad='" + personelsoyad + "' or Birim= '" + personelbirim+ "'  ";

                DataTable tablo = new DataTable();

                SqlDataAdapter idaripersonelgetir = new SqlDataAdapter(sorgu, frm.baglanti);

                idaripersonelgetir.Fill(tablo);

                idaripersoneldgv.DataSource = tablo;

                frm.baglanti.Close();
            }
        }

        private void aramatemizlebtn_Click(object sender, EventArgs e)
        {
            idaripersoneltablodoldur();
            idaripersoneladaramatxt.Clear();
            idaripersonelsoyadaramatxt.Clear();
            idaripersonelbirimaramatxt.Clear();

        }

        private void idaripersoneldgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idaripersonelduzenle ipd = new();
            ipd.idaripersonelId = Convert.ToInt32(idaripersoneldgv.CurrentRow.Cells["Id"].Value);
            ipd.ShowDialog();
        }
    }
}
