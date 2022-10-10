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
            PNL_LevelDisplay.Location = new Point(PNL_LevelDisplay.Location.X, (this.Height - PNL_LevelDisplay.Height) / 2);
            PNL_LevelOverview.Location = new Point(PNL_LevelOverview.Location.X, (this.Height - PNL_LevelOverview.Height) / 2);
            ResetButtonEnables();
        }

        public void ResetButtonEnables()
        {
            if (GlobalVariables.LevelsUnlocked > 0) { BTN_Level1.Enabled = true; BTN_Level1.Cursor = Cursors.Hand; }
            else { BTN_Level1.Enabled = false; BTN_Level1.Cursor = Cursors.Default; }
            if (GlobalVariables.LevelsUnlocked > 1) { BTN_Level2.Enabled = true; BTN_Level2.Cursor = Cursors.Hand; }
            else { BTN_Level2.Enabled = false; BTN_Level2.Cursor = Cursors.Default; }
            if (GlobalVariables.LevelsUnlocked > 2) { BTN_Level3.Enabled = true; BTN_Level3.Cursor = Cursors.Hand;}
            else { BTN_Level3.Enabled = false; BTN_Level3.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 3) { BTN_Level4.Enabled = true; BTN_Level4.Cursor = Cursors.Hand;}
            else { BTN_Level4.Enabled = false; BTN_Level4.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 4) { BTN_Level5.Enabled = true; BTN_Level5.Cursor = Cursors.Hand;}
            else { BTN_Level5.Enabled = false; BTN_Level5.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 5) { BTN_Level6.Enabled = true; BTN_Level6.Cursor = Cursors.Hand;}
            else { BTN_Level6.Enabled = false; BTN_Level6.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 6) { BTN_Level7.Enabled = true; BTN_Level7.Cursor = Cursors.Hand;}
            else { BTN_Level7.Enabled = false; BTN_Level7.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 7) { BTN_Level8.Enabled = true; BTN_Level8.Cursor = Cursors.Hand;}
            else { BTN_Level8.Enabled = false; BTN_Level8.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 8) { BTN_Level9.Enabled = true; BTN_Level9.Cursor = Cursors.Hand;}
            else { BTN_Level9.Enabled = false; BTN_Level9.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 9) { BTN_Level10.Enabled = true; BTN_Level10.Cursor = Cursors.Hand;}
            else { BTN_Level10.Enabled = false; BTN_Level10.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 10) { BTN_Level11.Enabled = true; BTN_Level11.Cursor = Cursors.Hand;}
            else { BTN_Level11.Enabled = false; BTN_Level11.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 11) { BTN_Level12.Enabled = true; BTN_Level12.Cursor = Cursors.Hand;}
            else { BTN_Level12.Enabled = false; BTN_Level12.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 12) { BTN_Level13.Enabled = true; BTN_Level13.Cursor = Cursors.Hand;}
            else { BTN_Level13.Enabled = false; BTN_Level13.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 13) { BTN_Level14.Enabled = true; BTN_Level14.Cursor = Cursors.Hand;}
            else { BTN_Level14.Enabled = false; BTN_Level14.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 14) { BTN_Level15.Enabled = true; BTN_Level15.Cursor = Cursors.Hand;}
            else { BTN_Level15.Enabled = false; BTN_Level15.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 15) { BTN_Level16.Enabled = true; BTN_Level16.Cursor = Cursors.Hand;}
            else { BTN_Level16.Enabled = false; BTN_Level16.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 16) { BTN_Level17.Enabled = true; BTN_Level17.Cursor = Cursors.Hand;}
            else { BTN_Level17.Enabled = false; BTN_Level17.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 17) { BTN_Level18.Enabled = true; BTN_Level18.Cursor = Cursors.Hand;}
            else { BTN_Level18.Enabled = false; BTN_Level18.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 18) { BTN_Level19.Enabled = true; BTN_Level19.Cursor = Cursors.Hand;}
            else { BTN_Level19.Enabled = false; BTN_Level19.Cursor = Cursors.Default;}
            if (GlobalVariables.LevelsUnlocked > 19) { BTN_Level20.Enabled = true; BTN_Level20.Cursor = Cursors.Hand;}
            else { BTN_Level20.Enabled = false; BTN_Level20.Cursor = Cursors.Default;}

            if (BTN_Level1.Enabled == true && GlobalVariables.LevelsUnlocked == 1) { BTN_Level1.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level1.ForeColor = Color.Black; }
            else if (BTN_Level1.Enabled == true) { BTN_Level1.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level1.ForeColor = Color.Black; }
            else { BTN_Level1.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level1.ForeColor = Color.Black; }
            if (BTN_Level2.Enabled == true && GlobalVariables.LevelsUnlocked == 2) { BTN_Level2.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level2.ForeColor = Color.Black; }
            else if (BTN_Level2.Enabled == true) { BTN_Level2.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level2.ForeColor = Color.Black; }
            else { BTN_Level2.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level2.ForeColor = Color.Black; }
            if (BTN_Level3.Enabled == true && GlobalVariables.LevelsUnlocked == 3) { BTN_Level3.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level3.ForeColor = Color.Black; }
            else if (BTN_Level3.Enabled == true) { BTN_Level3.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level3.ForeColor = Color.Black; }
            else { BTN_Level3.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level3.ForeColor = Color.Black; }
            if (BTN_Level4.Enabled == true && GlobalVariables.LevelsUnlocked == 4) { BTN_Level4.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level4.ForeColor = Color.Black; }
            else if (BTN_Level4.Enabled == true) { BTN_Level4.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level4.ForeColor = Color.Black; }
            else { BTN_Level4.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level4.ForeColor = Color.Black; }
            if (BTN_Level5.Enabled == true && GlobalVariables.LevelsUnlocked == 5) { BTN_Level5.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level5.ForeColor = Color.Black; }
            else if (BTN_Level5.Enabled == true) { BTN_Level5.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level5.ForeColor = Color.Black; }
            else { BTN_Level5.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level5.ForeColor = Color.Black; }
            if (BTN_Level6.Enabled == true && GlobalVariables.LevelsUnlocked == 6) { BTN_Level6.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level6.ForeColor = Color.Black; }
            else if (BTN_Level6.Enabled == true) { BTN_Level6.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level6.ForeColor = Color.Black; }
            else { BTN_Level6.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level6.ForeColor = Color.Black; }
            if (BTN_Level7.Enabled == true && GlobalVariables.LevelsUnlocked == 7) { BTN_Level7.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level7.ForeColor = Color.Black; }
            else if (BTN_Level7.Enabled == true) { BTN_Level7.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level7.ForeColor = Color.Black; }
            else { BTN_Level7.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level7.ForeColor = Color.Black; }
            if (BTN_Level8.Enabled == true && GlobalVariables.LevelsUnlocked == 8) { BTN_Level8.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level8.ForeColor = Color.Black; }
            else if (BTN_Level8.Enabled == true) { BTN_Level8.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level8.ForeColor = Color.Black; }
            else { BTN_Level8.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level8.ForeColor = Color.Black; }
            if (BTN_Level9.Enabled == true && GlobalVariables.LevelsUnlocked == 9) { BTN_Level9.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level9.ForeColor = Color.Black; }
            else if (BTN_Level9.Enabled == true) { BTN_Level9.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level9.ForeColor = Color.Black; }
            else { BTN_Level9.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level9.ForeColor = Color.Black; }
            if (BTN_Level10.Enabled == true && GlobalVariables.LevelsUnlocked == 10) { BTN_Level10.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level10.ForeColor = Color.Black; }
            else if (BTN_Level10.Enabled == true) { BTN_Level10.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level10.ForeColor = Color.Black; }
            else { BTN_Level10.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level10.ForeColor = Color.Black; }
            if (BTN_Level11.Enabled == true && GlobalVariables.LevelsUnlocked == 11) { BTN_Level11.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level11.ForeColor = Color.Black; }
            else if (BTN_Level11.Enabled == true) { BTN_Level11.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level11.ForeColor = Color.Black; }
            else { BTN_Level11.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level11.ForeColor = Color.Black; }
            if (BTN_Level12.Enabled == true && GlobalVariables.LevelsUnlocked == 12) { BTN_Level12.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level12.ForeColor = Color.Black; }
            else if (BTN_Level12.Enabled == true) { BTN_Level12.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level12.ForeColor = Color.Black; }
            else { BTN_Level12.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level12.ForeColor = Color.Black; }
            if (BTN_Level13.Enabled == true && GlobalVariables.LevelsUnlocked == 13) { BTN_Level13.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level13.ForeColor = Color.Black; }
            else if (BTN_Level13.Enabled == true) { BTN_Level13.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level13.ForeColor = Color.Black; }
            else { BTN_Level13.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level13.ForeColor = Color.Black; }
            if (BTN_Level14.Enabled == true && GlobalVariables.LevelsUnlocked == 14) { BTN_Level14.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level14.ForeColor = Color.Black; }
            else if (BTN_Level14.Enabled == true) { BTN_Level14.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level14.ForeColor = Color.Black; }
            else { BTN_Level14.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level14.ForeColor = Color.Black; }
            if (BTN_Level15.Enabled == true && GlobalVariables.LevelsUnlocked == 15) { BTN_Level15.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level15.ForeColor = Color.Black; }
            else if (BTN_Level15.Enabled == true) { BTN_Level15.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level15.ForeColor = Color.Black; }
            else { BTN_Level15.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level15.ForeColor = Color.Black; }
            if (BTN_Level16.Enabled == true && GlobalVariables.LevelsUnlocked == 16) { BTN_Level16.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level16.ForeColor = Color.Black; }
            else if (BTN_Level16.Enabled == true) { BTN_Level16.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level16.ForeColor = Color.Black; }
            else { BTN_Level16.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level16.ForeColor = Color.Black; }
            if (BTN_Level17.Enabled == true && GlobalVariables.LevelsUnlocked == 17) { BTN_Level17.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level17.ForeColor = Color.Black; }
            else if (BTN_Level17.Enabled == true) { BTN_Level17.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level17.ForeColor = Color.Black; }
            else { BTN_Level17.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level17.ForeColor = Color.Black; }
            if (BTN_Level18.Enabled == true && GlobalVariables.LevelsUnlocked == 18) { BTN_Level18.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level18.ForeColor = Color.Black; }
            else if (BTN_Level18.Enabled == true) { BTN_Level18.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level18.ForeColor = Color.Black; }
            else { BTN_Level18.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level18.ForeColor = Color.Black; }
            if (BTN_Level19.Enabled == true && GlobalVariables.LevelsUnlocked == 19) { BTN_Level19.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level19.ForeColor = Color.Black; }
            else if (BTN_Level19.Enabled == true) { BTN_Level19.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level19.ForeColor = Color.Black; }
            else { BTN_Level19.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level19.ForeColor = Color.Black; }
            if (BTN_Level20.Enabled == true && GlobalVariables.LevelsUnlocked == 20) { BTN_Level20.BackColor = Color.FromArgb(200, 3, 140, 252); BTN_Level20.ForeColor = Color.Black; }
            else if (BTN_Level20.Enabled == true) { BTN_Level20.BackColor = Color.FromArgb(200, 15, 186, 69); BTN_Level20.ForeColor = Color.Black; }
            else { BTN_Level20.BackColor = Color.FromArgb(100, 38, 38, 38); BTN_Level20.ForeColor = Color.Black; }
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
            BTN_Level1.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level1.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level2_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 2;
            BTN_Level2.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level2.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level3_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 3;
            BTN_Level3.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level3.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level4_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 4;
            BTN_Level4.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level4.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level5_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 5;
            BTN_Level5.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level5.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level6_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 6;
            BTN_Level6.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level6.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level7_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 7;
            BTN_Level7.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level7.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level8_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 8;
            BTN_Level8.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level8.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level9_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 9;
            BTN_Level9.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level9.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level10_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 10;
            BTN_Level10.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level10.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level11_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 11;
            BTN_Level11.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level11.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level12_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 12;
            BTN_Level12.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level12.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level13_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 13;
            BTN_Level13.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level13.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level14_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 14;
            BTN_Level14.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level14.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level15_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 15;
            BTN_Level15.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level15.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level16_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 16;
            BTN_Level16.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level16.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level17_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 17;
            BTN_Level17.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level17.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level18_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 18;
            BTN_Level18.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level18.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level19_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 19;
            BTN_Level19.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level19.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        private void BTN_Level20_Click(object sender, EventArgs e)
        {
            ResetButtonEnables();
            GlobalVariables.Level = 20;
            BTN_Level20.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level20.ForeColor = Color.White;
            RefreshLevelOverview();
        }

        public void RefreshLevelOverview()
        {
            LBL_Text.Text = "No level selected." + Environment.NewLine + Environment.NewLine + "Please select a level to fight.";

            if (GlobalVariables.Level != 0)
            {
                int Enemy_Strength = 0;
                int Enemy_Health = 0;
                string Boss = "none";
                string Boss_Level = "no";

                int[] SmallRange = new int[2];
                int[] BigRange = new int[2];
                int[] GlassRange = new int[2];
                int[] BottleRange = new int[2];

                foreach (Get_Level_Info i in GlobalVariables.Level_Info)
                {
                    if (i.Level == GlobalVariables.Level)
                    {
                        var Values1 = i.SmallRange.Split('-');
                        SmallRange[0] = int.Parse(Values1[0]);
                        SmallRange[1] = int.Parse(Values1[1]);

                        var Values2 = i.BigRange.Split('-');
                        BigRange[0] = int.Parse(Values2[0]);
                        BigRange[1] = int.Parse(Values2[1]);

                        var Values3 = i.GlassRange.Split('-');
                        GlassRange[0] = int.Parse(Values3[0]);
                        GlassRange[1] = int.Parse(Values3[1]);

                        var Values4 = i.BottleRange.Split('-');
                        BottleRange[0] = int.Parse(Values4[0]);
                        BottleRange[1] = int.Parse(Values4[1]);

                        Boss = i.Boss;
                        if (i.Boss != "" && i.Boss != "none") { Boss_Level = "yes"; }
                        else { Boss_Level = "no"; }
                    }
                }

                foreach (Get_EUnit_Info EUnit in GlobalVariables.EUnit_Info)
                {
                    if (EUnit.Name == "small")
                    {
                        Enemy_Strength = Enemy_Strength + (SmallRange[1] * EUnit.Damage);
                        Enemy_Health = Enemy_Health + (SmallRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == "big")
                    {
                        Enemy_Strength = Enemy_Strength + (BigRange[1] * EUnit.Damage);
                        Enemy_Health = Enemy_Health + (BigRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == "glass")
                    {
                        Enemy_Strength = Enemy_Strength + (GlassRange[1] * EUnit.Damage);
                        Enemy_Health = Enemy_Health + (GlassRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == "bottle")
                    {
                        Enemy_Strength = Enemy_Strength + (BottleRange[1] * EUnit.Damage);
                        Enemy_Health = Enemy_Health + (BottleRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == Boss)
                    {
                        Enemy_Strength = Enemy_Strength + EUnit.Damage;
                        Enemy_Health = Enemy_Health + EUnit.Health;
                    }
                }

                LBL_Text.Text = "Level:" + Environment.NewLine + GlobalVariables.Level.ToString() + Environment.NewLine + Environment.NewLine
                    + "Enemy Strength:" + Environment.NewLine + Enemy_Strength.ToString() + Environment.NewLine + Environment.NewLine
                    + "Enemy Health:" + Environment.NewLine + Enemy_Health.ToString() + Environment.NewLine + Environment.NewLine
                    + "Boss Level:" + Environment.NewLine + Boss_Level;
            }
        }
    }
}
