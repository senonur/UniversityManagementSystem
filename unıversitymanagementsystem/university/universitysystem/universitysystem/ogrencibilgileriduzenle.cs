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
    public partial class ogrencibilgileriduzenle : Form
    {
        public int ogrenciId=0;
        public ogrencibilgileriduzenle()
        {
            InitializeComponent();
        }

        private void ogrencibilgileriduzenle_Load(object sender, EventArgs e)
        {
            ogrenciDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            ogrenciDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultecbdoldur();
            bolumcbdoldur();
            ogrencibilgilerigetir(ogrenciId);
        }

        public void fakultecbdoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("fakulte");
            string sorgu = "select * from fakulte where Durum=1";
            SqlCommand fakultegetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader fakulteoku = fakultegetir.ExecuteReader();
            tablo.Load(fakulteoku);

            ogrenciduzenlefakultecb.DisplayMember = "FakülteAd";
            ogrenciduzenlefakultecb.ValueMember = "Id";
            ogrenciduzenlefakultecb.DataSource = tablo;

            frm.baglanti.Close();
        }

        public void bolumcbdoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("bolum");
            string sorgu = "select * from bolum where Durum=1";
            SqlCommand bolumgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader bolumoku = bolumgetir.ExecuteReader();
            tablo.Load(bolumoku);

            ogrenciduzenlebolumcb.DisplayMember = "BolumAd";
            ogrenciduzenlebolumcb.ValueMember = "Id";
            ogrenciduzenlebolumcb.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void ogrencibilgileriCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ogrencibilgilerigetir(int Id)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from OgrenciBilgileri where Id=" + Id;

            SqlCommand yg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader ogrencioku = yg.ExecuteReader();
            if (ogrencioku.Read())
            {

                ogrenciId = Convert.ToInt32(ogrencioku["Id"]);
                ogrenciduzenleadtxt.Text = ogrencioku["Ad"].ToString();
                ogrenciduzenlesoyadtxt.Text = ogrencioku["Soyad"].ToString();
                ogrenciduzenleemailtxt.Text = ogrencioku["Email"].ToString();
                ogrenciduzenletelefontxt.Text = ogrencioku["Telefon"].ToString();
                ogrenciduzenleadresrtb.Text = ogrencioku["Adres"].ToString();
                ogrenciduzenledurumcb.SelectedIndex = Convert.ToInt32(ogrencioku["Durum"]);
                ogrenciduzenletctxt.Text = ogrencioku["TC"].ToString();
                ogrenciduzenledogumdtp.Value = Convert.ToDateTime(ogrencioku["DoğumTarihi"]).Date;
                ogrenciduzenleogrencinotxt.Text= ogrencioku["ÖğrenciNo"].ToString();
                ogrenciduzenlefakultecb.SelectedValue= Convert.ToInt32(ogrencioku["FakülteId"]);
                ogrenciduzenlebolumcb.SelectedValue = Convert.ToInt32(ogrencioku["BölümId"]);
                ogrenciduzenlekullaniciadtxt.Text = ogrencioku["KullanıcıAd"].ToString();
                ogrenciduzenlesifretxt.Text = ogrencioku["Sifre"].ToString();

            }
            frm.baglanti.Close();
        }

        private void ogrenciduzenlebtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update OgrenciBilgileri set Ad ='" + ogrenciduzenleadtxt.Text + "',Soyad='" + ogrenciduzenlesoyadtxt.Text + "',Fakülte='" + ogrenciduzenlefakultecb.Text + "',Bölüm='" + ogrenciduzenlebolumcb.Text + "',Email='" + ogrenciduzenleemailtxt.Text + "',Telefon='"+ogrenciduzenletelefontxt.Text+"',Adres='"+ogrenciduzenleadresrtb.Text+"',Durum=" + ogrenciduzenledurumcb.SelectedIndex + ",YetkiId=" + 1 + ",TC='" + ogrenciduzenletctxt.Text + "',DoğumTarihi='" + (ogrenciduzenledogumdtp.Value.Day + "." + ogrenciduzenledogumdtp.Value.Month + "." + ogrenciduzenledogumdtp.Value.Year) + "',ÖğrenciNo='"+ogrenciduzenleogrencinotxt.Text+"',BölümId=" + (int)ogrenciduzenlebolumcb.SelectedValue + " ,FakülteId=" + (int)ogrenciduzenlefakultecb.SelectedValue + " ,KullanıcıAd='" + ogrenciduzenlekullaniciadtxt.Text + "',Sifre='" + ogrenciduzenlesifretxt.Text + "' where Id= " + ogrenciId + " ";

            SqlCommand ogrenciduzenle = new SqlCommand(sorgu, frm.baglanti);
            ogrenciduzenle.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        private void ogrencisilbtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(ogrenciduzenleadtxt.Text + " " + " Adlı Öğrenci Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "ogrencisil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("ogrenciId", SqlDbType.Int).Value = ogrenciId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("Öğrenci Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Öğrenci Silme İşlemi İptal Edildi");
            }
        }
    }
}
