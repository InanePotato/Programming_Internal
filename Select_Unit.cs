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
    public partial class Select_Unit : Form
    {
        //--------------------------------------------//
        // Declares public variables used in the form //
        //--------------------------------------------//
        int slot; // uesd to tell what slot the unit is being selected for

        // when a new instance of this form is created, it requires a slot number to be inputted
        public Select_Unit(int EditingSlot)
        {
            InitializeComponent();

            // sets the slot value to the given value
            slot = EditingSlot;
        }

        private void Select_Unit_Load(object sender, EventArgs e)
        {
            // makes this the top most form (above all other forms)
            this.TopMost = true;

            // gets all the duck images and uses the correct level versions to what the player has
            PIC_Basic.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic];
            PIC_Range.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range];
            PIC_Magic.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic];
            PIC_Gun.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun];
            PIC_Giant.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant];

            // updates the basic duck label to show the name of the corredtly upgraded basic duck
            if (GlobalVariables.UnitUpgrades_Basic == 2) { lbl_BasicName.Text = "Axe Duck"; }
            else if (GlobalVariables.UnitUpgrades_Basic == 1) { lbl_BasicName.Text = "Sword Duck"; }
            else { lbl_BasicName.Text = "Spear Duck"; }

            // updates the range duck label to show the name of the corredtly upgraded range duck
            if (GlobalVariables.UnitUpgrades_Range == 2) { lbl_RangeName.Text = "Cannon Duck"; }
            else if (GlobalVariables.UnitUpgrades_Range == 1) { lbl_RangeName.Text = "Catapult Duck"; }
            else { lbl_RangeName.Text = "Archer Duck"; }

            // updates the magic duck label to show the name of the corredtly upgraded magic duck
            if (GlobalVariables.UnitUpgrades_Magic == 2) { lbl_MagicName.Text = "Sorcerer Duck"; }
            else if (GlobalVariables.UnitUpgrades_Magic == 1) { lbl_MagicName.Text = "Wizard Duck"; }
            else { lbl_MagicName.Text = "Magician Duck"; }

            // updates the gun duck label to show the name of the corredtly upgraded gun duck
            if (GlobalVariables.UnitUpgrades_Gun == 2) { lbl_GunName.Text = "Sniper Duck"; }
            else if (GlobalVariables.UnitUpgrades_Gun == 1) { lbl_GunName.Text = "Gunner Duck"; }
            else { lbl_GunName.Text = "Agent Duck"; }

            // updates the giant duck label to show the name of the corredtly upgraded giant duck
            if (GlobalVariables.UnitUpgrades_Giant == 2) { lbl_GiantName.Text = "Buff Duck"; }
            else if (GlobalVariables.UnitUpgrades_Giant == 1) { lbl_GiantName.Text = "Tall Duck"; }
            else { lbl_GiantName.Text = "Stacked Duck"; }

            // updates the each ducks count label to the correct number of that unit the player has
            lbl_BasicUnitCount.Text = GlobalVariables.BasicUnit_Count.ToString();
            lbl_RangeUnitCount.Text = GlobalVariables.RangeUnit_Count.ToString();
            lbl_MagicUnitCount.Text = GlobalVariables.MagicUnit_Count.ToString();
            lbl_GunUnitCount.Text = GlobalVariables.GunUnit_Count.ToString();
            lbl_GiantUnitCount.Text = GlobalVariables.GiantUnit_Count.ToString();

            // enables the correct duck type lables
            // (if the unit hasn't been unlocked the button is dissables otherwise it's enabled)
            BTN_SelectBasic.Enabled = GlobalVariables.BasicUnitUnlocked;
            BTN_SelectRange.Enabled = GlobalVariables.RangeUnitUnlocked;
            BTN_SelectMagic.Enabled = GlobalVariables.MagicUnitUnlocked;
            BTN_SelectGun.Enabled = GlobalVariables.GunUnitUnlocked;
            BTN_SelectGiant.Enabled = GlobalVariables.GiantUnitUnlocked;

            // enables the correct duck type lables
            // (if the player has none of that type of unit then the button is dissables, otherwise it's enabled)
            if (GlobalVariables.BasicUnit_Count == 0) { BTN_SelectBasic.Enabled = false; }
            if (GlobalVariables.RangeUnit_Count == 0) { BTN_SelectRange.Enabled = false; }
            if (GlobalVariables.MagicUnit_Count == 0) { BTN_SelectMagic.Enabled = false; }
            if (GlobalVariables.GunUnit_Count == 0) { BTN_SelectGun.Enabled = false; }
            if (GlobalVariables.GiantUnit_Count == 0) { BTN_SelectGiant.Enabled = false; }
        }

        private void BTN_SelectBasic_Click(object sender, EventArgs e)
        {
            // when the basic ducks are choosen to go in the selected slot
            // checks if the basic units are already in another slot, if so gets confirmation for the change
            // and if the player confirms, changes the slot the basic units are in
            // otherwise, if the basic units arn't already in a slot, put them in the selected slot

            // declares and sets the count variable for the foreach loop
            int count = 0;
            // goes through each slot
            foreach (string Slot in GlobalVariables.SlotContents)
            {
                // checks if the basic units are already in that slot, and the slot being looked at isn't the selected slot
                if (Slot == "basic" && slot != count)
                {
                    // if so, then gets confirmation that the player wishes for the units to be moved
                    DialogResult dialogResult = MessageBox.Show("Slot " + count + " already contains your basic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // if the player says yes, moves the units over
                        // gets rid of where the basic units used to be
                        GlobalVariables.SlotContents[count] = "";

                        // adds the basic units to the selected slot
                        GlobalVariables.SlotContents[slot] = "basic";
                        // tells the game there has been a slot change
                        GlobalVariables.SlotChange = true;
                        // closes this form
                        this.Close();
                    }
                }
                count++;
            }

            // otherwise if the basic units don't already exist in another slot, then add them to the selected slot
            // adds the basic units to the selected slot
            GlobalVariables.SlotContents[slot] = "basic";
            // tells the game there has been a slot contents change
            GlobalVariables.SlotChange = true;
            // closes this form
            this.Close();
        }

        private void BTN_SelectRange_Click(object sender, EventArgs e)
        {
            // when the range ducks are choosen to go in the selected slot
            // checks if the range units are already in another slot, if so gets confirmation for the change
            // and if the player confirms, changes the slot the range units are in
            // otherwise, if the range units arn't already in a slot, put them in the selected slot

            // declares and sets the count variable for the foreach loop
            int count = 0;
            // goes through each slot
            foreach (string Slot in GlobalVariables.SlotContents)
            {
                // checks if the range units are already in that slot, and the slot being looked at isn't the selected slot
                if (Slot == "range" && slot != count)
                {
                    // if so, then gets confirmation that the player wishes for the units to be moved
                    DialogResult dialogResult = MessageBox.Show("Slot " + count + " already contains your range units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // if the player says yes, moves the units over
                        // gets rid of where the range units used to be
                        GlobalVariables.SlotContents[count] = "";

                        // adds the range units to the selected slot
                        GlobalVariables.SlotContents[slot] = "range";
                        // tells the game there has been a slot change
                        GlobalVariables.SlotChange = true;
                        // closes this form
                        this.Close();
                    }
                }
                count++;
            }

            // otherwise if the range units don't already exist in another slot, then add them to the selected slot
            // adds the basic units to the selected slot
            GlobalVariables.SlotContents[slot] = "range";
            // tells the game there has been a slot contents change
            GlobalVariables.SlotChange = true;
            // closes this form
            this.Close();
        }

        private void BTN_SelectMagic_Click(object sender, EventArgs e)
        {
            // when the magic ducks are choosen to go in the selected slot
            // checks if the magic units are already in another slot, if so gets confirmation for the change
            // and if the player confirms, changes the slot the magic units are in
            // otherwise, if the magic units arn't already in a slot, put them in the selected slot

            // declares and sets the count variable for the foreach loop
            int count = 0;
            // goes through each slot
            foreach (string Slot in GlobalVariables.SlotContents)
            {
                // checks if the magic units are already in that slot, and the slot being looked at isn't the selected slot
                if (Slot == "magic" && slot != count)
                {
                    // if so, then gets confirmation that the player wishes for the units to be moved
                    DialogResult dialogResult = MessageBox.Show("Slot " + count + " already contains your magic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // if the player says yes, moves the units over
                        // gets rid of where the magic units used to be
                        GlobalVariables.SlotContents[count] = "";

                        // adds the magic units to the selected slot
                        GlobalVariables.SlotContents[slot] = "magic";
                        // tells the game there has been a slot change
                        GlobalVariables.SlotChange = true;
                        // closes this form
                        this.Close();
                    }
                }
                count++;
            }

            // otherwise if the magic units don't already exist in another slot, then add them to the selected slot
            // adds the basic units to the selected slot
            GlobalVariables.SlotContents[slot] = "magic";
            // tells the game there has been a slot contents change
            GlobalVariables.SlotChange = true;
            // closes this form
            this.Close();
        }

        private void BTN_SelectGun_Click(object sender, EventArgs e)
        {
            // when the gun ducks are choosen to go in the selected slot
            // checks if the gun units are already in another slot, if so gets confirmation for the change
            // and if the player confirms, changes the slot the gun units are in
            // otherwise, if the gun units arn't already in a slot, put them in the selected slot

            // declares and sets the count variable for the foreach loop
            int count = 0;
            // goes through each slot
            foreach (string Slot in GlobalVariables.SlotContents)
            {
                // checks if the gun units are already in that slot, and the slot being looked at isn't the selected slot
                if (Slot == "gun" && slot != count)
                {
                    // if so, then gets confirmation that the player wishes for the units to be moved
                    DialogResult dialogResult = MessageBox.Show("Slot " + count + " already contains your gun units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // if the player says yes, moves the units over
                        // gets rid of where the gun units used to be
                        GlobalVariables.SlotContents[count] = "";

                        // adds the gun units to the selected slot
                        GlobalVariables.SlotContents[slot] = "gun";
                        // tells the game there has been a slot change
                        GlobalVariables.SlotChange = true;
                        // closes this form
                        this.Close();
                    }
                }
                count++;
            }

            // otherwise if the gun units don't already exist in another slot, then add them to the selected slot
            // adds the basic units to the selected slot
            GlobalVariables.SlotContents[slot] = "gun";
            // tells the game there has been a slot contents change
            GlobalVariables.SlotChange = true;
            // closes this form
            this.Close();
        }

        private void BTN_SelectGiant_Click(object sender, EventArgs e)
        {
            // when the giant ducks are choosen to go in the selected slot
            // checks if the giant units are already in another slot, if so gets confirmation for the change
            // and if the player confirms, changes the slot the giant units are in
            // otherwise, if the giant units arn't already in a slot, put them in the selected slot

            // declares and sets the count variable for the foreach loop
            int count = 0;
            // goes through each slot
            foreach (string Slot in GlobalVariables.SlotContents)
            {
                // checks if the giant units are already in that slot, and the slot being looked at isn't the selected slot
                if (Slot == "giant" && slot != count)
                {
                    // if so, then gets confirmation that the player wishes for the units to be moved
                    DialogResult dialogResult = MessageBox.Show("Slot " + count + " already contains your giant units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // if the player says yes, moves the units over
                        // gets rid of where the giant units used to be
                        GlobalVariables.SlotContents[count] = "";

                        // adds the giant units to the selected slot
                        GlobalVariables.SlotContents[slot] = "giant";
                        // tells the game there has been a slot change
                        GlobalVariables.SlotChange = true;
                        // closes this form
                        this.Close();
                    }
                }
                count++;
            }

            // otherwise if the giant units don't already exist in another slot, then add them to the selected slot
            // adds the basic units to the selected slot
            GlobalVariables.SlotContents[slot] = "giant";
            // tells the game there has been a slot contents change
            GlobalVariables.SlotChange = true;
            // closes this form
            this.Close();
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            // makes sure the windostate of theis form is never maximized
            // checks if the form has been maximized
            if (WindowState == FormWindowState.Maximized)
            {
                // if so, returns it to it's normal size
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
