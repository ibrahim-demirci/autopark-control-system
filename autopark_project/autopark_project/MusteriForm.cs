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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
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

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            verileri_goster("SELECT MusteriID as 'Müşteri ID', " +
                            "B.MusteriTc as 'Musteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "LEFT OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriID");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ara_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            musteri_id_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            sil_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            musteri_tc_textBox.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            musteri_ad_textBox.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            musteri_soyad_textBox.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
           

        }

        private void goster_buton_Click(object sender, EventArgs e)
        {
            verileri_goster("SELECT MusteriID as 'Müşteri ID', " +
                            "B.MusteriTc as 'Musteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "LEFT OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriID");

            MessageBox.Show("Müşteriler Gösterildi", "Uyarı");

        }

        private void kaydet_buton_Click(object sender, EventArgs e)
        { 
        try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("INSERT INTO Musteri (MusteriTc,MusteriAd,MusteriSoyad) values(@g_MusteriTc,@g_MusteriAd,@g_MusteriSoyad) " , baglanti);
                komut.Parameters.AddWithValue("@g_MusteriTc", String.IsNullOrWhiteSpace(musteri_tc_textBox.Text)? (object) DBNull.Value : musteri_tc_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriAd", String.IsNullOrWhiteSpace(musteri_ad_textBox.Text)? (object) DBNull.Value : musteri_ad_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriSoyad", String.IsNullOrWhiteSpace(musteri_soyad_textBox.Text)? (object) DBNull.Value : musteri_soyad_textBox.Text);
                
                komut.ExecuteNonQuery();
                
                MessageBox.Show("Müşteri Kaydetme İşlemi Başarılı", "Uyarı");

                verileri_goster("SELECT MusteriID as 'Müşteri ID', " +
                            "B.MusteriTc as 'Musteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "LEFT OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriID");
                baglanti.Close();

                clear_boxes();

}
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu müşteri TC'si  daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 515)
                    MessageBox.Show("Müşteri TC Bölümü Boş Geçilemez ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else
                    MessageBox.Show(err.Number + "\n\n" + err.Message, "Uyarı");
            }

        }

        void clear_boxes()
        {
            musteri_id_textBox.Clear();
            musteri_ad_textBox.Clear();
            musteri_soyad_textBox.Clear();
            musteri_tc_textBox.Clear();
            
        }

        private void musteri_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sil_buton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Sil", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {



                try
                {

                    if (sil_textBox.Text == "")
                    {
                        throw new Exception("Aşağıdaki Listeden Bir Müşteri Seçiniz!");
                    }

                    if (baglanti.State.ToString() == "Closed")
                    {
                        baglanti.Open();
                    }
                    SqlCommand komut = new SqlCommand("DELETE FROM Musteri WHERE MusteriID =@g_MusteriID", baglanti);
                    komut.Parameters.AddWithValue("@g_MusteriID", String.IsNullOrWhiteSpace(sil_textBox.Text) ? (object)DBNull.Value : sil_textBox.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Silme İşlemi Başarılı", "Uyarı");
                    verileri_goster("SELECT MusteriID as 'Müşteri ID', " +
                            "B.MusteriTc as 'Musteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "LEFT OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriID");
                    baglanti.Close();

                    clear_boxes();

                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message, "Uyarı");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Uyarı");
                }
            }
            
        }

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }
                if (musteri_id_textBox.Text == "")
                {
                    throw new Exception("Lütfen Aşağıdaki Listeden Bir Müşteri Seçiniz");
                }
                if (musteri_tc_textBox.Text == "")
                {
                    throw new Exception("Müşteri Tc Alanı Boş Bırakılamaz!");
                }
                


                SqlCommand komut = new SqlCommand("UPDATE Musteri SET MusteriTc =@g_MusteriTc," +
                                                  "MusteriAd = @g_MusteriAd," +
                                                  "MusteriSoyad = @g_MusteriSoyad " +
                                                  "WHERE MusteriID = @g_MusteriID" , baglanti);

                komut.Parameters.AddWithValue("@g_MusteriID", String.IsNullOrWhiteSpace(musteri_id_textBox.Text) ? (object)DBNull.Value : musteri_id_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriTc", String.IsNullOrWhiteSpace(musteri_tc_textBox.Text) ? (object)DBNull.Value : musteri_tc_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriAd", String.IsNullOrWhiteSpace(musteri_ad_textBox.Text) ? (object)DBNull.Value : musteri_ad_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriSoyad", String.IsNullOrWhiteSpace(musteri_soyad_textBox.Text) ? (object)DBNull.Value : musteri_soyad_textBox.Text);
                
                komut.ExecuteNonQuery();

                MessageBox.Show("Müşteri Güncelleme İşlemi Başarılı", "Uyarı");


                verileri_goster("SELECT MusteriID as 'Müşteri ID', " +
                            "B.MusteriTc as 'Musteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "LEFT OUTER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc ORDER BY MusteriID");
                baglanti.Close();

                clear_boxes();


            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu Tc daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 547)
                    MessageBox.Show("Bu TC ile bir müşteri bulunamıyor lütfen önce müşteriyi ekleyiniz ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else
                    MessageBox.Show(err.Number + "\n\n" + err.Message, "Uyarı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriTel musteri_tel = new MusteriTel();
            this.Hide();
            musteri_tel.ShowDialog();
            this.Show();
        }

        private void ara_buton_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }


                if (ara_comboBox.Text == "")
                {
                    throw new Exception("Aranacak Parametreyi Seçiniz!");
                }

                if (ara_textBox.Text == "")
                {
                    throw new Exception("Aranacak Değeri Boş Bırakmayınız!");
                }

                switch (ara_comboBox.Text)
                {
                    case "Müşteri TC":
                        verileri_goster("SELECT  " +
                            "MusteriID as 'Müşteri ID', " +
                            "A.MusteriTc 'Müşteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "INNER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc AND B.MusteriTc LIKE '%" + ara_textBox.Text + "%' ORDER BY MusteriID ");
                        break;
                    case "Ad":
                        verileri_goster("SELECT  " +
                            "MusteriID as 'Müşteri ID', " +
                            "A.MusteriTc 'Müşteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "INNER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc AND A.MusteriAd LIKE '%" + ara_textBox.Text + "%' ORDER BY MusteriID ");
                        break;
                    case "Soyad":
                        verileri_goster("SELECT  " +
                            "MusteriID as 'Müşteri ID', " +
                            "A.MusteriTc 'Müşteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "INNER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.MusteriTc AND A.MusteriSoyad LIKE '%" + ara_textBox.Text + "%' ORDER BY MusteriID ");
                        break;
                    case "Numara":
                        verileri_goster("SELECT  " +
                            "MusteriID as 'Müşteri ID', " +
                            "A.MusteriTc 'Müşteri TC', " +
                            "MusteriAd as 'Ad', " +
                            "MusteriSoyad as 'Soyad', " +
                            "B.MusteriTel as 'Telefon' " +
                            "FROM Musteri A " +
                            "INNER JOIN " +
                            "MusteriTel B ON A.MusteriTc = B.Musteri AND B.MusteriTel LIKE '%" + ara_textBox.Text + "%' ORDER BY MusteriID ");
                        break;
                    
                }

                baglanti.Close();

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Uyarı");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Uyarı");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

    
}
