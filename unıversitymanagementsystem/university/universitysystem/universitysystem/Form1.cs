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
    public partial class Form1 : Form
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BB8SAL2;Initial Catalog=universitymanagement;Integrated Security=True");
        string KullaniciAdi = "";
        string Sifre = "";
        public static int yetkiId;
        public static int kullaniciId = 0;
        public static int fakulteId = 0;
        public static int bolumId = 0;
        bool durum = false;
        derssecimi drs = new();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //kullanıcıgirispnl.Location = new Point(Width / 2 - 400, Height / 2 - 150);
            
        }



        private void cıkısbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            KullaniciAdi = kullaniciaditxt.Text;
            Sifre = kullanicisifretxt.Text;

            baglanti.Open();
            if (KullaniciAdi != "" && Sifre != "")
            {
                SqlCommand giriskontrol = new SqlCommand("select * from Kullanicilar where KullaniciAd='" + KullaniciAdi + "' and Sifre='" + Sifre + "'", baglanti);
                SqlDataReader verioku = giriskontrol.ExecuteReader();
                if (verioku.Read())
                {
                    yetkiId = Convert.ToInt32(verioku["YetkiId"]);
                    durum = true;

                }
                else
                {

                    MessageBox.Show("Girilen Bilgiler Uyuşmuyor.\nLütfen Tekrar Deneyiniz", "universitymanagement", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                baglanti.Close();
                if (durum == true)
                {
                    if (yetkiId == 1)
                    {
                        baglanti.Open();
                        SqlCommand command = new SqlCommand("select * from Kullanicilar inner join OgrenciBilgileri on (OgrenciBilgileri.Id=Kullanicilar.ogrenciId)   where Kullanicilar.KullaniciAd='" + KullaniciAdi + "' and Kullanicilar.Sifre='" + Sifre + "'", baglanti);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            kullaniciId = (int)reader["ogrenciId"];
                            drs.ogrenciId = kullaniciId;
                            fakulteId = (int)reader["FakülteId"];
                            bolumId= (int)reader["BölümId"];
                        }
                        baglanti.Close();
                        ogrenci ogrenci = new ogrenci();
                        kullaniciaditxt.Visible = false;
                        kullanicisifretxt.Visible = false;
                        girisbtn.Visible = false;
                        MessageBox.Show("Giriş Başarılı", "universitymanagement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ogrenci.ShowDialog();
                    }
                    else if (yetkiId == 2)
                    {

                        idaripersonel idaripersonel = new();
                        kullaniciaditxt.Visible = false;
                        kullanicisifretxt.Visible = false;
                        girisbtn.Visible = false;
                        MessageBox.Show("Giriş Başarılı", "universitymanagement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idaripersonel.ShowDialog();

                    }
                    else if (yetkiId == 3)
                    {

                        baglanti.Open();
                        SqlCommand command = new SqlCommand("select * from Kullanicilar where KullaniciAd='" + KullaniciAdi + "' and Sifre='" + Sifre + "'", baglanti);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            kullaniciId = (int)reader["AkademikPersonelId"];
                        }
                        baglanti.Close();
                        akademikpersonel akademikpersonel = new();
                        kullaniciaditxt.Visible = false;
                        kullanicisifretxt.Visible = false;
                        girisbtn.Visible = false;
                        MessageBox.Show("Giriş Başarılı", "universitymanagement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        akademikpersonel.Show();

                    }

                }
            }
            else
            {

                MessageBox.Show("Giriş Bilgileri Eksik", "universitymanagement", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış İşlemi Başarılı", "universitymanagement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            girisbtn.Visible = true;
            kullaniciaditxt.Visible = true;
            kullanicisifretxt.Visible = true;
            kullaniciaditxt.Clear();
            kullanicisifretxt.Clear();
        }


    }
}
