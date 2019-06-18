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
   
    public partial class KayitOl : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJ1D6UO;Initial Catalog=CreativeBox;Integrated Security=True");

        public KayitOl(){

            InitializeComponent();

        }private void Form2_Load(object sender, EventArgs e){

        }

        private void pictureBox2_Click(object sender, EventArgs e){

            Baslangic giris = new Baslangic();
            this.Visible = false;
            giris.ShowDialog();
            Application.Exit();

        }private void button1_Click(object sender, EventArgs e){

            baglanti.Open();

            if(checkBox1.Checked){ 

              SqlCommand komut = new SqlCommand("insert into kayit_yaratici(kullanici_adi,sifre,eposta,resim) values(@k1,@k2,@k3,@k4)", baglanti);

                komut.Parameters.AddWithValue("@k1", textBox1.Text);
                komut.Parameters.AddWithValue("@k3", textBox2.Text);
                komut.Parameters.AddWithValue("@k2", textBox3.Text);
                komut.Parameters.AddWithValue("@k4", textBox4.Text);

                if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") {

                    MessageBox.Show("Kutucuklar boş geçilemez!");

                }
                else{
                  
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Yaratici olarak kayit olundu");
                }

            }
            else{

                SqlCommand komut = new SqlCommand("insert into kayit(kullanici_adi,sifre,eposta,resim) values(@k1,@k2,@k3,@k4)", baglanti);

                komut.Parameters.AddWithValue("@k1", textBox1.Text);
                komut.Parameters.AddWithValue("@k3", textBox2.Text);
                komut.Parameters.AddWithValue("@k2", textBox3.Text);
                komut.Parameters.AddWithValue("@k4", textBox4.Text);

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""){

                    MessageBox.Show("Kutucuklar boş geçilemez!");

                }else{

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanici olarak kayit olundu");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e){

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox4.Text = openFileDialog1.FileName;

        }

        private void PictureBox3_Click(object sender, EventArgs e){

            Baslangic giris = new Baslangic();
            this.Visible = false;
            giris.ShowDialog();
            Application.Exit();

        }
    }
}
