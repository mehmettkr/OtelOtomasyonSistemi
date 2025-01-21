namespace WindowsFormsApp1
{
    partial class Sunuttumform
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
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblkulad = new System.Windows.Forms.Label();
            this.btngir = new System.Windows.Forms.Button();
            this.btngeridön = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Black;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSifre.Location = new System.Drawing.Point(596, 207);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(199, 49);
            this.txtSifre.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(596, 141);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(199, 49);
            this.txtKullaniciAdi.TabIndex = 8;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Black;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsifre.Location = new System.Drawing.Point(357, 210);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(233, 44);
            this.lblsifre.TabIndex = 7;
            this.lblsifre.Text = "Gizli Kelime :";
            // 
            // lblkulad
            // 
            this.lblkulad.AutoSize = true;
            this.lblkulad.BackColor = System.Drawing.Color.Black;
            this.lblkulad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblkulad.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkulad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblkulad.Location = new System.Drawing.Point(442, 144);
            this.lblkulad.Name = "lblkulad";
            this.lblkulad.Size = new System.Drawing.Size(148, 44);
            this.lblkulad.TabIndex = 6;
            this.lblkulad.Text = "Admin :";
            // 
            // btngir
            // 
            this.btngir.BackColor = System.Drawing.Color.Black;
            this.btngir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngir.Location = new System.Drawing.Point(596, 280);
            this.btngir.Name = "btngir";
            this.btngir.Size = new System.Drawing.Size(199, 60);
            this.btngir.TabIndex = 10;
            this.btngir.Text = "Giriş Yap";
            this.btngir.UseVisualStyleBackColor = false;
            this.btngir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngeridön
            // 
            this.btngeridön.BackColor = System.Drawing.Color.Black;
            this.btngeridön.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeridön.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngeridön.Location = new System.Drawing.Point(596, 421);
            this.btngeridön.Name = "btngeridön";
            this.btngeridön.Size = new System.Drawing.Size(199, 33);
            this.btngeridön.TabIndex = 11;
            this.btngeridön.Text = "Geri Dön";
            this.btngeridön.UseVisualStyleBackColor = false;
            this.btngeridön.Click += new System.EventHandler(this.btngeridön_Click);
            // 
            // Sunuttumform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pexels_pixabay_255464;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 631);
            this.Controls.Add(this.btngeridön);
            this.Controls.Add(this.btngir);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkulad);
            this.Name = "Sunuttumform";
            this.Text = "Sunuttumform";
            this.Load += new System.EventHandler(this.Sunuttumform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblkulad;
        private System.Windows.Forms.Button btngir;
        private System.Windows.Forms.Button btngeridön;
    }
}