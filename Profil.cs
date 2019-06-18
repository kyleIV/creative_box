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
    public partial class Profil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJ1D6UO;Initial Catalog=CreativeBox;Integrated Security=True");

        public Profil()
        {
            InitializeComponent();
        }

        public string kulid;
        private void Form4_Load(object sender, EventArgs e){

            
            this.kayit_oyunTableAdapter2.Fill(this.creativeBoxDataSet7.kayit_oyun);

            label3.Text = Yaratici_Girisi.kullanici_adi;
            label14.Text = kulid;


            baglanti.Open();
            string kayit = "select resim from kayit_yaratici where kullanici_adi='" + label14.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            baglanti.Close();

            pictureBox2.ImageLocation = dt.Rows[0]["resim"].ToString();

        }private void Button1_Click(object sender, EventArgs e){

            Oyun_Yukleme oyn = new Oyun_Yukleme();
            this.Visible = true;
            oyn.ShowDialog();
           
        }private void Label5_Click(object sender, EventArgs e){

            Oyun_Yukleme oy_yukle = new Oyun_Yukleme();
            this.Visible = true;
            oy_yukle.ShowDialog();
            Application.Exit();

        } private void Button2_Click(object sender, EventArgs e){

            Anasayfa frm5 = new Anasayfa();
            this.Visible = true;
            frm5.kulid = label14.Text;
            frm5.ShowDialog();
            

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Baslangic bas = new Baslangic();
            this.Visible = false;
            bas.ShowDialog();
            Application.Exit();
        }
    }
}



