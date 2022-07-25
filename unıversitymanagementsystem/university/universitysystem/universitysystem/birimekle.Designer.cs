
namespace universitysystem
{
    partial class birimekle
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
            this.birimekleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.birimekleCikisBtn = new System.Windows.Forms.Button();
            this.birimekleContentPanel = new System.Windows.Forms.Panel();
            this.lbl_idariidarisim = new System.Windows.Forms.Label();
            this.birimaditxt = new System.Windows.Forms.TextBox();
            this.birimdgv = new System.Windows.Forms.DataGridView();
            this.birimdurumcbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birimeklebtn = new System.Windows.Forms.Button();
            this.birimekleHeaderPanel.SuspendLayout();
            this.birimekleContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birimdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // birimekleHeaderPanel
            // 
            this.birimekleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.birimekleHeaderPanel.Controls.Add(this.birimekleCikisBtn);
            this.birimekleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.birimekleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.birimekleHeaderPanel.Name = "birimekleHeaderPanel";
            this.birimekleHeaderPanel.Size = new System.Drawing.Size(953, 45);
            this.birimekleHeaderPanel.TabIndex = 102;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(11, 9);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(108, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Birim Ekle";
            // 
            // birimekleCikisBtn
            // 
            this.birimekleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.birimekleCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.birimekleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birimekleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.birimekleCikisBtn.Location = new System.Drawing.Point(914, 3);
            this.birimekleCikisBtn.Name = "birimekleCikisBtn";
            this.birimekleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.birimekleCikisBtn.TabIndex = 5;
            this.birimekleCikisBtn.Text = "X";
            this.birimekleCikisBtn.UseVisualStyleBackColor = false;
            this.birimekleCikisBtn.Click += new System.EventHandler(this.birimekleCikisBtn_Click);
            // 
            // birimekleContentPanel
            // 
            this.birimekleContentPanel.Controls.Add(this.lbl_idariidarisim);
            this.birimekleContentPanel.Controls.Add(this.birimaditxt);
            this.birimekleContentPanel.Controls.Add(this.birimdgv);
            this.birimekleContentPanel.Controls.Add(this.birimdurumcbx);
            this.birimekleContentPanel.Controls.Add(this.label1);
            this.birimekleContentPanel.Controls.Add(this.birimeklebtn);
            this.birimekleContentPanel.Location = new System.Drawing.Point(0, 51);
            this.birimekleContentPanel.Name = "birimekleContentPanel";
            this.birimekleContentPanel.Size = new System.Drawing.Size(953, 145);
            this.birimekleContentPanel.TabIndex = 103;
            // 
            // lbl_idariidarisim
            // 
            this.lbl_idariidarisim.AutoSize = true;
            this.lbl_idariidarisim.Location = new System.Drawing.Point(6, 6);
            this.lbl_idariidarisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idariidarisim.Name = "lbl_idariidarisim";
            this.lbl_idariidarisim.Size = new System.Drawing.Size(59, 15);
            this.lbl_idariidarisim.TabIndex = 60;
            this.lbl_idariidarisim.Text = "Birim Adı:";
            // 
            // birimaditxt
            // 
            this.birimaditxt.Location = new System.Drawing.Point(110, 3);
            this.birimaditxt.Margin = new System.Windows.Forms.Padding(2);
            this.birimaditxt.Name = "birimaditxt";
            this.birimaditxt.Size = new System.Drawing.Size(220, 23);
            this.birimaditxt.TabIndex = 61;
            // 
            // birimdgv
            // 
            this.birimdgv.AllowUserToAddRows = false;
            this.birimdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birimdgv.Location = new System.Drawing.Point(346, 3);
            this.birimdgv.Name = "birimdgv";
            this.birimdgv.RowTemplate.Height = 25;
            this.birimdgv.Size = new System.Drawing.Size(600, 134);
            this.birimdgv.TabIndex = 80;
            // 
            // birimdurumcbx
            // 
            this.birimdurumcbx.FormattingEnabled = true;
            this.birimdurumcbx.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.birimdurumcbx.Location = new System.Drawing.Point(110, 50);
            this.birimdurumcbx.Name = "birimdurumcbx";
            this.birimdurumcbx.Size = new System.Drawing.Size(220, 23);
            this.birimdurumcbx.TabIndex = 79;
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
            // birimeklebtn
            // 
            this.birimeklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.birimeklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.birimeklebtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birimeklebtn.ForeColor = System.Drawing.Color.White;
            this.birimeklebtn.Location = new System.Drawing.Point(6, 88);
            this.birimeklebtn.Name = "birimeklebtn";
            this.birimeklebtn.Size = new System.Drawing.Size(324, 49);
            this.birimeklebtn.TabIndex = 77;
            this.birimeklebtn.Text = "Birim Ekle";
            this.birimeklebtn.UseVisualStyleBackColor = false;
            this.birimeklebtn.Click += new System.EventHandler(this.birimeklebtn_Click);
            // 
            // birimekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 202);
            this.Controls.Add(this.birimekleContentPanel);
            this.Controls.Add(this.birimekleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "birimekle";
            this.Text = "birimekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.birimekle_Load);
            this.birimekleHeaderPanel.ResumeLayout(false);
            this.birimekleHeaderPanel.PerformLayout();
            this.birimekleContentPanel.ResumeLayout(false);
            this.birimekleContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birimdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel birimekleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button birimekleCikisBtn;
        private System.Windows.Forms.Panel birimekleContentPanel;
        private System.Windows.Forms.Label lbl_idariidarisim;
        private System.Windows.Forms.TextBox birimaditxt;
        private System.Windows.Forms.DataGridView birimdgv;
        private System.Windows.Forms.ComboBox birimdurumcbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button birimeklebtn;
    }
}