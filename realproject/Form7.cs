﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int outcomefinal = int.Parse(textBox1.Text);
            int k;
            
            
            if (outcomefinal > 5000001)
            {
                k = (outcomefinal * 35 / 100);
            }
            else if (outcomefinal > 2000001)
            {
                k = (outcomefinal * 30 / 100);
            }
            else if (outcomefinal > 1000001)
            {
                k = (outcomefinal * 25 / 100);
            }
            else if (outcomefinal > 750001)
            {
                k = (outcomefinal * 20 / 100);
            }
            else if (outcomefinal > 500001)
            {
                k = (outcomefinal * 15 / 100);
            }
            else if (outcomefinal > 300001)
            {
                k = (outcomefinal * 10 / 100);
            }
            else if (outcomefinal > 150001)
            {
                k = (outcomefinal * 5 / 100);
            }
            else
            {
                k = (0);
            }

            textBox2.Text = k.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
