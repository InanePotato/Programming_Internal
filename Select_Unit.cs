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
        int slot;

        public Select_Unit(int EditingSlot)
        {
            InitializeComponent();

            slot = EditingSlot;
        }

        private void Select_Unit_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            PIC_Basic.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic];
            PIC_Range.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range];
            PIC_Magic.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic];
            PIC_Gun.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun];
            PIC_Giant.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant];

            if (GlobalVariables.UnitUpgrades_Basic == 2) { lbl_BasicName.Text = "Axe Duck"; }
            else if (GlobalVariables.UnitUpgrades_Basic == 1) { lbl_BasicName.Text = "Sword Duck"; }
            else { lbl_BasicName.Text = "Spear Duck"; }

            if (GlobalVariables.UnitUpgrades_Range == 2) { lbl_RangeName.Text = "Cannon Duck"; }
            else if (GlobalVariables.UnitUpgrades_Range == 1) { lbl_RangeName.Text = "Catapult Duck"; }
            else { lbl_RangeName.Text = "Archer Duck"; }

            if (GlobalVariables.UnitUpgrades_Magic == 2) { lbl_MagicName.Text = "Sorcerer Duck"; }
            else if (GlobalVariables.UnitUpgrades_Magic == 1) { lbl_MagicName.Text = "Wizard Duck"; }
            else { lbl_MagicName.Text = "Magician Duck"; }

            if (GlobalVariables.UnitUpgrades_Gun == 2) { lbl_GunName.Text = "Sniper Duck"; }
            else if (GlobalVariables.UnitUpgrades_Gun == 1) { lbl_GunName.Text = "Gunner Duck"; }
            else { lbl_GunName.Text = "Agent Duck"; }

            if (GlobalVariables.UnitUpgrades_Giant == 2) { lbl_GiantName.Text = "Buff Duck"; }
            else if (GlobalVariables.UnitUpgrades_Giant == 1) { lbl_GiantName.Text = "Tall Duck"; }
            else { lbl_GiantName.Text = "Stacked Duck"; }

            lbl_BasicUnitCount.Text = GlobalVariables.BasicUnit_Count.ToString();
            lbl_RangeUnitCount.Text = GlobalVariables.RangeUnit_Count.ToString();
            lbl_MagicUnitCount.Text = GlobalVariables.MagicUnit_Count.ToString();
            lbl_GunUnitCount.Text = GlobalVariables.GunUnit_Count.ToString();
            lbl_GiantUnitCount.Text = GlobalVariables.GiantUnit_Count.ToString();

            BTN_SelectBasic.Enabled = GlobalVariables.BasicUnitUnlocked;
            BTN_SelectRange.Enabled = GlobalVariables.RangeUnitUnlocked;
            BTN_SelectMagic.Enabled = GlobalVariables.MagicUnitUnlocked;
            BTN_SelectGun.Enabled = GlobalVariables.GunUnitUnlocked;
            BTN_SelectGiant.Enabled = GlobalVariables.GiantUnitUnlocked;

            if (GlobalVariables.BasicUnit_Count == 0) { BTN_SelectBasic.Enabled = false; }
            if (GlobalVariables.RangeUnit_Count == 0) { BTN_SelectRange.Enabled = false; }
            if (GlobalVariables.MagicUnit_Count == 0) { BTN_SelectMagic.Enabled = false; }
            if (GlobalVariables.GunUnit_Count == 0) { BTN_SelectGun.Enabled = false; }
            if (GlobalVariables.GiantUnit_Count == 0) { BTN_SelectGiant.Enabled = false; }
        }

        private void BTN_SelectBasic_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SlotContents[0] == "basic" && slot != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 0 already contains your basic units, would you like to move them to slot " + slot + "?","Selection Error",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[0] = "";

                    GlobalVariables.SlotContents[slot] = "basic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[1] == "basic" && slot != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 1 already contains your basic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[1] = "";

                    GlobalVariables.SlotContents[slot] = "basic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[2] == "basic" && slot != 2)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 2 already contains your basic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[2] = "";

                    GlobalVariables.SlotContents[slot] = "basic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[3] == "basic" && slot != 3)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 3 already contains your basic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[3] = "";

                    GlobalVariables.SlotContents[slot] = "basic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[4] == "basic" && slot != 4)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 4 already contains your basic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[4] = "";

                    GlobalVariables.SlotContents[slot] = "basic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else
            {
                GlobalVariables.SlotContents[slot] = "basic";
                GlobalVariables.SlotChange = true;
                this.Close();
            }
        }

        private void BTN_SelectRange_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SlotContents[0] == "range" && slot != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 0 already contains your range units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[0] = "";

                    GlobalVariables.SlotContents[slot] = "range";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[1] == "range" && slot != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 1 already contains your range units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[1] = "";

                    GlobalVariables.SlotContents[slot] = "range";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[2] == "range" && slot != 2)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 2 already contains your range units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[2] = "";

                    GlobalVariables.SlotContents[slot] = "range";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[3] == "range" && slot != 3)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 3 already contains your range units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[3] = "";

                    GlobalVariables.SlotContents[slot] = "range";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[4] == "range" && slot != 4)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 4 already contains your range units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[4] = "";

                    GlobalVariables.SlotContents[slot] = "range";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else
            {
                GlobalVariables.SlotContents[slot] = "range";
                GlobalVariables.SlotChange = true;
                this.Close();
            }
        }

        private void BTN_SelectMagic_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SlotContents[0] == "magic" && slot != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 0 already contains your magic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[0] = "";

                    GlobalVariables.SlotContents[slot] = "magic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[1] == "magic" && slot != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 1 already contains your magic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[1] = "";

                    GlobalVariables.SlotContents[slot] = "magic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[2] == "magic" && slot != 2)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 2 already contains your magic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[2] = "";

                    GlobalVariables.SlotContents[slot] = "magic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[3] == "magic" && slot != 3)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 3 already contains your magic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[3] = "";

                    GlobalVariables.SlotContents[slot] = "magic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[4] == "magic" && slot != 4)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 4 already contains your magic units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[4] = "";

                    GlobalVariables.SlotContents[slot] = "magic";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else
            {
                GlobalVariables.SlotContents[slot] = "magic";
                GlobalVariables.SlotChange = true;
                this.Close();
            }
        }

        private void BTN_SelectGun_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SlotContents[0] == "gun" && slot != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 0 already contains your gun units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[0] = "";

                    GlobalVariables.SlotContents[slot] = "gun";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[1] == "gun" && slot != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 1 already contains your gun units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[1] = "";

                    GlobalVariables.SlotContents[slot] = "gun";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[2] == "gun" && slot != 2)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 2 already contains your gun units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[2] = "";

                    GlobalVariables.SlotContents[slot] = "gun";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[3] == "gun" && slot != 3)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 3 already contains your gun units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[3] = "";

                    GlobalVariables.SlotContents[slot] = "gun";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[4] == "gun" && slot != 4)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 4 already contains your gun units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[4] = "";

                    GlobalVariables.SlotContents[slot] = "gun";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else
            {
                GlobalVariables.SlotContents[slot] = "gun";
                GlobalVariables.SlotChange = true;
                this.Close();
            }
        }

        private void BTN_SelectGiant_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SlotContents[0] == "giant" && slot != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 0 already contains your giant units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[0] = "";

                    GlobalVariables.SlotContents[slot] = "giant";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[1] == "giant" && slot != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 1 already contains your giant units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[1] = "";

                    GlobalVariables.SlotContents[slot] = "giant";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[2] == "giant" && slot != 2)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 2 already contains your giant units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[2] = "";

                    GlobalVariables.SlotContents[slot] = "giant";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[3] == "giant" && slot != 3)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 3 already contains your giant units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[3] = "";

                    GlobalVariables.SlotContents[slot] = "giant";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else if (GlobalVariables.SlotContents[4] == "giant" && slot != 4)
            {
                DialogResult dialogResult = MessageBox.Show("Slot 4 already contains your giant units, would you like to move them to slot " + slot + "?", "Selection Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GlobalVariables.SlotContents[4] = "";

                    GlobalVariables.SlotContents[slot] = "giant";
                    GlobalVariables.SlotChange = true;
                    this.Close();
                }
            }
            else
            {
                GlobalVariables.SlotContents[slot] = "giant";
                GlobalVariables.SlotChange = true;
                this.Close();
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
