using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DOMAIN;

namespace WindowsFormsApp1.DAL
{
    class odaDAO
    {
        public class OdaVeriErisim
        {
            public DataTable OdalariGetir()
            {
                DataTable odaTablosu = new DataTable();
                string sorgu = "SELECT * FROM tbl_oda";
                using (MySqlCommand komut = new MySqlCommand(sorgu, new baglanti().baglantiGetir()))
                {
                    MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);
                    adaptor.Fill(odaTablosu);
                }
                return odaTablosu;
            }
        }
    
        public void OdaEkle( string Oturu, int Ofiyat, string Odurum)
        {
            string kaydet = "INSERT INTO tbl_oda (Oda_turu, Oda_fiyatı,Oda_Durumu) VALUES (@Oda_turu,@Oda_fiyatı, @Oda_Durumu)";
            using (MySqlCommand komut = new MySqlCommand(kaydet, new baglanti().baglantiGetir()))
            {               
                komut.Parameters.AddWithValue("@Oda_turu", Oturu);
                komut.Parameters.AddWithValue("@Oda_fiyatı", Ofiyat);
                komut.Parameters.AddWithValue("@Oda_Durumu", Odurum);
                komut.ExecuteNonQuery();
            }
        }
        public void OdaGuncelle(int oNo, string Oturu, int Ofiyat, string Odurum)
        {
            string guncelle = "UPDATE tbl_oda SET oda_turu = @Oda_turu, Oda_fiyatı = @Oda_fiyatı, Oda_Durumu = @Oda_Durumu WHERE Oda_Id = @Oda_Id";
            using (MySqlCommand komut = new MySqlCommand(guncelle, new baglanti().baglantiGetir()))
            {
                komut.Parameters.AddWithValue("@Oda_Id", oNo);
                komut.Parameters.AddWithValue("@Oda_turu", Oturu);
                komut.Parameters.AddWithValue("@Oda_fiyatı", Ofiyat);
                komut.Parameters.AddWithValue("@Oda_Durumu", Odurum);
                komut.ExecuteNonQuery();
            }
        }
        public void OdaSil(int id)
        {
            string sorgu = "DELETE FROM tbl_oda WHERE Oda_Id = @Oda_Id";

            using (MySqlCommand komut = new MySqlCommand(sorgu, new baglanti().baglantiGetir()))
            {
                komut.Parameters.AddWithValue("@Oda_Id", id);
                komut.ExecuteNonQuery();
            }
        }
    }
}