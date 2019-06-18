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
    public partial class Yaratici_Girisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJ1D6UO;Initial Catalog=CreativeBox;Integrated Security=True");

        public Yaratici_Girisi()
        {
            InitializeComponent();
        }

        private void Yaratici_g_Load(object sender, EventArgs e){

        }

        public static string kullanici_adi;
        

        private void pictureBox1_Click(object sender, EventArgs e){

            Baslangic giris = new Baslangic();
            this.Visible = false;
            giris.ShowDialog();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e){

            KayitOl kayit_ol = new KayitOl();
            this.Visible = false;
            kayit_ol.ShowDialog();
            Application.Exit();

        }private void button1_Click(object sender, EventArgs e){

            kullanici_adi = textBox1.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kayit_yaratici where kullanici_adi='" + textBox1.Text + "' and sifre='" + textBox3.Text + "'", baglanti);
            SqlDataReader dl = komut.ExecuteReader();
            if (dl.Read()){

                Profil frmform4 = new Profil();
                this.Visible = false;
                frmform4.kulid = textBox1.Text;
                frmform4.ShowDialog();
                Application.Exit();

            }else{

                MessageBox.Show("Kullanıcı adı veya şifre yanlış");

            }

            baglanti.Close();

        }
    }
}
