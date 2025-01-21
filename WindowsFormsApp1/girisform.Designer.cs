namespace WindowsFormsApp1
{
    partial class girisform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisform));
            this.lblkulad = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.lblotelisim = new System.Windows.Forms.Label();
            this.btnSiferUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblkulad
            // 
            this.lblkulad.AutoSize = true;
            this.lblkulad.BackColor = System.Drawing.Color.Black;
            this.lblkulad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblkulad.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkulad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblkulad.Location = new System.Drawing.Point(406, 187);
            this.lblkulad.Name = "lblkulad";
            this.lblkulad.Size = new System.Drawing.Size(148, 44);
            this.lblkulad.TabIndex = 2;
            this.lblkulad.Text = "Admin :";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Black;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsifre.Location = new System.Drawing.Point(440, 253);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(114, 44);
            this.lblsifre.TabIndex = 3;
            this.lblsifre.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKullaniciAdi.HideSelection = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(603, 184);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(199, 49);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Black;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSifre.Location = new System.Drawing.Point(603, 253);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(199, 49);
            this.txtSifre.TabIndex = 5;
            // 
            // btngirisyap
            // 
            this.btngirisyap.BackColor = System.Drawing.Color.DimGray;
            this.btngirisyap.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.login;
            this.btngirisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngirisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngirisyap.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngirisyap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngirisyap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngirisyap.Location = new System.Drawing.Point(603, 316);
            this.btngirisyap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(200, 90);
            this.btngirisyap.TabIndex = 0;
            this.btngirisyap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngirisyap.UseVisualStyleBackColor = false;
            this.btngirisyap.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblotelisim
            // 
            this.lblotelisim.AutoSize = true;
            this.lblotelisim.BackColor = System.Drawing.Color.Black;
            this.lblotelisim.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblotelisim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblotelisim.Location = new System.Drawing.Point(256, 37);
            this.lblotelisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblotelisim.Name = "lblotelisim";
            this.lblotelisim.Size = new System.Drawing.Size(756, 97);
            this.lblotelisim.TabIndex = 6;
            this.lblotelisim.Text = "Signal İduna Bafra Otel\r\n";
            // 
            // btnSiferUnuttum
            // 
            this.btnSiferUnuttum.BackColor = System.Drawing.Color.Black;
            this.btnSiferUnuttum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiferUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiferUnuttum.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiferUnuttum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiferUnuttum.Location = new System.Drawing.Point(603, 430);
            this.btnSiferUnuttum.Name = "btnSiferUnuttum";
            this.btnSiferUnuttum.Size = new System.Drawing.Size(200, 51);
            this.btnSiferUnuttum.TabIndex = 7;
            this.btnSiferUnuttum.Text = "Şifremi Unuttum";
            this.btnSiferUnuttum.UseVisualStyleBackColor = false;
            this.btnSiferUnuttum.Click += new System.EventHandler(this.btnSiferUnuttum_Click);
            // 
            // girisform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pexels_pixabay_255464;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 637);
            this.Controls.Add(this.btnSiferUnuttum);
            this.Controls.Add(this.lblotelisim);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkulad);
            this.Controls.Add(this.btngirisyap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "girisform";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.Label lblkulad;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblotelisim;
        private System.Windows.Forms.Button btnSiferUnuttum;
    }
}

