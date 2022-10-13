using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class ShopWindow_UpgradeUnits : Form
    {
        //--------------------------------------------//
        // Declares public variables used in the form //
        //--------------------------------------------//
        string CurrentUnitName; // used to tell what the name of the currently selected / showing unit is
        string CurrentUnitType; // used to tell what the type of the currently selected / showing unit is
        bool CurrentUnitUnlocked; // used to tell whether the currently selected / showing unit is unlocked
        int CurrentUnitLevel; // used to tell the level of the currently selected / showing unit
        int Cost; // used to tell the upgrade / unlock cost of the currently selected / showing unit

        public ShopWindow_UpgradeUnits()
        {
            InitializeComponent();

            // sets the display panel to be doublebuffered
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Display, new object[] { true });
        }

        private void ShopWindow_UpgradeUnits_Load(object sender, EventArgs e)
        {
            // sets the size and loctions of each of the group boxes
            GB_UnlockUnit.Size = new Size(677, 388);
            GB_UnlockUnit.Location = new Point((PNL_Display.Width - GB_UnlockUnit.Width) / 2, (PNL_Display.Height - GB_UnlockUnit.Height) / 2);
            GB_UpgradeUnit.Size = new Size(677, 388);
            GB_UpgradeUnit.Location = new Point((PNL_Display.Width - GB_UpgradeUnit.Width) / 2, (PNL_Display.Height - GB_UpgradeUnit.Height) / 2);
            GB_FinalUnit.Size = new Size(677, 388);
            GB_FinalUnit.Location = new Point((PNL_Display.Width - GB_FinalUnit.Width) / 2, (PNL_Display.Height - GB_FinalUnit.Height) / 2);

            //sets the currently seelcted / showing unit type to basic
            CurrentUnitType = "basic";

            // calls on the update display method
            // this refreshes the displays in the group boxes to suit the currently selected / showing unit
            DisplayUpdate();
        }

        // this method is in charge of refreshing / updating the group boxes to suit the currently selected / showing unit
        public void DisplayUpdate()
        {
            // checks what type of unit is selected / showing nd finds the info needed regarding the unit
            if (CurrentUnitType == "giant")
            {
                // if the unit type showing / selected is a giant, then using the units level set the current name
                if (GlobalVariables.UnitUpgrades_Giant == 2) { CurrentUnitName = "buff"; }
                else if (GlobalVariables.UnitUpgrades_Giant == 1) { CurrentUnitName = "tall"; }
                else { CurrentUnitName = "stacked"; }

                // sets wether the unit type is unlocked or not
                CurrentUnitUnlocked = GlobalVariables.GiantUnitUnlocked;
                // gets the current unit level
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Giant;
            }
            else if (CurrentUnitType == "gun")
            {
                // if the unit type showing / selected is a gun, then using the units level set the current name
                if (GlobalVariables.UnitUpgrades_Gun == 2) { CurrentUnitName = "sniper"; }
                else if (GlobalVariables.UnitUpgrades_Gun == 1) { CurrentUnitName = "gunner"; }
                else { CurrentUnitName = "agent"; }

                // sets wether the unit type is unlocked or not
                CurrentUnitUnlocked = GlobalVariables.GunUnitUnlocked;
                // gets the current unit level
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Gun;
            }
            else if (CurrentUnitType == "magic")
            {
                // if the unit type showing / selected is a magic, then using the units level set the current name
                if (GlobalVariables.UnitUpgrades_Magic == 2) { CurrentUnitName = "sorcerer"; }
                else if (GlobalVariables.UnitUpgrades_Magic == 1) { CurrentUnitName = "wizard"; }
                else { CurrentUnitName = "magician"; }

                // sets wether the unit type is unlocked or not
                CurrentUnitUnlocked = GlobalVariables.MagicUnitUnlocked;
                // gets the current unit level
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Magic;
            }
            else if (CurrentUnitType == "range")
            {
                // if the unit type showing / selected is a range, then using the units level set the current name
                if (GlobalVariables.UnitUpgrades_Range == 2) { CurrentUnitName = "cannon"; }
                else if (GlobalVariables.UnitUpgrades_Range == 1) { CurrentUnitName = "catapult"; }
                else { CurrentUnitName = "archer"; }

                // sets wether the unit type is unlocked or not
                CurrentUnitUnlocked = GlobalVariables.RangeUnitUnlocked;
                // gets the current unit level
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Range;
            }
            else
            {
                // otherwise the unit type showing / selected is a basic, so using the units level set the current name
                if (GlobalVariables.UnitUpgrades_Basic == 2) { CurrentUnitName = "axe"; }
                else if (GlobalVariables.UnitUpgrades_Basic == 1) { CurrentUnitName = "sword"; }
                else { CurrentUnitName = "spear"; }

                // sets wether the unit type is unlocked or not
                CurrentUnitUnlocked = GlobalVariables.BasicUnitUnlocked;
                // gets the current unit level
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Basic;
            }

            // calls on the correct method depending on what stage of unlock/upgrade the unit is at
            // checks wether the unit has been unlocked
            if (CurrentUnitUnlocked == true)
            {
                // if it has, then checks wether the unit is max level
                if (CurrentUnitLevel == 2) { DisplayFinal(); } // the unit is max level, call on the display final method
                else { DisplayUpgrades(); } // the unit is unlocked, but not max level, call on the diaplay upgrade method
            }
            else { DisplayUnlock(); } // the unit isn't unlocked, call on the display unlock method
        }

        // this method shows the group box that correctly displays the unlock design
        public void DisplayUnlock()
        {
            // hides all but the unlock group box
            GB_UnlockUnit.Visible = true;
            GB_UpgradeUnit.Visible = false;
            GB_FinalUnit.Visible = false;

            // sets the title of the group box to include the unit type selected
            GB_UnlockUnit.Text = "Unlock - " + CurrentUnitType + " unit";

            // gets the correct image for the currently showing / selected unit type
            if (CurrentUnitType == "giant") { PIC_UnlockUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant]; }
            else if (CurrentUnitType == "gun") { PIC_UnlockUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun]; }
            else if (CurrentUnitType == "magic") { PIC_UnlockUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic]; }
            else if (CurrentUnitType == "range") { PIC_UnlockUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range]; }
            else { PIC_UnlockUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic]; }

            // gets all the units infomation and sets the correct lables to the values
            // goes through items in the global unit info list
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // finds the name of the currently showing / selected unit
                if (i.Name == CurrentUnitName)
                {
                    // sets the corresponding labels to the health, damage, attack speed, and range values
                    lbl_UnlockUnit_Health.Text = i.Health.ToString();
                    lbl_UnlockUnit_Damage.Text = i.Damage.ToString();
                    lbl_UnlockUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_UnlockUnit_Range.Text = i.Range;
                    // gets the cost to purchase the unit and multiplies it by 10 to get the unlock price
                    Cost = i.Cost * 10;

                    // changes the unlock buttons text to display the cost to unlock
                    BTN_Unlock.Text = "Unlock (" + Cost + " coins)";

                    // changes the abilities label to coming soon
                    lbl_UnlockAbilities.Text = "Coming Soon!";
                }
            }
        }

        // this method shows the group box that correctly displays the upgrade design
        public void DisplayUpgrades()
        {
            // hides all but the ugrade group box
            GB_UpgradeUnit.Visible = true;
            GB_UnlockUnit.Visible = false;
            GB_FinalUnit.Visible = false;

            // changes the title of the group box to show the unit type
            GB_UpgradeUnit.Text = "Upgrade - " + CurrentUnitType + " unit";

            // gets and sets the correct image for the current level selected / showing unit
            if (CurrentUnitType == "giant") { PIC_UpgradeUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant]; }
            else if (CurrentUnitType == "gun") { PIC_UpgradeUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun]; }
            else if (CurrentUnitType == "magic") { PIC_UpgradeUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic]; }
            else if (CurrentUnitType == "range") { PIC_UpgradeUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range]; }
            else { PIC_UpgradeUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic]; }

            // gets and sets the image of the next level of the current selected / showing unit
            if (CurrentUnitType == "giant") { PIC_UpgradeUnit2.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant + 1]; }
            else if (CurrentUnitType == "gun") { PIC_UpgradeUnit2.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun + 1]; }
            else if (CurrentUnitType == "magic") { PIC_UpgradeUnit2.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic + 1]; }
            else if (CurrentUnitType == "range") { PIC_UpgradeUnit2.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range + 1]; }
            else { PIC_UpgradeUnit2.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic + 1]; }

            string NextName = ""; // declares a variable used for getting the name of the next level of the selected / showing unit
            // finds the currently selected / showing units name and sets the next name to the value 1 down in the name list
            if (CurrentUnitName == "spear") { NextName = "sword"; }
            else if (CurrentUnitName == "sword") { NextName = "axe"; }
            else if (CurrentUnitName == "archer") { NextName = "catapult"; }
            else if (CurrentUnitName == "catapult") { NextName = "cannon"; }
            else if (CurrentUnitName == "magician") { NextName = "wizard"; }
            else if (CurrentUnitName == "wizard") { NextName = "sorcerer"; }
            else if (CurrentUnitName == "agent") { NextName = "gunner"; }
            else if (CurrentUnitName == "gunner") { NextName = "sniper"; }
            else if (CurrentUnitName == "stacked") { NextName = "tall"; }
            else if (CurrentUnitName == "tall") { NextName = "buff"; }

            // goes through all the units info in the global unit info list
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // checks if the name is either  the current or next unit name
                if (i.Name == CurrentUnitName)
                {
                    // if the name is the current selected / showing name,
                    // sets the corresponding labels to the health, damage, attack speed, and range values
                    lbl_UpgradeUnit_Health.Text = i.Health.ToString();
                    lbl_UpgradeUnit_Damage.Text = i.Damage.ToString();
                    lbl_UpgradeUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_UpgradeUnit_Range.Text = i.Range;

                    // sets the text for the abilities label to coming soon
                    lbl_UpgradeUnit_Abilities.Text = "Coming Soon!";
                }
                else if (i.Name == NextName)
                {
                    // otherwise if the name is the next unit name,
                    // sets the corresponding labels to the health, damage, attack speed, and range values
                    lbl_UpgradeUnit2_Health.Text = i.Health.ToString();
                    lbl_UpgradeUnit2_Damage.Text = i.Damage.ToString();
                    lbl_UpgradeUnit2_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_UpgradeUnit2_Range.Text = i.Range;

                    // gets the cost to purchase the unit and multiplies it by 15 to get the upgrade price
                    Cost = i.Cost * 15;
                    BTN_Upgrade.Text = "Upgrade (" + Cost + " coins)";

                    // sets the text for the abilities label to coming soon
                    lbl_UpgradeUnit2_Abilities.Text = "Coming Soon!";
                }
            }
        }

        // this method shows the group box that correctly displays the final unit level design
        public void DisplayFinal()
        {
            // hides all but the final unit group bob
            GB_FinalUnit.Visible = true;
            GB_UpgradeUnit.Visible = false;
            GB_UnlockUnit.Visible = false;

            // chabges the title of the group box to include the currently selected / showing unit type
            GB_FinalUnit.Text = "Upgrade - " + CurrentUnitType + " unit";

            // gets the correct picture for the final upgraded unit that is selected / showing
            if (CurrentUnitType == "giant") { PIC_FinalUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant]; }
            else if (CurrentUnitType == "gun") { PIC_FinalUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun]; }
            else if (CurrentUnitType == "magic") { PIC_FinalUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic]; }
            else if (CurrentUnitType == "range") { PIC_FinalUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range]; }
            else { PIC_FinalUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic]; }

            // goes through all the unit info in the global unit info list
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // finds the name of the currently selected / showing unit
                if (i.Name == CurrentUnitName)
                {
                    // sets the corresponding labels to the health, damage, attack speed, and range values
                    lbl_FinalUnit_Health.Text = i.Health.ToString();
                    lbl_FinalUnit_Damage.Text = i.Damage.ToString();
                    lbl_FinalUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_FinalUnit_Range.Text = i.Range;

                    // changes the text of the abilities label to coming soon
                    lbl_FinalUnit_Abilities.Text = "Coming Soon!";
                }
            }
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            // scrolls through each of the unit type options in order
            if (CurrentUnitType == "basic") { CurrentUnitType = "range"; }
            else if (CurrentUnitType == "range") { CurrentUnitType = "magic"; }
            else if (CurrentUnitType == "magic") { CurrentUnitType = "gun"; }
            else if (CurrentUnitType == "gun") { CurrentUnitType = "giant"; }
            else if (CurrentUnitType == "giant") { CurrentUnitType = "basic"; }

            // calls on the display update method to update the group boxes after the change
            DisplayUpdate();
        }

        private void BTN_Previous_Click(object sender, EventArgs e)
        {
            // scrolls through each of the unit type options in the opposie order
            if (CurrentUnitType == "basic") { CurrentUnitType = "giant"; }
            else if (CurrentUnitType == "range") { CurrentUnitType = "basic"; }
            else if (CurrentUnitType == "magic") { CurrentUnitType = "range"; }
            else if (CurrentUnitType == "gun") { CurrentUnitType = "magic"; }
            else if (CurrentUnitType == "giant") { CurrentUnitType = "gun"; }

            // calls on the display update method to update the group boxes after the change
            DisplayUpdate();
        }

        private void BTN_Upgrade_Click(object sender, EventArgs e)
        {
            // when the player wants to upgrade a unit
            // checks if they have enough coins
            if (GlobalVariables.Coins >= Cost)
            {
                // if they do, takes away the cost
                GlobalVariables.Coins = GlobalVariables.Coins - Cost;

                // finds what unit type is currently selected / showing, and adds 1 to that units level
                if (CurrentUnitType == "basic") { GlobalVariables.UnitUpgrades_Basic++; }
                else if (CurrentUnitType == "range") { GlobalVariables.UnitUpgrades_Range++; }
                else if (CurrentUnitType == "magic") { GlobalVariables.UnitUpgrades_Magic++; }
                else if (CurrentUnitType == "gun") { GlobalVariables.UnitUpgrades_Gun++; }
                else if (CurrentUnitType == "giant") { GlobalVariables.UnitUpgrades_Giant++; }

                // shows a message box that confirms the players purchase
                MessageBox.Show("You have now upgraded your " + CurrentUnitType + " ducks, thank you for wasting " + Cost + " of your coins on this purchase.", "Purchase Successful");

                // calls on the display update method to update the group boxes after the change
                DisplayUpdate();
            }
            else
            {
                // otherwise, if they don't have enough coins,
                // shows a message that tells them they can't afford the upgrade
                MessageBox.Show("Sorry, you do not have enough coins to upgrade this item", "Insufficient funds");
            }
        }

        private void BTN_Unlock_Click(object sender, EventArgs e)
        {
            // when the player wants to unlock a unit
            // checks if they can afford it
            if (GlobalVariables.Coins >= Cost)
            {
                // if they can, takes away the cost
                GlobalVariables.Coins = GlobalVariables.Coins - Cost;

                // finds what unit type is currently showing / selected and sets the unlocked value to true
                if (CurrentUnitType == "basic") { GlobalVariables.BasicUnitUnlocked = true; }
                else if (CurrentUnitType == "range") { GlobalVariables.RangeUnitUnlocked = true; }
                else if (CurrentUnitType == "magic") { GlobalVariables.MagicUnitUnlocked = true; }
                else if (CurrentUnitType == "gun") { GlobalVariables.GunUnitUnlocked = true; }
                else if (CurrentUnitType == "giant") { GlobalVariables.GiantUnitUnlocked = true; }

                // shows a message box that confirms the purchase
                MessageBox.Show("You have now unlocked " + CurrentUnitType + " ducks, thank you for wasting " + Cost + " of your coins on this purchase.", "Purchase Successful");

                // calls on the display update method to update the group boxes after the change
                DisplayUpdate();
            }
            else
            {
                // otherwise they don't have enough coins
                // shows a message box that tells them that thet can't afford the unlock
                MessageBox.Show("Sorry, you do not have enough coins to unlock this item", "Insufficient funds");
            }
        }
    }
}
