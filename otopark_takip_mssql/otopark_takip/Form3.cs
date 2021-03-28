using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otopark_takip
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }
        void texteyaz()
        {
            textBox9.Text = (this.BindingContext[frm1.dtst, "musbil"].Position + 1) + " / " + this.BindingContext[frm1.dtst, "musbil"].Count;
        }
        //www.gorselprogramlama.com
        
        private void Form3_Load(object sender, EventArgs e)
        {
            frm1.combo2();
            frm1.listelesene();
            textBox1.DataBindings.Add("Text", frm1.dtst, "musbil.TcKimlik");
            textBox2.DataBindings.Add("Text", frm1.dtst, "musbil.Ad");
            textBox3.DataBindings.Add("Text", frm1.dtst, "musbil.Soyad");
            textBox4.DataBindings.Add("Text", frm1.dtst, "musbil.CepTel");
            textBox5.DataBindings.Add("Text", frm1.dtst, "musbil.PlakaNo");
            textBox6.DataBindings.Add("Text", frm1.dtst, "musbil.Marka");
            textBox7.DataBindings.Add("Text", frm1.dtst, "musbil.Model");
            textBox8.DataBindings.Add("Text", frm1.dtst, "musbil.Renk");
            comboBox1.DataBindings.Add("Text", frm1.dtst, "musbil.Konumu");
            texteyaz();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    frm1.plakasil();
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "DELETE from musbil WHERE TcKimlik='" + textBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "INSERT INTO bos(bosyerler) VALUES ('" + comboBox1.Text + "') ";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "DELETE from dolu WHERE doluyerler='" + comboBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();//www.gorselprogramlama.com
                    frm1.bag.Close();
                    comboBox1.Items.Clear();
                    frm1.comboBox1.Items.Clear();
                    comboBox1.Text = "";
                    frm1.combo();
                    frm1.combo2();
                    frm1.dtst.Clear();
                    frm1.listelesene();//www.gorselprogramlama.com
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position += 1;
            texteyaz();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position -= 1;
            texteyaz();
            //www.gorselprogramlama.com
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position = this.BindingContext[frm1.dtst, "musbil"].Count;
            texteyaz();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position = 0;
            texteyaz();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            frm1.Show();
            this.Hide();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {//www.gorselprogramlama.com
            Application.Exit();
        }
    }
}
