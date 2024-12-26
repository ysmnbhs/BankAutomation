namespace OOP_Final_Projesi
{
    partial class HesapAcma
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
            this.txtHesabinSubesi = new System.Windows.Forms.TextBox();
            this.btnHesapOlustur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.havaleYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticariMüşteriKayıtToolStripMenuItem,
            this.hesapAçToolStripMenuItem,
            this.havaleYapToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // ticariMüşteriKayıtToolStripMenuItem
            // 
            this.ticariMüşteriKayıtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ticariMüşteriKayıtToolStripMenuItem.Name = "ticariMüşteriKayıtToolStripMenuItem";
            this.ticariMüşteriKayıtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ticariMüşteriKayıtToolStripMenuItem.Text = "Para Çek";
            this.ticariMüşteriKayıtToolStripMenuItem.Click += new System.EventHandler(this.ticariMüşteriKayıtToolStripMenuItem_Click);
            // 
            // hesapAçToolStripMenuItem
            // 
            this.hesapAçToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hesapAçToolStripMenuItem.Name = "hesapAçToolStripMenuItem";
            this.hesapAçToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hesapAçToolStripMenuItem.Text = "Para Yatir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hesabın Şubesi";
            // 
            // txtHesabinSubesi
            // 
            this.txtHesabinSubesi.Location = new System.Drawing.Point(136, 69);
            this.txtHesabinSubesi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHesabinSubesi.Name = "txtHesabinSubesi";
            this.txtHesabinSubesi.Size = new System.Drawing.Size(114, 27);
            this.txtHesabinSubesi.TabIndex = 4;
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.Location = new System.Drawing.Point(77, 123);
            this.btnHesapOlustur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(114, 41);
            this.btnHesapOlustur.TabIndex = 5;
            this.btnHesapOlustur.Text = "Hesap Oluştur";
            this.btnHesapOlustur.UseVisualStyleBackColor = true;
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHesapOlustur);
            this.panel1.Controls.Add(this.txtHesabinSubesi);
            this.panel1.Location = new System.Drawing.Point(316, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 244);
            this.panel1.TabIndex = 6;
            // 
            // havaleYapToolStripMenuItem
            // 
            this.havaleYapToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.havaleYapToolStripMenuItem.Name = "havaleYapToolStripMenuItem";
            this.havaleYapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.havaleYapToolStripMenuItem.Text = "Havale Yap";
            // 
            // HesapAcma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HesapAcma";
            this.Text = "Hesap Açma";
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
        private TextBox txtHesabinSubesi;
        private Button btnHesapOlustur;
        private Panel panel1;
        private ToolStripMenuItem havaleYapToolStripMenuItem;
    }
}