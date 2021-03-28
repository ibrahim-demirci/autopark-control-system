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
    public partial class AbonelikAracYardım : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9SPGDK;Initial Catalog=autopark;Integrated Security=True");
        public AbonelikAracYardım()
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

        private void AbonelikAracYardım_Load(object sender, EventArgs e)
        {
            verileri_goster("SELECT a.AracPlaka as 'Araç Plaka', " +
                            "a.AracMarka as 'Marka', " +
                            "a.AracModel as 'Model', " +
                            "a.AracYil as 'Araç Yılı', " +
                            "a.AracRenk as 'Renk', " +
                            "a.MusteriTc as 'Müşteri TC' " +
                            "FROM Arac a");
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

        private void AbonelikAracYardım_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
