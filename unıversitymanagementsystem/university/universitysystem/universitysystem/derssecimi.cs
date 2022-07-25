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
    public partial class derssecimi : Form
    {
        List<int> kredilist = new List<int>();

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int kredi = 0;
        public int ogrenciId = 0;
        public derssecimi()
        {
            InitializeComponent();
            dersgetir();
        }

        private void derssecimiCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dersgetir()
        {
            con = new SqlConnection("Data Source=DESKTOP-BB8SAL2;Initial Catalog=universitymanagement;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            //cmd.CommandText = "select * FROM Ders";
            //cmd.CommandText = "select Ders.Id as 'DersId' , Ders.DersAd as 'DersAdı' ,Ders.Kredi as 'DersKredisi' ,OgrenciDers.ÖğrenciId as 'ÖğrenciId' from Ders inner join OgrenciDers on Ders.Id = OgrenciDers.DersId";

            //cmd.CommandText = " select Ders.Id as 'DersID', Ders.DersAd as 'DersAdı', Ders.Kredi as 'DersKredisi' from Ders";

            //cmd.CommandText = $"select Ders.Id as 'DersId' , Ders.DersAd as 'DersAdı' ,Ders.FakülteId 'FakülteId',Ders.BölümId as 'BölümId',Ders.Kredi as 'DersKredisi', Ders.Durum as 'Durum' from Ders inner join OgrenciBilgileri on Ders.OgrenciDersId = OgrenciBilgileri.Id  where OgrenciBilgileri.FakülteId=  {Form1.fakulteId} and  OgrenciBilgileri.BölümId=  {Form1.bolumId}";

            cmd.CommandText = $"select Ders.Id as 'DersId' , Ders.DersAd as 'DersAdı' ,Ders.FakülteId 'FakülteId',Ders.BölümId as 'BölümId',Ders.Kredi as 'DersKredisi', Ders.Durum as 'Durum' from Ders where Ders.FakülteId= {Form1.fakulteId} and  Ders.BölümId=  {Form1.bolumId}";



            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secilecekderslerlb.Items.Add(dr[0] + "-Ders Adı: " + dr[1] + "Kredi: " + dr[4]);
                kredilist.Add(Convert.ToInt32(dr[4]));


            }
            con.Close();

        }

        private void SEC_Click(object sender, EventArgs e)
        {
            if (secilecekderslerlb.SelectedIndex != -1)
            {
                if (secilenderslerlb.Items.Count != 0)
                {
                    if (secilenderslerlb.Items.Contains(secilecekderslerlb.SelectedItem))
                    {
                        MessageBox.Show("Dersi Seçtiniz.Tekrar Seçim yapamazsınız");
                    }
                    else
                    {
                        kredi += kredilist[secilecekderslerlb.SelectedIndex];
                        if (kredi <= 30)
                        {
                            secilenderslerlb.Items.Add(secilecekderslerlb.SelectedItem);
                            toplamkredilbl.Text = "30" + "/" + kredilist[secilecekderslerlb.SelectedIndex];
                            secilecekderslerlb.SelectedIndex = -1;



                        }
                        else
                        {
                            kredi -= kredilist[secilecekderslerlb.SelectedIndex];
                            MessageBox.Show("Toplam Kredi Otuzu Geçemez.");
                            toplamkredilbl.Text = "30" + "/" + kredi;
                        }
                    }
                }
                else
                {
                    secilenderslerlb.Items.Add(secilecekderslerlb.SelectedItem);
                    kredi += kredilist[secilecekderslerlb.SelectedIndex];
                }
            }
            toplamkredilbl.Text = "30" + "/" + kredi;
        }

        private void BIRAK_Click(object sender, EventArgs e)
        {
            if (secilenderslerlb.SelectedIndex != -1)
            {


                kredi -= kredilist[secilenderslerlb.SelectedIndex];
                secilenderslerlb.Items.RemoveAt(secilenderslerlb.SelectedIndex);
                toplamkredilbl.Text = "30" + "/" + kredi;
            }
            else
            {
                MessageBox.Show(" sectiginiz derslerden birini seçin ");
            }

        }

        public void derscagır(int ogrenciId, int dersId)
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "insert into OgrenciDers(OgrenciId,DersId,Durum) values(" + ogrenciId + "," + dersId + ",1) ";
            

            SqlCommand ogrenciekle = new SqlCommand(sorgu, frm.baglanti);
            ogrenciekle.ExecuteNonQuery();

            MessageBox.Show("Ders Ekleme Başarılı");

            frm.baglanti.Close();
        }

        public void sınavgonder(int ogrenciId, int dersId)
        {
            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "insert into Sınav(OgrenciId,DersId,Vize,Final,Bütünleme,Durum) values(" + ogrenciId + "," + dersId + ",0,0,0,1) ";


            SqlCommand sınavekle = new SqlCommand(sorgu, frm.baglanti);
            sınavekle.ExecuteNonQuery();

            

            frm.baglanti.Close();

        }

        private void ogrenciderssecbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in secilenderslerlb.Items)
            {
                
                string[] srg = item.ToString().Split('-');


                derscagır(Form1.kullaniciId, Convert.ToInt32(srg[0]));
                sınavgonder(Form1.kullaniciId, Convert.ToInt32(srg[0]));

            }

            
            //string secilenders = secilenderslerlb.Text;
            //string[] srg = secilenders.Split(' ');
            //for (int i = 0; i < srg.Length; i++)
            //{
            //    Console.WriteLine("Deger: []", srg[i]);
            //}




            //foreach (var item in secilecekderslerlb.Items)
            //{
            //    string sorgu = "insert into Ders(DersAd,FakülteId,BölümId,Kredi,AkademikPersonelId,Durum,AkademikPersonel) values ()"
            //}
        }
    }
}
