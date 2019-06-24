namespace Creative_Box
{
    partial class Profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oyunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunresimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyundosyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunyaraticiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitoyunBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.creativeBoxDataSet7 = new Creative_Box.CreativeBoxDataSet7();
            this.kayitoyunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.creativeBoxDataSet5 = new Creative_Box.CreativeBoxDataSet5();
            this.kayitoyunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creativeBoxDataSet1 = new Creative_Box.CreativeBoxDataSet1();
            this.kayit_oyunTableAdapter = new Creative_Box.CreativeBoxDataSet1TableAdapters.kayit_oyunTableAdapter();
            this.kayit_oyunTableAdapter1 = new Creative_Box.CreativeBoxDataSet5TableAdapters.kayit_oyunTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kayit_oyunTableAdapter2 = new Creative_Box.CreativeBoxDataSet7TableAdapters.kayit_oyunTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitoyunBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creativeBoxDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitoyunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creativeBoxDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitoyunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creativeBoxDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(389, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nickname";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(369, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 29);
            this.label12.TabIndex = 41;
            this.label12.Text = "Box";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(305, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "Creative";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oyunadiDataGridViewTextBoxColumn,
            this.oyunturDataGridViewTextBoxColumn,
            this.oyunresimDataGridViewTextBoxColumn,
            this.oyundosyaDataGridViewTextBoxColumn,
            this.oyunyaraticiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayitoyunBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 152);
            this.dataGridView1.TabIndex = 57;
            // 
            // oyunadiDataGridViewTextBoxColumn
            // 
            this.oyunadiDataGridViewTextBoxColumn.DataPropertyName = "oyun_adi";
            this.oyunadiDataGridViewTextBoxColumn.HeaderText = "oyun_adi";
            this.oyunadiDataGridViewTextBoxColumn.Name = "oyunadiDataGridViewTextBoxColumn";
            // 
            // oyunturDataGridViewTextBoxColumn
            // 
            this.oyunturDataGridViewTextBoxColumn.DataPropertyName = "oyun_tur";
            this.oyunturDataGridViewTextBoxColumn.HeaderText = "oyun_tur";
            this.oyunturDataGridViewTextBoxColumn.Name = "oyunturDataGridViewTextBoxColumn";
            // 
            // oyunresimDataGridViewTextBoxColumn
            // 
            this.oyunresimDataGridViewTextBoxColumn.DataPropertyName = "oyun_resim";
            this.oyunresimDataGridViewTextBoxColumn.HeaderText = "oyun_resim";
            this.oyunresimDataGridViewTextBoxColumn.Name = "oyunresimDataGridViewTextBoxColumn";
            // 
            // oyundosyaDataGridViewTextBoxColumn
            // 
            this.oyundosyaDataGridViewTextBoxColumn.DataPropertyName = "oyun_dosya";
            this.oyundosyaDataGridViewTextBoxColumn.HeaderText = "oyun_dosya";
            this.oyundosyaDataGridViewTextBoxColumn.Name = "oyundosyaDataGridViewTextBoxColumn";
            // 
            // oyunyaraticiDataGridViewTextBoxColumn
            // 
            this.oyunyaraticiDataGridViewTextBoxColumn.DataPropertyName = "oyun_yaratici";
            this.oyunyaraticiDataGridViewTextBoxColumn.HeaderText = "oyun_yaratici";
            this.oyunyaraticiDataGridViewTextBoxColumn.Name = "oyunyaraticiDataGridViewTextBoxColumn";
            // 
            // kayitoyunBindingSource2
            // 
            this.kayitoyunBindingSource2.DataMember = "kayit_oyun";
            this.kayitoyunBindingSource2.DataSource = this.creativeBoxDataSet7;
            // 
            // creativeBoxDataSet7
            // 
            this.creativeBoxDataSet7.DataSetName = "CreativeBoxDataSet7";
            this.creativeBoxDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitoyunBindingSource1
            // 
            this.kayitoyunBindingSource1.DataMember = "kayit_oyun";
            this.kayitoyunBindingSource1.DataSource = this.creativeBoxDataSet5;
            // 
            // creativeBoxDataSet5
            // 
            this.creativeBoxDataSet5.DataSetName = "CreativeBoxDataSet5";
            this.creativeBoxDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitoyunBindingSource
            // 
            this.kayitoyunBindingSource.DataMember = "kayit_oyun";
            this.kayitoyunBindingSource.DataSource = this.creativeBoxDataSet1;
            // 
            // creativeBoxDataSet1
            // 
            this.creativeBoxDataSet1.DataSetName = "CreativeBoxDataSet1";
            this.creativeBoxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayit_oyunTableAdapter
            // 
            this.kayit_oyunTableAdapter.ClearBeforeFill = true;
            // 
            // kayit_oyunTableAdapter1
            // 
            this.kayit_oyunTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(544, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 171);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Games";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1291, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 60;
            this.label14.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(199, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 10);
            this.panel1.TabIndex = 89;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(199, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 10);
            this.panel2.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(540, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "© 2019 by Can AKAY. Proudly created with C#.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(748, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 92;
            this.button1.Text = "Oyun Yukle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // kayit_oyunTableAdapter2
            // 
            this.kayit_oyunTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(571, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 31);
            this.button2.TabIndex = 93;
            this.button2.Text = "Anasayfa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Creative_Box.Properties.Resources.simge_tr;
            this.pictureBox3.Location = new System.Drawing.Point(167, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(199, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(920, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 31);
            this.button5.TabIndex = 103;
            this.button5.Text = "Oturumu kapat";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1298, 541);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profilim";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitoyunBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creativeBoxDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitoyunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creativeBoxDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitoyunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creativeBoxDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CreativeBoxDataSet1 creativeBoxDataSet1;
        private System.Windows.Forms.BindingSource kayitoyunBindingSource;
        private CreativeBoxDataSet1TableAdapters.kayit_oyunTableAdapter kayit_oyunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunresimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyundosyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunyaraticiDataGridViewTextBoxColumn;
        private CreativeBoxDataSet5 creativeBoxDataSet5;
        private System.Windows.Forms.BindingSource kayitoyunBindingSource1;
        private CreativeBoxDataSet5TableAdapters.kayit_oyunTableAdapter kayit_oyunTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private CreativeBoxDataSet7 creativeBoxDataSet7;
        private System.Windows.Forms.BindingSource kayitoyunBindingSource2;
        private CreativeBoxDataSet7TableAdapters.kayit_oyunTableAdapter kayit_oyunTableAdapter2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}