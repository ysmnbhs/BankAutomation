namespace OOP_Final_Projesi
{
    partial class GirisYap
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
            this.components = new System.ComponentModel.Container();
            this.kullaniciTcLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.GirisPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.GirisPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciTcLbl
            // 
            this.kullaniciTcLbl.AutoSize = true;
            this.kullaniciTcLbl.Location = new System.Drawing.Point(72, 74);
            this.kullaniciTcLbl.Name = "kullaniciTcLbl";
            this.kullaniciTcLbl.Size = new System.Drawing.Size(208, 20);
            this.kullaniciTcLbl.TabIndex = 0;
            this.kullaniciTcLbl.Text = "Kullanicinin TC/ Firma sicil No:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(88, 28);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.bToolStripMenuItem.Text = "b";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(115, 106);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(125, 27);
            this.txtTc.TabIndex = 2;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(84, 162);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(94, 29);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giris Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(186, 162);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(94, 29);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // GirisPanel
            // 
            this.GirisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GirisPanel.Controls.Add(this.txtTc);
            this.GirisPanel.Controls.Add(this.kullaniciTcLbl);
            this.GirisPanel.Controls.Add(this.btnIptal);
            this.GirisPanel.Controls.Add(this.btnGiris);
            this.GirisPanel.Location = new System.Drawing.Point(216, 91);
            this.GirisPanel.Name = "GirisPanel";
            this.GirisPanel.Size = new System.Drawing.Size(335, 244);
            this.GirisPanel.TabIndex = 5;
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GirisPanel);
            this.Name = "GirisYap";
            this.Text = "GirisYap";
            this.contextMenuStrip1.ResumeLayout(false);
            this.GirisPanel.ResumeLayout(false);
            this.GirisPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label kullaniciTcLbl;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem bToolStripMenuItem;
        private TextBox txtTc;
        private Button btnGiris;
        private Button btnIptal;
        private Panel GirisPanel;
    }
}