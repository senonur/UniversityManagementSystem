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
    public partial class akademikpersoneldüzenle : Form
    {
        public int akademikpersonelId = 0;
        public akademikpersoneldüzenle()
        {
            InitializeComponent();
        }

        private void akademikpersoneldüzenle_Load(object sender, EventArgs e)
        {
            akademikpersonelDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            akademikpersonelDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultecbdoldur();
            bolumcbdoldur();
            unvancbdoldur();
            akademikpersonelgetir(akademikpersonelId);
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

            akademikpersonelduzenlefakultecb.DisplayMember = "FakülteAd";
            akademikpersonelduzenlefakultecb.ValueMember = "Id";
            akademikpersonelduzenlefakultecb.DataSource = tablo;

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

            akademikpersonelduzenlebolumcb.DisplayMember = "BolumAd";
            akademikpersonelduzenlebolumcb.ValueMember = "Id";
            akademikpersonelduzenlebolumcb.DataSource = tablo;

            frm.baglanti.Close();
        }

        public void unvancbdoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("Unvan");
            string sorgu = "select * from Unvan where Durum=1";
            SqlCommand unvangetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader unvanoku = unvangetir.ExecuteReader();
            tablo.Load(unvanoku);

            akademikpersonelduzenleunvancb.DisplayMember = "UnvanAd";
            akademikpersonelduzenleunvancb.ValueMember = "Id";
            akademikpersonelduzenleunvancb.DataSource = tablo;

            frm.baglanti.Close();

        }

        public void akademikpersonelgetir(int Id)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from AkademikPersonel where Id=" + Id;

            SqlCommand yg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader akademikpersoneloku = yg.ExecuteReader();
            if (akademikpersoneloku.Read())
            {
                akademikpersonelId = Convert.ToInt32(akademikpersoneloku["Id"]);
                akademikpersonelduzenleadtxt.Text = akademikpersoneloku["Ad"].ToString();
                akademikpersonelduzenlesoyadtxt.Text = akademikpersoneloku["Soyad"].ToString();
                akademikpersonelduzenleemailtxt.Text = akademikpersoneloku["Email"].ToString();
                akademikpersonelduzenletelefontxt.Text = akademikpersoneloku["Telefon"].ToString();
                akademikpersonelduzenleadresrtb.Text = akademikpersoneloku["Adres"].ToString();
                akademikpersonelduzenledurumcb.SelectedIndex = Convert.ToInt32(akademikpersoneloku["Durum"]);
                akademikpersonelduzenletctxt.Text = akademikpersoneloku["TC"].ToString();
                akademikpersonelduzenledogumtarihidtp.Value = Convert.ToDateTime(akademikpersoneloku["DoğumTarihi"]).Date;
                akademikpersonelduzenlefakultecb.SelectedValue = Convert.ToInt32(akademikpersoneloku["FakülteId"]);
                akademikpersonelduzenlebolumcb.SelectedValue = Convert.ToInt32(akademikpersoneloku["BölümId"]);
                akademikpersonelduzenleunvancb.SelectedValue = Convert.ToInt32(akademikpersoneloku["UnvanId"]);
                akademikpersonelduzenlekullanıcıadtxt.Text = akademikpersoneloku["KullanıcıAd"].ToString();
                akademikpersonelduzenlesifretxt.Text = akademikpersoneloku["Sifre"].ToString();

            }
            frm.baglanti.Close();

        }

        private void akademikpersonelduzenlecıkısbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void akademikpersonelduzenlebtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update AkademikPersonel set Ad='" + akademikpersonelduzenleadtxt.Text + "',Soyad='" + akademikpersonelduzenlesoyadtxt.Text + "',Email='" + akademikpersonelduzenleemailtxt.Text + "',Telefon='" + akademikpersonelduzenletelefontxt.Text + "',Adres='" + akademikpersonelduzenleadresrtb.Text + "',Durum=" + akademikpersonelduzenledurumcb.SelectedIndex + ",YetkiId=" + 3 + ",TC='" + akademikpersonelduzenletctxt.Text + "',DoğumTarihi='" + (akademikpersonelduzenledogumtarihidtp.Value.Day + "." + akademikpersonelduzenledogumtarihidtp.Value.Month + "." + akademikpersonelduzenledogumtarihidtp.Value.Year) + "',FakülteId=" + (int)akademikpersonelduzenlefakultecb.SelectedValue + " ,BölümId=" + (int)akademikpersonelduzenlebolumcb.SelectedValue + ",UnvanId=" + (int)akademikpersonelduzenleunvancb.SelectedValue + ",Fakülte='" + akademikpersonelduzenlefakultecb.Text + "',Bölüm='" + akademikpersonelduzenlebolumcb.Text + "',Unvan='" + akademikpersonelduzenleunvancb.Text + "',KullanıcıAd='" + akademikpersonelduzenlekullanıcıadtxt.Text + "',Sifre='" + akademikpersonelduzenlesifretxt.Text + "' where Id= " + akademikpersonelId + " ";

            //string sorgu = "update Ders set DersAd='" + dersduzenlefakultebolumderstxt.Text + "',FakülteId=" + (int)dersduzenlefakulteadicb.SelectedValue + ",BölümId=" + (int)dersduzenlefakultebolumadicb.SelectedValue + ",Kredi=" + dersduzenlederskredinud.Value + ",AkademikPersonelId=" + (int)dersduzenleakademikpersoneladcb.SelectedValue + ",Durum=" + dersduzenlefakultedersdurumcb.SelectedIndex + ",AkademikPersonel='" + dersduzenleakademikpersoneladcb.Text + "'  where Id= " + dersId + ""; ;

            SqlCommand akademikpersonelduzenle = new SqlCommand(sorgu, frm.baglanti);
            akademikpersonelduzenle.ExecuteNonQuery();
            MessageBox.Show("Akademik Personel Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        private void akademikpersonelduzenlesilbtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(akademikpersonelduzenleadtxt.Text + " " + " Adlı Akademik Personel Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "akademikpersonelsil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("akademikpersonelId", SqlDbType.Int).Value = akademikpersonelId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("Akademik Personel Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Akademik Personel İşlemi İptal Edildi");
            }
        }
    }
}
