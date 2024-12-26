namespace OOP_Final_Projesi
{
    partial class HesapOzeti
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
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.lvHesapOzeti = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(375, 472);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(130, 69);
            this.btnAnaSayfa.TabIndex = 13;
            this.btnAnaSayfa.Text = "Ana Sayfa Don";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // lvHesapOzeti
            // 
            this.lvHesapOzeti.Location = new System.Drawing.Point(34, 39);
            this.lvHesapOzeti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvHesapOzeti.Name = "lvHesapOzeti";
            this.lvHesapOzeti.Size = new System.Drawing.Size(845, 404);
            this.lvHesapOzeti.TabIndex = 14;
            this.lvHesapOzeti.UseCompatibleStateImageBehavior = false;
            this.lvHesapOzeti.View = System.Windows.Forms.View.Details;
            // 
            // HesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lvHesapOzeti);
            this.Controls.Add(this.btnAnaSayfa);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HesapOzeti";
            this.Text = "Hesap Özeti";
            this.Load += new System.EventHandler(this.HesapOzeti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnaSayfa;
        private ListView lvHesapOzeti;
    }
}