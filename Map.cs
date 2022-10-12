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
            // centers the level display and overview panels on the y axis
            PNL_LevelDisplay.Location = new Point(PNL_LevelDisplay.Location.X, (this.Height - PNL_LevelDisplay.Height) / 2);
            PNL_LevelOverview.Location = new Point(PNL_LevelOverview.Location.X, (this.Height - PNL_LevelOverview.Height) / 2);
            
            // calls on the reset level buttons method
            // this resets the properties (eg. cursor, enabled, back & fore colors) back to their default, non-selected values
            ResetLevelButtons();
        }

        // this method is in charge of reseting the properties
        // (eg. cursor, enabled, back & fore colors) back to their default, non-selected values
        public void ResetLevelButtons()
        {
            // goes through all of the buttons, and checks if the level they corrospond to has been unlocked,
            // if so, then enables them and changes their hover cursor to a hand.
            // otherwise, it dissables them and changes it's hover cursor back to the default
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

            // goes through each of the buttons, and if they are enabled (unlocked) changes their back (backgound) and fore (text & border) color appropriately
            // (if they are the newest level / not compleated yet, their back color is blue, otherwise their backcolor is green)
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

        // responsible for re-opening the army camp form if the player wants to go back
        private void BTN_Back_Click(object sender, EventArgs e)
        {
            // sets the appropriate global variable to army_camp, this is because the game form is responsible
            // for changing all the child forms, so a global variable is used to tell it what to open
            GlobalVariables.ChildToOpen = "army_camp";
        }

        // responsible for taking the player to the battleground form when they want to start the battle
        private void BTN_Fight_Click(object sender, EventArgs e)
        {
            // sets the appropriate global variable to battleground, this is because the game form is responsible
            // for changing all the child forms, so a global variable is used to tell it what to open
            GlobalVariables.ChildToOpen = "battleground";
        }

        // responsible for the selection of level 1
        private void BTN_Level1_Click(object sender, EventArgs e)
        {
            // when the player selects the level 1 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 1
            GlobalVariables.Level = 1;
            // changes the back and fore color of the button accrodingly
            BTN_Level1.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level1.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 2
        private void BTN_Level2_Click(object sender, EventArgs e)
        {
            // when the player selects the level 2 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 2
            GlobalVariables.Level = 2;
            // changes the back and fore color of the button accrodingly
            BTN_Level2.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level2.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 3
        private void BTN_Level3_Click(object sender, EventArgs e)
        {
            // when the player selects the level 3 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 3
            GlobalVariables.Level = 3;
            // changes the back and fore color of the button accrodingly
            BTN_Level3.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level3.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 4
        private void BTN_Level4_Click(object sender, EventArgs e)
        {
            // when the player selects the level 4 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 4
            GlobalVariables.Level = 4;
            // changes the back and fore color of the button accrodingly
            BTN_Level4.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level4.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 5
        
        
        
        

        private void BTN_Level5_Click(object sender, EventArgs e)
        {
            // when the player selects the level 5 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 5
            GlobalVariables.Level = 5;
            // changes the back and fore color of the button accrodingly
            BTN_Level5.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level5.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 6
        private void BTN_Level6_Click(object sender, EventArgs e)
        {
            // when the player selects the level 6 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 6
            GlobalVariables.Level = 6;
            // changes the back and fore color of the button accrodingly
            BTN_Level6.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level6.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 7
        private void BTN_Level7_Click(object sender, EventArgs e)
        {
            // when the player selects the level 7 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 7
            GlobalVariables.Level = 7;
            // changes the back and fore color of the button accrodingly
            BTN_Level7.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level7.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 8
        private void BTN_Level8_Click(object sender, EventArgs e)
        {
            // when the player selects the level 8 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 8
            GlobalVariables.Level = 8;
            // changes the back and fore color of the button accrodingly
            BTN_Level8.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level8.ForeColor = Color.White;
            RefreshLevelOverview();
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
        }

        // responsible for the selection of level 9
        private void BTN_Level9_Click(object sender, EventArgs e)
        {
            // when the player selects the level 9 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 9
            GlobalVariables.Level = 9;
            // changes the back and fore color of the button accrodingly
            BTN_Level9.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level9.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 10
        private void BTN_Level10_Click(object sender, EventArgs e)
        {
            // when the player selects the level 10 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 10
            GlobalVariables.Level = 10;
            // changes the back and fore color of the button accrodingly
            BTN_Level10.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level10.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 11
        private void BTN_Level11_Click(object sender, EventArgs e)
        {
            // when the player selects the level 11 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 11
            GlobalVariables.Level = 11;
            // changes the back and fore color of the button accrodingly
            BTN_Level11.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level11.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 12
        private void BTN_Level12_Click(object sender, EventArgs e)
        {
            // when the player selects the level 12 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 12
            GlobalVariables.Level = 12;
            // changes the back and fore color of the button accrodingly
            BTN_Level12.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level12.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 13
        private void BTN_Level13_Click(object sender, EventArgs e)
        {
            // when the player selects the level 13 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 13
            GlobalVariables.Level = 13;
            // changes the back and fore color of the button accrodingly
            BTN_Level13.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level13.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 14
        private void BTN_Level14_Click(object sender, EventArgs e)
        {
            // when the player selects the level 14 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 14
            GlobalVariables.Level = 14;
            // changes the back and fore color of the button accrodingly
            BTN_Level14.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level14.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 15
        private void BTN_Level15_Click(object sender, EventArgs e)
        {
            // when the player selects the level 15 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 15
            GlobalVariables.Level = 15;
            // changes the back and fore color of the button accrodingly
            BTN_Level15.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level15.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 16
        private void BTN_Level16_Click(object sender, EventArgs e)
        {
            // when the player selects the level 16 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 16
            GlobalVariables.Level = 16;
            // changes the back and fore color of the button accrodingly
            BTN_Level16.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level16.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 17
        private void BTN_Level17_Click(object sender, EventArgs e)
        {
            // when the player selects the level 17 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 17
            GlobalVariables.Level = 17;
            // changes the back and fore color of the button accrodingly
            BTN_Level17.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level17.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 18
        private void BTN_Level18_Click(object sender, EventArgs e)
        {
            // when the player selects the level 18 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 18
            GlobalVariables.Level = 18;
            // changes the back and fore color of the button accrodingly
            BTN_Level18.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level18.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 19
        private void BTN_Level19_Click(object sender, EventArgs e)
        {
            // when the player selects the level 19 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 19
            GlobalVariables.Level = 19;
            // changes the back and fore color of the button accrodingly
            BTN_Level19.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level19.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // responsible for the selection of level 20
        private void BTN_Level20_Click(object sender, EventArgs e)
        {
            // when the player selects the level 20 option by clicking it
            // resets all the buttons back to default
            ResetLevelButtons();
            // sets the currently selected level to 20
            GlobalVariables.Level = 20;
            // changes the back and fore color of the button accrodingly
            BTN_Level20.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Level20.ForeColor = Color.White;
            // calls on the RefreshLevelOverview to update the levels overview panel,
            // this gives a summary of what to expect in the level
            RefreshLevelOverview();
        }

        // when this method is called on, it updates the level overview panel to
        // show a summery of the currently selected level
        public void RefreshLevelOverview()
        {
            // by default the main text label says no level selected
            LBL_Text.Text = "No level selected." + Environment.NewLine + Environment.NewLine + "Please select a level to fight.";

            // checks if a level is selected
            if (GlobalVariables.Level != 0)
            {
                // if there is a level selected,
                // declares variables/arrays used throughout to create a summery of
                // the level's dificulty and gives them default values
                int Enemy_Strength = 0;
                int Enemy_Health = 0;
                string Boss = "none";
                string Boss_Level = "no";
                int[] SmallRange = new int[2];
                int[] BigRange = new int[2];
                int[] GlassRange = new int[2];
                int[] BottleRange = new int[2];

                // goes through all the level settings in the global level info list
                foreach (Get_Level_Info i in GlobalVariables.Level_Info)
                {
                    // finds the currently selected level
                    if (i.Level == GlobalVariables.Level)
                    {
                        // gets the range of small units that can spawn, and splits the
                        // single string into 2 ints for the max/min range
                        var Values1 = i.SmallRange.Split('-');
                        SmallRange[0] = int.Parse(Values1[0]);
                        SmallRange[1] = int.Parse(Values1[1]);

                        // gets the range of big units that can spawn, and splits the
                        // single string into 2 ints for the max/min range
                        var Values2 = i.BigRange.Split('-');
                        BigRange[0] = int.Parse(Values2[0]);
                        BigRange[1] = int.Parse(Values2[1]);

                        // gets the range of glass units that can spawn, and splits the
                        // single string into 2 ints for the max/min range
                        var Values3 = i.GlassRange.Split('-');
                        GlassRange[0] = int.Parse(Values3[0]);
                        GlassRange[1] = int.Parse(Values3[1]);

                        // gets the range of bottle units that can spawn, and splits the
                        // single string into 2 ints for the max/min range
                        var Values4 = i.BottleRange.Split('-');
                        BottleRange[0] = int.Parse(Values4[0]);
                        BottleRange[1] = int.Parse(Values4[1]);

                        // gets the levels bosses name (string will come out as none if there is no boss)
                        Boss = i.Boss;

                        // checks if there is a boss, if so then sets boss level to yes, otherwise sets boss level to no
                        if (i.Boss != "" && i.Boss != "none") { Boss_Level = "yes"; }
                        else { Boss_Level = "no"; }
                    }
                }

                // goes thrugh all the enemy unit info in the global EUnit_Info list 
                foreach (Get_EUnit_Info EUnit in GlobalVariables.EUnit_Info)
                {
                    // finds the levels total strength and health for each unit type
                    // finds out what unit it's looking at
                    if (EUnit.Name == "small")
                    {
                        // if it's a small unit
                        // adds the small units damage times the max ammount of small units that can spawn in the level to the total enemy strength int
                        Enemy_Strength = Enemy_Strength + (SmallRange[1] * EUnit.Damage);
                        // adds the small units health times the max ammount of small units that can spawn in the level to the total enemy heath int
                        Enemy_Health = Enemy_Health + (SmallRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == "big")
                    {
                        // if it's a big unit
                        // adds the big units damage times the max ammount of big units that can spawn in the level to the total enemy strength int
                        Enemy_Strength = Enemy_Strength + (BigRange[1] * EUnit.Damage);
                        // adds the big units health times the max ammount of big units that can spawn in the level to the total enemy heath int
                        Enemy_Health = Enemy_Health + (BigRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == "glass")
                    {
                        // if it's a glass unit
                        // adds the glass units damage times the max ammount of glass units that can spawn in the level to the total enemy strength int
                        Enemy_Strength = Enemy_Strength + (GlassRange[1] * EUnit.Damage);
                        // adds the glass units health times the max ammount of glass units that can spawn in the level to the total enemy heath int
                        Enemy_Health = Enemy_Health + (GlassRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == "bottle")
                    {
                        // if it's a bottle unit
                        // adds the bottle units damage times the max ammount of bottle units that can spawn in the level to the total enemy strength int
                        Enemy_Strength = Enemy_Strength + (BottleRange[1] * EUnit.Damage);
                        // adds the bottle units health times the max ammount of bottle units that can spawn in the level to the total enemy heath int
                        Enemy_Health = Enemy_Health + (BottleRange[1] * EUnit.Health);
                    }
                    else if (EUnit.Name == Boss)
                    {
                        // if it's the correctly names boss unit for the level
                        // adds the boss units damage to the total enemy strength int
                        Enemy_Strength = Enemy_Strength + EUnit.Damage;
                        // adds the boss units health to the total enemy heath int
                        Enemy_Health = Enemy_Health + EUnit.Health;
                    }
                }

                // updates the main text label to list the currently selected level, total enemy strength, total enemy health, and wether it's a boss level or not
                LBL_Text.Text = "Level:" + Environment.NewLine + GlobalVariables.Level.ToString() + Environment.NewLine + Environment.NewLine
                    + "Enemy Strength:" + Environment.NewLine + Enemy_Strength.ToString() + Environment.NewLine + Environment.NewLine
                    + "Enemy Health:" + Environment.NewLine + Enemy_Health.ToString() + Environment.NewLine + Environment.NewLine
                    + "Boss Level:" + Environment.NewLine + Boss_Level;
            }
        }
    }
}
