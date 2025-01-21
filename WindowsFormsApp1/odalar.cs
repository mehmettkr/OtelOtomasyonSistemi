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
using WindowsFormsApp1.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.DAL.odaDAO;
using static WindowsFormsApp1.Service.musteriService;
using static WindowsFormsApp1.Service.OdaService;

namespace WindowsFormsApp1
{
    public partial class odalar : Form
    {
        public odalar()
        {
            InitializeComponent();
        }
        private OdaIslemleri odaIslemleri = new OdaIslemleri();
        private void OdaBilgileriniYukle()
        {
            dataGridView1.DataSource = odaIslemleri.OdalarıListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void odalar_Load(object sender, EventArgs e)
        {
                OdaBilgileriniYukle();
            txtOdaFiyat.Focus();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void rdrDolu_CheckedChanged(object sender, EventArgs e)
        {
            lblDoluluk.Text = "Dolu";
        }

        private void rdrBoş_CheckedChanged(object sender, EventArgs e)
        {
            lblDoluluk.Text = "Boş";
        }

        private void btnodakaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //int OdaId = int.Parse(txtodaNo.Text);
                int fiyat = int.Parse(txtOdaFiyat.Text);
                string tür = cmcboxOdatur.Text;
                string durum = lblDoluluk.Text;

                (new OdaService()).OdaEkle(fiyat, tür, durum);
                MessageBox.Show("Yeni oda başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
            OdaBilgileriniYukle();
        }

        private void btnodadüzenle_Click(object sender, EventArgs e)
        {
            
            try
            {
                int OdaId = int.Parse(txtodaNo.Text);
                int fiyat = int.Parse(txtOdaFiyat.Text);
                string tür = cmcboxOdatur.Text;
                string durum = lblDoluluk.Text;

                (new OdaService()).OdaGuncelle(OdaId,tür,fiyat, durum);
                MessageBox.Show("Oda başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
            OdaBilgileriniYukle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtodaNo.ReadOnly = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
                txtOdaFiyat.Text = satir.Cells["Oda_fiyatı"].Value?.ToString();
                cmcboxOdatur.Text = satir.Cells["Oda_turu"].Value?.ToString();
                lblDoluluk.Text = satir.Cells["Oda_Durumu"].Value?.ToString();
                txtodaNo.Text = satir.Cells["Oda_Id"].Value?.ToString();

            }
        }

        private void btnodasil_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtodaNo.Text, out id))
            {
                MessageBox.Show("Lütfen geçerli bir ID seçin.");
                return;
            }
            new OdaService().OdaSil(id);
            MessageBox.Show("Oda başarıyla silindi!");
            OdaBilgileriniYukle();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            new menuform().Show(); this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
