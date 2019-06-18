using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Creative_Box
{


    public partial class Baslangic : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJ1D6UO;Initial Catalog=CreativeBox;Integrated Security=True");
        public Baslangic()
        {
            InitializeComponent();
        }

        private void Giris
           (object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KayitOl kayit_ol = new KayitOl();
            this.Visible = false;
            kayit_ol.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi kullanici_g = new Kullanici_Girisi();
            this.Visible = false;
            kullanici_g.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yaratici_Girisi yaratici = new Yaratici_Girisi();
            this.Visible = false;
            yaratici.ShowDialog();
            Application.Exit();
        }
    }
}
