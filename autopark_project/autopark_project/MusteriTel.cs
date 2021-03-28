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
    public partial class MusteriTel : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9SPGDK;Initial Catalog=autopark;Integrated Security=True");

        public MusteriTel()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void clear_boxes()
        {
            guncel_telefon_textBox.Clear();
            silinecek_tel_textBox1.Clear();
            guncellenecek_tel_textBox.Clear();
            musteri_tc_textBox.Clear();
            musteri_tel_textBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if(guncellenecek_tel_textBox.Text == "")
                {
                    throw new Exception("Güncellenecek Telefon Alanı Boş Aşağıdan Bir Telefon Seçiniz!");
                }

                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }


                SqlCommand komut = new SqlCommand("UPDATE MusteriTel SET MusteriTc =@g_MusteriTc," +
                                                  "MusteriTel = @g_MusteriTel " +
                                                  "WHERE MusteriTel = @g_MusteriTel_find", baglanti);

                komut.Parameters.AddWithValue("@g_MusteriTc", String.IsNullOrWhiteSpace(musteri_tc_textBox.Text) ? (object)DBNull.Value : musteri_tc_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriTel_find", String.IsNullOrWhiteSpace(guncellenecek_tel_textBox.Text) ? (object)DBNull.Value : guncellenecek_tel_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriTel", String.IsNullOrWhiteSpace(guncel_telefon_textBox.Text) ? (object)DBNull.Value : guncel_telefon_textBox.Text);


                komut.ExecuteNonQuery();

                MessageBox.Show("Telefon Güncelleme İşlemi Başarılı", "Uyarı");

                verileri_goster("SELECT  A.MusteriTc,MusteriAd,MusteriSoyad,B.MusteriTel FROM Musteri A " +
                            " FULL OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriAd ");
                baglanti.Close();

                clear_boxes();


            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu Tc daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 547)
                    MessageBox.Show("Bu TC ile bir müşteri bulunamıyor lütfen önce müşteriyi ekleyiniz ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else if (err.Number == 515)
                    MessageBox.Show("Güncel Telefon Bölümü Boş Geçilemez ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else
                    MessageBox.Show(err.Number + "\n\n" + err.Message, "Uyarı");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Uyarı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verileri_goster("SELECT  A.MusteriTc,MusteriAd,MusteriSoyad,B.MusteriTel FROM Musteri A " +
                           " FULL OUTER JOIN " +
                           "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriAd");
            ;
        }


        private void verileri_goster(String veriler)
        {     
            try { 
                    SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];    //0. kaynaktan başla

            }
            catch(SqlException err)
            {
                MessageBox.Show(err.Message, "Uyarı");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("INSERT INTO MusteriTel (MusteriTc,MusteriTel) values(@g_MusteriTc,@g_MusteriTel) ", baglanti);
                komut.Parameters.AddWithValue("@g_MusteriTel", String.IsNullOrWhiteSpace(musteri_tel_textBox.Text) ? (object)DBNull.Value : musteri_tel_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriTc", String.IsNullOrWhiteSpace(musteri_tc_textBox.Text) ? (object)DBNull.Value : musteri_tc_textBox.Text);
                
                komut.ExecuteNonQuery();

                MessageBox.Show("Müşteri Telefon Kaydetme İşlemi Başarılı", "Uyarı");

                verileri_goster("SELECT  A.MusteriTc,MusteriAd,MusteriSoyad,B.MusteriTel FROM Musteri A " +
                            " FULL OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriAd");
                baglanti.Close();

                clear_boxes();

            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu telefon daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 515)
                    MessageBox.Show("Müşteri TC Bölümü Boş Geçilemez ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else if(err.Number == 547)
                    MessageBox.Show("Böyle TC'ye Ait Bir Müşteri Bulunamadı! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else
                            MessageBox.Show(err.Number + "\n\n" + err.Message, "Uyarı");
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            musteri_tc_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            guncellenecek_tel_textBox.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            silinecek_tel_textBox1.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MusteriTel_Load(object sender, EventArgs e)
        {
            if (baglanti.State.ToString() == "Closed")
            {
                baglanti.Open();
            }
            verileri_goster("SELECT  A.MusteriTc,MusteriAd,MusteriSoyad,B.MusteriTel FROM Musteri A " +
                           " FULL OUTER JOIN " +
                           "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriAd");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (silinecek_tel_textBox1.Text == "")
                {
                    throw new Exception("Silinecek Telefon Alanı Boş Aşağıdaki Listeden Bir Telefon Seçiniz!");
                }

                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("DELETE FROM MusteriTel WHERE MusteriTel =@g_MusteriTel", baglanti);
                komut.Parameters.AddWithValue("@g_MusteriTel", String.IsNullOrWhiteSpace(silinecek_tel_textBox1.Text) ? (object)DBNull.Value : silinecek_tel_textBox1.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri Silme İşlemi Başarılı");
                verileri_goster("SELECT  A.MusteriTc,MusteriAd,MusteriSoyad,B.MusteriTel FROM Musteri A " +
                            " FULL OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriAd");
                baglanti.Close();

                clear_boxes();

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Uyarı");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Uyarı");
            }
        
        clear_boxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            musteri_tc_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            musteri_tel_textBox.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            guncellenecek_tel_textBox.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            silinecek_tel_textBox1.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
        }
    }
}
