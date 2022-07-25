
namespace universitysystem
{
    partial class ogrencibelge
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
            this.ogrencibelgebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kitapDuzenleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.ogrencibelgeCikisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.kitapDuzenleHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrencibelgebtn
            // 
            this.ogrencibelgebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ogrencibelgebtn.Location = new System.Drawing.Point(245, 16);
            this.ogrencibelgebtn.Name = "ogrencibelgebtn";
            this.ogrencibelgebtn.Size = new System.Drawing.Size(130, 23);
            this.ogrencibelgebtn.TabIndex = 35;
            this.ogrencibelgebtn.Text = "Onayla";
            this.ogrencibelgebtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Belge Türü ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(372, 266);
            this.dataGridView1.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ogrencibelgebtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 316);
            this.panel1.TabIndex = 37;
            // 
            // kitapDuzenleHeaderPanel
            // 
            this.kitapDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.kitapDuzenleHeaderPanel.Controls.Add(this.ogrencibelgeCikisBtn);
            this.kitapDuzenleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kitapDuzenleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.kitapDuzenleHeaderPanel.Name = "kitapDuzenleHeaderPanel";
            this.kitapDuzenleHeaderPanel.Size = new System.Drawing.Size(383, 48);
            this.kitapDuzenleHeaderPanel.TabIndex = 105;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(3, 9);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(151, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Öğrenci  Belge";
            // 
            // ogrencibelgeCikisBtn
            // 
            this.ogrencibelgeCikisBtn.BackColor = System.Drawing.Color.Red;
            this.ogrencibelgeCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ogrencibelgeCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ogrencibelgeCikisBtn.ForeColor = System.Drawing.Color.White;
            this.ogrencibelgeCikisBtn.Location = new System.Drawing.Point(343, 6);
            this.ogrencibelgeCikisBtn.Name = "ogrencibelgeCikisBtn";
            this.ogrencibelgeCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.ogrencibelgeCikisBtn.TabIndex = 5;
            this.ogrencibelgeCikisBtn.Text = "X";
            this.ogrencibelgeCikisBtn.UseVisualStyleBackColor = false;
            this.ogrencibelgeCikisBtn.Click += new System.EventHandler(this.ogrencibelgeCikisBtn_Click);
            // 
            // ogrencibelge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 373);
            this.Controls.Add(this.kitapDuzenleHeaderPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrencibelge";
            this.Text = "ogrencibelge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.kitapDuzenleHeaderPanel.ResumeLayout(false);
            this.kitapDuzenleHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogrencibelgebtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel kitapDuzenleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button ogrencibelgeCikisBtn;
    }
}