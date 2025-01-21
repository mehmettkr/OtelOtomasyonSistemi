using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DOMAIN;
using static WindowsFormsApp1.DAL.musteriDAO;
using static WindowsFormsApp1.DAL.odaDAO;

namespace WindowsFormsApp1.Service
{
    class OdaService
    {
        public class OdaIslemleri
        {
            private OdaVeriErisim veriErisim = new OdaVeriErisim();

            public DataTable OdalarıListele()
            {
                return veriErisim.OdalariGetir();
            }
        }
        internal void OdaEkle( int Ofiyat, string Oturu, string Odurum)
        {
            (new odaDAO()).OdaEkle(Oturu, Ofiyat, Odurum);
        }
        internal void OdaGuncelle(int oNo, string Oturu, int Ofiyat, string Odurum)
        {
            new odaDAO().OdaGuncelle(oNo, Oturu, Ofiyat, Odurum);
        }
        public void OdaSil(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçerli bir ID girin.");
            }

            new odaDAO().OdaSil(id);
        }
    }
}
