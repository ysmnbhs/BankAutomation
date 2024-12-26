namespace OOP_Final_Projesi
{
    partial class Hesaplarım
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
            this.btnSeciliHesabaGec = new System.Windows.Forms.Button();
            this.btnYeniHesapAc = new System.Windows.Forms.Button();
            this.lvHesaplarım = new System.Windows.Forms.ListView();
            this.txtHesabinSahibi = new System.Windows.Forms.TextBox();
            this.LblHesabinSahibi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeciliHesabaGec
            // 
            this.btnSeciliHesabaGec.Location = new System.Drawing.Point(465, 475);
            this.btnSeciliHesabaGec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeciliHesabaGec.Name = "btnSeciliHesabaGec";
            this.btnSeciliHesabaGec.Size = new System.Drawing.Size(126, 57);
            this.btnSeciliHesabaGec.TabIndex = 7;
            this.btnSeciliHesabaGec.Text = "Seçili Hesaba Geç";
            this.btnSeciliHesabaGec.UseVisualStyleBackColor = true;
            this.btnSeciliHesabaGec.Click += new System.EventHandler(this.btnSeciliHesabaGec_Click);
            // 
            // btnYeniHesapAc
            // 
            this.btnYeniHesapAc.Location = new System.Drawing.Point(302, 475);
            this.btnYeniHesapAc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYeniHesapAc.Name = "btnYeniHesapAc";
            this.btnYeniHesapAc.Size = new System.Drawing.Size(126, 57);
            this.btnYeniHesapAc.TabIndex = 8;
            this.btnYeniHesapAc.Text = "Yeni Hesap Aç";
            this.btnYeniHesapAc.UseVisualStyleBackColor = true;
            this.btnYeniHesapAc.Click += new System.EventHandler(this.btnYeniHesapAc_Click);
            // 
            // lvHesaplarım
            // 
            this.lvHesaplarım.Location = new System.Drawing.Point(124, 91);
            this.lvHesaplarım.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvHesaplarım.Name = "lvHesaplarım";
            this.lvHesaplarım.Size = new System.Drawing.Size(665, 359);
            this.lvHesaplarım.TabIndex = 9;
            this.lvHesaplarım.UseCompatibleStateImageBehavior = false;
            this.lvHesaplarım.View = System.Windows.Forms.View.Details;
            this.lvHesaplarım.SelectedIndexChanged += new System.EventHandler(this.lvHesaplarım_SelectedIndexChanged);
            // 
            // txtHesabinSahibi
            // 
            this.txtHesabinSahibi.Location = new System.Drawing.Point(237, 52);
            this.txtHesabinSahibi.Name = "txtHesabinSahibi";
            this.txtHesabinSahibi.ReadOnly = true;
            this.txtHesabinSahibi.Size = new System.Drawing.Size(125, 27);
            this.txtHesabinSahibi.TabIndex = 10;
            // 
            // LblHesabinSahibi
            // 
            this.LblHesabinSahibi.AutoSize = true;
            this.LblHesabinSahibi.Location = new System.Drawing.Point(124, 55);
            this.LblHesabinSahibi.Name = "LblHesabinSahibi";
            this.LblHesabinSahibi.Size = new System.Drawing.Size(107, 20);
            this.LblHesabinSahibi.TabIndex = 11;
            this.LblHesabinSahibi.Text = "HesabinSahibi:";
            // 
            // Hesaplarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.LblHesabinSahibi);
            this.Controls.Add(this.txtHesabinSahibi);
            this.Controls.Add(this.lvHesaplarım);
            this.Controls.Add(this.btnYeniHesapAc);
            this.Controls.Add(this.btnSeciliHesabaGec);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Hesaplarım";
            this.Text = "Hesaplarım";
            this.Load += new System.EventHandler(this.Hesaplarım_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSeciliHesabaGec;
        private Button btnYeniHesapAc;
        private ListView lvHesaplarım;
        private TextBox txtHesabinSahibi;
        private Label LblHesabinSahibi;
    }
}