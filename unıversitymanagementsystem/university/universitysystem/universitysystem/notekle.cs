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
    public partial class notekle : Form
    {

        public int dersId = 0;
        public string ogrenciad;
        public string dersad;
        public int Id = 0;
        public string vizenotu;
        public string finalnotu;
        public string bütünlemenotu;
        public string hartnotuortalama;
        public string harfnotu;

        public notekle()
        {
            InitializeComponent();
        }

        private void sınavnotduzenlecıkısbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notekle_Load(object sender, EventArgs e)
        {
            notDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            notDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            notogrenciadtxt.Text = ogrenciad;
            notdersadıtxt.Text = dersad;
            notvizetxt.Text = vizenotu;
            notfinaltxt.Text = finalnotu;
            notbutunlemetxt.Text = bütünlemenotu;
            
            
        }

        public void notortalama(int vn,int fn,int bn)
        {
            double ho = Convert.ToDouble(hartnotuortalama);
            //int vn = Convert.ToInt32(vizenotu);
            vn = Convert.ToInt32(vizenotu);
            fn = Convert.ToInt32(finalnotu);
            bn = Convert.ToInt32(bütünlemenotu);

            if (vizenotu != "" && finalnotu != "" && bütünlemenotu == "")
            {
                ho = (vn * 0.4) + (fn * 0.6);
            }

            else if (vizenotu != "" && finalnotu != "" && bütünlemenotu != "") // else if 
            {

                ho = (vn * 0.4) + (bn * 0.6);
            }

            if (ho < 35)
            {
                harfnotu = "FF";
            }

            else if (ho >= 40 && ho <= 49)
            {

                harfnotu = "FD";
            }

            else if (ho >= 50 && ho <= 57)
            {

                harfnotu = "DD";
            }
            else if (ho >= 58 && ho <= 64)
            {

                harfnotu = "DC";
            }
            else if (ho >= 65 && ho <= 74)
            {

                harfnotu = "CC";
            }
            else if (ho >= 75 && ho <= 79)
            {

                harfnotu = "CB";
            }
            else if (ho >= 80 && ho <= 84)
            {

                harfnotu = "BB";
            }
            else if (ho >= 85 && ho <= 89)
            {

                harfnotu = "BA";
            }
            else if (ho >= 90 && ho <= 100)
            {

                harfnotu = "AA";
            }
        }

        private void sınavnotkayıtbtn_Click(object sender, EventArgs e)
        {
            //akademikpersonel akademikpersonel = new();
            //akademikpersonel.sınavdoldur();

            if (notogrenciadtxt.Text != "" && notdersadıtxt.Text != "" && notdurumcb.SelectedIndex != -1 && notvizetxt.Text != "" && notfinaltxt.Text != "" && notbutunlemetxt.Text != "")
            {
                Form1 frm = new();
                frm.baglanti.Open();
                string sorgu = "update Sınav set Vize='" + notvizetxt.Text + "',Final='" + notfinaltxt.Text + "',Bütünleme='" + notbutunlemetxt.Text + "',Harfnotu='"+ harfnotu + "',Durum='" + notdurumcb.SelectedIndex + "' where Id =" + Id;

                SqlCommand notduzenle = new SqlCommand(sorgu, frm.baglanti);
                notduzenle.ExecuteNonQuery();
                MessageBox.Show("Not Ekleme Başarılı");
                notogrenciadtxt.Clear();
                notdersadıtxt.Clear();
                frm.baglanti.Close();

            }

            notortalama(Convert.ToInt32(vizenotu), Convert.ToInt32(finalnotu), Convert.ToInt32(bütünlemenotu));

            //if (notogrenciadtxt.Text != "" && notdersadıtxt.Text != "" && notdurumcb.SelectedIndex != -1 && notvizetxt.Text != "" && notfinaltxt.Text != "" && notbutunlemetxt.Text != "")
            //{

            //    Form1 frm = new();
            //    frm.baglanti.Open();
            //    //string sorgu = "insert into Not SınavId="+Id+",

            //    SqlCommand harfnotugonder = new SqlCommand(sorgu, frm.baglanti);
            //    harfnotugonder.ExecuteNonQuery();


            //    frm.baglanti.Close();
            //    MessageBox.Show("Not Ekleme Başarılı");

            //}


        }
    }
}
