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
    public partial class Kullanici_Girisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJ1D6UO;Initial Catalog=CreativeBox;Integrated Security=True");

        public Kullanici_Girisi()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e){

        }

        public static string kullanici_adi;


        private void pictureBox1_Click(object sender, EventArgs e){

            Baslangic giris = new Baslangic();
            this.Visible = false;
            giris.ShowDialog();
            Application.Exit();

        }private void button3_Click(object sender, EventArgs e){

            KayitOl kayit_ol = new KayitOl();
            this.Visible = false;
            kayit_ol.ShowDialog();
            Application.Exit();

        } private void button1_Click(object sender, EventArgs e){

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kayit where kullanici_adi='" + textBox1.Text + "' and sifre='" + textBox3.Text +"'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()){

                Anasayfa frm5 = new Anasayfa();
                this.Visible = false;
                frm5.kuladi = textBox1.Text;
                frm5.ShowDialog();
                Application.Exit();

            }else{

                MessageBox.Show("Kullanıcı adi veya sifre yanlis");

            }

            baglanti.Close();
            kullanici_adi = textBox1.Text;
        }
    }
}
