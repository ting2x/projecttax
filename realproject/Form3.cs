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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

 

        private void button2_Click(object sender, EventArgs e)
        {
            int raidai = int.Parse(textBox11.Text);
            int taxprakunsankom = int.Parse(numericUpDown1.Text);
            int taxlife = int.Parse(numericUpDown2.Text);
            int taxhealt = int.Parse(numericUpDown3.Text);
            int taxhealtmomdad = int.Parse(numericUpDown4.Text);
            int moneysave = int.Parse(numericUpDown6.Text);
            int taxwitf = int.Parse(numericUpDown5.Text);
            int o = 0;
            int i = 0;
            int outcome;
            if ((taxlife + taxhealt) > 100000)
            {
                i = 100000;
            }
            else if ((taxlife + taxhealt) < 100000)
            {
                i = (taxlife + taxhealt);
            }
            if (radioButton1.Checked)
            {
                o = 0;
            }
            else if (radioButton2.Checked)
            {
                o = 0;
            }
            else if (radioButton3.Checked)
            {
                o = 10000;
            }
            outcome = (taxprakunsankom + i + taxhealtmomdad + moneysave + taxwitf) + o;
            textBox1.Text = outcome.ToString(); //รายได้ทั้งหมดมาลดกับประกัน

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                numericUpDown5.Enabled = false;
            }
            else
            {
                numericUpDown5.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                numericUpDown5.Enabled = false;
            }
            else
            {
                numericUpDown5.Enabled = true;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.textBox9.Text = textBox9.Text;
            frm4.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox11.Text);
            int c;
           
            c = b - a;
            textBox9.Text = c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
