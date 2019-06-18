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


    public partial class Oyun_Yukleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJ1D6UO;Initial Catalog=CreativeBox;Integrated Security=True");

        public Oyun_Yukleme()
        {
            InitializeComponent();
        }

        public static string gonderilecekveri;

        private void oyun_yukle_Load(object sender, EventArgs e){

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                textBox5.Enabled = false;
                textBox5.Text = Yaratici_Girisi.kullanici_adi;

        } private void button2_Click(object sender, EventArgs e){

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox4.Text = openFileDialog1.FileName;
            
        }private void button3_Click(object sender, EventArgs e){

            openFileDialog2.ShowDialog();
            textBox3.Text = openFileDialog2.FileName;

        }private void button1_Click(object sender, EventArgs e){

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kayit_oyun(oyun_adi,oyun_tur,oyun_resim,oyun_dosya,oyun_yaratici) values(@o1,@o2,@o3,@o4,@o5)", baglanti);

            komut.Parameters.AddWithValue("@o1", textBox1.Text);
            komut.Parameters.AddWithValue("@o2", comboBox1.Text);
            komut.Parameters.AddWithValue("@o3", textBox4.Text);
            komut.Parameters.AddWithValue("@o4", textBox3.Text);
            komut.Parameters.AddWithValue("@o5", textBox5.Text);

            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text =="")
            {

                MessageBox.Show("Kutucuklar boş geçilemez!");

            }
            else
            {

                komut.ExecuteNonQuery();
                baglanti.Close();

                gonderilecekveri = textBox1.Text;


                MessageBox.Show("Oyununuz başarı ile yüklendi.");
                this.Close();
            }
        }

        private void Button5_Click(object sender, EventArgs e){

            this.Close();
        }
    }
}
