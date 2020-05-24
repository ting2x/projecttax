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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valuehouse2558 = int.Parse(numericUpDown2.Text);
            int taxhouse = int.Parse(numericUpDown1.Text);
            int raidaipung = int.Parse(textBox9.Text);
            int raidaifinal;
            int outcome2558;
            int outcome4;
            int outcomefinal2558;
            

            outcome2558 = (valuehouse2558 * 20) / 100;
            textBox1.Text = outcome2558.ToString();
            outcome4 = (outcome2558 / 5);
            textBox5.Text = outcome4.ToString();
            outcomefinal2558 = (taxhouse + outcome4);
            textBox3.Text = outcomefinal2558.ToString();

            raidaifinal = raidaipung - outcomefinal2558;
            textBox11.Text = raidaifinal.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valuehouse2562 = int.Parse(numericUpDown3.Text);
            int taxhouse = int.Parse(numericUpDown1.Text);
            int raidaipung = int.Parse(textBox9.Text);
            int raidaifinal;
            int outcome2562;
            int outcomefinal2562;
            int i = 0;
            

            if (valuehouse2562 < 200000)
            {
                i = valuehouse2562;
            }
            else if (valuehouse2562 < 5000001)
            {
                i = 200000;
            }

            outcome2562 = i;
            textBox2.Text = outcome2562.ToString();
            outcomefinal2562 = (taxhouse + i);
            textBox4.Text = outcomefinal2562.ToString();

            raidaifinal = raidaipung - outcomefinal2562;
            textBox12.Text = raidaifinal.ToString();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }


        private void label44_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.textBox5.Text = textBox11.Text;
            frm5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.textBox5.Text = textBox12.Text;
            frm5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
