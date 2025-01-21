using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girisform fr = new girisform();
            fr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odalar odalar = new odalar();
            odalar.Show();
            this.Close();
        }

        private void btnrezarvasyon_Click(object sender, EventArgs e)
        {
            rezervasyonlar fr = new rezervasyonlar();
            fr.Show();
            this.Close();
        }

        private void menuform_Load(object sender, EventArgs e)
        {

        }
    }
}
