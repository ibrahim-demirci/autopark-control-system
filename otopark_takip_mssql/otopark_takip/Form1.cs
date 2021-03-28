using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;//www.gorselprogramlama.com
using System.Text;
using System.Windows.Forms;

namespace otopark_takip
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm2.frm1 = this;
            frm3.frm1 = this;
        }
        public SqlConnection bag = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=otopark; Integrated Security=true");
      public SqlCommand kmt = new SqlCommand();
      public SqlDataAdapter adtr = new SqlDataAdapter();
      public DataSet dtst = new DataSet();
      
      public void combo()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from bos";

            SqlDataReader  oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
             }
            bag.Close();
            oku.Dispose();
            comboBox1.Sorted = true;
        }
      public void combo2()
      {
          bag.Open();
          kmt.Connection = bag;
          kmt.CommandText = "Select * from dolu";      
       SqlDataReader oku = kmt.ExecuteReader();
          while (oku.Read())
          {
             frm3.comboBox1.Items.Add(oku[0].ToString());
          }
          bag.Close();
          oku.Dispose();
          frm3.comboBox1.Sorted = true;
      }
     public void listelesene()
      {
          bag.Open();//www.gorselprogramlama.com
          SqlDataAdapter adtr = new SqlDataAdapter("select * From musbil", bag);
          adtr.Fill(dtst, "musbil");
          frm3.dataView1.Table = dtst.Tables[0];
          frm3.dataGrid1.DataSource = frm3.dataView1;
         adtr.Dispose();
          bag.Close();
      }

    public void plakayaz()
     {


         bag.Open();
         kmt.Connection = bag;
         kmt.CommandText = "Select * from musbil";
         
         SqlDataReader  oku = kmt.ExecuteReader();
         while (oku.Read())
         {
             switch (oku[8].ToString())
             {
                 case "A1":
                     {
                         frm2.button1.Text = oku[4].ToString();
                         frm2.button1.BackColor = System.Drawing.Color.Red;
                         break;
                     }//www.gorselprogramlama.com
                 case "A2":
                     {
                         frm2.button2.Text = oku[4].ToString();
                         frm2.button2.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "A3":
                     {
                         frm2.button3.Text = oku[4].ToString();
                         frm2.button3.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "A4":
                     {
                         frm2.button4.Text = oku[4].ToString();
                         frm2.button4.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "A5":
                     {
                         frm2.button5.Text = oku[4].ToString();
                         frm2.button5.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "B1":
                     {
                         frm2.button6.Text = oku[4].ToString();
                         frm2.button6.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "B2":
                     {//www.gorselprogramlama.com
                         frm2.button7.Text = oku[4].ToString();
                         frm2.button7.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "B3":
                     {
                         frm2.button8.Text = oku[4].ToString();
                         frm2.button8.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "B4":
                     {
                         frm2.button9.Text = oku[4].ToString();
                         frm2.button9.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "B5":
                     {
                         frm2.button10.Text = oku[4].ToString();
                         frm2.button10.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "C1":
                     {
                         
                         frm2.button11.Text = oku[4].ToString();
                         frm2.button11.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "C2":
                     {
                         frm2.button12.Text = oku[4].ToString();
                         frm2.button12.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "C3":
                     {
                         frm2.button13.Text = oku[4].ToString();//www.gorselprogramlama.com
                         frm2.button13.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "C4":
                     {
                         frm2.button14.Text = oku[4].ToString();
                         frm2.button14.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "C5":
                     {
                         frm2.button15.Text = oku[4].ToString();
                         frm2.button15.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "D1":
                     {
                         frm2.button16.Text = oku[4].ToString();
                         frm2.button16.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "D2":
                     {
                         frm2.button17.Text = oku[4].ToString();//www.gorselprogramlama.com
                         frm2.button17.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "D3":
                     {
                         frm2.button18.Text = oku[4].ToString();
                         frm2.button18.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "D4":
                     {
                         frm2.button19.Text = oku[4].ToString();
                         frm2.button19.BackColor = System.Drawing.Color.Red;
                         break;
                     }
                 case "D5":
                     {
                         frm2.button20.Text = oku[4].ToString();
                         frm2.button20.BackColor = System.Drawing.Color.Red;
                         break;
                     }
             }
            
         }
         bag.Close();
         oku.Dispose();
     }

   public void plakasil()
    {
        switch (frm3.comboBox1.Text)
        {
            case "A1":
                {
                    frm2.button1.Text = "A1";
                    frm2.button1.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "A2":
                {

                    frm2.button2.Text = "A2";
                    frm2.button2.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "A3":
                {
                    frm2.button3.Text = "A3";
                    frm2.button3.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "A4":
                {
                    frm2.button4.Text = "A4";//www.gorselprogramlama.com
                    frm2.button4.BackColor = System.Drawing.Color.Red;
                    break;
                }
            case "A5":
                {
                    frm2.button5.Text = "A5";
                    frm2.button5.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "B1":
                {
                    frm2.button6.Text = "B1";
                    frm2.button6.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "B2":
                {
                    frm2.button7.Text = "B2";
                    frm2.button7.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "B3":
                {
                    frm2.button8.Text = "B3";
                    frm2.button8.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "B4":
                {
                    frm2.button9.Text = "B4";
                    frm2.button9.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "B5":
                {
                    frm2.button10.Text = "B5";
                    frm2.button10.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "C1":
                {
                    frm2.button11.Text = "C1";
                    frm2.button11.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "C2":
                {
                    frm2.button12.Text = "C2";
                    frm2.button12.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "C3":
                {
                    frm2.button13.Text = "C3";//www.gorselprogramlama.com
                    frm2.button13.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "C4":
                {
                    frm2.button14.Text = "C4";
                    frm2.button14.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "C5":
                {
                    frm2.button15.Text = "C5";
                    frm2.button15.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "D1":
                {
                    frm2.button16.Text = "D1";
                    frm2.button16.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "D2":
                {
                    frm2.button17.Text = "D2";
                    frm2.button17.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "D3":
                {
                    frm2.button18.Text = "D3";
                    frm2.button18.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "D4":
                {
                    frm2.button19.Text = "D4";
                    frm2.button19.BackColor = System.Drawing.Color.Green;
                    break;
                }
            case "D5":
                {
                    frm2.button20.Text ="D5";
                    frm2.button20.BackColor = System.Drawing.Color.Green;
                    break;
                }
        }
    }
        private void Form1_Load(object sender, EventArgs e)
        {
              combo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox5.Text !="" && comboBox1.Text!="" )
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "INSERT INTO musbil(TcKimlik,Ad,Soyad,CepTel,PlakaNo,Marka,Model,Renk,Konumu) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox1.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "INSERT INTO dolu(doluyerler) VALUES ('" + comboBox1.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "DELETE from bos WHERE bosyerler='" + comboBox1.Text + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                comboBox1.Items.Clear();
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear();
                comboBox1.Text = "";
                combo();
                plakayaz();
                MessageBox.Show("Kayıt işlemi tamamlandı ! ");
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//www.gorselprogramlama.com
}
