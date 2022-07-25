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
    public partial class akademikpersonel : Form
    {
        public int kullaniciId2;
        public akademikpersonel()
        {
            InitializeComponent();
            kullaniciId2 = Form1.kullaniciId;
        }

        private void akademikpersonelCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void akademikpersonel_Load(object sender, EventArgs e)
        {
            akademikpersonelHeaderPanel.Size = new Size(this.Width, 80);
            akademikpersonelContentPanel.Size = new Size(this.Width, this.Height - 80);
            dersgetir();
            ogrenciderscbgetir();
            ogrencidoldur();
            akademikpersonelderscbgetir();
            sınavdoldur();
        }

        public void dersgetir()
        {
            

            //string sorgu2 = $"select Ders.Id ,Ders.DersAd,Ders.Kredi,Ders.Durum from Ders inner join AkademikPersonel on(Ders.AkademikPersonelId= AkademikPersonel.Id) where Ders.AkademikPersonelId={}";

            Form1 frm = new();
            frm.baglanti.Open();
            
            string sorgu2 = $"select Ders.Id ,Ders.DersAd,Ders.Kredi,Ders.Durum from Ders inner join AkademikPersonel on Ders.AkademikPersonelId=AkademikPersonel.Id where Ders.AkademikPersonelId={kullaniciId2}";
            DataTable tablo = new DataTable();

            SqlDataAdapter dersgetir = new SqlDataAdapter(sorgu2, frm.baglanti);

            dersgetir.Fill(tablo);

            akademikpersoneldersdgv.DataSource = tablo;

            frm.baglanti.Close();
        }

        public void ogrenciderscbgetir()
        {
            ogrenciderscb.Items.Clear();

            DataTable dt = new DataTable();

            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = $"select Id,DersAd from Ders where AkademikPersonelId={kullaniciId2} ";
            SqlCommand cagir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader oku = cagir.ExecuteReader();
            dt.Load(oku);
            
            ogrenciderscb.DisplayMember = "DersAd";
            ogrenciderscb.ValueMember = "Id";
            ogrenciderscb.DataSource = dt;

            frm.baglanti.Close();
        }

        public void akademikpersonelderscbgetir()
        {
            akademikpersonelderscb.Items.Clear();

            DataTable dt = new DataTable();

            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = $"select Id,DersAd from Ders where AkademikPersonelId={kullaniciId2} ";
            SqlCommand cagir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader oku = cagir.ExecuteReader();
            dt.Load(oku);

            akademikpersonelderscb.DisplayMember = "DersAd";
            akademikpersonelderscb.ValueMember = "Id";
            akademikpersonelderscb.DataSource = dt;

            frm.baglanti.Close();


        }

        public void sınavdoldur()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = $"select OgrenciBilgileri.Id as 'Id',OgrenciBilgileri.Ad as 'Ogrenci Adı',OgrenciBilgileri.Soyad as 'Ogrenci Soyadı',OgrenciBilgileri.ÖğrenciNo as 'Ogrenci No',Ders.DersAd as 'Ders Adı',Sınav.Vize as 'Vize Notu',Sınav.Final as 'Final Notu',Sınav.Bütünleme as 'Bütünleme Notu',Sınav.Durum as 'Durum',Sınav.Id as 'SınavId' from Sınav inner join OgrenciBilgileri on(OgrenciBilgileri.Id=Sınav.OgrenciId) inner join Ders on (Ders.Id=Sınav.DersId) where DersId = {akademikpersonelderscb.SelectedValue}";

            DataTable tablo = new DataTable();

            SqlDataAdapter sınavgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            sınavgetir.Fill(tablo);

            akademikpersonelsınavdgv.DataSource = tablo;

            frm.baglanti.Close();


        }
        public void ogrencidoldur()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu2 = $"select  OgrenciBilgileri.Ad as 'Ogrenci Adı',OgrenciBilgileri.Soyad as 'Ogrenci Soyadı',Ders.DersAd as 'Ders Adı' from OgrenciDers inner join OgrenciBilgileri on(OgrenciBilgileri.Id=OgrenciDers.OgrenciId) inner join Ders on (Ders.Id=OgrenciDers.DersId) where DersId = {ogrenciderscb.SelectedValue}";

            DataTable tablo = new DataTable();

            SqlDataAdapter dersgetir = new SqlDataAdapter(sorgu2, frm.baglanti);

            dersgetir.Fill(tablo);

            akademikpersoneldersogrencilistesidgv.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void ogrenciderscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogrencidoldur();
        }

        private void akademikpersonelderscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sınavdoldur();

        }

        private void akademikpersonelsınavdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            notekle notekle = new();

            notekle.dersId = (int)akademikpersonelderscb.SelectedValue;
            notekle.ogrenciad = akademikpersonelsınavdgv.CurrentRow.Cells[1].Value.ToString();
            notekle.dersad = akademikpersonelsınavdgv.CurrentRow.Cells[4].Value.ToString();
            notekle.Id = Convert.ToInt32(akademikpersonelsınavdgv.CurrentRow.Cells["SınavId"].Value.ToString());
            notekle.vizenotu = akademikpersonelsınavdgv.CurrentRow.Cells[5].Value.ToString();
            notekle.finalnotu = akademikpersonelsınavdgv.CurrentRow.Cells[6].Value.ToString();
            notekle.bütünlemenotu = akademikpersonelsınavdgv.CurrentRow.Cells[7].Value.ToString();

            notekle.ShowDialog();
        }

        private void ogrenciarabtn_Click(object sender, EventArgs e)
        {

        }
    }
}
