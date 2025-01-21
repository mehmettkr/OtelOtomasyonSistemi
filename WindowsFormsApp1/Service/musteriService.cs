using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DOMAIN;
using MySql.Data.MySqlClient;
using System.Collections;
using static WindowsFormsApp1.DAL.musteriDAO;
using System.Data;


namespace WindowsFormsApp1.Service
{
    class musteriService
    {
        public class MusteriIslemleri
        {
           private MusteriVeriErisim veriErisim = new MusteriVeriErisim();

            public DataTable MusterileriListele()
            {
                return veriErisim.MusterileriGetir();
            }
        }
        internal void MusteriEkle(string mAd, string mSoyad, string mTel, string mOdasec, string mGir,string mCik)
        {
            new musteriDAO().MusteriEkle(mAd, mSoyad,mTel, mOdasec, mGir,mCik);
        }
        internal void MusteriGuncelle(int mId, string mAd, string mSoyad, string mTel, string mOdasec, string mGir, string mCik)
        {
            new musteriDAO().MusteriGuncelle(mId, mAd, mSoyad, mTel, mOdasec, mGir, mCik);
        }
        public void MusteriSil(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçerli bir ID girin.");
            }

            new musteriDAO().MusteriSil(id);
        }
    }
}
