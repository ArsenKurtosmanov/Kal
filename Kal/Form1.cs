﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void Buttons_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
