﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BTN_Play_Click(object sender, EventArgs e)
        {
            new Game().Show();
            GlobalVariables.frmHome.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}