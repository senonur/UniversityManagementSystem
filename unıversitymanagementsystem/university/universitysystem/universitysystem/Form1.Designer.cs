
namespace universitysystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanıcıgirispnl = new System.Windows.Forms.Panel();
            this.cıkısbtn = new System.Windows.Forms.Button();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.girisbtn = new System.Windows.Forms.Button();
            this.kullanicilbl = new System.Windows.Forms.Label();
            this.kullanicisifretxt = new System.Windows.Forms.TextBox();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.kullanıcıgirispnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanıcıgirispnl
            // 
            this.kullanıcıgirispnl.BackColor = System.Drawing.Color.Transparent;
            this.kullanıcıgirispnl.Controls.Add(this.cıkısbtn);
            this.kullanıcıgirispnl.Controls.Add(this.cikisbtn);
            this.kullanıcıgirispnl.Controls.Add(this.girisbtn);
            this.kullanıcıgirispnl.Controls.Add(this.kullanicilbl);
            this.kullanıcıgirispnl.Controls.Add(this.kullanicisifretxt);
            this.kullanıcıgirispnl.Controls.Add(this.kullaniciaditxt);
            this.kullanıcıgirispnl.Location = new System.Drawing.Point(358, 12);
            this.kullanıcıgirispnl.Name = "kullanıcıgirispnl";
            this.kullanıcıgirispnl.Size = new System.Drawing.Size(430, 42);
            this.kullanıcıgirispnl.TabIndex = 30;
            // 
            // cıkısbtn
            // 
            this.cıkısbtn.BackColor = System.Drawing.Color.Red;
            this.cıkısbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cıkısbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cıkısbtn.ForeColor = System.Drawing.Color.White;
            this.cıkısbtn.Location = new System.Drawing.Point(395, 11);
            this.cıkısbtn.Name = "cıkısbtn";
            this.cıkısbtn.Size = new System.Drawing.Size(32, 23);
            this.cıkısbtn.TabIndex = 5;
            this.cıkısbtn.Text = "X";
            this.cıkısbtn.UseVisualStyleBackColor = false;
            this.cıkısbtn.Click += new System.EventHandler(this.cıkısbtn_Click);
            // 
            // cikisbtn
            // 
            this.cikisbtn.BackColor = System.Drawing.Color.Yellow;
            this.cikisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisbtn.Location = new System.Drawing.Point(318, 11);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(75, 23);
            this.cikisbtn.TabIndex = 4;
            this.cikisbtn.Text = "Çıkış";
            this.cikisbtn.UseVisualStyleBackColor = false;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // girisbtn
            // 
            this.girisbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.girisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisbtn.Location = new System.Drawing.Point(237, 11);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(75, 23);
            this.girisbtn.TabIndex = 3;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.UseVisualStyleBackColor = false;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // kullanicilbl
            // 
            this.kullanicilbl.AutoSize = true;
            this.kullanicilbl.Location = new System.Drawing.Point(11, 13);
            this.kullanicilbl.Name = "kullanicilbl";
            this.kullanicilbl.Size = new System.Drawing.Size(52, 15);
            this.kullanicilbl.TabIndex = 2;
            this.kullanicilbl.Text = "Kullanıcı";
            this.kullanicilbl.Visible = false;
            // 
            // kullanicisifretxt
            // 
            this.kullanicisifretxt.Location = new System.Drawing.Point(153, 11);
            this.kullanicisifretxt.MaxLength = 20;
            this.kullanicisifretxt.Name = "kullanicisifretxt";
            this.kullanicisifretxt.PasswordChar = '*';
            this.kullanicisifretxt.PlaceholderText = "Password";
            this.kullanicisifretxt.Size = new System.Drawing.Size(78, 23);
            this.kullanicisifretxt.TabIndex = 1;
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(69, 11);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.PlaceholderText = "UserName";
            this.kullaniciaditxt.Size = new System.Drawing.Size(78, 23);
            this.kullaniciaditxt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::universitysystem.Properties.Resources.Atatürk_Üniversitesi__2012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.kullanıcıgirispnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.kullanıcıgirispnl.ResumeLayout(false);
            this.kullanıcıgirispnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kullanıcıgirispnl;
        private System.Windows.Forms.Button cıkısbtn;
        private System.Windows.Forms.Button cikisbtn;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label kullanicilbl;
        private System.Windows.Forms.TextBox kullanicisifretxt;
        private System.Windows.Forms.TextBox kullaniciaditxt;
    }
}

