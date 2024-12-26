namespace OOP_Final_Projesi
{
    partial class BireyselMusteriKayit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticariMüşteriKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBireyselKaydet = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticariMüşteriKayıtToolStripMenuItem,
            this.hesapAçToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // ticariMüşteriKayıtToolStripMenuItem
            // 
            this.ticariMüşteriKayıtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ticariMüşteriKayıtToolStripMenuItem.Name = "ticariMüşteriKayıtToolStripMenuItem";
            this.ticariMüşteriKayıtToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ticariMüşteriKayıtToolStripMenuItem.Text = "Ticari Müşteri Kayıt";
            // 
            // hesapAçToolStripMenuItem
            // 
            this.hesapAçToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hesapAçToolStripMenuItem.Name = "hesapAçToolStripMenuItem";
            this.hesapAçToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.hesapAçToolStripMenuItem.Text = "Hesap Aç";
            this.hesapAçToolStripMenuItem.Click += new System.EventHandler(this.hesapAçToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad         :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC         :";
            // 
            // btnBireyselKaydet
            // 
            this.btnBireyselKaydet.Location = new System.Drawing.Point(70, 192);
            this.btnBireyselKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBireyselKaydet.Name = "btnBireyselKaydet";
            this.btnBireyselKaydet.Size = new System.Drawing.Size(88, 42);
            this.btnBireyselKaydet.TabIndex = 4;
            this.btnBireyselKaydet.Text = "Kaydet";
            this.btnBireyselKaydet.UseVisualStyleBackColor = true;
            this.btnBireyselKaydet.Click += new System.EventHandler(this.btnBireyselKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(176, 192);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(84, 42);
            this.btnİptal.TabIndex = 5;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(149, 46);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(114, 27);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(149, 96);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(114, 27);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(149, 141);
            this.txtTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(114, 27);
            this.txtTC.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnİptal);
            this.panel1.Controls.Add(this.txtTC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBireyselKaydet);
            this.panel1.Location = new System.Drawing.Point(280, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 294);
            this.panel1.TabIndex = 9;
            // 
            // BireyselMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BireyselMusteriKayit";
            this.Text = "Bireysel Müşteri Kayıt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem işlemlerToolStripMenuItem;
        private ToolStripMenuItem ticariMüşteriKayıtToolStripMenuItem;
        private ToolStripMenuItem hesapAçToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBireyselKaydet;
        private Button btnİptal;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTC;
        private Panel panel1;
    }
}