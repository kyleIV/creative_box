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
using System.Net;

namespace Creative_Box
{
    public partial class Anasayfa : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJ1D6UO;Initial Catalog=CreativeBox;Integrated Security=True");
        public Anasayfa() {
           InitializeComponent();
        }

        public string kulid;
        public string kuladi;

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'creativeBoxDataSet10.kayit_oyun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayit_oyunTableAdapter6.Fill(this.creativeBoxDataSet10.kayit_oyun);
            // TODO: Bu kod satırı 'creativeBoxDataSet9.kayit_oyun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayit_oyunTableAdapter5.Fill(this.creativeBoxDataSet9.kayit_oyun);
            // TODO: Bu kod satırı 'creativeBoxDataSet8.kayit_oyun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayit_oyunTableAdapter4.Fill(this.creativeBoxDataSet8.kayit_oyun);
            // TODO: Bu kod satırı 'creativeBoxDataSet6.kayit_oyun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayit_oyunTableAdapter3.Fill(this.creativeBoxDataSet6.kayit_oyun);
            label3.Text = Yaratici_Girisi.kullanici_adi;

           // pictureBox2.ImageLocation = dataGridView2.Rows[Select * from ].Cells[2].Value.ToString();



            label22.Text = kulid;
            label23.Text = kuladi;


            // Profil fotoğrafı yükleme yaratıcı girişi
            if (label22.Text != "") {

                baglanti.Open();
                string kayit = "select resim from kayit_yaratici where kullanici_adi='" + label22.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                baglanti.Close();
                pictureBox1.ImageLocation = dt.Rows[0]["resim"].ToString();
            }

            // Profil fotoğrafı yükleme kullanıcı girişi
            if (label23.Text !=""){

                baglanti.Open();
                string kay = "select resim from kayit where kullanici_adi='" + label23.Text + "'";
                SqlCommand kmt = new SqlCommand(kay, baglanti);
                SqlDataAdapter db = new SqlDataAdapter(kmt);
                DataTable dtb = new DataTable();
                db.Fill(dtb);

                baglanti.Close();
                pictureBox1.ImageLocation = dtb.Rows[0]["resim"].ToString();
            }

            // Beğeni sırasına göre DataGridWiewda sıralama
                baglanti.Open();
                string ka = "SELECT * from kayit_oyun ORDER BY oyun_begenme DESC;";

                SqlCommand kom = new SqlCommand(ka, baglanti);
                SqlDataAdapter de = new SqlDataAdapter(kom);
                DataTable dy = new DataTable();
                de.Fill(dy);
                dataGridView2.DataSource = dy;
                baglanti.Close();
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            textBox2.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            label20.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();

            pictureBox7.ImageLocation = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
        }



        private void WClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void WClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("İndirme başarıyla tamamlandı !");
        }

        private void FileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e){

            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kayit_oyunTableAdapter6.FillBy(this.creativeBoxDataSet10.kayit_oyun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kayit_oyunTableAdapter6.FillBy1(this.creativeBoxDataSet10.kayit_oyun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(label20.Text);
            deger = deger + 1;
            label20.Text = deger.ToString();
            button1.BackColor = Color.DarkRed;
            button1.Enabled = false;

            //baglanti.Open();
            // SqlCommand guncelle = new SqlCommand(" update oyun_kayit set oyun_begenme='" + label20.Text + "' where oyun_adi= '" + textBox2.Text + "'", baglanti);
            // baglanti.ExecuteNonQuery();
            // baglanti.Close();
            //int deger = int.Parse(label20.Text);
            //deger = deger + 1;
            //label20.Text = deger.ToString();
            //button1.BackColor = Color.DarkRed;
            //button1.Enabled = false;
            //SqlCommand kkk = new SqlCommand("update oyun_kayit set oyun_begenme = @lbl20");
            //kkk.Parameters.AddWithValue("@lbl20", label20.Text);

            //kkk.ExecuteNonQuery();
            //baglanti.Close();

            //SqlCommand command = new SqlCommand("Update kayit_oyun (oyun_begenme) values("+ deger.ToString()+")", baglanti);
            //SqlCommand baglanti = new SqlCommand("update kayit__oyun set oyun_begenme = @lbl20");

            //baglanti.Parameters.AddWithValue("@lbl20", label20.Text);

            // baglanti.ExecuteNonQuery();
            //  baglanti.Close();

        }

        private void Begenme_siralamasiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kayit_oyunTableAdapter6.Begenme_siralamasi(this.creativeBoxDataSet10.kayit_oyun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Baslangic bas = new Baslangic();
            this.Visible = false;
            bas.ShowDialog();
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Oyun_Sayfasi oy_yukle = new Oyun_Sayfasi();
            this.Visible = true;
            oy_yukle.ShowDialog();
            
        }
    }
}

