﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfTest
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            lblResult.Text = Test.GetResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test.toStart = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test.Exit = true;
            Close();
        }
    }
}
