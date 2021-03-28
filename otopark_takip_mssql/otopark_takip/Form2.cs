using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;//www.gorselprogramlama.com
using System.Windows.Forms;

namespace otopark_takip
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            frm1.plakayaz();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
