namespace WindowsFormsApp1
{
    partial class menuform
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
            this.btndön = new System.Windows.Forms.Button();
            this.btnOdaEkran = new System.Windows.Forms.Button();
            this.btnrezarvasyon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndön
            // 
            this.btndön.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btndön.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndön.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndön.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndön.Location = new System.Drawing.Point(532, 507);
            this.btndön.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndön.Name = "btndön";
            this.btndön.Size = new System.Drawing.Size(184, 46);
            this.btndön.TabIndex = 1;
            this.btndön.Text = "Ana Menüye Dön";
            this.btndön.UseVisualStyleBackColor = false;
            this.btndön.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdaEkran
            // 
            this.btnOdaEkran.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOdaEkran.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdaEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaEkran.Location = new System.Drawing.Point(253, 102);
            this.btnOdaEkran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdaEkran.Name = "btnOdaEkran";
            this.btnOdaEkran.Size = new System.Drawing.Size(293, 167);
            this.btnOdaEkran.TabIndex = 2;
            this.btnOdaEkran.Text = "Oda Ekranı";
            this.btnOdaEkran.UseVisualStyleBackColor = false;
            this.btnOdaEkran.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrezarvasyon
            // 
            this.btnrezarvasyon.BackColor = System.Drawing.Color.Maroon;
            this.btnrezarvasyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrezarvasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrezarvasyon.Location = new System.Drawing.Point(642, 102);
            this.btnrezarvasyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrezarvasyon.Name = "btnrezarvasyon";
            this.btnrezarvasyon.Size = new System.Drawing.Size(306, 167);
            this.btnrezarvasyon.TabIndex = 3;
            this.btnrezarvasyon.Text = "Rezarvasyon \r\nEkranı";
            this.btnrezarvasyon.UseVisualStyleBackColor = false;
            this.btnrezarvasyon.Click += new System.EventHandler(this.btnrezarvasyon_Click);
            // 
            // menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pexels_pixabay_255464;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 564);
            this.Controls.Add(this.btnrezarvasyon);
            this.Controls.Add(this.btnOdaEkran);
            this.Controls.Add(this.btndön);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menuform";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.menuform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndön;
        private System.Windows.Forms.Button btnOdaEkran;
        private System.Windows.Forms.Button btnrezarvasyon;
    }
}