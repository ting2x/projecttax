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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shophelp = int.Parse(numericUpDown1.Text);
            int shopstudysport = int.Parse(numericUpDown2.Text);
            int shopbook = int.Parse(numericUpDown3.Text);
            int shopotop = int.Parse(numericUpDown4.Text);
            int travel1 = int.Parse(numericUpDown5.Text);
            int travel2 = int.Parse(numericUpDown6.Text);
            int fixhome = int.Parse(numericUpDown7.Text);
            int fixcar = int.Parse(numericUpDown8.Text);
            int raidaipung = int.Parse(textBox5.Text);
            int outcomefinal;
            int outcome;
            int i = 0;
            int j = 0;

            if ((travel1 + travel2) < 20000)
            {
                i = (travel1 + travel2);
            }
            else if ((travel1 + travel2) > 20001)
            {
                i = 20000;
            }
            if ((fixhome + fixcar) < 100000)
            {
                j = (fixhome + fixcar);
            }
            else if ((fixhome + fixcar) > 100001)
            {
                j = 100000;
            }

            outcome = (shophelp + shopstudysport + shopbook + shopotop + i) + j;
            textBox1.Text = outcome.ToString();

            outcomefinal = raidaipung - outcome;
            textBox6.Text = outcomefinal.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }


        private void label124_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.textBox1.Text = textBox6.Text;
            frm7.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
    }
}
