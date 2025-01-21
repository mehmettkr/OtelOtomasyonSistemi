using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DOMAIN;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Service;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;
using static WindowsFormsApp1.Service.musteriService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace WindowsFormsApp1
{
    public partial class rezervasyonlar : Form
    {
        public string AlinanDeger { get; set; }
        private MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
        public rezervasyonlar()
        {
            InitializeComponent();
        }        
        private void MusteriBilgileriniYukle()
        {
            try
            {
                dataGridView1.DataSource = musteriIslemleri.MusterileriListele();
            }
            catch (Exception hata)
            {
                MessageBox.Show($"Müşteri bilgileri yüklenirken hata oluştu: {hata.Message}");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {     
                try
                {
                    string ad = txtmusteriad.Text;
                    string soyad = txtmusterisoyad.Text;
                    string tel = msktxtel.Text;
                    string oda = ctxtodasec.Text;
                    string giris=timegiris.Value.ToString("dd-MM-yyyy");
                    string cikis=timecıkıs.Value.ToString("dd-MM-yyyy");
                (new musteriService()).MusteriEkle(ad, soyad, tel, oda,giris,cikis);
                    MessageBox.Show("Yeni müşteri başarıyla eklendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            MusteriBilgileriniYukle();
        }


        private void rezervasyonlar_Load(object sender, EventArgs e)
        {            
            MusteriBilgileriniYukle();
            ctxtodasec.Text = AlinanDeger;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(txtId.Text, out id))
                {
                    MessageBox.Show("Lütfen geçerli bir ID seçin.");
                    return;
                }       
                new musteriService().MusteriSil(id);
                MessageBox.Show("Müşteri başarıyla silindi!");
                MusteriBilgileriniYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string ad = txtmusteriad.Text;
                string soyad = txtmusterisoyad.Text;
                string tel = msktxtel.Text;
                string oda = ctxtodasec.Text;
                string giris = timegiris.Value.ToString("dd-MM-yyyy");
                string cikis = timecıkıs.Value.ToString("dd-MM-yyyy");

                new musteriService().MusteriGuncelle( id,ad, soyad,tel,oda, giris, cikis);
                MessageBox.Show("Kayıt başarıyla güncellendi!");
                MusteriBilgileriniYukle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
                txtmusteriad.Text = satir.Cells["Musteri_adi"].Value?.ToString();
                txtmusterisoyad.Text = satir.Cells["Musteri_soyadi"].Value?.ToString();
                msktxtel.Text = satir.Cells["Musteri_tel"].Value?.ToString();
                ctxtodasec.Text = satir.Cells["Musteri_odaNo"].Value?.ToString();
                timegiris.Text = satir.Cells["Musteri_giris"].Value?.ToString();
                timecıkıs.Text = satir.Cells["Musteri_cıkıs"].Value?.ToString();
                txtId.Text = satir.Cells["Musteri_id"].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bosodalar bo=new bosodalar();
            if (bo.ShowDialog() == DialogResult.OK)
            {
                // Form2'den gelen şifreyi txtSifre'ye yaz
                ctxtodasec.Text = bo.odano;
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            new menuform().Show(); this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


