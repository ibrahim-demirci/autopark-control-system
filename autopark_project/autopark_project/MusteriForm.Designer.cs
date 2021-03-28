
namespace autopark_project
{
    partial class MusteriForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ara_comboBox = new System.Windows.Forms.ComboBox();
            this.ara_textBox = new System.Windows.Forms.TextBox();
            this.sil_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ara_buton = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.sil_buton = new System.Windows.Forms.Button();
            this.musteri_id_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kaydet_buton = new System.Windows.Forms.Button();
            this.musteri_soyad_textBox = new System.Windows.Forms.TextBox();
            this.musteri_ad_textBox = new System.Windows.Forms.TextBox();
            this.musteri_tc_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goster_buton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(954, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 51;
            this.label10.Text = "Aranacak Değer";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(793, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "Arama Türü";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ara_comboBox
            // 
            this.ara_comboBox.FormattingEnabled = true;
            this.ara_comboBox.Items.AddRange(new object[] {
            "Müşteri TC",
            "Ad",
            "Soyad",
            "Numara"});
            this.ara_comboBox.Location = new System.Drawing.Point(789, 193);
            this.ara_comboBox.Name = "ara_comboBox";
            this.ara_comboBox.Size = new System.Drawing.Size(151, 27);
            this.ara_comboBox.TabIndex = 49;
            this.ara_comboBox.SelectedIndexChanged += new System.EventHandler(this.ara_comboBox_SelectedIndexChanged);
            // 
            // ara_textBox
            // 
            this.ara_textBox.Location = new System.Drawing.Point(958, 193);
            this.ara_textBox.Name = "ara_textBox";
            this.ara_textBox.Size = new System.Drawing.Size(151, 28);
            this.ara_textBox.TabIndex = 48;
            // 
            // sil_textBox
            // 
            this.sil_textBox.Enabled = false;
            this.sil_textBox.Location = new System.Drawing.Point(789, 101);
            this.sil_textBox.Name = "sil_textBox";
            this.sil_textBox.Size = new System.Drawing.Size(143, 28);
            this.sil_textBox.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(785, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Silinecek Müşteri ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ara_buton
            // 
            this.ara_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.ara_buton.ForeColor = System.Drawing.SystemColors.Control;
            this.ara_buton.Location = new System.Drawing.Point(1125, 183);
            this.ara_buton.Name = "ara_buton";
            this.ara_buton.Size = new System.Drawing.Size(55, 38);
            this.ara_buton.TabIndex = 45;
            this.ara_buton.Text = "Ara";
            this.ara_buton.UseVisualStyleBackColor = false;
            this.ara_buton.Click += new System.EventHandler(this.ara_buton_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.guncelle_button.ForeColor = System.Drawing.SystemColors.Control;
            this.guncelle_button.Location = new System.Drawing.Point(556, 191);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(190, 55);
            this.guncelle_button.TabIndex = 44;
            this.guncelle_button.Text = "Müşteri Güncelle";
            this.guncelle_button.UseVisualStyleBackColor = false;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // sil_buton
            // 
            this.sil_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.sil_buton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_buton.ForeColor = System.Drawing.SystemColors.Control;
            this.sil_buton.Location = new System.Drawing.Point(982, 76);
            this.sil_buton.Name = "sil_buton";
            this.sil_buton.Size = new System.Drawing.Size(192, 53);
            this.sil_buton.TabIndex = 43;
            this.sil_buton.Text = "Müşteri Sil";
            this.sil_buton.UseVisualStyleBackColor = false;
            this.sil_buton.Click += new System.EventHandler(this.sil_buton_Click);
            // 
            // musteri_id_textBox
            // 
            this.musteri_id_textBox.Enabled = false;
            this.musteri_id_textBox.Location = new System.Drawing.Point(128, 91);
            this.musteri_id_textBox.Name = "musteri_id_textBox";
            this.musteri_id_textBox.Size = new System.Drawing.Size(122, 28);
            this.musteri_id_textBox.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Müşteri ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kaydet_buton
            // 
            this.kaydet_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.kaydet_buton.ForeColor = System.Drawing.SystemColors.Control;
            this.kaydet_buton.Location = new System.Drawing.Point(556, 130);
            this.kaydet_buton.Name = "kaydet_buton";
            this.kaydet_buton.Size = new System.Drawing.Size(190, 55);
            this.kaydet_buton.TabIndex = 38;
            this.kaydet_buton.Text = "Müşteri Ekle";
            this.kaydet_buton.UseVisualStyleBackColor = false;
            this.kaydet_buton.Click += new System.EventHandler(this.kaydet_buton_Click);
            // 
            // musteri_soyad_textBox
            // 
            this.musteri_soyad_textBox.Location = new System.Drawing.Point(406, 145);
            this.musteri_soyad_textBox.Name = "musteri_soyad_textBox";
            this.musteri_soyad_textBox.Size = new System.Drawing.Size(122, 28);
            this.musteri_soyad_textBox.TabIndex = 35;
            // 
            // musteri_ad_textBox
            // 
            this.musteri_ad_textBox.Location = new System.Drawing.Point(406, 95);
            this.musteri_ad_textBox.Name = "musteri_ad_textBox";
            this.musteri_ad_textBox.Size = new System.Drawing.Size(122, 28);
            this.musteri_ad_textBox.TabIndex = 34;
            // 
            // musteri_tc_textBox
            // 
            this.musteri_tc_textBox.Location = new System.Drawing.Point(128, 144);
            this.musteri_tc_textBox.Name = "musteri_tc_textBox";
            this.musteri_tc_textBox.Size = new System.Drawing.Size(122, 28);
            this.musteri_tc_textBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(269, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Müşteri Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Müşteri Ad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Müşteri TC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // goster_buton
            // 
            this.goster_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.goster_buton.ForeColor = System.Drawing.SystemColors.Control;
            this.goster_buton.Location = new System.Drawing.Point(556, 68);
            this.goster_buton.Name = "goster_buton";
            this.goster_buton.Size = new System.Drawing.Size(190, 55);
            this.goster_buton.TabIndex = 27;
            this.goster_buton.Text = "Müşterileri Göster";
            this.goster_buton.UseVisualStyleBackColor = false;
            this.goster_buton.Click += new System.EventHandler(this.goster_buton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(308, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 211);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteri_dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(128, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 55);
            this.button1.TabIndex = 52;
            this.button1.Text = "Müşteri Telefon Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 34);
            this.button2.TabIndex = 53;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(490, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 41);
            this.label11.TabIndex = 54;
            this.label11.Text = "Müşteri İşlemleri";
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1244, 492);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.musteri_id_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kaydet_buton);
            this.Controls.Add(this.musteri_soyad_textBox);
            this.Controls.Add(this.musteri_ad_textBox);
            this.Controls.Add(this.musteri_tc_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goster_buton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ara_comboBox;
        private System.Windows.Forms.TextBox ara_textBox;
        private System.Windows.Forms.TextBox sil_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ara_buton;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button sil_buton;
        private System.Windows.Forms.TextBox musteri_id_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kaydet_buton;
        private System.Windows.Forms.TextBox musteri_soyad_textBox;
        private System.Windows.Forms.TextBox musteri_ad_textBox;
        private System.Windows.Forms.TextBox musteri_tc_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goster_buton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
    }
}