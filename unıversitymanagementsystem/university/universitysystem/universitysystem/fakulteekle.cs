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
    public partial class fakulteekle : Form
    {
        public fakulteekle()
        {
            InitializeComponent();
        }

        private void fakülteekleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fakulteeklebtn_Click(object sender, EventArgs e)
        {
            if (fakulteaditxt.Text != "" && fakultedurumcbx.SelectedIndex != -1 && fakulteadresrtb.Text != "")
            {

                Form1 frm = new Form1();
                frm.baglanti.Open();
                string sorgu= "insert into fakulte(FakülteAd,Durum,Adres) values('" + fakulteaditxt.Text + "'," + fakultedurumcbx.SelectedIndex + ",'" + fakulteadresrtb.Text + "')";
                SqlCommand fakulteekle = new SqlCommand(sorgu, frm.baglanti);

                fakulteekle.ExecuteNonQuery();

                MessageBox.Show("Fakülte Ekleme Başarılı");

                fakulteaditxt.Clear();
                fakultedurumcbx.SelectedIndex = -1;
                fakulteadresrtb.Clear();

                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz");
            }
        }

        private void fakulteekle_Load(object sender, EventArgs e)
        {
            fakulteekleHeaderPanel.Size = new Size(this.Width, 80);
            fakulteekleContentPanel.Size = new Size(this.Width, this.Height - 80);
            fakultetablodoldur();
        }

        public void fakultetablodoldur()
        {

            Form1 frm = new();
            frm.baglanti.Open();

            string sorgu = "select * from fakulte";
            DataTable tablo = new DataTable();

            SqlDataAdapter fakultegetir = new SqlDataAdapter(sorgu, frm.baglanti);

            fakultegetir.Fill(tablo);

            fakultedgv.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void fakultedgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fakulteduzenle fdznl = new();
            fdznl.fakulteId = Convert.ToInt32(fakultedgv.CurrentRow.Cells["Id"].Value);
            fdznl.ShowDialog();
        }

        private void aramatemizlebtn_Click(object sender, EventArgs e)
        {
            fakultetablodoldur();
        }
    }
}
