namespace OOP_Final_Projesi
{
    partial class SeciliHesap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeciliHesapNo = new System.Windows.Forms.TextBox();
            this.txtSeciliHesapBakiye = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnHavaleYap = new System.Windows.Forms.Button();
            this.btnÖzet = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.tutarLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bakiye       :";
            // 
            // txtSeciliHesapNo
            // 
            this.txtSeciliHesapNo.Location = new System.Drawing.Point(116, 60);
            this.txtSeciliHesapNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeciliHesapNo.Name = "txtSeciliHesapNo";
            this.txtSeciliHesapNo.ReadOnly = true;
            this.txtSeciliHesapNo.Size = new System.Drawing.Size(114, 27);
            this.txtSeciliHesapNo.TabIndex = 2;
            // 
            // txtSeciliHesapBakiye
            // 
            this.txtSeciliHesapBakiye.Location = new System.Drawing.Point(116, 116);
            this.txtSeciliHesapBakiye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeciliHesapBakiye.Name = "txtSeciliHesapBakiye";
            this.txtSeciliHesapBakiye.ReadOnly = true;
            this.txtSeciliHesapBakiye.Size = new System.Drawing.Size(114, 27);
            this.txtSeciliHesapBakiye.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSeciliHesapBakiye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSeciliHesapNo);
            this.groupBox1.Location = new System.Drawing.Point(86, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(279, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(597, 171);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(126, 57);
            this.btnParaYatir.TabIndex = 9;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(597, 265);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(126, 57);
            this.btnParaCek.TabIndex = 10;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.Location = new System.Drawing.Point(597, 357);
            this.btnHavaleYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(126, 57);
            this.btnHavaleYap.TabIndex = 11;
            this.btnHavaleYap.Text = "Havale Yap";
            this.btnHavaleYap.UseVisualStyleBackColor = true;
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // btnÖzet
            // 
            this.btnÖzet.Location = new System.Drawing.Point(597, 465);
            this.btnÖzet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnÖzet.Name = "btnÖzet";
            this.btnÖzet.Size = new System.Drawing.Size(126, 57);
            this.btnÖzet.TabIndex = 12;
            this.btnÖzet.Text = "Özet";
            this.btnÖzet.UseVisualStyleBackColor = true;
            this.btnÖzet.Click += new System.EventHandler(this.btnÖzet_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(597, 81);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(135, 49);
            this.txtTutar.TabIndex = 13;
            // 
            // tutarLbl
            // 
            this.tutarLbl.AutoSize = true;
            this.tutarLbl.Location = new System.Drawing.Point(402, 99);
            this.tutarLbl.Name = "tutarLbl";
            this.tutarLbl.Size = new System.Drawing.Size(189, 20);
            this.tutarLbl.TabIndex = 14;
            this.tutarLbl.Text = "Yatirilacak/ Cekilecek Tutar:";
            // 
            // SeciliHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(891, 571);
            this.Controls.Add(this.tutarLbl);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnÖzet);
            this.Controls.Add(this.btnHavaleYap);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SeciliHesap";
            this.Text = "Seçili Hesap";
            this.Load += new System.EventHandler(this.SeciliHesap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSeciliHesapNo;
        private TextBox txtSeciliHesapBakiye;
        private GroupBox groupBox1;
        private Button btnParaYatir;
        private Button btnParaCek;
        private Button btnHavaleYap;
        private Button btnÖzet;
        private TextBox txtTutar;
        private Label tutarLbl;
    }
}