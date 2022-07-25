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
    public partial class bolumekleduzenle : Form
    {
        public int bolumId = 0;
        public int fakulteId = 0;
        public bolumekleduzenle()
        {
            InitializeComponent();
        }

        private void bolumekleduzenle_Load(object sender, EventArgs e)
        {
            bölümDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            bölümDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultecbdoldur();
            bolumgetir(bolumId);
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

            bolumduzenlefakulteadcb.DisplayMember = "FakülteAd";
            bolumduzenlefakulteadcb.ValueMember = "Id";
            bolumduzenlefakulteadcb.DataSource = tablo;

            frm.baglanti.Close();
        }

        public void bolumgetir(int Id)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from bolum where Id=" + Id;

            SqlCommand yg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader bolumoku = yg.ExecuteReader();
            if (bolumoku.Read())
            {
                bolumId = Convert.ToInt32(bolumoku["Id"]);
                bolumduzenlefakulteadcb.SelectedValue = bolumoku["FakülteId"].ToString();
                bolumduzenlebolumadtxt.Text = bolumoku["BolumAd"].ToString();
                bolumduzenledurumcb.SelectedIndex = Convert.ToInt32(bolumoku["Durum"]);
            }
            frm.baglanti.Close();

        }

        private void bolumduzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bölümdüzenlebtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update bolum set FakülteId=" + (int)bolumduzenlefakulteadcb.SelectedValue + ",BolumAd='"+bolumduzenlebolumadtxt.Text+"', Durum=" + bolumduzenledurumcb.SelectedIndex + "  where Id= " + bolumId + ""; ;

            SqlCommand bolumduzenle = new SqlCommand(sorgu, frm.baglanti);
            bolumduzenle.ExecuteNonQuery();
            MessageBox.Show("Bölüm Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        private void bölümsilbtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(bolumduzenlefakulteadcb.Text + " Adlı Fakültedeki " + bolumduzenlebolumadtxt.Text + " Adlı Bölüm Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "bolumsil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("bolumId", SqlDbType.Int).Value = bolumId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("Bölüm Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bölüm İşlemi İptal Edildi");
            }
        }
    }
}
