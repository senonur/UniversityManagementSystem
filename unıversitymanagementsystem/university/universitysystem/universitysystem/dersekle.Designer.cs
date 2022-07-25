
namespace universitysystem
{
    partial class dersekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dersekledgv = new System.Windows.Forms.DataGridView();
            this.fakultedersdurumcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fakulteadicb = new System.Windows.Forms.ComboBox();
            this.derseklebtn = new System.Windows.Forms.Button();
            this.lbl_idariidarisim = new System.Windows.Forms.Label();
            this.fakultebolumadicb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fakultebolumderstxt = new System.Windows.Forms.TextBox();
            this.dersekleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.dersekleCikisBtn = new System.Windows.Forms.Button();
            this.dersekleContentPanel = new System.Windows.Forms.Panel();
            this.bilgitakippnl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.akademikpersoneladtxt = new System.Windows.Forms.TextBox();
            this.aramatemizlebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dersArabtn = new System.Windows.Forms.Button();
            this.dersadıtxt = new System.Windows.Forms.TextBox();
            this.akademikpersoneladcb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.derskredinud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dersekledgv)).BeginInit();
            this.dersekleHeaderPanel.SuspendLayout();
            this.dersekleContentPanel.SuspendLayout();
            this.bilgitakippnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derskredinud)).BeginInit();
            this.SuspendLayout();
            // 
            // dersekledgv
            // 
            this.dersekledgv.AllowUserToAddRows = false;
            this.dersekledgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersekledgv.Location = new System.Drawing.Point(350, 70);
            this.dersekledgv.Name = "dersekledgv";
            this.dersekledgv.RowTemplate.Height = 25;
            this.dersekledgv.Size = new System.Drawing.Size(644, 251);
            this.dersekledgv.TabIndex = 95;
            this.dersekledgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dersekledgv_CellDoubleClick);
            // 
            // fakultedersdurumcb
            // 
            this.fakultedersdurumcb.FormattingEnabled = true;
            this.fakultedersdurumcb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.fakultedersdurumcb.Location = new System.Drawing.Point(150, 233);
            this.fakultedersdurumcb.Name = "fakultedersdurumcb";
            this.fakultedersdurumcb.Size = new System.Drawing.Size(194, 23);
            this.fakultedersdurumcb.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 93;
            this.label2.Text = "Durum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Bölüm Adı:";
            // 
            // fakulteadicb
            // 
            this.fakulteadicb.FormattingEnabled = true;
            this.fakulteadicb.Location = new System.Drawing.Point(151, 3);
            this.fakulteadicb.Name = "fakulteadicb";
            this.fakulteadicb.Size = new System.Drawing.Size(193, 23);
            this.fakulteadicb.TabIndex = 91;
            // 
            // derseklebtn
            // 
            this.derseklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.derseklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.derseklebtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.derseklebtn.ForeColor = System.Drawing.Color.White;
            this.derseklebtn.Location = new System.Drawing.Point(11, 272);
            this.derseklebtn.Name = "derseklebtn";
            this.derseklebtn.Size = new System.Drawing.Size(333, 49);
            this.derseklebtn.TabIndex = 90;
            this.derseklebtn.Text = "Ders Ekle";
            this.derseklebtn.UseVisualStyleBackColor = false;
            this.derseklebtn.Click += new System.EventHandler(this.derseklebtn_Click);
            // 
            // lbl_idariidarisim
            // 
            this.lbl_idariidarisim.AutoSize = true;
            this.lbl_idariidarisim.Location = new System.Drawing.Point(11, 6);
            this.lbl_idariidarisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idariidarisim.Name = "lbl_idariidarisim";
            this.lbl_idariidarisim.Size = new System.Drawing.Size(69, 15);
            this.lbl_idariidarisim.TabIndex = 88;
            this.lbl_idariidarisim.Text = "Fakülte Adı:";
            // 
            // fakultebolumadicb
            // 
            this.fakultebolumadicb.FormattingEnabled = true;
            this.fakultebolumadicb.Location = new System.Drawing.Point(150, 46);
            this.fakultebolumadicb.Name = "fakultebolumadicb";
            this.fakultebolumadicb.Size = new System.Drawing.Size(194, 23);
            this.fakultebolumadicb.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Ders Adı:";
            // 
            // fakultebolumderstxt
            // 
            this.fakultebolumderstxt.Location = new System.Drawing.Point(150, 89);
            this.fakultebolumderstxt.Name = "fakultebolumderstxt";
            this.fakultebolumderstxt.Size = new System.Drawing.Size(194, 23);
            this.fakultebolumderstxt.TabIndex = 98;
            // 
            // dersekleHeaderPanel
            // 
            this.dersekleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.dersekleHeaderPanel.Controls.Add(this.dersekleCikisBtn);
            this.dersekleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dersekleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.dersekleHeaderPanel.Name = "dersekleHeaderPanel";
            this.dersekleHeaderPanel.Size = new System.Drawing.Size(1002, 61);
            this.dersekleHeaderPanel.TabIndex = 99;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(11, 9);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(100, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Ders Ekle";
            // 
            // dersekleCikisBtn
            // 
            this.dersekleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.dersekleCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dersekleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dersekleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.dersekleCikisBtn.Location = new System.Drawing.Point(962, 3);
            this.dersekleCikisBtn.Name = "dersekleCikisBtn";
            this.dersekleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.dersekleCikisBtn.TabIndex = 5;
            this.dersekleCikisBtn.Text = "X";
            this.dersekleCikisBtn.UseVisualStyleBackColor = false;
            this.dersekleCikisBtn.Click += new System.EventHandler(this.dersekleCikisBtn_Click);
            // 
            // dersekleContentPanel
            // 
            this.dersekleContentPanel.Controls.Add(this.bilgitakippnl);
            this.dersekleContentPanel.Controls.Add(this.akademikpersoneladcb);
            this.dersekleContentPanel.Controls.Add(this.label5);
            this.dersekleContentPanel.Controls.Add(this.derskredinud);
            this.dersekleContentPanel.Controls.Add(this.label4);
            this.dersekleContentPanel.Controls.Add(this.dersekledgv);
            this.dersekleContentPanel.Controls.Add(this.lbl_idariidarisim);
            this.dersekleContentPanel.Controls.Add(this.fakultebolumderstxt);
            this.dersekleContentPanel.Controls.Add(this.derseklebtn);
            this.dersekleContentPanel.Controls.Add(this.label3);
            this.dersekleContentPanel.Controls.Add(this.fakulteadicb);
            this.dersekleContentPanel.Controls.Add(this.fakultebolumadicb);
            this.dersekleContentPanel.Controls.Add(this.label1);
            this.dersekleContentPanel.Controls.Add(this.label2);
            this.dersekleContentPanel.Controls.Add(this.fakultedersdurumcb);
            this.dersekleContentPanel.Location = new System.Drawing.Point(0, 68);
            this.dersekleContentPanel.Name = "dersekleContentPanel";
            this.dersekleContentPanel.Size = new System.Drawing.Size(998, 331);
            this.dersekleContentPanel.TabIndex = 100;
            // 
            // bilgitakippnl
            // 
            this.bilgitakippnl.Controls.Add(this.label6);
            this.bilgitakippnl.Controls.Add(this.akademikpersoneladtxt);
            this.bilgitakippnl.Controls.Add(this.aramatemizlebtn);
            this.bilgitakippnl.Controls.Add(this.label8);
            this.bilgitakippnl.Controls.Add(this.dersArabtn);
            this.bilgitakippnl.Controls.Add(this.dersadıtxt);
            this.bilgitakippnl.Location = new System.Drawing.Point(350, 6);
            this.bilgitakippnl.Name = "bilgitakippnl";
            this.bilgitakippnl.Size = new System.Drawing.Size(645, 61);
            this.bilgitakippnl.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Akademik Personel Adı";
            // 
            // akademikpersoneladtxt
            // 
            this.akademikpersoneladtxt.Location = new System.Drawing.Point(115, 28);
            this.akademikpersoneladtxt.Name = "akademikpersoneladtxt";
            this.akademikpersoneladtxt.Size = new System.Drawing.Size(163, 23);
            this.akademikpersoneladtxt.TabIndex = 8;
            // 
            // aramatemizlebtn
            // 
            this.aramatemizlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aramatemizlebtn.Location = new System.Drawing.Point(540, 14);
            this.aramatemizlebtn.Name = "aramatemizlebtn";
            this.aramatemizlebtn.Size = new System.Drawing.Size(99, 37);
            this.aramatemizlebtn.TabIndex = 5;
            this.aramatemizlebtn.Text = "Arama Temizle";
            this.aramatemizlebtn.UseVisualStyleBackColor = true;
            this.aramatemizlebtn.Click += new System.EventHandler(this.aramatemizlebtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ders Adı";
            // 
            // dersArabtn
            // 
            this.dersArabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dersArabtn.Location = new System.Drawing.Point(435, 14);
            this.dersArabtn.Name = "dersArabtn";
            this.dersArabtn.Size = new System.Drawing.Size(99, 37);
            this.dersArabtn.TabIndex = 2;
            this.dersArabtn.Text = "Ders Ara";
            this.dersArabtn.UseVisualStyleBackColor = true;
            this.dersArabtn.Click += new System.EventHandler(this.dersArabtn_Click);
            // 
            // dersadıtxt
            // 
            this.dersadıtxt.Location = new System.Drawing.Point(9, 28);
            this.dersadıtxt.Name = "dersadıtxt";
            this.dersadıtxt.Size = new System.Drawing.Size(100, 23);
            this.dersadıtxt.TabIndex = 1;
            // 
            // akademikpersoneladcb
            // 
            this.akademikpersoneladcb.FormattingEnabled = true;
            this.akademikpersoneladcb.Location = new System.Drawing.Point(150, 138);
            this.akademikpersoneladcb.Name = "akademikpersoneladcb";
            this.akademikpersoneladcb.Size = new System.Drawing.Size(194, 23);
            this.akademikpersoneladcb.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 101;
            this.label5.Text = "Akademik Personel Adı:";
            // 
            // derskredinud
            // 
            this.derskredinud.Location = new System.Drawing.Point(150, 185);
            this.derskredinud.Name = "derskredinud";
            this.derskredinud.Size = new System.Drawing.Size(194, 23);
            this.derskredinud.TabIndex = 100;
            this.derskredinud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "Ders Kredisi:";
            // 
            // dersekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 409);
            this.Controls.Add(this.dersekleContentPanel);
            this.Controls.Add(this.dersekleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dersekle";
            this.Text = "dersekle";
            this.Load += new System.EventHandler(this.dersekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersekledgv)).EndInit();
            this.dersekleHeaderPanel.ResumeLayout(false);
            this.dersekleHeaderPanel.PerformLayout();
            this.dersekleContentPanel.ResumeLayout(false);
            this.dersekleContentPanel.PerformLayout();
            this.bilgitakippnl.ResumeLayout(false);
            this.bilgitakippnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derskredinud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dersekledgv;
        private System.Windows.Forms.ComboBox fakultedersdurumcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fakulteadicb;
        private System.Windows.Forms.Button derseklebtn;
        private System.Windows.Forms.Label lbl_idariidarisim;
        private System.Windows.Forms.ComboBox fakultebolumadicb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fakultebolumderstxt;
        private System.Windows.Forms.Panel dersekleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button dersekleCikisBtn;
        private System.Windows.Forms.Panel dersekleContentPanel;
        private System.Windows.Forms.NumericUpDown derskredinud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox akademikpersoneladcb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel bilgitakippnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox akademikpersoneladtxt;
        private System.Windows.Forms.Button aramatemizlebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dersArabtn;
        private System.Windows.Forms.TextBox dersadıtxt;
    }
}