﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Programming_Internal
{
    public partial class Admin : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRng")]

        //private static extern IntPtr CreateRoundRectRng
        //(
        //int nLeftRect,
        //int nTopRect,
        //int nRightRect,
        //int nBottomRect,
        //int nWidthEllipse,
        //int nHeightEllispe
        //);

        public Admin()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRng(0, 0, Width, Height, 25, 25));
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            BTN_Home.BackColor = Color.FromArgb(46, 51, 73);
            BTN_Home.Cursor = Cursors.Default;

            BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
            BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            BTN_Home.BackColor = Color.FromArgb(46, 51, 73);
            BTN_Home.Cursor = Cursors.Default;

            BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
            BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
            BTN_LiveVariables.Cursor = Cursors.Hand;
            BTN_UnitSettings.Cursor = Cursors.Hand;
            BTN_Users.Cursor = Cursors.Hand;
        }

        private void BTN_LiveVariables_Click(object sender, EventArgs e)
        {
            BTN_LiveVariables.BackColor = Color.FromArgb(46, 51, 73);
            BTN_LiveVariables.Cursor = Cursors.Default;

            BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
            BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Home.Cursor = Cursors.Hand;
            BTN_UnitSettings.Cursor = Cursors.Hand;
            BTN_Users.Cursor = Cursors.Hand;
        }

        private void BTN_UnitSettings_Click(object sender, EventArgs e)
        {
            BTN_UnitSettings.BackColor = Color.FromArgb(46, 51, 73);
            BTN_UnitSettings.Cursor = Cursors.Default;

            BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
            BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Home.Cursor = Cursors.Hand;
            BTN_LiveVariables.Cursor = Cursors.Hand;
            BTN_Users.Cursor = Cursors.Hand;
        }

        private void BTN_Users_Click(object sender, EventArgs e)
        {
            BTN_Users.BackColor = Color.FromArgb(46, 51, 73);
            BTN_Users.Cursor = Cursors.Default;

            BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
            BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
            BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Home.Cursor = Cursors.Hand;
            BTN_LiveVariables.Cursor = Cursors.Hand;
            BTN_UnitSettings.Cursor = Cursors.Hand;
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
