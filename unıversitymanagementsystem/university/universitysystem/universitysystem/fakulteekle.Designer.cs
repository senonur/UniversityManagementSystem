
namespace universitysystem
{
    partial class fakulteekle
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
            this.fakulteaditxt = new System.Windows.Forms.TextBox();
            this.lbl_idariidarisim = new System.Windows.Forms.Label();
            this.fakulteadresrtb = new System.Windows.Forms.RichTextBox();
            this.lbl_idariidariadres = new System.Windows.Forms.Label();
            this.fakulteeklebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fakultedurumcbx = new System.Windows.Forms.ComboBox();
            this.fakultedgv = new System.Windows.Forms.DataGridView();
            this.fakulteekleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.fakülteekleCikisBtn = new System.Windows.Forms.Button();
            this.fakulteekleContentPanel = new System.Windows.Forms.Panel();
            this.aramatemizlebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fakultedgv)).BeginInit();
            this.fakulteekleHeaderPanel.SuspendLayout();
            this.fakulteekleContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fakulteaditxt
            // 
            this.fakulteaditxt.Location = new System.Drawing.Point(110, 3);
            this.fakulteaditxt.Margin = new System.Windows.Forms.Padding(2);
            this.fakulteaditxt.Name = "fakulteaditxt";
            this.fakulteaditxt.Size = new System.Drawing.Size(220, 23);
            this.fakulteaditxt.TabIndex = 61;
            // 
            // lbl_idariidarisim
            // 
            this.lbl_idariidarisim.AutoSize = true;
            this.lbl_idariidarisim.Location = new System.Drawing.Point(6, 6);
            this.lbl_idariidarisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idariidarisim.Name = "lbl_idariidarisim";
            this.lbl_idariidarisim.Size = new System.Drawing.Size(69, 15);
            this.lbl_idariidarisim.TabIndex = 60;
            this.lbl_idariidarisim.Text = "Fakülte Adı:";
            // 
            // fakulteadresrtb
            // 
            this.fakulteadresrtb.Location = new System.Drawing.Point(110, 97);
            this.fakulteadresrtb.Name = "fakulteadresrtb";
            this.fakulteadresrtb.Size = new System.Drawing.Size(220, 168);
            this.fakulteadresrtb.TabIndex = 73;
            this.fakulteadresrtb.Text = "";
            // 
            // lbl_idariidariadres
            // 
            this.lbl_idariidariadres.AutoSize = true;
            this.lbl_idariidariadres.Location = new System.Drawing.Point(6, 101);
            this.lbl_idariidariadres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idariidariadres.Name = "lbl_idariidariadres";
            this.lbl_idariidariadres.Size = new System.Drawing.Size(40, 15);
            this.lbl_idariidariadres.TabIndex = 72;
            this.lbl_idariidariadres.Text = "Adres:";
            // 
            // fakulteeklebtn
            // 
            this.fakulteeklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fakulteeklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fakulteeklebtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fakulteeklebtn.ForeColor = System.Drawing.Color.White;
            this.fakulteeklebtn.Location = new System.Drawing.Point(6, 271);
            this.fakulteeklebtn.Name = "fakulteeklebtn";
            this.fakulteeklebtn.Size = new System.Drawing.Size(324, 49);
            this.fakulteeklebtn.TabIndex = 77;
            this.fakulteeklebtn.Text = "Fakülte Ekle";
            this.fakulteeklebtn.UseVisualStyleBackColor = false;
            this.fakulteeklebtn.Click += new System.EventHandler(this.fakulteeklebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Durum:";
            // 
            // fakultedurumcbx
            // 
            this.fakultedurumcbx.FormattingEnabled = true;
            this.fakultedurumcbx.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.fakultedurumcbx.Location = new System.Drawing.Point(110, 50);
            this.fakultedurumcbx.Name = "fakultedurumcbx";
            this.fakultedurumcbx.Size = new System.Drawing.Size(220, 23);
            this.fakultedurumcbx.TabIndex = 79;
            // 
            // fakultedgv
            // 
            this.fakultedgv.AllowUserToAddRows = false;
            this.fakultedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakultedgv.Location = new System.Drawing.Point(346, 49);
            this.fakultedgv.Name = "fakultedgv";
            this.fakultedgv.RowTemplate.Height = 25;
            this.fakultedgv.Size = new System.Drawing.Size(592, 271);
            this.fakultedgv.TabIndex = 80;
            this.fakultedgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fakultedgv_CellDoubleClick);
            // 
            // fakulteekleHeaderPanel
            // 
            this.fakulteekleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.fakulteekleHeaderPanel.Controls.Add(this.fakülteekleCikisBtn);
            this.fakulteekleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fakulteekleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.fakulteekleHeaderPanel.Name = "fakulteekleHeaderPanel";
            this.fakulteekleHeaderPanel.Size = new System.Drawing.Size(949, 61);
            this.fakulteekleHeaderPanel.TabIndex = 101;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(11, 9);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(125, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Fakülte Ekle";
            // 
            // fakülteekleCikisBtn
            // 
            this.fakülteekleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.fakülteekleCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fakülteekleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fakülteekleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.fakülteekleCikisBtn.Location = new System.Drawing.Point(914, 6);
            this.fakülteekleCikisBtn.Name = "fakülteekleCikisBtn";
            this.fakülteekleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.fakülteekleCikisBtn.TabIndex = 5;
            this.fakülteekleCikisBtn.Text = "X";
            this.fakülteekleCikisBtn.UseVisualStyleBackColor = false;
            this.fakülteekleCikisBtn.Click += new System.EventHandler(this.fakülteekleCikisBtn_Click);
            // 
            // fakulteekleContentPanel
            // 
            this.fakulteekleContentPanel.Controls.Add(this.aramatemizlebtn);
            this.fakulteekleContentPanel.Controls.Add(this.lbl_idariidarisim);
            this.fakulteekleContentPanel.Controls.Add(this.fakulteaditxt);
            this.fakulteekleContentPanel.Controls.Add(this.fakultedgv);
            this.fakulteekleContentPanel.Controls.Add(this.lbl_idariidariadres);
            this.fakulteekleContentPanel.Controls.Add(this.fakultedurumcbx);
            this.fakulteekleContentPanel.Controls.Add(this.fakulteadresrtb);
            this.fakulteekleContentPanel.Controls.Add(this.label1);
            this.fakulteekleContentPanel.Controls.Add(this.fakulteeklebtn);
            this.fakulteekleContentPanel.Location = new System.Drawing.Point(0, 67);
            this.fakulteekleContentPanel.Name = "fakulteekleContentPanel";
            this.fakulteekleContentPanel.Size = new System.Drawing.Size(946, 326);
            this.fakulteekleContentPanel.TabIndex = 102;
            // 
            // aramatemizlebtn
            // 
            this.aramatemizlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aramatemizlebtn.Location = new System.Drawing.Point(838, 6);
            this.aramatemizlebtn.Name = "aramatemizlebtn";
            this.aramatemizlebtn.Size = new System.Drawing.Size(99, 37);
            this.aramatemizlebtn.TabIndex = 81;
            this.aramatemizlebtn.Text = "Arama Temizle";
            this.aramatemizlebtn.UseVisualStyleBackColor = true;
            this.aramatemizlebtn.Click += new System.EventHandler(this.aramatemizlebtn_Click);
            // 
            // fakulteekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 404);
            this.Controls.Add(this.fakulteekleContentPanel);
            this.Controls.Add(this.fakulteekleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fakulteekle";
            this.Text = "fakulteekle";
            this.Load += new System.EventHandler(this.fakulteekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakultedgv)).EndInit();
            this.fakulteekleHeaderPanel.ResumeLayout(false);
            this.fakulteekleHeaderPanel.PerformLayout();
            this.fakulteekleContentPanel.ResumeLayout(false);
            this.fakulteekleContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fakulteaditxt;
        private System.Windows.Forms.Label lbl_idariidarisim;
        private System.Windows.Forms.RichTextBox fakulteadresrtb;
        private System.Windows.Forms.Label lbl_idariidariadres;
        private System.Windows.Forms.Button fakulteeklebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fakultedurumcbx;
        private System.Windows.Forms.DataGridView fakultedgv;
        private System.Windows.Forms.Panel fakulteekleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button fakülteekleCikisBtn;
        private System.Windows.Forms.Panel fakulteekleContentPanel;
        private System.Windows.Forms.Button aramatemizlebtn;
    }
}