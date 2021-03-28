
namespace autopark_project
{
    partial class AracForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goster_buton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plaka_textBox = new System.Windows.Forms.TextBox();
            this.marka_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.yil_textBox = new System.Windows.Forms.TextBox();
            this.renk_textBox = new System.Windows.Forms.TextBox();
            this.kaydet_buton = new System.Windows.Forms.Button();
            this.mus_tc_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.aracid_textBox = new System.Windows.Forms.TextBox();
            this.sil_buton = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.ara_buton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sil_textBox = new System.Windows.Forms.TextBox();
            this.ara_textBox = new System.Windows.Forms.TextBox();
            this.ara_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // goster_buton
            // 
            this.goster_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.goster_buton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goster_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goster_buton.Location = new System.Drawing.Point(547, 69);
            this.goster_buton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goster_buton.Name = "goster_buton";
            this.goster_buton.Size = new System.Drawing.Size(208, 56);
            this.goster_buton.TabIndex = 1;
            this.goster_buton.Text = "Araçları Göster";
            this.goster_buton.UseVisualStyleBackColor = false;
            this.goster_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araç Plaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Araç Marka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Araç Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(283, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Araç Yıl";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(283, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Araç Renk";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // plaka_textBox
            // 
            this.plaka_textBox.Location = new System.Drawing.Point(146, 121);
            this.plaka_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plaka_textBox.Name = "plaka_textBox";
            this.plaka_textBox.Size = new System.Drawing.Size(112, 28);
            this.plaka_textBox.TabIndex = 7;
            this.plaka_textBox.TextChanged += new System.EventHandler(this.plaka_textBox_TextChanged);
            // 
            // marka_textBox
            // 
            this.marka_textBox.Location = new System.Drawing.Point(146, 164);
            this.marka_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marka_textBox.Name = "marka_textBox";
            this.marka_textBox.Size = new System.Drawing.Size(112, 28);
            this.marka_textBox.TabIndex = 8;
            this.marka_textBox.TextChanged += new System.EventHandler(this.marka_textBox_TextChanged);
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(146, 204);
            this.model_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(112, 28);
            this.model_textBox.TabIndex = 8;
            this.model_textBox.TextChanged += new System.EventHandler(this.model_textBox_TextChanged);
            // 
            // yil_textBox
            // 
            this.yil_textBox.Location = new System.Drawing.Point(392, 75);
            this.yil_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yil_textBox.Name = "yil_textBox";
            this.yil_textBox.Size = new System.Drawing.Size(112, 28);
            this.yil_textBox.TabIndex = 9;
            this.yil_textBox.TextChanged += new System.EventHandler(this.yil_textBox_TextChanged);
            // 
            // renk_textBox
            // 
            this.renk_textBox.Location = new System.Drawing.Point(392, 118);
            this.renk_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.renk_textBox.Name = "renk_textBox";
            this.renk_textBox.Size = new System.Drawing.Size(112, 28);
            this.renk_textBox.TabIndex = 10;
            this.renk_textBox.TextChanged += new System.EventHandler(this.renk_textBox_TextChanged);
            // 
            // kaydet_buton
            // 
            this.kaydet_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.kaydet_buton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kaydet_buton.Location = new System.Drawing.Point(547, 133);
            this.kaydet_buton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kaydet_buton.Name = "kaydet_buton";
            this.kaydet_buton.Size = new System.Drawing.Size(208, 56);
            this.kaydet_buton.TabIndex = 11;
            this.kaydet_buton.Text = "Araç Ekle";
            this.kaydet_buton.UseVisualStyleBackColor = false;
            this.kaydet_buton.Click += new System.EventHandler(this.button2_Click);
            // 
            // mus_tc_textBox
            // 
            this.mus_tc_textBox.Location = new System.Drawing.Point(392, 163);
            this.mus_tc_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mus_tc_textBox.Name = "mus_tc_textBox";
            this.mus_tc_textBox.Size = new System.Drawing.Size(112, 28);
            this.mus_tc_textBox.TabIndex = 13;
            this.mus_tc_textBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(283, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Müşteri Tc";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Arac ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // aracid_textBox
            // 
            this.aracid_textBox.Enabled = false;
            this.aracid_textBox.Location = new System.Drawing.Point(146, 78);
            this.aracid_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aracid_textBox.Name = "aracid_textBox";
            this.aracid_textBox.Size = new System.Drawing.Size(112, 28);
            this.aracid_textBox.TabIndex = 15;
            this.aracid_textBox.TextChanged += new System.EventHandler(this.aracid_textBox_TextChanged);
            // 
            // sil_buton
            // 
            this.sil_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.sil_buton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sil_buton.Location = new System.Drawing.Point(938, 78);
            this.sil_buton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sil_buton.Name = "sil_buton";
            this.sil_buton.Size = new System.Drawing.Size(202, 52);
            this.sil_buton.TabIndex = 16;
            this.sil_buton.Text = "Araç Sil";
            this.sil_buton.UseVisualStyleBackColor = false;
            this.sil_buton.Click += new System.EventHandler(this.sil_buton_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.guncelle_button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guncelle_button.Location = new System.Drawing.Point(547, 200);
            this.guncelle_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(208, 56);
            this.guncelle_button.TabIndex = 17;
            this.guncelle_button.Text = "Araç Güncelle";
            this.guncelle_button.UseVisualStyleBackColor = false;
            this.guncelle_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // ara_buton
            // 
            this.ara_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.ara_buton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ara_buton.Location = new System.Drawing.Point(1080, 187);
            this.ara_buton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara_buton.Name = "ara_buton";
            this.ara_buton.Size = new System.Drawing.Size(60, 42);
            this.ara_buton.TabIndex = 18;
            this.ara_buton.Text = "Ara";
            this.ara_buton.UseVisualStyleBackColor = false;
            this.ara_buton.Click += new System.EventHandler(this.ara_buton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(778, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Silinecek Araç ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // sil_textBox
            // 
            this.sil_textBox.Enabled = false;
            this.sil_textBox.Location = new System.Drawing.Point(782, 98);
            this.sil_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sil_textBox.Name = "sil_textBox";
            this.sil_textBox.Size = new System.Drawing.Size(129, 28);
            this.sil_textBox.TabIndex = 20;
            this.sil_textBox.TextChanged += new System.EventHandler(this.sil_textBox_TextChanged);
            // 
            // ara_textBox
            // 
            this.ara_textBox.Location = new System.Drawing.Point(938, 200);
            this.ara_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara_textBox.Name = "ara_textBox";
            this.ara_textBox.Size = new System.Drawing.Size(136, 28);
            this.ara_textBox.TabIndex = 22;
            this.ara_textBox.TextChanged += new System.EventHandler(this.ara_textBox_TextChanged);
            // 
            // ara_comboBox
            // 
            this.ara_comboBox.FormattingEnabled = true;
            this.ara_comboBox.Items.AddRange(new object[] {
            "Plaka",
            "Marka",
            "Model",
            "Yıl",
            "Renk",
            "Müşteri TC"});
            this.ara_comboBox.Location = new System.Drawing.Point(780, 200);
            this.ara_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara_comboBox.Name = "ara_comboBox";
            this.ara_comboBox.Size = new System.Drawing.Size(136, 27);
            this.ara_comboBox.TabIndex = 23;
            this.ara_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(778, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Arama Türü";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(934, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Aranacak Değer";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(512, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 41);
            this.label11.TabIndex = 27;
            this.label11.Text = "Araç İşlemleri";
            // 
            // AracForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1208, 503);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ara_comboBox);
            this.Controls.Add(this.ara_textBox);
            this.Controls.Add(this.sil_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ara_buton);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.sil_buton);
            this.Controls.Add(this.aracid_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mus_tc_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kaydet_buton);
            this.Controls.Add(this.renk_textBox);
            this.Controls.Add(this.yil_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.marka_textBox);
            this.Controls.Add(this.plaka_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goster_buton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AracForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Menü";
            this.Load += new System.EventHandler(this.AracForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goster_buton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox plaka_textBox;
        private System.Windows.Forms.TextBox marka_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox yil_textBox;
        private System.Windows.Forms.TextBox renk_textBox;
        private System.Windows.Forms.Button kaydet_buton;
        private System.Windows.Forms.TextBox mus_tc_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aracid_textBox;
        private System.Windows.Forms.Button sil_buton;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button ara_buton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sil_textBox;
        private System.Windows.Forms.TextBox ara_textBox;
        private System.Windows.Forms.ComboBox ara_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}

