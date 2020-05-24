using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox1.Text);
            int bonus = int.Parse(textBox2.Text);
            int raidaietc = int.Parse(textBox3.Text);
            int outcome;

            outcome = (money * 12) + bonus + raidaietc;
            textBox4.Text = outcome.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.textBox5.Text = textBox4.Text;
            frm2.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
