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

namespace autopark_project
{
    public partial class Abonelik : Form
    {
        public Abonelik()
        {
            InitializeComponent();
            this.SetFontAndColors();

        }
        private void SetFontAndColors()
        {

            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9SPGDK;Initial Catalog=autopark;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            verileri_goster("SELECT  A.AracPlaka as 'Araç Plakası', " +
                            "C.MusteriAd as 'Müşteri Adı', " +
                            "C.MusteriSoyad as 'Müşteri Soyad', " +
                            "A.AbonelikBaslangic as 'Başlangıç', " +
                            "A.AbonelikBitis as 'Abonelik Bitiş', " +
                            "DATEDIFF(DAY,GETDATE(), A.AbonelikBitis) as 'Kalan Süre (Gün)' " +
                            "FROM Abonelik A " +
                            "LEFT JOIN Arac B " +
                            "ON A.AracPlaka = B.AracPlaka " +
                            "INNER JOIN " +
                            "Musteri C ON C.MusteriTc = B.MusteriTc ");

            MessageBox.Show("Abonelikler Gösterildi", "Uyarı");
        }

        private void verileri_goster(String veriler)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];    //0. kaynaktan başla

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Uyarı");
            }
        }

        void clear_boxes()
        {
            arac_plaka_textBox.Clear();
            abonelik_baslangic_textBox.Clear();
            abonelik_bitis_textBox1.Clear();
            
        }

        private void Abonelik_Load(object sender, EventArgs e)
        {
            verileri_goster("SELECT  A.AracPlaka as 'Araç Plakası', " +
                            "C.MusteriAd as 'Müşteri Adı', " +
                            "C.MusteriSoyad as 'Müşteri Soyad', " +
                            "(A.AbonelikBaslangic) as 'Başlangıç', " +
                            "(A.AbonelikBitis) as 'Abonelik Bitiş', " +
                            "DATEDIFF(DAY,GETDATE(), A.AbonelikBitis) as 'Kalan Süre (Gün)' " +
                            "FROM Abonelik A " +
                            "LEFT  JOIN Arac B " +
                            "ON A.AracPlaka = B.AracPlaka " +
                            "INNER JOIN " +
                            "Musteri C ON C.MusteriTc = B.MusteriTc ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("INSERT INTO Abonelik (AracPlaka,AbonelikBaslangic,AbonelikBitis) values(@g_AracPlaka,@g_AbonelikBaslangic,@g_AbonelikBitis) ", baglanti);
                komut.Parameters.AddWithValue("@g_AracPlaka", String.IsNullOrWhiteSpace(arac_plaka_textBox.Text) ? (object)DBNull.Value : arac_plaka_textBox.Text);
                komut.Parameters.AddWithValue("@g_AbonelikBaslangic", String.IsNullOrWhiteSpace(abonelik_baslangic_textBox.Text) ? (object)DBNull.Value : abonelik_baslangic_textBox.Text);
                komut.Parameters.AddWithValue("@g_AbonelikBitis", String.IsNullOrWhiteSpace(abonelik_bitis_textBox1.Text) ? (object)DBNull.Value : abonelik_bitis_textBox1.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Abonelik Ekleme İşlemi Başarılı", "Uyarı");

                verileri_goster("SELECT  A.AracPlaka as 'Araç Plakası', " +
                            "C.MusteriAd as 'Müşteri Adı', " +
                            "C.MusteriSoyad as 'Müşteri Soyad', " +
                            "A.AbonelikBaslangic as 'Başlangıç', " +
                            "A.AbonelikBitis as 'Abonelik Bitiş', " +
                            "DATEDIFF(DAY,GETDATE(), A.AbonelikBitis) as 'Kalan Süre (Gün)' " +
                            "FROM Abonelik A " +
                            "LEFT  JOIN Arac B " +
                            "ON A.AracPlaka = B.AracPlaka " +
                            "INNER JOIN " +
                            "Musteri C ON C.MusteriTc = B.MusteriTc ");
                baglanti.Close();

                clear_boxes();

            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu araç plakası daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 515)
                    MessageBox.Show("Boş alan bırakılamaz lütfen tüm kutuları doldurunuz ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else if (err.Number == 241)
                    MessageBox.Show("Tarih formatını yanlış girdiniz. Lütfen (yyyy-aa-gg) şeklinde giriniz. ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else
                    MessageBox.Show(err.Number + "\n\n" + err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbonelikBitis bitis = new AbonelikBitis();
            bitis.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbonelikAracYardım yardim = new AbonelikAracYardım();
            yardim.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if(arac_plaka_textBox.Text == "")
                {
                    throw new Exception("Araç Plaka Bölümü Boş Lütfen Bir Araç Seçiniz!");
                }

                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }


                SqlCommand komut = new SqlCommand("UPDATE Abonelik SET AracPlaka =@g_AracPlaka," +
                                                  "AbonelikBaslangic = @g_AbonelikBaslangic," +
                                                  "AbonelikBitis = @g_AbonelikBitis " +
                                                  "WHERE AracPlaka = @g_AracPlaka", baglanti);

                komut.Parameters.AddWithValue("@g_AracPlaka", String.IsNullOrWhiteSpace(arac_plaka_textBox.Text) ? (object)DBNull.Value : arac_plaka_textBox.Text);
                komut.Parameters.AddWithValue("@g_AbonelikBaslangic", String.IsNullOrWhiteSpace(abonelik_baslangic_textBox.Text) ? (object)DBNull.Value : abonelik_baslangic_textBox.Text);
                komut.Parameters.AddWithValue("@g_AbonelikBitis", String.IsNullOrWhiteSpace(abonelik_bitis_textBox1.Text) ? (object)DBNull.Value : abonelik_bitis_textBox1.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Abonelik Güncelleme İşlemi Başarılı", "Uyarı");

                verileri_goster("SELECT  A.AracPlaka as 'Araç Plakası', " +
                            "C.MusteriAd as 'Müşteri Adı', " +
                            "C.MusteriSoyad as 'Müşteri Soyad', " +
                            "A.AbonelikBaslangic  as 'Başlangıç', " +
                            "A.AbonelikBitis as'Abonelik Bitiş', " +
                            "DATEDIFF(DAY,GETDATE(), A.AbonelikBitis) as 'Kalan Süre (Gün)' " +
                            "FROM Abonelik A " +
                            "LEFT  JOIN Arac B " +
                            "ON A.AracPlaka = B.AracPlaka " +
                            "INNER JOIN " +
                            "Musteri C ON C.MusteriTc = B.MusteriTc ");
                baglanti.Close();

                clear_boxes();


            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu araç plakası daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 547)
                    MessageBox.Show("Bu plaka  ile bir araç bulunamıyor lütfen önce araç ekleyiniz ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else if (err.Number == 515)
                    MessageBox.Show("Boş alan bırakılamaz tüm kutuları doldurunuz. ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else
                    MessageBox.Show(err.Number + "\n\n" + err.Message, "Uyarı");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Uyarı");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            arac_plaka_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            silinecek_plaka_textBox1.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();

            abonelik_baslangic_textBox.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();

            abonelik_bitis_textBox1.Text = dataGridView1.Rows[secili].Cells[4].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Sil", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (silinecek_plaka_textBox1.Text == "")
                    {
                        throw new Exception("Araç Seçmediniz Bir Araç Seçiniz");
                    }

                    if (baglanti.State.ToString() == "Closed")
                    {
                        baglanti.Open();
                    }
                    SqlCommand komut = new SqlCommand("DELETE FROM Abonelik " +
                                                      "WHERE " +
                                                      "AracPlaka =@g_AracPlaka", baglanti);

                    komut.Parameters.AddWithValue("@g_AracPlaka", String.IsNullOrWhiteSpace(silinecek_plaka_textBox1.Text) ? (object)DBNull.Value : silinecek_plaka_textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Abonelik Silme İşlemi Başarılı", "Uyarı");
                    verileri_goster("SELECT  A.AracPlaka as 'Araç Plakası', " +
                                "C.MusteriAd as 'Müşteri Adı', " +
                                "C.MusteriSoyad as 'Müşteri Soyad', " +
                                "A.AbonelikBaslangic as 'Başlangıç', " +
                                "A.AbonelikBitis as 'Abonelik Bitiş', " +
                                "DATEDIFF(DAY,GETDATE(), A.AbonelikBitis) as 'Kalan Süre (Gün)' " +
                                "FROM Abonelik A " +
                                "LEFT  JOIN Arac B " +
                                "ON A.AracPlaka = B.AracPlaka " +
                                "INNER JOIN " +
                                "Musteri C ON C.MusteriTc = B.MusteriTc ");
                    baglanti.Close();

                    clear_boxes();

                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message, "Uyarı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Uyarı");
                }
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
