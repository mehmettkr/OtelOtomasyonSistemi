using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public partial class Sunuttumform : Form
    {
        public Sunuttumform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string ksoyad = txtSifre.Text;
            string d = "SELECT COUNT(*) FROM tbl_Yonetici WHERE Yonetici_ad = @Yonetici_ad AND Yonetici_KızlıkSoyad = @Yonetici_KızlıkSoyad";
            MySqlCommand cmd = new MySqlCommand(d, new baglanti().baglantiGetir());

            cmd.Parameters.AddWithValue("@Yonetici_ad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@Yonetici_KızlıkSoyad", ksoyad);

            // Sonucu kontrol et
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Burada başka bir forma geçiş yapabilirsiniz
                new menuform().Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngeridön_Click(object sender, EventArgs e)
        {
            girisform fr = new girisform();
            fr.Show();
            this.Close();
        }

        private void Sunuttumform_Load(object sender, EventArgs e)
        {
            lblkulad.BackColor = Color.Transparent;
            lblsifre.BackColor = Color.Transparent;
        }
    }
}
