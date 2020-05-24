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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                groupBox8.Enabled = false;
                groupBox3.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox8.Enabled = true;
                groupBox3.Enabled = true;
                groupBox2.Enabled = true;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a1 = int.Parse(numericUpDown4.Text);
            int a2 = int.Parse(numericUpDown1.Text);
            int a3 = int.Parse(numericUpDown3.Text); // 62 คนเดียว
            int a4 = int.Parse(numericUpDown2.Text); // พิการ
            int a5 = int.Parse(numericUpDown5.Text); // 61
            int a6 = int.Parse(numericUpDown6.Text); // 62 มากกว่า 1
            int p4;
            int p5 = 0;
            int p3 = 0;
            int p7 = 0;
            int md1 = 0;
            int md2 = 0;
            int md3 = 0;
            int md4 = 0;
            int o = 0;
            int k = 0;
            int outcome;
            int outcomekids;
            int outcomemd;

            if (radioButton1.Checked)
            {
                o = 0;
            }
            else if(radioButton2.Checked)
            {
                o = 0;
            }
            else if(radioButton3.Checked)
            {
                o = 60000;
            }
            if(radioButton4.Checked)
            {
                md1 = 30000;
            }
            else if(radioButton5.Checked)
            {
                md1 = 0;
            }
            if(radioButton6.Checked)
            {
                md2 = 30000;
            }
            else if(radioButton7.Checked)
            {
                md2 = 0;
            }
            if(radioButton9.Checked)
            {
                md3 = 30000;
            }
            else if(radioButton8.Checked)
            {
                md3 = 0;
            }
            if(radioButton11.Checked)
            {
                md4 = 30000;
            }
            else if(radioButton10.Checked)
            {
                md4 = 0;
            }
            if(a5 >= 1)
            {
                p5 = a5 * 30000;
            }
            if(a3 == 1)
            {
                p3 = a3 * 30000;
            }
            if(a6 >= 1)
            {
                p7 = a6 * 60000;
            }

    
 

            outcomemd = md1 + md2 + md3 + md4;
            outcomekids = p3 + p5 + p7;
            p4 = a4 * 60000; //พิการ


            //outcome = a1 + a2 + p5 + p4 + k + o + md1 + md2 + md3 + md4 + a3;
            outcome = (a1 + a2) + p4 + outcomekids + (k + o) + outcomemd;
            textBox1.Text = outcome.ToString();

        }




        private void button4_Click(object sender, EventArgs e)
        {
            
            int raidaipung1 = int.Parse(textBox5.Text);
            int outcome1 = int.Parse(textBox1.Text);
            int outcomefinal;

            outcomefinal = raidaipung1 - outcome1;
            textBox6.Text = outcomefinal.ToString();

        }


        private void label40_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.textBox11.Text = textBox6.Text;
            frm3.Show();
            this.Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
