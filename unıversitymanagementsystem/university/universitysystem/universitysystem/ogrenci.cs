using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universitysystem
{
    public partial class ogrenci : Form
    {
        public static int kullanıcıId3;
        public ogrenci()
        {
            InitializeComponent();
        }



        private void ogrencibelgebtn_Click(object sender, EventArgs e)
        {
            ogrencibelge obelge = new ogrencibelge();
            obelge.ShowDialog();
        }

        private void ogrenciderssecimibtn_Click(object sender, EventArgs e)
        {
            derssecimi drs = new derssecimi();
            drs.ShowDialog();
        }

        private void ogrenciderssinavlistesibtn_Click(object sender, EventArgs e)
        {
            derssinavlistesi dsl = new derssinavlistesi();
            dsl.ShowDialog();
        }

        private void ogrenciCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
