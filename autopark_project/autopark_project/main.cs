using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace autopark_project
{
    public partial class main : Form
    {


        AracForm arac_form = new AracForm();
        public main()
        {
            InitializeComponent();
        }
        
        public  void main_show()
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracForm arac_form = new AracForm();
            this.Hide();
            arac_form.ShowDialog();
            this.Show();
            
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriForm musteri_form = new MusteriForm();
            this.Hide();
            musteri_form.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abonelik abonelik_form = new Abonelik();
            this.Hide();
            abonelik_form.ShowDialog();
            this.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz", "Exit", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
                Application.Exit();
            else if (cikis == DialogResult.No)
            {

            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalisanForm calisan = new CalisanForm();
            this.Hide();
            calisan.ShowDialog();
            this.Show();
        }
    }
}
