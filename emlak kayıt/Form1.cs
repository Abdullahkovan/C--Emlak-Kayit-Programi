﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlak_kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "siteadmin" && textBox2.Text == "site12345")
            {
                Form2 emlakkayıt = new Form2();
                emlakkayıt.Show();
                this.Hide();
            }
        }
    }
}
