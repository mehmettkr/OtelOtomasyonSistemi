using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1.DOMAIN

{
    public class Oda
    {
        public Oda(int oNo, string Oturu, int Ofiyat,string Odurum)
        {
            this.oId = oNo;
            this.OdaFiyat = Ofiyat;
            this.OdaTuru = Oturu;
            this.OdaDurum = Odurum;
        }
        public Oda(string Oturu, int Ofiyat, string Odurum)
        {          
           
            this.OdaTuru = Oturu;
            this.OdaFiyat = Ofiyat;
            this.OdaDurum = Odurum;
        }

        int odaId;
        public int oId 
        {
            get { return odaId; }
            set { odaId = value;}
        }
       
        string odaTuru;
        public string OdaTuru
        {
            get { return odaTuru; }
            set { odaTuru = value; }
        }
        int odaFiyat;
        public int OdaFiyat
        {
            get { return odaFiyat; }
            set { odaFiyat = value; }
        }
        string odaDurum;
        public string OdaDurum
        {
            get { return odaDurum; }
            set { odaDurum = value; }
        }
        public override string ToString()
        {
            return this.oId + " <-> " + this.OdaTuru + " <-> " + this.OdaFiyat + " <-> "+this.OdaDurum;
        }
    }
}
