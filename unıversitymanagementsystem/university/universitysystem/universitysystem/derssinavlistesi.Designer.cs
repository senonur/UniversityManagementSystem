
namespace universitysystem
{
    partial class derssinavlistesi
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
            this.ogrencisınavdgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciCikisBtn = new System.Windows.Forms.Button();
            this.dersinavlistesipanel = new System.Windows.Forms.Panel();
            this.ogrencidersdgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencisınavdgv)).BeginInit();
            this.dersinavlistesipanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencidersdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrencisınavdgv
            // 
            this.ogrencisınavdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrencisınavdgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.ogrencisınavdgv.Location = new System.Drawing.Point(655, 0);
            this.ogrencisınavdgv.Name = "ogrencisınavdgv";
            this.ogrencisınavdgv.RowTemplate.Height = 25;
            this.ogrencisınavdgv.Size = new System.Drawing.Size(606, 294);
            this.ogrencisınavdgv.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Dersleriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(563, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "Sınavlarınız";
            // 
            // ogrenciCikisBtn
            // 
            this.ogrenciCikisBtn.BackColor = System.Drawing.Color.Red;
            this.ogrenciCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ogrenciCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ogrenciCikisBtn.ForeColor = System.Drawing.Color.White;
            this.ogrenciCikisBtn.Location = new System.Drawing.Point(1234, 12);
            this.ogrenciCikisBtn.Name = "ogrenciCikisBtn";
            this.ogrenciCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.ogrenciCikisBtn.TabIndex = 41;
            this.ogrenciCikisBtn.Text = "X";
            this.ogrenciCikisBtn.UseVisualStyleBackColor = false;
            this.ogrenciCikisBtn.Click += new System.EventHandler(this.ogrenciCikisBtn_Click);
            // 
            // dersinavlistesipanel
            // 
            this.dersinavlistesipanel.Controls.Add(this.ogrencidersdgv);
            this.dersinavlistesipanel.Controls.Add(this.ogrencisınavdgv);
            this.dersinavlistesipanel.Location = new System.Drawing.Point(5, 69);
            this.dersinavlistesipanel.Name = "dersinavlistesipanel";
            this.dersinavlistesipanel.Size = new System.Drawing.Size(1261, 294);
            this.dersinavlistesipanel.TabIndex = 42;
            // 
            // ogrencidersdgv
            // 
            this.ogrencidersdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrencidersdgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.ogrencidersdgv.Location = new System.Drawing.Point(0, 0);
            this.ogrencidersdgv.Name = "ogrencidersdgv";
            this.ogrencidersdgv.RowTemplate.Height = 25;
            this.ogrencidersdgv.Size = new System.Drawing.Size(575, 294);
            this.ogrencidersdgv.TabIndex = 35;
            // 
            // derssinavlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1271, 375);
            this.Controls.Add(this.dersinavlistesipanel);
            this.Controls.Add(this.ogrenciCikisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "derssinavlistesi";
            this.Text = "derssinavlistesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.derssinavlistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrencisınavdgv)).EndInit();
            this.dersinavlistesipanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ogrencidersdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ogrencisınavdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ogrenciCikisBtn;
        private System.Windows.Forms.Panel dersinavlistesipanel;
        private System.Windows.Forms.DataGridView ogrencidersdgv;
    }
}