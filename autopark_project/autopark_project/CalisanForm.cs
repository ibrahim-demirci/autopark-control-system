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
    public partial class CalisanForm : Form
    {
        public CalisanForm()
        {

            
            InitializeComponent();
            this.SetFontAndColors();
        }

        private void SetFontAndColors()
        {
            
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic",9, FontStyle.Bold);
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

        private void goster_buton_Click(object sender, EventArgs e)
        {
            verileri_goster("SELECT " +
                            "CalisanID as 'Çalışan ID', " +
                            "CalisanTc as 'Çalışan TC', " +
                            "CalisanAd as 'Adı', " +
                            "CalisanSoyad as 'Soyadı', " +
                            "CalisanMaas as 'Maaş', " +
                            "CalisanYas as 'Yaş', " +
                            "MesaiTur as 'Mesai' " +
                            "FROM Calisan " +
                            "ORDER BY CalisanAd");
        }



        void clear_boxes()
        {
            calisanid_textBox.Clear();
            calisanad_textBox.Clear();
            calisantc_textBox.Clear();
            calisansoyad_textBox.Clear();
            calisanmaas_textBox.Clear();
            calisanyas_textBox.Clear();
            mesai_textBox.Clear();
            sil_textBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            calisanid_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            calisantc_textBox.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            calisanad_textBox.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            calisansoyad_textBox.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            calisanmaas_textBox.Text = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            calisanyas_textBox.Text = dataGridView1.Rows[secili].Cells[5].Value.ToString();
            mesai_textBox.Text = dataGridView1.Rows[secili].Cells[6].Value.ToString();
            sil_textBox.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
        }

        private void kaydet_buton_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("INSERT INTO Calisan " +
                                                  "(CalisanTc,CalisanAd,CalisanSoyad,CalisanMaas,CalisanYas,MesaiTur) " +
                                                  "values(@g_CalisanTc,@g_CalisanAd,@g_CalisanSoyad,@g_CalisanMaas,@g_CalisanYas,@g_MesaiTur) ", baglanti);
                komut.Parameters.AddWithValue("@g_CalisanTc", String.IsNullOrWhiteSpace(calisantc_textBox.Text) ? (object)DBNull.Value : calisantc_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanAd", String.IsNullOrWhiteSpace(calisanad_textBox.Text) ? (object)DBNull.Value : calisanad_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanSoyad", String.IsNullOrWhiteSpace(calisansoyad_textBox.Text) ? (object)DBNull.Value : calisansoyad_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanMaas", String.IsNullOrWhiteSpace(calisanmaas_textBox.Text) ? (object)DBNull.Value : calisanmaas_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanYas", String.IsNullOrWhiteSpace(calisanyas_textBox.Text) ? (object)DBNull.Value : calisanyas_textBox.Text);
                komut.Parameters.AddWithValue("@g_MesaiTur", String.IsNullOrWhiteSpace(mesai_textBox.Text) ? (object)DBNull.Value : mesai_textBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Çalışan Ekleme İşlemi Başarılı", "Uyarı");
                verileri_goster("SELECT " +
                            "CalisanID as 'Çalışan ID', " +
                            "CalisanTc as 'Çalışan TC', " +
                            "CalisanAd as 'Adı', " +
                            "CalisanSoyad as 'Soyadı', " +
                            "CalisanMaas as 'Maaş', " +
                            "CalisanYas as 'Yaş', " +
                            "MesaiTur as 'Mesai' " +
                            "FROM Calisan " +
                            "ORDER BY CalisanAd");
                baglanti.Close();

                clear_boxes();

            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu TC daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 515)
                    MessageBox.Show("Tc Bölümü Boş Geçilemez ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
                else
                    MessageBox.Show(err.Number + "\n\n" + err.Message, "Uyarı");
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

                if (calisanid_textBox.Text == "")
                {
                    throw new Exception(" Çalışan ID Boş Lütfen Aşağıdaki Listeden Bir Çalışan Seçiniz");
                }

                if (calisantc_textBox.Text =="")
                {
                    throw new Exception("TC Bölümünü Boş Bırakmayınız!");
                }


                SqlCommand komut = new SqlCommand("UPDATE Calisan SET CalisanTc =@g_CalisanTc," +
                                                  "CalisanAd = @g_CalisanAd," +
                                                  "CalisanSoyad = @g_CalisanSoyad," +
                                                  "CalisanMaas = @g_CalisanMaas," +
                                                  "CalisanYas = @g_CalisanYas," +
                                                  "MesaiTur = @g_MesaiTur " +
                                                  "where CalisanID = @g_CalisanID", baglanti);
                komut.Parameters.AddWithValue("@g_CalisanID", String.IsNullOrWhiteSpace(calisanid_textBox.Text) ? (object)DBNull.Value : calisanid_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanTc", String.IsNullOrWhiteSpace(calisantc_textBox.Text) ? (object)DBNull.Value : calisantc_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanAd", String.IsNullOrWhiteSpace(calisanad_textBox.Text) ? (object)DBNull.Value : calisanad_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanSoyad", String.IsNullOrWhiteSpace(calisansoyad_textBox.Text) ? (object)DBNull.Value : calisansoyad_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanMaas", String.IsNullOrWhiteSpace(calisanmaas_textBox.Text) ? (object)DBNull.Value : calisanmaas_textBox.Text);
                komut.Parameters.AddWithValue("@g_CalisanYas", String.IsNullOrWhiteSpace(calisanyas_textBox.Text) ? (object)DBNull.Value : calisanyas_textBox.Text);
                komut.Parameters.AddWithValue("@g_MesaiTur", String.IsNullOrWhiteSpace(mesai_textBox.Text) ? (object)DBNull.Value : mesai_textBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Çalışan Güncelleme İşlemi Başarılı", "Uyarı");

                verileri_goster("SELECT " +
                            "CalisanID as 'Çalışan ID', " +
                            "CalisanTc as 'Çalışan TC', " +
                            "CalisanAd as 'Adı', " +
                            "CalisanSoyad as 'Soyadı', " +
                            "CalisanMaas as 'Maaş', " +
                            "CalisanYas as 'Yaş', " +
                            "MesaiTur as 'Mesai' " +
                            "FROM Calisan " +
                            "ORDER BY CalisanAd");
                baglanti.Close();

                clear_boxes();

            }
            catch (SqlException err)
            {
                if (err.Number == 2627)
                    MessageBox.Show("Bu TC daha önce kaydedilmiş !\n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");

                else if (err.Number == 515)
                    MessageBox.Show("Çalışan Tc Bölümü Boş Geçilemez ! \n\n" + "Hata Numarası : " + err.Number + "\n\n" + err.Message, "Uyarı");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Uyarı");
            }
        }

        private void CalisanForm_Load(object sender, EventArgs e)
        {
            verileri_goster("SELECT " +
                            "CalisanID as 'Çalışan ID', " +
                            "CalisanTc as 'Çalışan TC', " +
                            "CalisanAd as 'Adı', " +
                            "CalisanSoyad as 'Soyadı', " +
                            "CalisanMaas as 'Maaş', " +
                            "CalisanYas as 'Yaş', " +
                            "MesaiTur as 'Mesai' " +
                            "FROM Calisan " +
                            "ORDER BY CalisanAd");
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {

            try
            {

                if (sil_textBox.Text == "")
                {
                    throw new Exception("Silinecek Çalışan ID Alanı Boş Aşağıdaki Listeden Bir Çalışan Seçiniz!");
                }

                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("DELETE FROM Calisan WHERE CalisanID =@g_CalisanID", baglanti);
                komut.Parameters.AddWithValue("@g_CalisanID", String.IsNullOrWhiteSpace(sil_textBox.Text) ? (object)DBNull.Value : sil_textBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Çalışan Silme İşlemi Başarılı", "Uyarı");
                verileri_goster("SELECT " +
                            "CalisanID as 'Çalışan ID', " +
                            "CalisanTc as 'Çalışan TC', " +
                            "CalisanAd as 'Adı', " +
                            "CalisanSoyad as 'Soyadı', " +
                            "CalisanMaas as 'Maaş', " +
                            "CalisanYas as 'Yaş', " +
                            "MesaiTur as 'Mesai' " +
                            "FROM Calisan " +
                            "ORDER BY CalisanAd");
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

        private void ara_buton_Click(object sender, EventArgs e)
        {
            try
            {

                if(ara_comboBox.Text == "")
                {
                    throw new Exception("Aranacak Parametreyi Seçiniz!");
                }

                if (ara_textBox.Text == "")
                {
                    throw new Exception("Aranacak Değeri Boş Bırakmayınız!");
                }


                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }

                switch (ara_comboBox.SelectedIndex)
                {
                    
                    case 0:
                        verileri_goster("SELECT " +
                                "CalisanID as 'Çalışan ID', " +
                                "CalisanTc as 'Çalışan TC', " +
                                "CalisanAd as 'Adı', " +
                                "CalisanSoyad as 'Soyadı', " +
                                "CalisanMaas as 'Maaş', " +
                                "CalisanYas as 'Yaş', " +
                                "MesaiTur as 'Mesai' " +
                                "FROM Calisan " +
                                "WHERE CalisanTc LIKE '%" + ara_textBox.Text + "%' " +
                                "ORDER BY CalisanAd");
                        break;
                    case 1:
                        verileri_goster("SELECT " +
                                "CalisanID as 'Çalışan ID', " +
                                "CalisanTc as 'Çalışan TC', " +
                                "CalisanAd as 'Adı', " +
                                "CalisanSoyad as 'Soyadı', " +
                                "CalisanMaas as 'Maaş', " +
                                "CalisanYas as 'Yaş', " +
                                "MesaiTur as 'Mesai' " +
                                "FROM Calisan " +
                                "WHERE CalisanAd LIKE '%" + ara_textBox.Text + "%' " +
                                "ORDER BY CalisanAd");
                        break;
                    case 2:
                        verileri_goster("SELECT " +
                                "CalisanID as 'Çalışan ID', " +
                                "CalisanTc as 'Çalışan TC', " +
                                "CalisanAd as 'Adı', " +
                                "CalisanSoyad as 'Soyadı', " +
                                "CalisanMaas as 'Maaş', " +
                                "CalisanYas as 'Yaş', " +
                                "MesaiTur as 'Mesai' " +
                                "FROM Calisan " +
                                "WHERE CalisanSoyad LIKE '%" + ara_textBox.Text + "%' " +
                                "ORDER BY CalisanAd");
                        break;
                    case 3:
                        verileri_goster("SELECT " +
                                "CalisanID as 'Çalışan ID', " +
                                "CalisanTc as 'Çalışan TC', " +
                                "CalisanAd as 'Adı', " +
                                "CalisanSoyad as 'Soyadı', " +
                                "CalisanMaas as 'Maaş', " +
                                "CalisanYas as 'Yaş', " +
                                "MesaiTur as 'Mesai' " +
                                "FROM Calisan " +
                                "WHERE CalisanMaas LIKE '%" + ara_textBox.Text + "%' " +
                                "ORDER BY CalisanAd");
                        break;
                    case 4:
                        verileri_goster("SELECT " +
                                "CalisanID as 'Çalışan ID', " +
                                "CalisanTc as 'Çalışan TC', " +
                                "CalisanAd as 'Adı', " +
                                "CalisanSoyad as 'Soyadı', " +
                                "CalisanMaas as 'Maaş', " +
                                "CalisanYas as 'Yaş', " +
                                "MesaiTur as 'Mesai' " +
                                "FROM Calisan " +
                                "WHERE CalisanYas LIKE '%" + ara_textBox.Text + "%' " +
                                "ORDER BY CalisanAd");
                        break;
                    case 5:
                        verileri_goster("SELECT " +
                                "CalisanID as 'Çalışan ID', " +
                                "CalisanTc as 'Çalışan TC', " +
                                "CalisanAd as 'Adı', " +
                                "CalisanSoyad as 'Soyadı', " +
                                "CalisanMaas as 'Maaş', " +
                                "CalisanYas as 'Yaş', " +
                                "MesaiTur as 'Mesai' " +
                                "FROM Calisan " +
                                "WHERE MesaiTur LIKE '%" + ara_textBox.Text + "%' " +
                                "ORDER BY CalisanAd");
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
    }
}
