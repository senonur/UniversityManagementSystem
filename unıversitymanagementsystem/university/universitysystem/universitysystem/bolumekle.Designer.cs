
namespace universitysystem
{
    partial class bolumekle
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
            this.bolumeklebtn = new System.Windows.Forms.Button();
            this.lbl_idariidarisim = new System.Windows.Forms.Label();
            this.fakultebolumadıtxt = new System.Windows.Forms.TextBox();
            this.fakultebolumcb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fakultebolumdurumcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bolumdgv = new System.Windows.Forms.DataGridView();
            this.bolumekleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.bolumekleCikisBtn = new System.Windows.Forms.Button();
            this.bolumekleContentPanel = new System.Windows.Forms.Panel();
            this.bilgitakippnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bölümadaramatxt = new System.Windows.Forms.TextBox();
            this.aramatemizlebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bolumArabtn = new System.Windows.Forms.Button();
            this.fakulteadaramatxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bolumdgv)).BeginInit();
            this.bolumekleHeaderPanel.SuspendLayout();
            this.bolumekleContentPanel.SuspendLayout();
            this.bilgitakippnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bolumeklebtn
            // 
            this.bolumeklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bolumeklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bolumeklebtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bolumeklebtn.ForeColor = System.Drawing.Color.White;
            this.bolumeklebtn.Location = new System.Drawing.Point(11, 159);
            this.bolumeklebtn.Name = "bolumeklebtn";
            this.bolumeklebtn.Size = new System.Drawing.Size(314, 49);
            this.bolumeklebtn.TabIndex = 82;
            this.bolumeklebtn.Text = "Bölüm Ekle";
            this.bolumeklebtn.UseVisualStyleBackColor = false;
            this.bolumeklebtn.Click += new System.EventHandler(this.bolumeklebtn_Click);
            // 
            // lbl_idariidarisim
            // 
            this.lbl_idariidarisim.AutoSize = true;
            this.lbl_idariidarisim.Location = new System.Drawing.Point(11, 12);
            this.lbl_idariidarisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idariidarisim.Name = "lbl_idariidarisim";
            this.lbl_idariidarisim.Size = new System.Drawing.Size(69, 15);
            this.lbl_idariidarisim.TabIndex = 78;
            this.lbl_idariidarisim.Text = "Fakülte Adı:";
            // 
            // fakultebolumadıtxt
            // 
            this.fakultebolumadıtxt.Location = new System.Drawing.Point(122, 57);
            this.fakultebolumadıtxt.Margin = new System.Windows.Forms.Padding(2);
            this.fakultebolumadıtxt.Name = "fakultebolumadıtxt";
            this.fakultebolumadıtxt.Size = new System.Drawing.Size(203, 23);
            this.fakultebolumadıtxt.TabIndex = 79;
            // 
            // fakultebolumcb
            // 
            this.fakultebolumcb.FormattingEnabled = true;
            this.fakultebolumcb.Location = new System.Drawing.Point(122, 9);
            this.fakultebolumcb.Name = "fakultebolumcb";
            this.fakultebolumcb.Size = new System.Drawing.Size(203, 23);
            this.fakultebolumcb.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "Bölüm Adı:";
            // 
            // fakultebolumdurumcb
            // 
            this.fakultebolumdurumcb.FormattingEnabled = true;
            this.fakultebolumdurumcb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.fakultebolumdurumcb.Location = new System.Drawing.Point(122, 105);
            this.fakultebolumdurumcb.Name = "fakultebolumdurumcb";
            this.fakultebolumdurumcb.Size = new System.Drawing.Size(203, 23);
            this.fakultebolumdurumcb.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Durum:";
            // 
            // bolumdgv
            // 
            this.bolumdgv.AllowUserToAddRows = false;
            this.bolumdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bolumdgv.Location = new System.Drawing.Point(342, 68);
            this.bolumdgv.Name = "bolumdgv";
            this.bolumdgv.RowTemplate.Height = 25;
            this.bolumdgv.Size = new System.Drawing.Size(623, 212);
            this.bolumdgv.TabIndex = 87;
            this.bolumdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bolumdgv_CellDoubleClick);
            // 
            // bolumekleHeaderPanel
            // 
            this.bolumekleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.bolumekleHeaderPanel.Controls.Add(this.bolumekleCikisBtn);
            this.bolumekleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bolumekleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.bolumekleHeaderPanel.Name = "bolumekleHeaderPanel";
            this.bolumekleHeaderPanel.Size = new System.Drawing.Size(968, 61);
            this.bolumekleHeaderPanel.TabIndex = 88;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(11, 9);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(118, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Bölüm Ekle";
            // 
            // bolumekleCikisBtn
            // 
            this.bolumekleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.bolumekleCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bolumekleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bolumekleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.bolumekleCikisBtn.Location = new System.Drawing.Point(928, 3);
            this.bolumekleCikisBtn.Name = "bolumekleCikisBtn";
            this.bolumekleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.bolumekleCikisBtn.TabIndex = 5;
            this.bolumekleCikisBtn.Text = "X";
            this.bolumekleCikisBtn.UseVisualStyleBackColor = false;
            this.bolumekleCikisBtn.Click += new System.EventHandler(this.bolumekleCikisBtn_Click);
            // 
            // bolumekleContentPanel
            // 
            this.bolumekleContentPanel.Controls.Add(this.bilgitakippnl);
            this.bolumekleContentPanel.Controls.Add(this.lbl_idariidarisim);
            this.bolumekleContentPanel.Controls.Add(this.fakultebolumadıtxt);
            this.bolumekleContentPanel.Controls.Add(this.bolumdgv);
            this.bolumekleContentPanel.Controls.Add(this.bolumeklebtn);
            this.bolumekleContentPanel.Controls.Add(this.fakultebolumdurumcb);
            this.bolumekleContentPanel.Controls.Add(this.fakultebolumcb);
            this.bolumekleContentPanel.Controls.Add(this.label2);
            this.bolumekleContentPanel.Controls.Add(this.label1);
            this.bolumekleContentPanel.Location = new System.Drawing.Point(0, 68);
            this.bolumekleContentPanel.Name = "bolumekleContentPanel";
            this.bolumekleContentPanel.Size = new System.Drawing.Size(968, 289);
            this.bolumekleContentPanel.TabIndex = 89;
            // 
            // bilgitakippnl
            // 
            this.bilgitakippnl.Controls.Add(this.label3);
            this.bilgitakippnl.Controls.Add(this.bölümadaramatxt);
            this.bilgitakippnl.Controls.Add(this.aramatemizlebtn);
            this.bilgitakippnl.Controls.Add(this.label5);
            this.bilgitakippnl.Controls.Add(this.bolumArabtn);
            this.bilgitakippnl.Controls.Add(this.fakulteadaramatxt);
            this.bilgitakippnl.Location = new System.Drawing.Point(342, 9);
            this.bilgitakippnl.Name = "bilgitakippnl";
            this.bilgitakippnl.Size = new System.Drawing.Size(623, 53);
            this.bilgitakippnl.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bölüm Adı";
            // 
            // bölümadaramatxt
            // 
            this.bölümadaramatxt.Location = new System.Drawing.Point(109, 22);
            this.bölümadaramatxt.Name = "bölümadaramatxt";
            this.bölümadaramatxt.Size = new System.Drawing.Size(100, 23);
            this.bölümadaramatxt.TabIndex = 6;
            // 
            // aramatemizlebtn
            // 
            this.aramatemizlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aramatemizlebtn.Location = new System.Drawing.Point(512, 8);
            this.aramatemizlebtn.Name = "aramatemizlebtn";
            this.aramatemizlebtn.Size = new System.Drawing.Size(99, 37);
            this.aramatemizlebtn.TabIndex = 5;
            this.aramatemizlebtn.Text = "Arama Temizle";
            this.aramatemizlebtn.UseVisualStyleBackColor = true;
            this.aramatemizlebtn.Click += new System.EventHandler(this.aramatemizlebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fakülte Adı";
            // 
            // bolumArabtn
            // 
            this.bolumArabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bolumArabtn.Location = new System.Drawing.Point(407, 8);
            this.bolumArabtn.Name = "bolumArabtn";
            this.bolumArabtn.Size = new System.Drawing.Size(99, 37);
            this.bolumArabtn.TabIndex = 2;
            this.bolumArabtn.Text = "Bölüm Ara";
            this.bolumArabtn.UseVisualStyleBackColor = true;
            this.bolumArabtn.Click += new System.EventHandler(this.bolumArabtn_Click_1);
            // 
            // fakulteadaramatxt
            // 
            this.fakulteadaramatxt.Location = new System.Drawing.Point(3, 22);
            this.fakulteadaramatxt.Name = "fakulteadaramatxt";
            this.fakulteadaramatxt.Size = new System.Drawing.Size(100, 23);
            this.fakulteadaramatxt.TabIndex = 0;
            // 
            // bolumekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 364);
            this.Controls.Add(this.bolumekleContentPanel);
            this.Controls.Add(this.bolumekleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bolumekle";
            this.Text = "bolumekle";
            this.Load += new System.EventHandler(this.bolumekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bolumdgv)).EndInit();
            this.bolumekleHeaderPanel.ResumeLayout(false);
            this.bolumekleHeaderPanel.PerformLayout();
            this.bolumekleContentPanel.ResumeLayout(false);
            this.bolumekleContentPanel.PerformLayout();
            this.bilgitakippnl.ResumeLayout(false);
            this.bilgitakippnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bolumeklebtn;
        private System.Windows.Forms.Label lbl_idariidarisim;
        private System.Windows.Forms.TextBox fakultebolumadıtxt;
        private System.Windows.Forms.ComboBox fakultebolumcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fakultebolumdurumcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView bolumdgv;
        private System.Windows.Forms.Panel bolumekleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button bolumekleCikisBtn;
        private System.Windows.Forms.Panel bolumekleContentPanel;
        private System.Windows.Forms.Panel bilgitakippnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bölümadaramatxt;
        private System.Windows.Forms.Button aramatemizlebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bolumArabtn;
        private System.Windows.Forms.TextBox fakulteadaramatxt;
    }
}