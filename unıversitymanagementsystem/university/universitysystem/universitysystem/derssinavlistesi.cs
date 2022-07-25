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
    public partial class derssinavlistesi : Form
    {
        public int kullanıcıId3;
        public derssinavlistesi()
        {
            InitializeComponent();
            kullanıcıId3 = Form1.kullaniciId;
        }

        private void ogrenciCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void derssinavlistesi_Load(object sender, EventArgs e)
        {
            ogrencidersdgv.Size = new Size(dersinavlistesipanel.Width / 2, dersinavlistesipanel.Height);
            ogrencisınavdgv.Size = new Size(dersinavlistesipanel.Width / 2, dersinavlistesipanel.Height);
            dersgetir();
            sınavgetir();
        }

        public void dersgetir()
        {

            Form1 frm = new();
            frm.baglanti.Open();

            //string sorgu = $"select * from OgrenciDers where OgrenciId={kullanıcıId3}";

            //string sorgu2 = $"select Ders.Id ,Ders.DersAd,Ders.Kredi,Ders.Durum from Ders inner join AkademikPersonel on Ders.AkademikPersonelId=AkademikPersonel.Id where Ders.AkademikPersonelId={kullaniciId2}";

            string sorgu = $"select OgrenciBilgileri.Ad as 'Ogrenci Adı',OgrenciBilgileri.Soyad as 'Ogrenci Soyadı',Ders.DersAd as 'Ders Adı' ,Harfnotu as 'Harf Notu' from OgrenciDers inner join OgrenciBilgileri on (OgrenciBilgileri.Id = OgrenciDers.OgrenciId) inner join Ders on (Ders.Id = OgrenciDers.DersId) where OgrenciId={kullanıcıId3} ";
            DataTable tablo = new DataTable();

            SqlDataAdapter dersgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            dersgetir.Fill(tablo);

            ogrencidersdgv.DataSource = tablo;

            frm.baglanti.Close();

        }

        public void sınavgetir()
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = $"select OgrenciBilgileri.Ad as 'Öğrenci Ad' ,OgrenciBilgileri.Soyad as 'Öğrenci Soyad', Ders.DersAd as 'Ders Adı', Sınav.Vize as 'Vize Notu',Sınav.Final as 'Final Notu', Sınav.Bütünleme as 'Bütünleme Notu', Sınav.Durum as 'Durum'  from Sınav inner join OgrenciBilgileri on (OgrenciBilgileri.Id = Sınav.OgrenciId) inner join Ders on (Ders.Id = Sınav.DersId) where OgrenciId={kullanıcıId3} ";
            DataTable tablo = new DataTable();

            SqlDataAdapter dersgetir = new SqlDataAdapter(sorgu, frm.baglanti);

            dersgetir.Fill(tablo);

            ogrencisınavdgv.DataSource = tablo;

            frm.baglanti.Close();

        }
    }
}
