using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.DOMAIN;


namespace WindowsFormsApp1.DAL
{
    class baglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330005; Uid=25_132330005; Pwd=!nif.ogr05TO");
            baglanti.Open();
            return baglanti;
        }
    }
}
