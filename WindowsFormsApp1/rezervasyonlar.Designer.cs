namespace WindowsFormsApp1
{
    partial class rezervasyonlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezervasyonlar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmenu = new System.Windows.Forms.Button();
            this.ctxtodasec = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msktxtel = new System.Windows.Forms.MaskedTextBox();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.timecıkıs = new System.Windows.Forms.DateTimePicker();
            this.timegiris = new System.Windows.Forms.DateTimePicker();
            this.lblodasec = new System.Windows.Forms.Label();
            this.txtmusterisoyad = new System.Windows.Forms.TextBox();
            this.txtmusteriad = new System.Windows.Forms.TextBox();
            this.lblcıkıstarih = new System.Windows.Forms.Label();
            this.lblgiristarih = new System.Windows.Forms.Label();
            this.lblmüsteritelno = new System.Windows.Forms.Label();
            this.lblmüsterisoyadi = new System.Windows.Forms.Label();
            this.lblmüsteriadi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblmusteriid = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblmusteriid);
            this.groupBox1.Controls.Add(this.btnmenu);
            this.groupBox1.Controls.Add(this.ctxtodasec);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.msktxtel);
            this.groupBox1.Controls.Add(this.btnDüzenle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.timecıkıs);
            this.groupBox1.Controls.Add(this.timegiris);
            this.groupBox1.Controls.Add(this.lblodasec);
            this.groupBox1.Controls.Add(this.txtmusterisoyad);
            this.groupBox1.Controls.Add(this.txtmusteriad);
            this.groupBox1.Controls.Add(this.lblcıkıstarih);
            this.groupBox1.Controls.Add(this.lblgiristarih);
            this.groupBox1.Controls.Add(this.lblmüsteritelno);
            this.groupBox1.Controls.Add(this.lblmüsterisoyadi);
            this.groupBox1.Controls.Add(this.lblmüsteriadi);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(105, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1034, 292);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Rezarvasyon Ekrani";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmenu.Location = new System.Drawing.Point(887, 227);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(144, 50);
            this.btnmenu.TabIndex = 23;
            this.btnmenu.Text = "Ana Menüye Dön";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // ctxtodasec
            // 
            this.ctxtodasec.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ctxtodasec.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.ctxtodasec.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ctxtodasec.Location = new System.Drawing.Point(187, 182);
            this.ctxtodasec.Name = "ctxtodasec";
            this.ctxtodasec.Size = new System.Drawing.Size(172, 32);
            this.ctxtodasec.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(61, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Oda Seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msktxtel
            // 
            this.msktxtel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.msktxtel.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.msktxtel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.msktxtel.Location = new System.Drawing.Point(191, 139);
            this.msktxtel.Mask = "(999) 000-0000";
            this.msktxtel.Name = "msktxtel";
            this.msktxtel.Size = new System.Drawing.Size(172, 34);
            this.msktxtel.TabIndex = 35;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDüzenle.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDüzenle.Location = new System.Drawing.Point(598, 162);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(127, 73);
            this.btnDüzenle.TabIndex = 33;
            this.btnDüzenle.Text = "Müşteri Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(731, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(118, 73);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaydet.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(474, 162);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 73);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "Müşteri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // timecıkıs
            // 
            this.timecıkıs.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.timecıkıs.Location = new System.Drawing.Point(638, 92);
            this.timecıkıs.Name = "timecıkıs";
            this.timecıkıs.Size = new System.Drawing.Size(176, 34);
            this.timecıkıs.TabIndex = 30;
            // 
            // timegiris
            // 
            this.timegiris.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.timegiris.Location = new System.Drawing.Point(638, 60);
            this.timegiris.Name = "timegiris";
            this.timegiris.Size = new System.Drawing.Size(176, 34);
            this.timegiris.TabIndex = 29;
            // 
            // lblodasec
            // 
            this.lblodasec.AutoSize = true;
            this.lblodasec.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblodasec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblodasec.Location = new System.Drawing.Point(30, 188);
            this.lblodasec.Name = "lblodasec";
            this.lblodasec.Size = new System.Drawing.Size(149, 26);
            this.lblodasec.TabIndex = 26;
            this.lblodasec.Text = "Oda Numarası :";
            // 
            // txtmusterisoyad
            // 
            this.txtmusterisoyad.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtmusterisoyad.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtmusterisoyad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmusterisoyad.Location = new System.Drawing.Point(191, 101);
            this.txtmusterisoyad.Name = "txtmusterisoyad";
            this.txtmusterisoyad.Size = new System.Drawing.Size(172, 32);
            this.txtmusterisoyad.TabIndex = 20;
            // 
            // txtmusteriad
            // 
            this.txtmusteriad.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtmusteriad.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.txtmusteriad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmusteriad.Location = new System.Drawing.Point(191, 63);
            this.txtmusteriad.Name = "txtmusteriad";
            this.txtmusteriad.Size = new System.Drawing.Size(172, 34);
            this.txtmusteriad.TabIndex = 19;
            // 
            // lblcıkıstarih
            // 
            this.lblcıkıstarih.AutoSize = true;
            this.lblcıkıstarih.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.lblcıkıstarih.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcıkıstarih.Location = new System.Drawing.Point(478, 92);
            this.lblcıkıstarih.Name = "lblcıkıstarih";
            this.lblcıkıstarih.Size = new System.Drawing.Size(124, 26);
            this.lblcıkıstarih.TabIndex = 18;
            this.lblcıkıstarih.Text = "Çıkış Tarihi :";
            // 
            // lblgiristarih
            // 
            this.lblgiristarih.AutoSize = true;
            this.lblgiristarih.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.lblgiristarih.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblgiristarih.Location = new System.Drawing.Point(481, 60);
            this.lblgiristarih.Name = "lblgiristarih";
            this.lblgiristarih.Size = new System.Drawing.Size(122, 26);
            this.lblgiristarih.TabIndex = 17;
            this.lblgiristarih.Text = "Giriş Tarihi :";
            // 
            // lblmüsteritelno
            // 
            this.lblmüsteritelno.AutoSize = true;
            this.lblmüsteritelno.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmüsteritelno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmüsteritelno.Location = new System.Drawing.Point(4, 142);
            this.lblmüsteritelno.Name = "lblmüsteritelno";
            this.lblmüsteritelno.Size = new System.Drawing.Size(177, 26);
            this.lblmüsteritelno.TabIndex = 16;
            this.lblmüsteritelno.Text = "Telefon Numarası :";
            // 
            // lblmüsterisoyadi
            // 
            this.lblmüsterisoyadi.AutoSize = true;
            this.lblmüsterisoyadi.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmüsterisoyadi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmüsterisoyadi.Location = new System.Drawing.Point(30, 103);
            this.lblmüsterisoyadi.Name = "lblmüsterisoyadi";
            this.lblmüsterisoyadi.Size = new System.Drawing.Size(151, 26);
            this.lblmüsterisoyadi.TabIndex = 13;
            this.lblmüsterisoyadi.Text = "Müşteri Soyadı :";
            // 
            // lblmüsteriadi
            // 
            this.lblmüsteriadi.AutoSize = true;
            this.lblmüsteriadi.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmüsteriadi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmüsteriadi.Location = new System.Drawing.Point(56, 66);
            this.lblmüsteriadi.Name = "lblmüsteriadi";
            this.lblmüsteriadi.Size = new System.Drawing.Size(125, 26);
            this.lblmüsteriadi.TabIndex = 12;
            this.lblmüsteriadi.Text = "Müşteri Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(105, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 209);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblmusteriid
            // 
            this.lblmusteriid.AutoSize = true;
            this.lblmusteriid.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusteriid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmusteriid.Location = new System.Drawing.Point(66, 30);
            this.lblmusteriid.Name = "lblmusteriid";
            this.lblmusteriid.Size = new System.Drawing.Size(113, 26);
            this.lblmusteriid.TabIndex = 40;
            this.lblmusteriid.Text = "Müşteri Id :";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtId.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(191, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(172, 34);
            this.txtId.TabIndex = 41;
            // 
            // rezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pexels_pixabay_2554641;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rezervasyonlar";
            this.Text = "rezervasyonlar";
            this.Load += new System.EventHandler(this.rezervasyonlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmusterisoyad;
        private System.Windows.Forms.TextBox txtmusteriad;
        private System.Windows.Forms.Label lblcıkıstarih;
        private System.Windows.Forms.Label lblgiristarih;
        private System.Windows.Forms.Label lblmüsteritelno;
        private System.Windows.Forms.Label lblmüsterisoyadi;
        private System.Windows.Forms.Label lblmüsteriadi;
        private System.Windows.Forms.DateTimePicker timecıkıs;
        private System.Windows.Forms.DateTimePicker timegiris;
        private System.Windows.Forms.Label lblodasec;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox msktxtel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ctxtodasec;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblmusteriid;
    }
}