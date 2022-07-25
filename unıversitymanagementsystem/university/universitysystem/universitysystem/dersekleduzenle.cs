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
    public partial class dersekleduzenle : Form
    {
        public int dersId = 0;
        public dersekleduzenle()
        {
            InitializeComponent();
        }

        private void dersekleduzenle_Load(object sender, EventArgs e)
        {
            dersDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            dersDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultecbdoldur();
            bolumcbdoldur();
            akademikpersonelcbdoldur();
            dersgetir(dersId);
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

            dersduzenlefakulteadicb.DisplayMember = "FakülteAd";
            dersduzenlefakulteadicb.ValueMember = "Id";
            dersduzenlefakulteadicb.DataSource = tablo;

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

            dersduzenlefakultebolumadicb.DisplayMember = "BolumAd";
            dersduzenlefakultebolumadicb.ValueMember = "Id";
            dersduzenlefakultebolumadicb.DataSource = tablo;

            frm.baglanti.Close();
        }

        public void akademikpersonelcbdoldur()
        {
            Form1 frm = new Form1();
            frm.baglanti.Open();

            DataTable tablo = new DataTable("AkademikPersonel");
            string sorgu = "select Id,(Ad+' '+Soyad)as Ad from AkademikPersonel where Durum=1 ";
            SqlCommand akademikpersonelgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader akademikpersoneloku = akademikpersonelgetir.ExecuteReader();
            tablo.Load(akademikpersoneloku);

            dersduzenleakademikpersoneladcb.DisplayMember = "Ad";
            dersduzenleakademikpersoneladcb.ValueMember = "Id";
            dersduzenleakademikpersoneladcb.DataSource = tablo;

            frm.baglanti.Close();
        }

        public void dersgetir(int Id)
        {

            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from Ders where Id=" + Id;

            SqlCommand yg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader dersoku = yg.ExecuteReader();
            if (dersoku.Read())
            {
                dersId = Convert.ToInt32(dersoku["Id"]);
                dersduzenlefakultebolumderstxt.Text = dersoku["DersAd"].ToString();
                dersduzenlefakulteadicb.SelectedValue = dersoku["FakülteId"].ToString();
                dersduzenlefakultebolumadicb.SelectedValue = dersoku["BölümId"].ToString();
                dersduzenlederskredinud.Value = Convert.ToInt32(dersoku["Kredi"]);
                dersduzenleakademikpersoneladcb.SelectedValue = dersoku["AkademikPersonelId"].ToString();
                dersduzenlefakultedersdurumcb.SelectedIndex= Convert.ToInt32(dersoku["Durum"]);
                
            }
            frm.baglanti.Close();
        }

        private void dersdüzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dersdüzenlebtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update Ders set DersAd='" +dersduzenlefakultebolumderstxt.Text+ "',FakülteId=" + (int)dersduzenlefakulteadicb.SelectedValue + ",BölümId="+(int)dersduzenlefakultebolumadicb.SelectedValue+",Kredi="+dersduzenlederskredinud.Value+ ",AkademikPersonelId=" +(int)dersduzenleakademikpersoneladcb.SelectedValue+",Durum=" + dersduzenlefakultedersdurumcb.SelectedIndex + ",AkademikPersonel='"+ dersduzenleakademikpersoneladcb.Text + "'  where Id= " + dersId + "";

            SqlCommand dersduzenle = new SqlCommand(sorgu, frm.baglanti);
            dersduzenle.ExecuteNonQuery();
            MessageBox.Show("Ders Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        private void derssilbtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(dersduzenlefakulteadicb.Text + " Adlı Fakültedeki " + dersduzenlefakultebolumadicb.Text + " Adlı Bölümdeki " + dersduzenlefakultebolumderstxt.Text+ " Adlı Dersi Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "derssil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("dersId", SqlDbType.Int).Value = dersId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("Ders Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ders İşlemi İptal Edildi");
            }
        }
    }
}
