using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.DOMAIN;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    class musteriDAO
    {

        public class MusteriVeriErisim
        {
            public DataTable MusterileriGetir()
            {
                DataTable musteriTablosu = new DataTable();
                string sorgu = "SELECT * FROM tbl_Müsteri";
                using (MySqlCommand komut = new MySqlCommand(sorgu, new baglanti().baglantiGetir()))
                {
                    MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);
                    adaptor.Fill(musteriTablosu);
                }
                return musteriTablosu;
            }
        }

        public void MusteriEkle(string mAd, string mSoyad, string mTel, string mOdasec, string mGir,string mCik)
        {
            string kaydet = "INSERT INTO tbl_Müsteri (Musteri_adi,Musteri_soyadi,Musteri_tel,Musteri_odaNo,Musteri_giris,Musteri_cıkıs) VALUES (@Musteri_adi, @Musteri_soyadi,@Musteri_tel, @Musteri_odaNo,@Musteri_giris,@Musteri_cıkıs)";
            using (MySqlCommand komut = new MySqlCommand(kaydet, new baglanti().baglantiGetir()))
            {
                komut.Parameters.AddWithValue("@Musteri_adi", mAd);
                komut.Parameters.AddWithValue("@Musteri_soyadi", mSoyad);
                komut.Parameters.AddWithValue("@Musteri_tel", mTel);
                komut.Parameters.AddWithValue("@Musteri_odaNo", mOdasec);
                komut.Parameters.AddWithValue("@Musteri_giris", mGir);
                komut.Parameters.AddWithValue("@Musteri_cıkıs", mCik);
                komut.ExecuteNonQuery();
            }
        }
        public void MusteriGuncelle(int mId, string mAd, string mSoyad,string mTel, string mOdasec, string mGir,string mCik)
        {
            string guncelle = "UPDATE tbl_Müsteri SET Musteri_adi = @Musteri_adi, Musteri_soyadi = @Musteri_soyadi,Musteri_tel = @Musteri_tel, Musteri_odaNo = @Musteri_odaNo, Musteri_giris = @Musteri_giris,Musteri_cıkıs=@Musteri_cıkıs WHERE Musteri_id = @Musteri_id";
            using (MySqlCommand komut = new MySqlCommand(guncelle, new baglanti().baglantiGetir()))
            {
                komut.Parameters.AddWithValue("@Musteri_id", mId);
                komut.Parameters.AddWithValue("@Musteri_adi", mAd);
                komut.Parameters.AddWithValue("@Musteri_soyadi", mSoyad);
                komut.Parameters.AddWithValue("@Musteri_tel", mTel);
                komut.Parameters.AddWithValue("@Musteri_odaNo", mOdasec);
                komut.Parameters.AddWithValue("@Musteri_giris", mGir);
                komut.Parameters.AddWithValue("@Musteri_cıkıs", mCik);
                komut.ExecuteNonQuery();
            }
        }
        public void MusteriSil(int id)
        {
            string sorgu = "DELETE FROM tbl_Müsteri WHERE Musteri_id = @Musteri_id";

            using (MySqlCommand komut = new MySqlCommand(sorgu, new baglanti().baglantiGetir()))
            {
                komut.Parameters.AddWithValue("@Musteri_id", id);
                komut.ExecuteNonQuery();
            }
        }
    }
}


    

