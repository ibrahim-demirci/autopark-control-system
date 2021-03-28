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
    public partial class AbonelikBitis : Form
    {


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9SPGDK;Initial Catalog=autopark;Integrated Security=True");

        public AbonelikBitis()
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
                MessageBox.Show(err.Message);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AbonelikBitis_Load(object sender, EventArgs e)
        {
            verileri_goster("SELECT A.AracPlaka, " +
                            "DATEDIFF(DAY,GETDATE(), A.AbonelikBitis) as 'Kalan Süre (Gün)' " +
                            "FROM Abonelik A " +
                            "WHERE DATEDIFF(DAY,GETDATE(), A.AbonelikBitis) <= 15");
            
            baglanti.Close();
        }
    }
}
