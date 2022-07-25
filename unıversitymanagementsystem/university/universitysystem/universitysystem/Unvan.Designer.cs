
namespace universitysystem
{
    partial class Unvan
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
            this.unvanekleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.unvanekleCikisBtn = new System.Windows.Forms.Button();
            this.unvanekleContentPanel = new System.Windows.Forms.Panel();
            this.lbl_idariidarisim = new System.Windows.Forms.Label();
            this.unvanaditxt = new System.Windows.Forms.TextBox();
            this.unvandgv = new System.Windows.Forms.DataGridView();
            this.unvandurumcbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unvaneklebtn = new System.Windows.Forms.Button();
            this.unvanekleHeaderPanel.SuspendLayout();
            this.unvanekleContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unvandgv)).BeginInit();
            this.SuspendLayout();
            // 
            // unvanekleHeaderPanel
            // 
            this.unvanekleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.unvanekleHeaderPanel.Controls.Add(this.unvanekleCikisBtn);
            this.unvanekleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.unvanekleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.unvanekleHeaderPanel.Name = "unvanekleHeaderPanel";
            this.unvanekleHeaderPanel.Size = new System.Drawing.Size(959, 61);
            this.unvanekleHeaderPanel.TabIndex = 102;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(3, 9);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(117, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Unvan Ekle";
            // 
            // unvanekleCikisBtn
            // 
            this.unvanekleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.unvanekleCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unvanekleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unvanekleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.unvanekleCikisBtn.Location = new System.Drawing.Point(921, 6);
            this.unvanekleCikisBtn.Name = "unvanekleCikisBtn";
            this.unvanekleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.unvanekleCikisBtn.TabIndex = 5;
            this.unvanekleCikisBtn.Text = "X";
            this.unvanekleCikisBtn.UseVisualStyleBackColor = false;
            this.unvanekleCikisBtn.Click += new System.EventHandler(this.unvanekleCikisBtn_Click);
            // 
            // unvanekleContentPanel
            // 
            this.unvanekleContentPanel.Controls.Add(this.lbl_idariidarisim);
            this.unvanekleContentPanel.Controls.Add(this.unvanaditxt);
            this.unvanekleContentPanel.Controls.Add(this.unvandgv);
            this.unvanekleContentPanel.Controls.Add(this.unvandurumcbx);
            this.unvanekleContentPanel.Controls.Add(this.label1);
            this.unvanekleContentPanel.Controls.Add(this.unvaneklebtn);
            this.unvanekleContentPanel.Location = new System.Drawing.Point(0, 67);
            this.unvanekleContentPanel.Name = "unvanekleContentPanel";
            this.unvanekleContentPanel.Size = new System.Drawing.Size(953, 145);
            this.unvanekleContentPanel.TabIndex = 104;
            // 
            // lbl_idariidarisim
            // 
            this.lbl_idariidarisim.AutoSize = true;
            this.lbl_idariidarisim.Location = new System.Drawing.Point(6, 6);
            this.lbl_idariidarisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idariidarisim.Name = "lbl_idariidarisim";
            this.lbl_idariidarisim.Size = new System.Drawing.Size(65, 15);
            this.lbl_idariidarisim.TabIndex = 60;
            this.lbl_idariidarisim.Text = "Unvan Adı:";
            // 
            // unvanaditxt
            // 
            this.unvanaditxt.Location = new System.Drawing.Point(110, 3);
            this.unvanaditxt.Margin = new System.Windows.Forms.Padding(2);
            this.unvanaditxt.Name = "unvanaditxt";
            this.unvanaditxt.Size = new System.Drawing.Size(220, 23);
            this.unvanaditxt.TabIndex = 61;
            // 
            // unvandgv
            // 
            this.unvandgv.AllowUserToAddRows = false;
            this.unvandgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unvandgv.Location = new System.Drawing.Point(346, 3);
            this.unvandgv.Name = "unvandgv";
            this.unvandgv.RowTemplate.Height = 25;
            this.unvandgv.Size = new System.Drawing.Size(600, 134);
            this.unvandgv.TabIndex = 80;
            // 
            // unvandurumcbx
            // 
            this.unvandurumcbx.FormattingEnabled = true;
            this.unvandurumcbx.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.unvandurumcbx.Location = new System.Drawing.Point(110, 50);
            this.unvandurumcbx.Name = "unvandurumcbx";
            this.unvandurumcbx.Size = new System.Drawing.Size(220, 23);
            this.unvandurumcbx.TabIndex = 79;
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
            // unvaneklebtn
            // 
            this.unvaneklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.unvaneklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unvaneklebtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unvaneklebtn.ForeColor = System.Drawing.Color.White;
            this.unvaneklebtn.Location = new System.Drawing.Point(6, 88);
            this.unvaneklebtn.Name = "unvaneklebtn";
            this.unvaneklebtn.Size = new System.Drawing.Size(324, 49);
            this.unvaneklebtn.TabIndex = 77;
            this.unvaneklebtn.Text = "Unvan Ekle";
            this.unvaneklebtn.UseVisualStyleBackColor = false;
            this.unvaneklebtn.Click += new System.EventHandler(this.unvaneklebtn_Click);
            // 
            // Unvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 217);
            this.Controls.Add(this.unvanekleContentPanel);
            this.Controls.Add(this.unvanekleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unvan";
            this.Text = "Unvan";
            this.Load += new System.EventHandler(this.Unvan_Load);
            this.unvanekleHeaderPanel.ResumeLayout(false);
            this.unvanekleHeaderPanel.PerformLayout();
            this.unvanekleContentPanel.ResumeLayout(false);
            this.unvanekleContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unvandgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel unvanekleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button unvanekleCikisBtn;
        private System.Windows.Forms.Panel unvanekleContentPanel;
        private System.Windows.Forms.Label lbl_idariidarisim;
        private System.Windows.Forms.TextBox unvanaditxt;
        private System.Windows.Forms.DataGridView unvandgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button unvaneklebtn;
        private System.Windows.Forms.ComboBox unvandurumcbx;
    }
}