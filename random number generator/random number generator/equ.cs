﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_number_generator
{
    public partial class Form1 : Form
    {
        int x;
        int b = 1;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new Random(2);
            int x = Convert.ToInt32(a);
        }
    }
    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
}
