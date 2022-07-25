
namespace universitysystem
{
    partial class akademikpersonel
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
            this.akademikpersonelHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.akademikpersonelCikisBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.akademikpersonelderslertp = new System.Windows.Forms.TabPage();
            this.akademikpersoneldersdgv = new System.Windows.Forms.DataGridView();
            this.akademikpersonelsınavtp = new System.Windows.Forms.TabPage();
            this.ogrenciarabtn = new System.Windows.Forms.Button();
            this.akademikpersonelsınavdgv = new System.Windows.Forms.DataGridView();
            this.lbl_akdogrno = new System.Windows.Forms.Label();
            this.lbl_akdogrismi = new System.Windows.Forms.Label();
            this.lbl_akdders = new System.Windows.Forms.Label();
            this.ogrencinoaratxt = new System.Windows.Forms.TextBox();
            this.ogrenciadaratxt = new System.Windows.Forms.TextBox();
            this.akademikpersonelderscb = new System.Windows.Forms.ComboBox();
            this.akademikpersonelogrenciderstp = new System.Windows.Forms.TabPage();
            this.label_akdogrlistesi = new System.Windows.Forms.Label();
            this.lbl_akdogrders = new System.Windows.Forms.Label();
            this.akademikpersoneldersogrencilistesidgv = new System.Windows.Forms.DataGridView();
            this.ogrenciderscb = new System.Windows.Forms.ComboBox();
            this.akademikpersonelContentPanel = new System.Windows.Forms.Panel();
            this.akademikpersonelHeaderPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.akademikpersonelderslertp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akademikpersoneldersdgv)).BeginInit();
            this.akademikpersonelsınavtp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akademikpersonelsınavdgv)).BeginInit();
            this.akademikpersonelogrenciderstp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akademikpersoneldersogrencilistesidgv)).BeginInit();
            this.akademikpersonelContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // akademikpersonelHeaderPanel
            // 
            this.akademikpersonelHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.akademikpersonelHeaderPanel.Controls.Add(this.akademikpersonelCikisBtn);
            this.akademikpersonelHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.akademikpersonelHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.akademikpersonelHeaderPanel.Name = "akademikpersonelHeaderPanel";
            this.akademikpersonelHeaderPanel.Size = new System.Drawing.Size(907, 48);
            this.akademikpersonelHeaderPanel.TabIndex = 104;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(3, 9);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(192, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Akademik Personel";
            // 
            // akademikpersonelCikisBtn
            // 
            this.akademikpersonelCikisBtn.BackColor = System.Drawing.Color.Red;
            this.akademikpersonelCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.akademikpersonelCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.akademikpersonelCikisBtn.ForeColor = System.Drawing.Color.White;
            this.akademikpersonelCikisBtn.Location = new System.Drawing.Point(870, 12);
            this.akademikpersonelCikisBtn.Name = "akademikpersonelCikisBtn";
            this.akademikpersonelCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.akademikpersonelCikisBtn.TabIndex = 5;
            this.akademikpersonelCikisBtn.Text = "X";
            this.akademikpersonelCikisBtn.UseVisualStyleBackColor = false;
            this.akademikpersonelCikisBtn.Click += new System.EventHandler(this.akademikpersonelCikisBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.akademikpersonelderslertp);
            this.tabControl1.Controls.Add(this.akademikpersonelsınavtp);
            this.tabControl1.Controls.Add(this.akademikpersonelogrenciderstp);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 345);
            this.tabControl1.TabIndex = 106;
            // 
            // akademikpersonelderslertp
            // 
            this.akademikpersonelderslertp.Controls.Add(this.akademikpersoneldersdgv);
            this.akademikpersonelderslertp.Location = new System.Drawing.Point(4, 24);
            this.akademikpersonelderslertp.Name = "akademikpersonelderslertp";
            this.akademikpersonelderslertp.Padding = new System.Windows.Forms.Padding(3);
            this.akademikpersonelderslertp.Size = new System.Drawing.Size(891, 317);
            this.akademikpersonelderslertp.TabIndex = 2;
            this.akademikpersonelderslertp.Text = "Dersleriniz";
            this.akademikpersonelderslertp.UseVisualStyleBackColor = true;
            // 
            // akademikpersoneldersdgv
            // 
            this.akademikpersoneldersdgv.AllowUserToAddRows = false;
            this.akademikpersoneldersdgv.AllowUserToDeleteRows = false;
            this.akademikpersoneldersdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.akademikpersoneldersdgv.Location = new System.Drawing.Point(3, 3);
            this.akademikpersoneldersdgv.Name = "akademikpersoneldersdgv";
            this.akademikpersoneldersdgv.RowTemplate.Height = 25;
            this.akademikpersoneldersdgv.Size = new System.Drawing.Size(885, 311);
            this.akademikpersoneldersdgv.TabIndex = 0;
            // 
            // akademikpersonelsınavtp
            // 
            this.akademikpersonelsınavtp.Controls.Add(this.ogrenciarabtn);
            this.akademikpersonelsınavtp.Controls.Add(this.akademikpersonelsınavdgv);
            this.akademikpersonelsınavtp.Controls.Add(this.lbl_akdogrno);
            this.akademikpersonelsınavtp.Controls.Add(this.lbl_akdogrismi);
            this.akademikpersonelsınavtp.Controls.Add(this.lbl_akdders);
            this.akademikpersonelsınavtp.Controls.Add(this.ogrencinoaratxt);
            this.akademikpersonelsınavtp.Controls.Add(this.ogrenciadaratxt);
            this.akademikpersonelsınavtp.Controls.Add(this.akademikpersonelderscb);
            this.akademikpersonelsınavtp.Location = new System.Drawing.Point(4, 24);
            this.akademikpersonelsınavtp.Name = "akademikpersonelsınavtp";
            this.akademikpersonelsınavtp.Padding = new System.Windows.Forms.Padding(3);
            this.akademikpersonelsınavtp.Size = new System.Drawing.Size(891, 317);
            this.akademikpersonelsınavtp.TabIndex = 3;
            this.akademikpersonelsınavtp.Text = "Sınavlar";
            this.akademikpersonelsınavtp.UseVisualStyleBackColor = true;
            // 
            // ogrenciarabtn
            // 
            this.ogrenciarabtn.Location = new System.Drawing.Point(92, 121);
            this.ogrenciarabtn.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenciarabtn.Name = "ogrenciarabtn";
            this.ogrenciarabtn.Size = new System.Drawing.Size(129, 26);
            this.ogrenciarabtn.TabIndex = 20;
            this.ogrenciarabtn.Text = "Öğrenci Ara";
            this.ogrenciarabtn.UseVisualStyleBackColor = true;
            this.ogrenciarabtn.Click += new System.EventHandler(this.ogrenciarabtn_Click);
            // 
            // akademikpersonelsınavdgv
            // 
            this.akademikpersonelsınavdgv.AllowUserToAddRows = false;
            this.akademikpersonelsınavdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.akademikpersonelsınavdgv.Location = new System.Drawing.Point(225, 5);
            this.akademikpersonelsınavdgv.Margin = new System.Windows.Forms.Padding(2);
            this.akademikpersonelsınavdgv.Name = "akademikpersonelsınavdgv";
            this.akademikpersonelsınavdgv.RowHeadersWidth = 62;
            this.akademikpersonelsınavdgv.RowTemplate.Height = 33;
            this.akademikpersonelsınavdgv.Size = new System.Drawing.Size(661, 307);
            this.akademikpersonelsınavdgv.TabIndex = 19;
            this.akademikpersonelsınavdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.akademikpersonelsınavdgv_CellDoubleClick);
            // 
            // lbl_akdogrno
            // 
            this.lbl_akdogrno.AutoSize = true;
            this.lbl_akdogrno.Location = new System.Drawing.Point(6, 91);
            this.lbl_akdogrno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_akdogrno.Name = "lbl_akdogrno";
            this.lbl_akdogrno.Size = new System.Drawing.Size(71, 15);
            this.lbl_akdogrno.TabIndex = 17;
            this.lbl_akdogrno.Text = "Ögrenci No:";
            // 
            // lbl_akdogrismi
            // 
            this.lbl_akdogrismi.AutoSize = true;
            this.lbl_akdogrismi.Location = new System.Drawing.Point(6, 53);
            this.lbl_akdogrismi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_akdogrismi.Name = "lbl_akdogrismi";
            this.lbl_akdogrismi.Size = new System.Drawing.Size(77, 15);
            this.lbl_akdogrismi.TabIndex = 16;
            this.lbl_akdogrismi.Text = "Ögrenci Ismi:";
            // 
            // lbl_akdders
            // 
            this.lbl_akdders.AutoSize = true;
            this.lbl_akdders.Location = new System.Drawing.Point(6, 8);
            this.lbl_akdders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_akdders.Name = "lbl_akdders";
            this.lbl_akdders.Size = new System.Drawing.Size(33, 15);
            this.lbl_akdders.TabIndex = 15;
            this.lbl_akdders.Text = "Ders:";
            // 
            // ogrencinoaratxt
            // 
            this.ogrencinoaratxt.Location = new System.Drawing.Point(92, 88);
            this.ogrencinoaratxt.Margin = new System.Windows.Forms.Padding(2);
            this.ogrencinoaratxt.Name = "ogrencinoaratxt";
            this.ogrencinoaratxt.Size = new System.Drawing.Size(129, 23);
            this.ogrencinoaratxt.TabIndex = 13;
            // 
            // ogrenciadaratxt
            // 
            this.ogrenciadaratxt.Location = new System.Drawing.Point(92, 50);
            this.ogrenciadaratxt.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenciadaratxt.Name = "ogrenciadaratxt";
            this.ogrenciadaratxt.Size = new System.Drawing.Size(129, 23);
            this.ogrenciadaratxt.TabIndex = 12;
            // 
            // akademikpersonelderscb
            // 
            this.akademikpersonelderscb.FormattingEnabled = true;
            this.akademikpersonelderscb.Location = new System.Drawing.Point(92, 5);
            this.akademikpersonelderscb.Margin = new System.Windows.Forms.Padding(2);
            this.akademikpersonelderscb.Name = "akademikpersonelderscb";
            this.akademikpersonelderscb.Size = new System.Drawing.Size(129, 23);
            this.akademikpersonelderscb.TabIndex = 11;
            this.akademikpersonelderscb.SelectedIndexChanged += new System.EventHandler(this.akademikpersonelderscb_SelectedIndexChanged);
            // 
            // akademikpersonelogrenciderstp
            // 
            this.akademikpersonelogrenciderstp.Controls.Add(this.label_akdogrlistesi);
            this.akademikpersonelogrenciderstp.Controls.Add(this.lbl_akdogrders);
            this.akademikpersonelogrenciderstp.Controls.Add(this.akademikpersoneldersogrencilistesidgv);
            this.akademikpersonelogrenciderstp.Controls.Add(this.ogrenciderscb);
            this.akademikpersonelogrenciderstp.Location = new System.Drawing.Point(4, 24);
            this.akademikpersonelogrenciderstp.Name = "akademikpersonelogrenciderstp";
            this.akademikpersonelogrenciderstp.Padding = new System.Windows.Forms.Padding(3);
            this.akademikpersonelogrenciderstp.Size = new System.Drawing.Size(891, 317);
            this.akademikpersonelogrenciderstp.TabIndex = 4;
            this.akademikpersonelogrenciderstp.Text = "Öğrenci - Ders Listesi";
            this.akademikpersonelogrenciderstp.UseVisualStyleBackColor = true;
            // 
            // label_akdogrlistesi
            // 
            this.label_akdogrlistesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_akdogrlistesi.AutoSize = true;
            this.label_akdogrlistesi.Location = new System.Drawing.Point(463, 3);
            this.label_akdogrlistesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_akdogrlistesi.Name = "label_akdogrlistesi";
            this.label_akdogrlistesi.Size = new System.Drawing.Size(87, 15);
            this.label_akdogrlistesi.TabIndex = 7;
            this.label_akdogrlistesi.Text = "Ögrenci Listesi:";
            // 
            // lbl_akdogrders
            // 
            this.lbl_akdogrders.AutoSize = true;
            this.lbl_akdogrders.Location = new System.Drawing.Point(61, 3);
            this.lbl_akdogrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_akdogrders.Name = "lbl_akdogrders";
            this.lbl_akdogrders.Size = new System.Drawing.Size(33, 15);
            this.lbl_akdogrders.TabIndex = 6;
            this.lbl_akdogrders.Text = "Ders:";
            // 
            // akademikpersoneldersogrencilistesidgv
            // 
            this.akademikpersoneldersogrencilistesidgv.AllowUserToAddRows = false;
            this.akademikpersoneldersogrencilistesidgv.AllowUserToDeleteRows = false;
            this.akademikpersoneldersogrencilistesidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.akademikpersoneldersogrencilistesidgv.Location = new System.Drawing.Point(160, 20);
            this.akademikpersoneldersogrencilistesidgv.Margin = new System.Windows.Forms.Padding(2);
            this.akademikpersoneldersogrencilistesidgv.Name = "akademikpersoneldersogrencilistesidgv";
            this.akademikpersoneldersogrencilistesidgv.RowHeadersWidth = 62;
            this.akademikpersoneldersogrencilistesidgv.RowTemplate.Height = 33;
            this.akademikpersoneldersogrencilistesidgv.Size = new System.Drawing.Size(726, 292);
            this.akademikpersoneldersogrencilistesidgv.TabIndex = 5;
            // 
            // ogrenciderscb
            // 
            this.ogrenciderscb.FormattingEnabled = true;
            this.ogrenciderscb.Location = new System.Drawing.Point(7, 20);
            this.ogrenciderscb.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenciderscb.Name = "ogrenciderscb";
            this.ogrenciderscb.Size = new System.Drawing.Size(151, 23);
            this.ogrenciderscb.TabIndex = 4;
            this.ogrenciderscb.SelectedIndexChanged += new System.EventHandler(this.ogrenciderscb_SelectedIndexChanged);
            // 
            // akademikpersonelContentPanel
            // 
            this.akademikpersonelContentPanel.Controls.Add(this.tabControl1);
            this.akademikpersonelContentPanel.Location = new System.Drawing.Point(0, 54);
            this.akademikpersonelContentPanel.Name = "akademikpersonelContentPanel";
            this.akademikpersonelContentPanel.Size = new System.Drawing.Size(907, 356);
            this.akademikpersonelContentPanel.TabIndex = 107;
            // 
            // akademikpersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(907, 416);
            this.Controls.Add(this.akademikpersonelContentPanel);
            this.Controls.Add(this.akademikpersonelHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "akademikpersonel";
            this.Text = "akademikpersonel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.akademikpersonel_Load);
            this.akademikpersonelHeaderPanel.ResumeLayout(false);
            this.akademikpersonelHeaderPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.akademikpersonelderslertp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.akademikpersoneldersdgv)).EndInit();
            this.akademikpersonelsınavtp.ResumeLayout(false);
            this.akademikpersonelsınavtp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akademikpersonelsınavdgv)).EndInit();
            this.akademikpersonelogrenciderstp.ResumeLayout(false);
            this.akademikpersonelogrenciderstp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akademikpersoneldersogrencilistesidgv)).EndInit();
            this.akademikpersonelContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel akademikpersonelHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button akademikpersonelCikisBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage akademikpersonelderslertp;
        private System.Windows.Forms.DataGridView akademikpersoneldersdgv;
        private System.Windows.Forms.TabPage akademikpersonelsınavtp;
        private System.Windows.Forms.Button ogrenciarabtn;
        private System.Windows.Forms.DataGridView akademikpersonelsınavdgv;
        private System.Windows.Forms.Label lbl_akdogrno;
        private System.Windows.Forms.Label lbl_akdogrismi;
        private System.Windows.Forms.Label lbl_akdders;
        private System.Windows.Forms.TextBox ogrencinoaratxt;
        private System.Windows.Forms.TextBox ogrenciadaratxt;
        private System.Windows.Forms.ComboBox akademikpersonelderscb;
        private System.Windows.Forms.TabPage akademikpersonelogrenciderstp;
        private System.Windows.Forms.Label label_akdogrlistesi;
        private System.Windows.Forms.Label lbl_akdogrders;
        private System.Windows.Forms.DataGridView akademikpersoneldersogrencilistesidgv;
        private System.Windows.Forms.ComboBox ogrenciderscb;
        private System.Windows.Forms.Panel akademikpersonelContentPanel;
    }
}