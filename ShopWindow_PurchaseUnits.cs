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
    public partial class ShopWindow_PurchaseUnits : Form
    {
        //--------------------------------------------//
        // Declares public variables used in the form //
        //--------------------------------------------//
        int BasicUnit_Cost, RangeUnit_Cost, MagicUnit_Cost, GunUnit_Cost, GiantUnit_Cost; // used to keep the costs of each unti
        string BasicUnit_Name, RangeUnit_Name, MagicUnit_Name, GunUnit_Name, GiantUnit_Name; // used to keep the name of each units type (this is affected by the types level)
        string currently_selected = "basic"; // used to keep the current unit purchase option at the top of the list

        public ShopWindow_PurchaseUnits()
        {
            InitializeComponent();

            // sets the unit display panel to be doublebuffered
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_UnitDisplay, new object[] { true });
        }

        private void ShopWindow_PurchaseUnits_Load(object sender, EventArgs e)
        {
            // declares ints used for setting the size and location of the group boxes
            int location_x = 5;
            int location_y = (PNL_UnitDisplay.Height - 182) / 2;
            int size_width = 677;
            int size_height = 182;

            // sets the size and locations of the group boxes using the ints above
            GB_BasicUnit.Size = new Size(677, 182);
            GB_BasicUnit.Location = new Point(location_x, location_y);
            GB_RangeUnit.Size = new Size(size_width, size_height);
            GB_RangeUnit.Location = new Point(location_x, location_y);
            GB_MagicUnit.Size = new Size(size_width, size_height);
            GB_MagicUnit.Location = new Point(location_x, location_y);
            GB_GunUnit.Size = new Size(size_width, size_height);
            GB_GunUnit.Location = new Point(location_x, location_y);
            GB_GiantUnit.Size = new Size(size_width, size_height);
            GB_GiantUnit.Location = new Point(location_x, location_y);

            // dissables the group boxes of unit types that havent been unlocked
            if (GlobalVariables.BasicUnitUnlocked == false) { GB_BasicUnit.Enabled = false; }
            if (GlobalVariables.RangeUnitUnlocked == false) { GB_RangeUnit.Enabled = false; }
            if (GlobalVariables.MagicUnitUnlocked == false) { GB_MagicUnit.Enabled = false; }
            if (GlobalVariables.GunUnitUnlocked == false) { GB_GunUnit.Enabled = false; }
            if (GlobalVariables.GiantUnitUnlocked == false) { GB_GiantUnit.Enabled = false; }

            // sets the images in each unit type's picture boxes (the image used is affected by the level of the unit type)
            PIC_BasicUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic];
            PIC_RangeUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range];
            PIC_MagicUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic];
            PIC_GunUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun];
            PIC_GiantUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant];

            // sets the name of the basic unit and title of the group box depending on the level of the basic units
            if (GlobalVariables.UnitUpgrades_Basic == 2) { BasicUnit_Name = "axe"; GB_BasicUnit.Text = "Basic Unit - Axe Duck"; }
            else if (GlobalVariables.UnitUpgrades_Basic == 1) { BasicUnit_Name = "sword"; GB_BasicUnit.Text = "Basic Unit - Sword Duck"; }
            else { BasicUnit_Name = "spear"; GB_BasicUnit.Text = "Basic Unit - Spear Duck"; }

            // sets the name of the range unit and title of the group box depending on the level of the range units
            if (GlobalVariables.UnitUpgrades_Range == 2) { RangeUnit_Name = "cannon"; GB_RangeUnit.Text = "Range Unit - Cannon Duck"; }
            else if (GlobalVariables.UnitUpgrades_Range == 1) { RangeUnit_Name = "catapult"; GB_RangeUnit.Text = "Range Unit - Catapult Duck"; }
            else { RangeUnit_Name = "archer"; GB_RangeUnit.Text = "Range Unit - Archer Duck"; }

            // sets the name of the magic unit and title of the group box depending on the level of the magic units
            if (GlobalVariables.UnitUpgrades_Magic == 2) { MagicUnit_Name = "sorcerer"; GB_MagicUnit.Text = "Magic Unit - Sorcerer Duck"; }
            else if (GlobalVariables.UnitUpgrades_Magic == 1) { MagicUnit_Name = "wizard"; GB_MagicUnit.Text = "Magic Unit - Wizard Duck"; }
            else { MagicUnit_Name = "magician"; GB_MagicUnit.Text = "Magic Unit - Magician Duck"; }

            // sets the name of the gun unit and title of the group box depending on the level of the gun units
            if (GlobalVariables.UnitUpgrades_Gun == 2) { GunUnit_Name = "sniper"; GB_GunUnit.Text = "Gun Unit - Sniper Duck"; }
            else if (GlobalVariables.UnitUpgrades_Gun == 1) { GunUnit_Name = "gunner"; GB_GunUnit.Text = "Gun Unit - Gunner Duck"; }
            else { GunUnit_Name = "agent"; GB_GunUnit.Text = "Gun Unit - Agent Duck"; }

            // sets the name of the giant unit and title of the group box depending on the level of the giant units
            if (GlobalVariables.UnitUpgrades_Giant == 2) { GiantUnit_Name = "buff"; GB_GiantUnit.Text = "Giant Unit - Buff Duck"; }
            else if (GlobalVariables.UnitUpgrades_Giant == 1) { GiantUnit_Name = "tall"; GB_GiantUnit.Text = "Giant Unit - Tall Duck"; }
            else { GiantUnit_Name = "stacked"; GB_GiantUnit.Text = "Giant Unit - Stacked Duck"; }

            // goes through and gets all the unit information to display in the group boxes
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // finds the basic units name
                if (i.Name == BasicUnit_Name)
                {
                    // sets the health, damage, attack speed, & range labels to the correct values of the unit
                    lbl_BasicUnit_Health.Text = i.Health.ToString();
                    lbl_BasicUnit_Damage.Text = i.Damage.ToString();
                    lbl_BasicUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_BasicUnit_Range.Text = i.Range;
                    // gets and stores the units cost
                    BasicUnit_Cost = i.Cost;
                    // changes the purchase buttons text display the correct costs
                    BTN_BasicUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_BasicUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    // changes the abilities labels text to coming soon
                    lbl_BasicAbilities.Text = "Coming soon!";                
                }

                // finds the range units name
                if (i.Name == RangeUnit_Name)
                {
                    // sets the health, damage, attack speed, & range labels to the correct values of the unit
                    lbl_RangeUnit_Health.Text = i.Health.ToString();
                    lbl_RangeUnit_Damage.Text = i.Damage.ToString();
                    lbl_RangeUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_RangeUnit_Range.Text = i.Range;
                    // gets and stores the units cost
                    RangeUnit_Cost = i.Cost;
                    // changes the purchase buttons text to display the correct costs
                    BTN_RangeUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_RangeUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    // changes the abilities labels text to coming soon
                    lbl_RangeUnit_Abilities.Text = "Coming soon!";
                }

                // finds the magic units name
                if (i.Name == MagicUnit_Name)
                {
                    // sets the health, damage, attack speed, & range labels to the correct values of the unit
                    lbl_MagicUnit_Health.Text = i.Health.ToString();
                    lbl_MagicUnit_Damage.Text = i.Damage.ToString();
                    lbl_MagicUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_MagicUnit_Range.Text = i.Range;
                    // gets and stores the units cost
                    MagicUnit_Cost = i.Cost;
                    // changes the purchase buttons text to display the corrrext costs
                    BTN_MagicUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_MagicUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    // changes the abilities labels text to coming soon
                    lbl_MagicUnit_Abilities.Text = "Coming soon!";
                }

                // finds the gun units name
                if (i.Name == GunUnit_Name)
                {
                    // sets the health, damage, attack speed, & range labels to the correct values of the unit
                    lbl_GunUnit_Health.Text = i.Health.ToString();
                    lbl_GunUnit_Damage.Text = i.Damage.ToString();
                    lbl_GunUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_GunUnit_Range.Text = i.Range;
                    // gets and stores the units cost
                    GunUnit_Cost = i.Cost;
                    // changes the purchase buttons text to diaplay the correct costs
                    BTN_GunUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_GunUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    // changes the abilities labels text to coming soon
                    lbl_GunUnit_Abilities.Text = "Coming soon!";
                }

                // finds the giant units name
                if (i.Name == GiantUnit_Name)
                {
                    // sets the health, damage, attack speed, & range labels to the correct values of the unit
                    lbl_GiantUnit_Health.Text = i.Health.ToString();
                    lbl_GiantUnit_Damage.Text = i.Damage.ToString();
                    lbl_GiantUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_GiantUnit_Range.Text = i.Range;
                    // gets and stores the units cost
                    GiantUnit_Cost = i.Cost;
                    // changes the purchase buttons text to display the correct costs
                    BTN_GiantUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_GiantUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    // changes the abilities labels text to coming soon
                    lbl_GiantUnit_Abilities.Text = "Coming soon!";
                }
            }

            // calls on the update display method
            // this is in charge of showing the correct group boxes to the player
            UpdateDisplay();
        }

        private void BTN_BasicUnit_Purchase1_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 1 of the basic units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= BasicUnit_Cost)
            {
                // if they do, then takes away the cost of te unit
                GlobalVariables.Coins = GlobalVariables.Coins - BasicUnit_Cost;
                // gives them 1 basic unit
                GlobalVariables.BasicUnit_Count++;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 1 " + BasicUnit_Name + " duck, thank you for wasting " + BasicUnit_Cost +" of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + BasicUnit_Name + " ducks's is now " + GlobalVariables.BasicUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_BasicUnit_Purchase10_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 10 of the basic units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= (BasicUnit_Cost * 10))
            {
                // if they do, then takes away the cost of 10 of the units
                GlobalVariables.Coins = GlobalVariables.Coins - (BasicUnit_Cost * 10);
                // gives them 10 basic units
                GlobalVariables.BasicUnit_Count = GlobalVariables.BasicUnit_Count + 10;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 10 " + BasicUnit_Name + " ducks, thank you for wasting " + (BasicUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + BasicUnit_Name + " ducks's is now " + GlobalVariables.BasicUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            // in charge of allowing the player to scroll forward (in sets of 2) through all the units
            // checks what unit is currently at the top, and moves down 2 in the order
            if (currently_selected == "basic") { currently_selected = "magic"; }
            else if (currently_selected == "range") { currently_selected = "gun"; }
            else if (currently_selected == "magic") { currently_selected = "giant"; }
            else if (currently_selected == "gun") { currently_selected = "basic"; }
            else if (currently_selected == "giant") { currently_selected = "range"; }

            // calls on the updae display method to refresh what is showing
            UpdateDisplay();
        }

        private void BTN_Previous_Click(object sender, EventArgs e)
        {
            // in charge of allowing the player to scroll backwards (in sets of 2) through all the units
            // checks what unit is currently at the top, and moves up 2 in the order
            if (currently_selected == "basic") { currently_selected = "gun"; }
            else if (currently_selected == "range") { currently_selected = "giant"; }
            else if (currently_selected == "magic") { currently_selected = "basic"; }
            else if (currently_selected == "gun") { currently_selected = "range"; }
            else if (currently_selected == "giant") { currently_selected = "magic"; }

            // calls on the updae display method to refresh what is showing
            UpdateDisplay();
        }

        // this method refreshec what group boxs are showing and what arn'y according to the currently selected string
        public void UpdateDisplay()
        {
            // checks what unit type is supposed to be at the top of the list
            if (currently_selected == "basic")
            {
                // if it's basic, then hides all but the basic and range group boxes
                GB_BasicUnit.Visible = true;
                GB_RangeUnit.Visible = true;
                GB_MagicUnit.Visible = false;
                GB_GunUnit.Visible = false;
                GB_GiantUnit.Visible = false;

                //sets the spacing between the 2 group boxes
                int spacing = (PNL_UnitDisplay.Height - (GB_BasicUnit.Height * 2)) / 3;
                // changes the group boxes location accordingly
                GB_BasicUnit.Location = new Point(5, spacing);
                GB_RangeUnit.Location = new Point(5, GB_BasicUnit.Location.Y + GB_BasicUnit.Height + spacing);
            }
            else if (currently_selected == "range")
            {
                // if it's range, then hides all but the range and magic group boxes
                GB_BasicUnit.Visible = false;
                GB_RangeUnit.Visible = true;
                GB_MagicUnit.Visible = true;
                GB_GunUnit.Visible = false;
                GB_GiantUnit.Visible = false;

                // sets the spacing between the 2 group boxes
                int spacing = (PNL_UnitDisplay.Height - (GB_RangeUnit.Height * 2)) / 3;
                // changes the group boxes location accordingly
                GB_RangeUnit.Location = new Point(5, spacing);
                GB_MagicUnit.Location = new Point(5, GB_RangeUnit.Location.Y + GB_RangeUnit.Height + spacing);
            }
            else if (currently_selected == "magic")
            {
                // if it's magic at the top, then hides all but the magic and gun unit group boxes
                GB_BasicUnit.Visible = false;
                GB_RangeUnit.Visible = false;
                GB_MagicUnit.Visible = true;
                GB_GunUnit.Visible = true;
                GB_GiantUnit.Visible = false;

                // sets the spacing between the group boxes
                int spacing = (PNL_UnitDisplay.Height - (GB_MagicUnit.Height * 2)) / 3;
                // changes the group boxes location accordingly
                GB_MagicUnit.Location = new Point(5, spacing);
                GB_GunUnit.Location = new Point(5, GB_MagicUnit.Location.Y + GB_MagicUnit.Height + spacing);
            }
            else if (currently_selected == "gun")
            {
                // if the gun unit is at the top, then hides all but the gun and giant unit group boxes
                GB_BasicUnit.Visible = false;
                GB_RangeUnit.Visible = false;
                GB_MagicUnit.Visible = false;
                GB_GunUnit.Visible = true;
                GB_GiantUnit.Visible = true;

                // sets the spacing between the group boxes
                int spacing = (PNL_UnitDisplay.Height - (GB_GunUnit.Height * 2)) / 3;
                // changes the group boxes location accordingly
                GB_GunUnit.Location = new Point(5, spacing);
                GB_GiantUnit.Location = new Point(5, GB_GunUnit.Location.Y + GB_GunUnit.Height + spacing);
            }
            else if (currently_selected == "giant")
            {
                // if the giant unit is at the top, then hides all but the giant and basic unit group boxes
                GB_BasicUnit.Visible = true;
                GB_RangeUnit.Visible = false;
                GB_MagicUnit.Visible = false;
                GB_GunUnit.Visible = false;
                GB_GiantUnit.Visible = true;

                // sets the spacing between the group boxes
                int spacing = (PNL_UnitDisplay.Height - (GB_GiantUnit.Height * 2)) / 3;
                // changes the location of the group boxdes accordingly
                GB_GiantUnit.Location = new Point(5, spacing);
                GB_BasicUnit.Location = new Point(5, GB_GiantUnit.Location.Y + GB_GiantUnit.Height + spacing);
            }
        }

        private void BTN_RangeUnit_Purchase1_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 1 of the range units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= RangeUnit_Cost)
            {
                // if they do, then takes away the cost of te unit
                GlobalVariables.Coins = GlobalVariables.Coins - RangeUnit_Cost;
                // gives them 1 range unit
                GlobalVariables.RangeUnit_Count++;
                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 1 " + RangeUnit_Name + " duck, thank you for wasting " + RangeUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + RangeUnit_Name + " ducks's is now " + GlobalVariables.RangeUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_RangeUnit_Purchase10_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 10 of the range units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= (RangeUnit_Cost * 10))
            {
                // if they do, then takes away the cost of 10 of the units
                GlobalVariables.Coins = GlobalVariables.Coins - (RangeUnit_Cost * 10);
                // gives them 10 range units
                GlobalVariables.RangeUnit_Count = GlobalVariables.RangeUnit_Count + 10;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 10 " + RangeUnit_Name + " ducks, thank you for wasting " + (RangeUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + RangeUnit_Name + " ducks's is now " + GlobalVariables.RangeUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_MagicUnit_Purchase1_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 1 of the magic units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= BasicUnit_Cost)
            {
                // if they do, then takes away the cost of te unit
                GlobalVariables.Coins = GlobalVariables.Coins - MagicUnit_Cost;
                // gives them 1 magic unit
                GlobalVariables.MagicUnit_Count++;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 1 " + MagicUnit_Name + " duck, thank you for wasting " + MagicUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + MagicUnit_Name + " ducks's is now " + GlobalVariables.MagicUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_MagicUnit_Purchase10_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 10 of the magic units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= (MagicUnit_Cost * 10))
            {
                // if they do, then takes away the cost of 10 of the units
                GlobalVariables.Coins = GlobalVariables.Coins - (MagicUnit_Cost * 10);
                // gives them 10 magic units
                GlobalVariables.MagicUnit_Count = GlobalVariables.MagicUnit_Count + 10;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 10 " + MagicUnit_Name + " ducks, thank you for wasting " + (MagicUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + MagicUnit_Name + " ducks's is now " + GlobalVariables.MagicUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GunUnit_Purchase1_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 1 of the gun units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= BasicUnit_Cost)
            {
                // if they do, then takes away the cost of te unit
                GlobalVariables.Coins = GlobalVariables.Coins - GunUnit_Cost;
                // gives them 1 gun unit
                GlobalVariables.GunUnit_Count++;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 1 " + GunUnit_Name + " duck, thank you for wasting " + GunUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GunUnit_Name + " ducks's is now " + GlobalVariables.GunUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GunUnit_Purchase10_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 10 of the gun units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= (GunUnit_Cost * 10))
            {
                // if they do, then takes away the cost of 10 of the units
                GlobalVariables.Coins = GlobalVariables.Coins - (GunUnit_Cost * 10);
                // gives them 10 gun units
                GlobalVariables.GunUnit_Count = GlobalVariables.GunUnit_Count + 10;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 10 " + GunUnit_Name + " ducks, thank you for wasting " + (GunUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GunUnit_Name + " ducks's is now " + GlobalVariables.GunUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GiantUnit_Purchase1_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 1 of the giant units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= GiantUnit_Cost)
            {
                // if they do, then takes away the cost of te unit
                GlobalVariables.Coins = GlobalVariables.Coins - GiantUnit_Cost;
                // gives them 1 giant unit
                GlobalVariables.GiantUnit_Count++;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 1 " + GiantUnit_Name + " duck, thank you for wasting " + GiantUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GiantUnit_Name + " ducks's is now " + GlobalVariables.GiantUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GiantUnit_Purchase10_Click(object sender, EventArgs e)
        {
            // when the player clicks this button to purchase 10 of the giant units,
            // checks if they have enough coins
            if (GlobalVariables.Coins >= (GiantUnit_Cost * 10))
            {
                // if they do, then takes away the cost of 10 of the units
                GlobalVariables.Coins = GlobalVariables.Coins - (GiantUnit_Cost * 10);
                // gives them 10 giant units
                GlobalVariables.GiantUnit_Count = GlobalVariables.GiantUnit_Count + 10;

                // displays a message box telling the player the purchase was successful
                MessageBox.Show("You have now recived 10 " + GiantUnit_Name + " ducks, thank you for wasting " + (GiantUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GiantUnit_Name + " ducks's is now " + GlobalVariables.GiantUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                // otherwise they don't have enough coins
                // display a message box that tells them they can't afford to purchase the unit
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }
    }
}
