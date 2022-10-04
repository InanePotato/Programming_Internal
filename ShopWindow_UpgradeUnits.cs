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
        string CurrentUnitName;
        string CurrentUnitType;
        bool CurrentUnitUnlocked;
        int CurrentUnitLevel;
        int Cost;

        public ShopWindow_UpgradeUnits()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Display, new object[] { true });
        }

        private void ShopWindow_UpgradeUnits_Load(object sender, EventArgs e)
        {
            GB_UnlockUnit.Size = new Size(677, 388);
            GB_UnlockUnit.Location = new Point((PNL_Display.Width - GB_UnlockUnit.Width) / 2, (PNL_Display.Height - GB_UnlockUnit.Height) / 2);
            GB_UpgradeUnit.Size = new Size(677, 388);
            GB_UpgradeUnit.Location = new Point((PNL_Display.Width - GB_UpgradeUnit.Width) / 2, (PNL_Display.Height - GB_UpgradeUnit.Height) / 2);
            GB_FinalUnit.Size = new Size(677, 388);
            GB_FinalUnit.Location = new Point((PNL_Display.Width - GB_FinalUnit.Width) / 2, (PNL_Display.Height - GB_FinalUnit.Height) / 2);

            CurrentUnitType = "basic";

            DisplayUpdate();

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                Console.WriteLine(i.Name + ": " +i.Cost);
            }

            Console.WriteLine("-------------------------------------");
        }

        public void DisplayUpdate()
        {
            if (CurrentUnitType == "giant")
            {
                if (GlobalVariables.UnitUpgrades_Giant == 2) { CurrentUnitName = "buff"; }
                else if (GlobalVariables.UnitUpgrades_Giant == 1) { CurrentUnitName = "tall"; }
                else { CurrentUnitName = "stacked"; }

                CurrentUnitUnlocked = GlobalVariables.GiantUnitUnlocked;
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Giant;
            }
            else if (CurrentUnitType == "gun")
            {
                if (GlobalVariables.UnitUpgrades_Gun == 2) { CurrentUnitName = "sniper"; }
                else if (GlobalVariables.UnitUpgrades_Gun == 1) { CurrentUnitName = "gunner"; }
                else { CurrentUnitName = "agent"; }

                CurrentUnitUnlocked = GlobalVariables.GunUnitUnlocked;
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Gun;
            }
            else if (CurrentUnitType == "magic")
            {
                if (GlobalVariables.UnitUpgrades_Magic == 2) { CurrentUnitName = "sorcerer"; }
                else if (GlobalVariables.UnitUpgrades_Magic == 1) { CurrentUnitName = "wizard"; }
                else { CurrentUnitName = "magician"; }

                CurrentUnitUnlocked = GlobalVariables.MagicUnitUnlocked;
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Magic;
            }
            else if (CurrentUnitType == "range")
            {
                if (GlobalVariables.UnitUpgrades_Range == 2) { CurrentUnitName = "cannon"; }
                else if (GlobalVariables.UnitUpgrades_Range == 1) { CurrentUnitName = "catapult"; }
                else { CurrentUnitName = "archer"; }

                CurrentUnitUnlocked = GlobalVariables.RangeUnitUnlocked;
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Range;
            }
            else
            {
                if (GlobalVariables.UnitUpgrades_Basic == 2) { CurrentUnitName = "axe"; }
                else if (GlobalVariables.UnitUpgrades_Basic == 1) { CurrentUnitName = "sword"; }
                else { CurrentUnitName = "spear"; }

                CurrentUnitUnlocked = GlobalVariables.BasicUnitUnlocked;
                CurrentUnitLevel = GlobalVariables.UnitUpgrades_Basic;
            }

            if (CurrentUnitUnlocked == true)
            {
                if (CurrentUnitLevel == 2) { DisplayFinal(); }
                else { DisplayUpgrades(); }
            }
            else { DisplayUnlock(); }
        }

        public void DisplayUnlock()
        {
            GB_UnlockUnit.Visible = true;
            GB_UpgradeUnit.Visible = false;
            GB_FinalUnit.Visible = false;

            GB_UnlockUnit.Text = "Unlock - " + CurrentUnitType + " unit";

            if (CurrentUnitType == "giant") { PIC_UnlockUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant]; }
            else if (CurrentUnitType == "gun") { PIC_UnlockUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun]; }
            else if (CurrentUnitType == "magic") { PIC_UnlockUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic]; }
            else if (CurrentUnitType == "range") { PIC_UnlockUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range]; }
            else { PIC_UnlockUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic]; }

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == CurrentUnitName)
                {
                    lbl_UnlockUnit_Health.Text = i.Health.ToString();
                    lbl_UnlockUnit_Damage.Text = i.Damage.ToString();
                    lbl_UnlockUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_UnlockUnit_Range.Text = i.Range;
                    Cost = i.Cost * 15;

                    BTN_Unlock.Text = "Unlock (" + Cost + " coins)";

                    lbl_UnlockAbilities.Text = "Coming Soon!";
                }
            }
        }

        public void DisplayUpgrades()
        {
            GB_UpgradeUnit.Visible = true;
            GB_UnlockUnit.Visible = false;
            GB_FinalUnit.Visible = false;

            GB_UpgradeUnit.Text = "Upgrade - " + CurrentUnitType + " unit";

            if (CurrentUnitType == "giant") { PIC_UpgradeUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant]; }
            else if (CurrentUnitType == "gun") { PIC_UpgradeUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun]; }
            else if (CurrentUnitType == "magic") { PIC_UpgradeUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic]; }
            else if (CurrentUnitType == "range") { PIC_UpgradeUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range]; }
            else { PIC_UpgradeUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic]; }

            if (CurrentUnitType == "giant") { PIC_UpgradeUnit2.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant + 1]; }
            else if (CurrentUnitType == "gun") { PIC_UpgradeUnit2.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun + 1]; }
            else if (CurrentUnitType == "magic") { PIC_UpgradeUnit2.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic + 1]; }
            else if (CurrentUnitType == "range") { PIC_UpgradeUnit2.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range + 1]; }
            else { PIC_UpgradeUnit2.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic + 1]; }

            string NextName = "";
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

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == CurrentUnitName)
                {
                    lbl_UpgradeUnit_Health.Text = i.Health.ToString();
                    lbl_UpgradeUnit_Damage.Text = i.Damage.ToString();
                    lbl_UpgradeUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_UpgradeUnit_Range.Text = i.Range;

                    lbl_UpgradeUnit_Abilities.Text = "Coming Soon!";
                }
                else if (i.Name == NextName)
                {
                    lbl_UpgradeUnit2_Health.Text = i.Health.ToString();
                    lbl_UpgradeUnit2_Damage.Text = i.Damage.ToString();
                    lbl_UpgradeUnit2_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_UpgradeUnit2_Range.Text = i.Range;

                    Cost = i.Cost * 20;
                    BTN_Upgrade.Text = "Upgrade (" + Cost + " coins)";

                    lbl_UpgradeUnit2_Abilities.Text = "Coming Soon!";
                }
            }
        }

        public void DisplayFinal()
        {
            GB_FinalUnit.Visible = true;
            GB_UpgradeUnit.Visible = false;
            GB_UnlockUnit.Visible = false;

            GB_FinalUnit.Text = "Upgrade - " + CurrentUnitType + " unit";

            if (CurrentUnitType == "giant") { PIC_FinalUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant]; }
            else if (CurrentUnitType == "gun") { PIC_FinalUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun]; }
            else if (CurrentUnitType == "magic") { PIC_FinalUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic]; }
            else if (CurrentUnitType == "range") { PIC_FinalUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range]; }
            else { PIC_FinalUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic]; }

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == CurrentUnitName)
                {
                    lbl_FinalUnit_Health.Text = i.Health.ToString();
                    lbl_FinalUnit_Damage.Text = i.Damage.ToString();
                    lbl_FinalUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_FinalUnit_Range.Text = i.Range;

                    lbl_FinalUnit_Abilities.Text = "Coming Soon!";
                }
            }
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if (CurrentUnitType == "basic") { CurrentUnitType = "range"; }
            else if (CurrentUnitType == "range") { CurrentUnitType = "magic"; }
            else if (CurrentUnitType == "magic") { CurrentUnitType = "gun"; }
            else if (CurrentUnitType == "gun") { CurrentUnitType = "giant"; }
            else if (CurrentUnitType == "giant") { CurrentUnitType = "basic"; }

            DisplayUpdate();
        }

        private void BTN_Previous_Click(object sender, EventArgs e)
        {
            if (CurrentUnitType == "basic") { CurrentUnitType = "giant"; }
            else if (CurrentUnitType == "range") { CurrentUnitType = "basic"; }
            else if (CurrentUnitType == "magic") { CurrentUnitType = "range"; }
            else if (CurrentUnitType == "gun") { CurrentUnitType = "magic"; }
            else if (CurrentUnitType == "giant") { CurrentUnitType = "gun"; }

            DisplayUpdate();
        }

        private void BTN_Upgrade_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= Cost)
            {
                GlobalVariables.Coins = GlobalVariables.Coins - Cost;

                if (CurrentUnitType == "basic") { GlobalVariables.UnitUpgrades_Basic++; }
                else if (CurrentUnitType == "range") { GlobalVariables.UnitUpgrades_Range++; }
                else if (CurrentUnitType == "magic") { GlobalVariables.UnitUpgrades_Magic++; }
                else if (CurrentUnitType == "gun") { GlobalVariables.UnitUpgrades_Gun++; }
                else if (CurrentUnitType == "giant") { GlobalVariables.UnitUpgrades_Giant++; }

                MessageBox.Show("You have now upgraded your " + CurrentUnitType + " ducks, thank you for wasting " + Cost + " of your coins on this purchase.", "Purchase Successful");

                DisplayUpdate();
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to upgrade this item", "Insufficient funds");
            }
        }

        private void BTN_Unlock_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= Cost)
            {
                GlobalVariables.Coins = GlobalVariables.Coins - Cost;

                if (CurrentUnitType == "basic") { GlobalVariables.BasicUnitUnlocked = true; }
                else if (CurrentUnitType == "range") { GlobalVariables.RangeUnitUnlocked = true; }
                else if (CurrentUnitType == "magic") { GlobalVariables.MagicUnitUnlocked = true; }
                else if (CurrentUnitType == "gun") { GlobalVariables.GunUnitUnlocked = true; }
                else if (CurrentUnitType == "giant") { GlobalVariables.GiantUnitUnlocked = true; }

                MessageBox.Show("You have now unlocked " + CurrentUnitType + " ducks, thank you for wasting " + Cost + " of your coins on this purchase.", "Purchase Successful");

                DisplayUpdate();
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to unlock this item", "Insufficient funds");
            }
        }
    }
}
