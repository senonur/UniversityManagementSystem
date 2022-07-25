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
    public partial class fakulteduzenle : Form
    {
        public int fakulteId=0;
        public fakulteduzenle()
        {
            InitializeComponent();
        }

        private void fakulteduzenle_Load(object sender, EventArgs e)
        {
            fakulteDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            fakulteDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultegetir(fakulteId);
        }

        public void fakultegetir(int Id)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from fakulte where Id=" + Id;

            SqlCommand yg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader fakulteoku = yg.ExecuteReader();
            if (fakulteoku.Read())
            {
                fakulteId = Convert.ToInt32(fakulteoku["Id"]);
                fakulteadduzenletxt.Text = fakulteoku["FakülteAd"].ToString();
                fakulteduzenledurumcb.SelectedIndex = Convert.ToInt32(fakulteoku["Durum"]);
                fakulteduzenleadresrtb.Text= fakulteoku["Adres"].ToString();
            }
            frm.baglanti.Close();
        }

        private void fakulteduzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fakültedüzenlebtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update fakulte set FakülteAd='" + fakulteadduzenletxt.Text + "', Durum=" + fakulteduzenledurumcb.SelectedIndex + ", Adres='" + fakulteduzenleadresrtb.Text + "' where Id= " + fakulteId + ""; ;

            SqlCommand fakulteduzenle = new SqlCommand(sorgu, frm.baglanti);
            fakulteduzenle.ExecuteNonQuery();
            MessageBox.Show("fakulte Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        private void fakültesilbtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(fakulteadduzenletxt.Text + " " + " Adlı Fakülte Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "fakultesil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("fakulteId", SqlDbType.Int).Value = fakulteId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("Fakülte Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fakülte İşlemi İptal Edildi");
            }
        }
    }
}
