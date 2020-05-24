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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int helpstudy = int.Parse(textBox6.Text);
            int helprb = int.Parse(textBox7.Text);
            int helpsport = int.Parse(textBox8.Text);
            int helppublic = int.Parse(textBox9.Text);
            int helpplabuk = int.Parse(textBox10.Text);
            int helpetc = int.Parse(textBox11.Text);
            int helppolitical = int.Parse(numericUpDown1.Text);
            int raidaifinal = int.Parse(textBox5.Text);
            int calraidaifinal;
            int outcomefinal;
            int i = 0;
            int a1;
            int a2;
            int a3;
            int a4;
            int a5;
            int a6;
            int a7;
            int outcomefinalz;


            a1 = (helpstudy * 2);
            textBox17.Text = a1.ToString();
            a2 = (helprb * 2);
            textBox16.Text = a2.ToString();
            a3 = (helpsport * 2);
            textBox15.Text = a3.ToString();
            a4 = (helppublic * 2);
            textBox14.Text = a4.ToString();
            a5 = helpplabuk;
            textBox13.Text = a5.ToString();
            a6 = helpetc;
            textBox12.Text = a6.ToString();
            a7 = helppolitical;
            textBox18.Text = a7.ToString();

            calraidaifinal = (raidaifinal * 10) / 100;

            outcomefinal = (a1 + a2 + a3 + a4 + a5 + a6 + a7);
            if (outcomefinal > calraidaifinal)
            {
                i = calraidaifinal;
            }
            else if (outcomefinal < calraidaifinal)
            {
                i = outcomefinal;
            }
            textBox19.Text = i.ToString();

            outcomefinalz = raidaifinal - i;
            textBox20.Text = outcomefinalz.ToString();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.textBox5.Text = textBox20.Text;
            frm6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }
    }
}
