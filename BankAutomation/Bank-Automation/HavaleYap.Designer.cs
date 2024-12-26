namespace OOP_Final_Projesi
{
    partial class HavaleYap
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
            this.txtHavaleMiktari = new System.Windows.Forms.TextBox();
            this.txtHavaleYapilacakHesapNo = new System.Windows.Forms.TextBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHavaleMiktari
            // 
            this.txtHavaleMiktari.Location = new System.Drawing.Point(194, 128);
            this.txtHavaleMiktari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHavaleMiktari.Name = "txtHavaleMiktari";
            this.txtHavaleMiktari.Size = new System.Drawing.Size(114, 27);
            this.txtHavaleMiktari.TabIndex = 16;
            // 
            // txtHavaleYapilacakHesapNo
            // 
            this.txtHavaleYapilacakHesapNo.Location = new System.Drawing.Point(194, 60);
            this.txtHavaleYapilacakHesapNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHavaleYapilacakHesapNo.Multiline = true;
            this.txtHavaleYapilacakHesapNo.Name = "txtHavaleYapilacakHesapNo";
            this.txtHavaleYapilacakHesapNo.Size = new System.Drawing.Size(122, 30);
            this.txtHavaleYapilacakHesapNo.TabIndex = 14;
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(194, 188);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(95, 39);
            this.btnİptal.TabIndex = 13;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(71, 188);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(96, 39);
            this.btnOnayla.TabIndex = 12;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Havale Miktarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Havale Yapılacak Hesap:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHavaleMiktari);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHavaleYapilacakHesapNo);
            this.panel1.Controls.Add(this.btnOnayla);
            this.panel1.Controls.Add(this.btnİptal);
            this.panel1.Location = new System.Drawing.Point(278, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 336);
            this.panel1.TabIndex = 17;
            // 
            // HavaleYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HavaleYap";
            this.Text = "Havale Yap Bireysel/Ticari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtHavaleMiktari;
        private TextBox txtHavaleYapilacakHesapNo;
        private Button btnİptal;
        private Button btnOnayla;
        private Label label3;
        private Label label1;
        private Panel panel1;
    }
}