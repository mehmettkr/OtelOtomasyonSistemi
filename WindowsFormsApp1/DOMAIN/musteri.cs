using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Service;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1.DOMAIN
{
    public class musteri
    {
        public musteri(int muID, string mAd, string mSoyad, string mTel, string mOdasec, string mGir, string mCik)
        {
            this.MId = muID;
            this.MüsteriAd = mAd;
            this.MüsteriSoyad = mSoyad;
            this.MüsteriTel = mTel;
            this.OdaSec = mOdasec;
            this.MusGiris = mGir;
            this.MusCikis = mCik;
        }
        public musteri( string mAd, string mSoyad,string mTel, string mOdasec, string mGir,string mCik)
        {            
            this.MüsteriAd = mAd;
            this.MüsteriSoyad = mSoyad;
            this.MüsteriTel = mTel;
            this.OdaSec = mOdasec;
            this.MusGiris = mGir;
            this.MusCikis = mCik;
        }


        int mId;
        public int MId 
        {
            get { return mId; }
            set { mId = value; }
        }
        string mAd;
        public string MüsteriAd
        {
            get { return mAd; }
            set { mAd = value; }
        }
        string mSoyad;
        public string MüsteriSoyad
        {
            get { return mSoyad; }
            set { mSoyad = value; }
        }            
        string mTel;
        public string MüsteriTel
        {
            get { return mTel; }
            set { mTel = value; }
        }
        string mOdasec;
        public string OdaSec
        {
            get { return mOdasec; }
            set { mOdasec = value; }
        }
        string mGir;
        public string MusGiris
        {
            get { return mGir; }
            set { mGir = value; }
        }
        string mCik;
        public string MusCikis
        {
            get { return mCik; }
            set { mCik = value; }
        }
        public override string ToString()
        {
            return  this.MId+ "" + this.MüsteriAd + " " + this.MüsteriSoyad + "" +this.MüsteriTel + "" +this.OdaSec+""+this.MusGiris+ ""+this.MusCikis;
        }
    }
}
