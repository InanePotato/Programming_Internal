using System;
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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            PNL_LevelDisplay.Location = new Point((this.Width - PNL_LevelDisplay.Width) / 2, (this.Height - PNL_LevelDisplay.Height) / 2);
        }

        public void ResetButtonEnables()
        {
            BTN_Level1.Enabled = true;
            BTN_Level2.Enabled = true;
            BTN_Level3.Enabled = true;
            BTN_Level4.Enabled = true;
            BTN_Level5.Enabled = true;
            BTN_Level6.Enabled = true;
            BTN_Level7.Enabled = true;
            BTN_Level8.Enabled = true;
            BTN_Level9.Enabled = true;
            BTN_Level10.Enabled = true;
            BTN_Level11.Enabled = true;
            BTN_Level12.Enabled = true;
            BTN_Level13.Enabled = true;
            BTN_Level14.Enabled = true;
            BTN_Level15.Enabled = true;
            BTN_Level16.Enabled = true;
            BTN_Level17.Enabled = true;
            BTN_Level18.Enabled = true;
            BTN_Level19.Enabled = true;
            BTN_Level20.Enabled = true;
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            GlobalVariables.ChildToOpen = "army_camp";
        }

        private void BTN_Fight_Click(object sender, EventArgs e)
        {
            GlobalVariables.ChildToOpen = "battleground";
        }

        private void BTN_Level1_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 1;
            BTN_Level1.Enabled = false;
        }

        private void BTN_Level2_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 2;
            BTN_Level2.Enabled = false;
        }

        private void BTN_Level3_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 3;
            BTN_Level3.Enabled = false;
        }

        private void BTN_Level4_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 4;
            BTN_Level4.Enabled = false;
        }

        private void BTN_Level5_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 5;
            BTN_Level5.Enabled = false;
        }

        private void BTN_Level6_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 6;
            BTN_Level6.Enabled = false;
        }

        private void BTN_Level7_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 7;
            BTN_Level7.Enabled = false;
        }

        private void BTN_Level8_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 8;
            BTN_Level8.Enabled = false;
        }

        private void BTN_Level9_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 9;
            BTN_Level9.Enabled = false;
        }

        private void BTN_Level10_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 10;
            BTN_Level10.Enabled = false;
        }

        private void BTN_Level11_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 11;
            BTN_Level11.Enabled = false;
        }

        private void BTN_Level12_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 12;
            BTN_Level12.Enabled = false;
        }

        private void BTN_Level13_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 13;
            BTN_Level13.Enabled = false;
        }

        private void BTN_Level14_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 14;
            BTN_Level14.Enabled = false;
        }

        private void BTN_Level15_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 15;
            BTN_Level15.Enabled = false;
        }

        private void BTN_Level16_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 16;
            BTN_Level16.Enabled = false;
        }

        private void BTN_Level17_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 17;
            BTN_Level17.Enabled = false;
        }

        private void BTN_Level18_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 18;
            BTN_Level18.Enabled = false;
        }

        private void BTN_Level19_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 19;
            BTN_Level19.Enabled = false;
        }

        private void BTN_Level20_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 20;
            BTN_Level20.Enabled = false;
        }
    }
}
