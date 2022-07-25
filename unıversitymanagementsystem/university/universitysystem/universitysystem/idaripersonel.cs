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
    public partial class idaripersonel : Form
    {
        public idaripersonel()
        {
            InitializeComponent();
        }

        private void idaripersonelCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ögrencigirisbtn_Click(object sender, EventArgs e)
        {
            ogrencibilgileri oblg = new ogrencibilgileri();
            oblg.ShowDialog();
        }

        private void personelbilgilerigirisbtn_Click(object sender, EventArgs e)
        {
            //personelbilgileri pblg = new personelbilgileri();
            //pblg.ShowDialog();
            personelbilgipanel.Visible = true;
        }

        private void digerbilgilereklebtn_Click(object sender, EventArgs e)
        {
            digerbilgilerpanel.Visible = true;
        }

        private void idaripersoneleklebtn_Click(object sender, EventArgs e)
        {
            idaripersonelekle idaripersonelekle = new();
            idaripersonelekle.ShowDialog();
        }

        private void akademikpersoneleklebtn_Click(object sender, EventArgs e)
        {
            akademikpersonelekle akademikpersonelekle = new();
            akademikpersonelekle.ShowDialog();
        }

        private void fakulteeklebtn_Click(object sender, EventArgs e)
        {
            fakulteekle fakulteekle = new();
            fakulteekle.ShowDialog();
        }

        private void bolumeklebtn_Click(object sender, EventArgs e)
        {
            bolumekle bolumekle = new();
            bolumekle.ShowDialog();
        }

        private void derseklemebtn_Click(object sender, EventArgs e)
        {
            dersekle dersekle = new();
            dersekle.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            personelbilgipanel.Visible = false;
            digerbilgilerpanel.Visible = false;
        }

        private void birimeklebtn_Click(object sender, EventArgs e)
        {
            birimekle birimekle = new();
            birimekle.ShowDialog();
        }

        private void unvaneklebtn_Click(object sender, EventArgs e)
        {
            Unvan unvan = new();
            unvan.ShowDialog();
        }
    }
}
