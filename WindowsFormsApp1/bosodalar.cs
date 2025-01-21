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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.Service.OdaService;

namespace WindowsFormsApp1
{
    public partial class bosodalar : Form
    {
        public string odano { get { return txtodano.Text; } }
        public bosodalar()
        {
            InitializeComponent();
        }
        //private OdaIslemleri odaIslemleri = new OdaIslemleri();
        //private void OdaBilgileriniYukle()
        //{
        //    dataGridView1.DataSource = odaIslemleri.OdalarıListele();
        //}
        private void bosodalar_Load(object sender, EventArgs e)
        {
            //    /*OdaBilgileriniYukle*/();
            odayukle();
        }
        private void odayukle()
        {
            string sorgu = "SELECT * FROM tbl_oda WHERE Oda_Durumu = 'bos'";
            using (MySqlCommand komut = new MySqlCommand(sorgu, new baglanti().baglantiGetir()))
            {
                MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);

                DataTable dt = new DataTable();
                adaptor.Fill(dt);
                dataGridView1.DataSource = dt; 
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
                txtodano.Text = satir.Cells["Oda_Id"].Value?.ToString();

            }
        }

        private void btnseç_Click(object sender, EventArgs e)
        {        
            try
            {
                if (string.IsNullOrEmpty(txtodano.Text))
                {
                    MessageBox.Show("Lütfen bir Oda_Id seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                    int odaId = int.Parse(txtodano.Text);
                    string query = "UPDATE tbl_oda SET Oda_Durumu = 'Dolu' WHERE Oda_Id = @odaId AND Oda_Durumu = 'Boş'";
                    MySqlCommand komut = new MySqlCommand(query, new baglanti().baglantiGetir());
                    // Parametre ekle
                    komut.Parameters.AddWithValue("@odaId", odaId);
                    int rowsAffected = komut.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Oda durumu başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız. Oda zaten dolu olabilir veya Oda_Id geçerli değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
