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
    public partial class idaripersonelduzenle : Form
    {
        public int idaripersonelId = 0;
        public idaripersonelduzenle()
        {
            InitializeComponent();

        }

        private void idaripersonelduzenle_Load(object sender, EventArgs e)
        {
            idaripersonelDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            idaripersonelDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            birimcbdoldur();
            idaripersonelgetir(idaripersonelId);
        }

        public void birimcbdoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("Birim");
            string sorgu = "select * from Birim where Durum=1";
            SqlCommand birimgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader birimoku = birimgetir.ExecuteReader();
            tablo.Load(birimoku);

            idaripersonelduzenlebirimcb.DisplayMember = "BirimAd";
            idaripersonelduzenlebirimcb.ValueMember = "Id";
            idaripersonelduzenlebirimcb.DataSource = tablo;

            frm.baglanti.Close();

        }

        public void idaripersonelgetir(int Id)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from idaripersonel where Id=" + Id;

            SqlCommand yg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader idaripersoneloku = yg.ExecuteReader();
            if (idaripersoneloku.Read())
            {

                idaripersonelId = Convert.ToInt32(idaripersoneloku["Id"]);
                idaripersonelduzenleadtxt.Text = idaripersoneloku["Ad"].ToString();
                idaripersonelduzenlesoyadtxt.Text = idaripersoneloku["Soyad"].ToString();
                idaripersonelduzenlesoyadtxt.Text = idaripersoneloku["Email"].ToString();
                idaripersonelduzenletelefontxt.Text = idaripersoneloku["Telefon"].ToString();
                idaripersonelduzenleadresrtb.Text = idaripersoneloku["Adres"].ToString();
                idaripersonelduzenledurumcb.SelectedIndex = Convert.ToInt32(idaripersoneloku["Durum"]);
                idaripersonelduzenletctxt.Text = idaripersoneloku["TC"].ToString();
                idaripersonelduzenledtp.Value = Convert.ToDateTime(idaripersoneloku["DoğumTarihi"]).Date;
                idaripersonelduzenlebirimcb.SelectedValue = Convert.ToInt32(idaripersoneloku["BirimId"]);
                idaripersonelduzenlekullanıcıadtxt.Text = idaripersoneloku["KullanıcıAd"].ToString();
                idaripersonelduzenlesifretxt.Text = idaripersoneloku["Sifre"].ToString();

            }
            frm.baglanti.Close();
        }

        private void idaripersonelduzenlebtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update idaripersonel set Ad ='"+idaripersonelduzenleadtxt.Text+ "',Soyad='"+idaripersonelduzenlesoyadtxt.Text+ "',Email='" + idaripersonelduzenleemailtxt.Text + "',Telefon='" + idaripersonelduzenletelefontxt.Text + "',Adres='" + idaripersonelduzenleadresrtb.Text + "',Durum=" + idaripersonelduzenledurumcb.SelectedIndex + ",YetkiId=" + 2 + ",TC='" + idaripersonelduzenletctxt.Text + "',DoğumTarihi='" + (idaripersonelduzenledtp.Value.Day + "." + idaripersonelduzenledtp.Value.Month + "." + idaripersonelduzenledtp.Value.Year) + "',BirimId=" + (int)idaripersonelduzenlebirimcb.SelectedValue + " ,Birim='"+idaripersonelduzenlebirimcb.Text+ "',KullanıcıAd='" + idaripersonelduzenlekullanıcıadtxt.Text + "',Sifre='" + idaripersonelduzenlesifretxt.Text + "' where Id= " + idaripersonelId + " ";

            SqlCommand idaripersonelduzenle = new SqlCommand(sorgu, frm.baglanti);
            idaripersonelduzenle.ExecuteNonQuery();
            MessageBox.Show("İdari Personel Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        private void idaripersonelekleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idaripersonelsilbtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(idaripersonelduzenleadtxt.Text + " " + " Adlı İdari Personel Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "idaripersonelsil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("idaripersonelId", SqlDbType.Int).Value = idaripersonelId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("İdari Personel Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("İdari Personel İşlemi İptal Edildi");
            }
        }
    }
}

