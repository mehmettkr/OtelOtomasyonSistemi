namespace WindowsFormsApp1
{
    partial class odalar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdrBoş = new System.Windows.Forms.RadioButton();
            this.rdrDolu = new System.Windows.Forms.RadioButton();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnodasil = new System.Windows.Forms.Button();
            this.btnodadüzenle = new System.Windows.Forms.Button();
            this.btnodakaydet = new System.Windows.Forms.Button();
            this.lbltür = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.cmcboxOdatur = new System.Windows.Forms.ComboBox();
            this.txtOdaFiyat = new System.Windows.Forms.TextBox();
            this.txtodaNo = new System.Windows.Forms.TextBox();
            this.lblodabilgi = new System.Windows.Forms.Label();
            this.lblDoluluk = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnmenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.rdrBoş);
            this.groupBox1.Controls.Add(this.rdrDolu);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.btnodasil);
            this.groupBox1.Controls.Add(this.btnodadüzenle);
            this.groupBox1.Controls.Add(this.btnodakaydet);
            this.groupBox1.Controls.Add(this.lbltür);
            this.groupBox1.Controls.Add(this.lblfiyat);
            this.groupBox1.Controls.Add(this.lblOdaNo);
            this.groupBox1.Controls.Add(this.cmcboxOdatur);
            this.groupBox1.Controls.Add(this.txtOdaFiyat);
            this.groupBox1.Controls.Add(this.txtodaNo);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(81, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(377, 361);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oda Ekleme";
            // 
            // rdrBoş
            // 
            this.rdrBoş.AutoSize = true;
            this.rdrBoş.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdrBoş.Location = new System.Drawing.Point(280, 163);
            this.rdrBoş.Name = "rdrBoş";
            this.rdrBoş.Size = new System.Drawing.Size(62, 24);
            this.rdrBoş.TabIndex = 21;
            this.rdrBoş.TabStop = true;
            this.rdrBoş.Text = "Boş";
            this.rdrBoş.UseVisualStyleBackColor = true;
            this.rdrBoş.CheckedChanged += new System.EventHandler(this.rdrBoş_CheckedChanged);
            // 
            // rdrDolu
            // 
            this.rdrDolu.AutoSize = true;
            this.rdrDolu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdrDolu.Location = new System.Drawing.Point(193, 163);
            this.rdrDolu.Name = "rdrDolu";
            this.rdrDolu.Size = new System.Drawing.Size(68, 24);
            this.rdrDolu.TabIndex = 20;
            this.rdrDolu.TabStop = true;
            this.rdrDolu.Text = "Dolu";
            this.rdrDolu.UseVisualStyleBackColor = true;
            this.rdrDolu.CheckedChanged += new System.EventHandler(this.rdrDolu_CheckedChanged);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDurum.Location = new System.Drawing.Point(6, 156);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(157, 25);
            this.lblDurum.TabIndex = 19;
            this.lblDurum.Text = "Oda Durumu :";
            // 
            // btnodasil
            // 
            this.btnodasil.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnodasil.ForeColor = System.Drawing.Color.Black;
            this.btnodasil.Location = new System.Drawing.Point(34, 295);
            this.btnodasil.Name = "btnodasil";
            this.btnodasil.Size = new System.Drawing.Size(265, 45);
            this.btnodasil.TabIndex = 18;
            this.btnodasil.Text = "Oda Sil";
            this.btnodasil.UseVisualStyleBackColor = true;
            this.btnodasil.Click += new System.EventHandler(this.btnodasil_Click);
            // 
            // btnodadüzenle
            // 
            this.btnodadüzenle.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnodadüzenle.ForeColor = System.Drawing.Color.Black;
            this.btnodadüzenle.Location = new System.Drawing.Point(34, 244);
            this.btnodadüzenle.Name = "btnodadüzenle";
            this.btnodadüzenle.Size = new System.Drawing.Size(265, 45);
            this.btnodadüzenle.TabIndex = 17;
            this.btnodadüzenle.Text = "Oda Düzenle";
            this.btnodadüzenle.UseVisualStyleBackColor = true;
            this.btnodadüzenle.Click += new System.EventHandler(this.btnodadüzenle_Click);
            // 
            // btnodakaydet
            // 
            this.btnodakaydet.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnodakaydet.ForeColor = System.Drawing.Color.Black;
            this.btnodakaydet.Location = new System.Drawing.Point(34, 193);
            this.btnodakaydet.Name = "btnodakaydet";
            this.btnodakaydet.Size = new System.Drawing.Size(265, 45);
            this.btnodakaydet.TabIndex = 16;
            this.btnodakaydet.Text = "Oda Kaydet";
            this.btnodakaydet.UseVisualStyleBackColor = true;
            this.btnodakaydet.Click += new System.EventHandler(this.btnodakaydet_Click);
            // 
            // lbltür
            // 
            this.lbltür.AutoSize = true;
            this.lbltür.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltür.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbltür.Location = new System.Drawing.Point(40, 118);
            this.lbltür.Name = "lbltür";
            this.lbltür.Size = new System.Drawing.Size(123, 25);
            this.lbltür.TabIndex = 15;
            this.lbltür.Text = "Oda Türü :";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblfiyat.Location = new System.Drawing.Point(29, 80);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(134, 25);
            this.lblfiyat.TabIndex = 14;
            this.lblfiyat.Text = "Oda Fiyatı :";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOdaNo.Location = new System.Drawing.Point(58, 42);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(105, 25);
            this.lblOdaNo.TabIndex = 13;
            this.lblOdaNo.Text = "Oda NO :";
            // 
            // cmcboxOdatur
            // 
            this.cmcboxOdatur.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmcboxOdatur.ForeColor = System.Drawing.Color.Black;
            this.cmcboxOdatur.FormattingEnabled = true;
            this.cmcboxOdatur.Items.AddRange(new object[] {
            "Tek Kişilik",
            "Çift Kişilik",
            "Aile Odası"});
            this.cmcboxOdatur.Location = new System.Drawing.Point(206, 118);
            this.cmcboxOdatur.Name = "cmcboxOdatur";
            this.cmcboxOdatur.Size = new System.Drawing.Size(141, 33);
            this.cmcboxOdatur.TabIndex = 11;
            // 
            // txtOdaFiyat
            // 
            this.txtOdaFiyat.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtOdaFiyat.ForeColor = System.Drawing.Color.Black;
            this.txtOdaFiyat.Location = new System.Drawing.Point(206, 81);
            this.txtOdaFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOdaFiyat.Name = "txtOdaFiyat";
            this.txtOdaFiyat.Size = new System.Drawing.Size(141, 32);
            this.txtOdaFiyat.TabIndex = 10;
            // 
            // txtodaNo
            // 
            this.txtodaNo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtodaNo.ForeColor = System.Drawing.Color.Black;
            this.txtodaNo.Location = new System.Drawing.Point(206, 42);
            this.txtodaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtodaNo.Name = "txtodaNo";
            this.txtodaNo.ReadOnly = true;
            this.txtodaNo.Size = new System.Drawing.Size(141, 32);
            this.txtodaNo.TabIndex = 9;
            // 
            // lblodabilgi
            // 
            this.lblodabilgi.AutoSize = true;
            this.lblodabilgi.BackColor = System.Drawing.Color.White;
            this.lblodabilgi.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblodabilgi.Location = new System.Drawing.Point(785, 43);
            this.lblodabilgi.Name = "lblodabilgi";
            this.lblodabilgi.Size = new System.Drawing.Size(147, 25);
            this.lblodabilgi.TabIndex = 19;
            this.lblodabilgi.Text = "Oda Bilgileri";
            // 
            // lblDoluluk
            // 
            this.lblDoluluk.AutoSize = true;
            this.lblDoluluk.Location = new System.Drawing.Point(9, 646);
            this.lblDoluluk.Name = "lblDoluluk";
            this.lblDoluluk.Size = new System.Drawing.Size(44, 16);
            this.lblDoluluk.TabIndex = 20;
            this.lblDoluluk.Text = "label1";
            this.lblDoluluk.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(486, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 351);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oda Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmenu.Location = new System.Drawing.Point(1040, 524);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(174, 33);
            this.btnmenu.TabIndex = 22;
            this.btnmenu.Text = "Ana Menüye Dön";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pexels_pixabay_255464;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 649);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDoluluk);
            this.Controls.Add(this.lblodabilgi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "odalar";
            this.Text = "odalar";
            this.Load += new System.EventHandler(this.odalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOdaFiyat;
        private System.Windows.Forms.TextBox txtodaNo;
        private System.Windows.Forms.ComboBox cmcboxOdatur;
        private System.Windows.Forms.Label lbltür;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Button btnodasil;
        private System.Windows.Forms.Button btnodadüzenle;
        private System.Windows.Forms.Button btnodakaydet;
        private System.Windows.Forms.Label lblodabilgi;
        private System.Windows.Forms.RadioButton rdrBoş;
        private System.Windows.Forms.RadioButton rdrDolu;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblDoluluk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnmenu;
    }
}