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
    public partial class AracForm : Form
    {
        public AracForm()
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

        public void verileri_goster(String veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];    //0. kaynaktan başla


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AracForm_Load(object sender, EventArgs e)
        {
            verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            "ORDER BY a.AracID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            "ORDER BY a.AracID"); verileri_goster("SELECT * FROM Arac");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("INSERT INTO Arac (AracPlaka,AracMarka,AracModel,AracYil,AracRenk,MusteriTc) values(@g_AracPlaka,@g_AracMarka,@g_AracModel,@g_AracYil,@g_AracRenk,@g_MusteriTc) ", baglanti);
                komut.Parameters.AddWithValue("@g_AracPlaka", String.IsNullOrWhiteSpace(plaka_textBox.Text) ? (object)DBNull.Value : plaka_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracMarka", String.IsNullOrWhiteSpace(marka_textBox.Text) ? (object)DBNull.Value : marka_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracModel", String.IsNullOrWhiteSpace(model_textBox.Text) ? (object)DBNull.Value : model_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracYil", String.IsNullOrWhiteSpace(yil_textBox.Text) ? (object)DBNull.Value : yil_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracRenk", String.IsNullOrWhiteSpace(renk_textBox.Text) ? (object)DBNull.Value : renk_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriTc", mus_tc_textBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Araç Kaydetme İşlemi Başarılı", "Uyarı");
                verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            "ORDER BY a.AracID");
                baglanti.Close();

                clear_boxes();

            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu plaka daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 547)
                    MessageBox.Show("Bu TC ile bir müşteri bulunamıyor lütfen önce müşteriyi ekleyiniz ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message,"Uyarı");
                else if (err.Number == 515)
                    MessageBox.Show("Araç Plaka Bölümü Boş Geçilemez ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message,"Uyarı");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            aracid_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            sil_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            plaka_textBox.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            marka_textBox.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            model_textBox.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            yil_textBox.Text = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            renk_textBox.Text = dataGridView1.Rows[secili].Cells[5].Value.ToString();
            mus_tc_textBox.Text = dataGridView1.Rows[secili].Cells[6].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }

                if (aracid_textBox.Text == "")
                {
                    throw new Exception(" Araç ID Boş Lütfen Aşağıdaki Listeden Bir Çalışan Seçiniz");
                }

                if (plaka_textBox.Text == "")
                {
                    throw new Exception("Plaka Bölümünü Boş Bırakmayınız!");
                }

                SqlCommand komut = new SqlCommand("UPDATE Arac SET AracPlaka =@g_AracPlaka," +
                                                  "AracMarka = @g_AracMarka," +
                                                  "AracModel = @g_AracModel," +
                                                  "AracYil = @g_AracYil," +
                                                  "AracRenk = @g_AracRenk," +
                                                  "MusteriTc = @g_MusteriTc " +
                                                  "where AracID = @g_AracID", baglanti);
                komut.Parameters.AddWithValue("@g_AracID",String.IsNullOrWhiteSpace(aracid_textBox.Text) ? (object)DBNull.Value : aracid_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracPlaka", String.IsNullOrWhiteSpace(plaka_textBox.Text) ? (object)DBNull.Value : plaka_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracMarka", String.IsNullOrWhiteSpace(marka_textBox.Text) ? (object)DBNull.Value : marka_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracModel", String.IsNullOrWhiteSpace(model_textBox.Text) ? (object)DBNull.Value : model_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracYil", String.IsNullOrWhiteSpace(yil_textBox.Text) ? (object)DBNull.Value : yil_textBox.Text);
                komut.Parameters.AddWithValue("@g_AracRenk", String.IsNullOrWhiteSpace(renk_textBox.Text) ? (object)DBNull.Value : renk_textBox.Text);
                komut.Parameters.AddWithValue("@g_MusteriTc", mus_tc_textBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Araç Güncelleme İşlemi Başarılı", "Uyarı");
                verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            "ORDER BY a.AracID");
                baglanti.Close();

                clear_boxes();

             
            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu plaka daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 547)
                    MessageBox.Show("Bu TC ile bir müşteri bulunamıyor lütfen önce müşteriyi ekleyiniz ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else if (err.Number == 515)
                    MessageBox.Show("Araç Plaka Bölümü Boş Geçilemez ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Uyarı");
            }
        }

        private void label9_Click(object sender, EventArgs e)
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
                        throw new Exception(" Silinecek ID Boş Lütfen Aşağıdaki Listeden Bir Çalışan Seçiniz");
                    }

                    if (baglanti.State.ToString() == "Closed")
                    {
                        baglanti.Open();    
                    }
                    SqlCommand komut = new SqlCommand("DELETE FROM Arac WHERE AracID =@g_AracID", baglanti);
                    komut.Parameters.AddWithValue("@g_AracID", String.IsNullOrWhiteSpace(sil_textBox.Text) ? (object)DBNull.Value : sil_textBox.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Silme İşlemi Başarılı", "Uyarı");
                    verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            "ORDER BY a.AracID");
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

        void clear_boxes()
        {
            aracid_textBox.Clear();
            plaka_textBox.Clear();
            marka_textBox.Clear();
            model_textBox.Clear();
            yil_textBox.Clear();
            renk_textBox.Clear();
            mus_tc_textBox.Clear();
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
                    case "Plaka":
                        verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            " WHERE AracPlaka LIKE '%" + ara_textBox.Text + "%' ORDER BY a.AracID");
                        break;
                    case "Marka":
                        verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            " WHERE a.AracMarka LIKE '%" + ara_textBox.Text + "%' ORDER BY a.AracID");
                        break;
                    case "Model":
                        verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            " WHERE a.AracModel LIKE '%" + ara_textBox.Text + "%' ORDER BY a.AracID");
                        break;
                    case "Yıl":
                        verileri_goster("SELECT " +
                             "a.AracID as 'Arac ID', " +
                             "a.AracPlaka as 'Plaka'," +
                             "a.AracMarka as 'Marka', " +
                             "a.AracModel as 'Model', " +
                             "a.AracYil as 'Yıl', " +
                             "a.AracRenk as 'Renk', " +
                             "a.MusteriTc as 'Müşteri TC' " +
                             "FROM Arac a " +
                             " WHERE a.AracYil LIKE '%" + ara_textBox.Text + "%' ORDER BY a.AracID");
                        break;
                    case "Renk":
                        verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            " WHERE a.AracRenk LIKE '%" + ara_textBox.Text + "%' ORDER BY a.AracID");
                        break;
                    case "Müşteri TC":
                        verileri_goster("SELECT " +
                            "a.AracID as 'Arac ID', " +
                            "a.AracPlaka as 'Plaka'," +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Yıl', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a " +
                            " WHERE a.MusteriTc LIKE '%" + ara_textBox.Text + "%' ORDER BY a.AracID");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ara_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sil_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aracid_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void renk_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yil_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void model_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void marka_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void plaka_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }
    }
    
}
