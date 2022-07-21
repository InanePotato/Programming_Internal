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
    public partial class ShopWindow_PurchaseUnits : Form
    {
        int BasicUnit_Cost, RangeUnit_Cost, MagicUnit_Cost, GunUnit_Cost, GiantUnit_Cost;
        string BasicUnit_Name, RangeUnit_Name, MagicUnit_Name, GunUnit_Name, GiantUnit_Name;

        public ShopWindow_PurchaseUnits()
        {
            InitializeComponent();
        }

        private void ShopWindow_PurchaseUnits_Load(object sender, EventArgs e)
        {
            // x = 11    width = 677    height = 182
            int location_x = 5;
            int size_width = 677;
            int size_height = 182;
            GB_BasicUnit.Size = new Size(677, 182);
            GB_BasicUnit.Location = new Point(location_x, 5);
            GB_RangeUnit.Size = new Size(size_width, size_height);
            GB_RangeUnit.Location = new Point(location_x, GB_BasicUnit.Location.Y + GB_BasicUnit.Height + 10);
            GB_MagicUnit.Size = new Size(size_width, size_height);
            GB_MagicUnit.Location = new Point(location_x, GB_RangeUnit.Location.Y + GB_RangeUnit.Height + 10);
            GB_GunUnit.Size = new Size(size_width, size_height);
            GB_GunUnit.Location = new Point(location_x, GB_MagicUnit.Location.Y + GB_MagicUnit.Height + 10);
            GB_GiantUnit.Size = new Size(size_width, size_height);
            GB_GiantUnit.Location = new Point(location_x, GB_GunUnit.Location.Y + GB_GunUnit.Height + 10);

            if (GlobalVariables.BasicUnitUnlocked == false) { GB_BasicUnit.Enabled = false; }
            if (GlobalVariables.RangeUnitUnlocked == false) { GB_RangeUnit.Enabled = false; }
            if (GlobalVariables.MagicUnitUnlocked == false) { GB_MagicUnit.Enabled = false; }
            if (GlobalVariables.GunUnitUnlocked == false) { GB_GunUnit.Enabled = false; }
            if (GlobalVariables.GiantUnitUnlocked == false) { GB_GiantUnit.Enabled = false; }

            PIC_BasicUnit.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic];
            PIC_RangeUnit.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range];
            PIC_MagicUnit.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic];
            PIC_GunUnit.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun];
            PIC_GiantUnit.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant];

            if (GlobalVariables.UnitUpgrades_Basic == 2) { BasicUnit_Name = "axe"; GB_BasicUnit.Text = "Basic Unit - Axe Duck"; }
            else if (GlobalVariables.UnitUpgrades_Basic == 1) { BasicUnit_Name = "sword"; GB_BasicUnit.Text = "Basic Unit - Sword Duck"; }
            else { BasicUnit_Name = "spear"; GB_BasicUnit.Text = "Basic Unit - Spear Duck"; }

            if (GlobalVariables.UnitUpgrades_Range == 2) { RangeUnit_Name = "cannon"; GB_RangeUnit.Text = "Range Unit - Cannon Duck"; }
            else if (GlobalVariables.UnitUpgrades_Range == 1) { RangeUnit_Name = "catapult"; GB_RangeUnit.Text = "Range Unit - Catapult Duck"; }
            else { RangeUnit_Name = "archer"; GB_RangeUnit.Text = "Range Unit - Archer Duck"; }

            if (GlobalVariables.UnitUpgrades_Magic == 2) { MagicUnit_Name = "sorcerer"; GB_MagicUnit.Text = "Magic Unit - Sorcerer Duck"; }
            else if (GlobalVariables.UnitUpgrades_Magic == 1) { MagicUnit_Name = "wizard"; GB_MagicUnit.Text = "Magic Unit - Wizard Duck"; }
            else { MagicUnit_Name = "magician"; GB_MagicUnit.Text = "Magic Unit - Magician Duck"; }

            if (GlobalVariables.UnitUpgrades_Gun == 2) { GunUnit_Name = "sniper"; GB_GunUnit.Text = "Gun Unit - Sniper Duck"; }
            else if (GlobalVariables.UnitUpgrades_Gun == 1) { GunUnit_Name = "gunner"; GB_GunUnit.Text = "Gun Unit - Gunner Duck"; }
            else { GunUnit_Name = "agent"; GB_GunUnit.Text = "Gun Unit - Agent Duck"; }

            if (GlobalVariables.UnitUpgrades_Giant == 2) { GiantUnit_Name = "buff"; GB_GiantUnit.Text = "Giant Unit - Buff Duck"; }
            else if (GlobalVariables.UnitUpgrades_Giant == 1) { GiantUnit_Name = "tall"; GB_GiantUnit.Text = "Giant Unit - Tall Duck"; }
            else { GiantUnit_Name = "stacked"; GB_GiantUnit.Text = "Giant Unit - Stacked Duck"; }

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == BasicUnit_Name)
                {
                    lbl_BasicUnit_Health.Text = i.Health.ToString();
                    lbl_BasicUnit_Damage.Text = i.Damage.ToString();
                    lbl_BasicUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_BasicUnit_Range.Text = i.Range;
                    BasicUnit_Cost = i.Cost;
                    BTN_BasicUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_BasicUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    if (i.Abilities == "none")
                    {
                        lbl_BasicAbilities.Text = "   - none" + Environment.NewLine + "   - none" + Environment.NewLine + "   - none";
                    }
                    else
                    {
                        string[] abilities = new string[3];
                        abilities = i.Abilities.Split(' ');

                        string[] ability1_TEXT = new string[2];
                        if (abilities[0] == "none")
                        {
                            ability1_TEXT[0] = "";
                            ability1_TEXT[1] = "none";
                        }
                        else
                        {
                            ability1_TEXT = abilities[0].Split('%');
                            ability1_TEXT[0] = ability1_TEXT[0] + "% ";
                        }

                        string[] ability2_TEXT = new string[2];
                        if (abilities[1] == "none")
                        {
                            ability2_TEXT[0] = "";
                            ability2_TEXT[1] = "none";
                        }
                        else
                        {
                            ability2_TEXT = abilities[1].Split('%');
                            ability2_TEXT[0] = ability2_TEXT[0] + "% ";
                        }

                        string[] ability3_TEXT = new string[2];
                        if (abilities[2] == "none")
                        {
                            ability3_TEXT[0] = "";
                            ability3_TEXT[1] = "none";
                        }
                        else
                        {
                            ability3_TEXT = abilities[2].Split('%');
                            ability3_TEXT[0] = ability3_TEXT[0] + "% ";
                        }

                        lbl_BasicAbilities.Text = "   - " + ability1_TEXT[0] + ability1_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability2_TEXT[0] + ability2_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability3_TEXT[0] + ability3_TEXT[1] + Environment.NewLine;
                    }
                }

                if (i.Name == RangeUnit_Name)
                {
                    lbl_RangeUnit_Health.Text = i.Health.ToString();
                    lbl_RangeUnit_Damage.Text = i.Damage.ToString();
                    lbl_RangeUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_RangeUnit_Range.Text = i.Range;
                    RangeUnit_Cost = i.Cost;
                    BTN_RangeUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_RangeUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    if (i.Abilities == "none")
                    {
                        lbl_RangeUnit_Abilities.Text = "   - none" + Environment.NewLine + "   - none" + Environment.NewLine + "   - none";
                    }
                    else
                    {
                        string[] abilities = new string[3];
                        abilities = i.Abilities.Split(' ');

                        string[] ability1_TEXT = new string[2];
                        if (abilities[0] == "none")
                        {
                            ability1_TEXT[0] = "";
                            ability1_TEXT[1] = "none";
                        }
                        else
                        {
                            ability1_TEXT = abilities[0].Split('%');
                            ability1_TEXT[0] = ability1_TEXT[0] + "% ";
                        }

                        string[] ability2_TEXT = new string[2];
                        if (abilities[1] == "none")
                        {
                            ability2_TEXT[0] = "";
                            ability2_TEXT[1] = "none";
                        }
                        else
                        {
                            ability2_TEXT = abilities[1].Split('%');
                            ability2_TEXT[0] = ability2_TEXT[0] + "% ";
                        }

                        string[] ability3_TEXT = new string[2];
                        if (abilities[2] == "none")
                        {
                            ability3_TEXT[0] = "";
                            ability3_TEXT[1] = "none";
                        }
                        else
                        {
                            ability3_TEXT = abilities[2].Split('%');
                            ability3_TEXT[0] = ability3_TEXT[0] + "% ";
                        }

                        lbl_RangeUnit_Abilities.Text = "   - " + ability1_TEXT[0] + ability1_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability2_TEXT[0] + ability2_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability3_TEXT[0] + ability3_TEXT[1] + Environment.NewLine;
                    }
                }

                if (i.Name == MagicUnit_Name)
                {
                    lbl_MagicUnit_Health.Text = i.Health.ToString();
                    lbl_MagicUnit_Damage.Text = i.Damage.ToString();
                    lbl_MagicUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_MagicUnit_Range.Text = i.Range;
                    MagicUnit_Cost = i.Cost;
                    BTN_MagicUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_MagicUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    if (i.Abilities == "none")
                    {
                        lbl_MagicUnit_Abilities.Text = "   - none" + Environment.NewLine + "   - none" + Environment.NewLine + "   - none";
                    }
                    else
                    {
                        string[] abilities = new string[3];
                        abilities = i.Abilities.Split(' ');

                        string[] ability1_TEXT = new string[2];
                        if (abilities[0] == "none")
                        {
                            ability1_TEXT[0] = "";
                            ability1_TEXT[1] = "none";
                        }
                        else
                        {
                            ability1_TEXT = abilities[0].Split('%');
                            ability1_TEXT[0] = ability1_TEXT[0] + "% ";
                        }

                        string[] ability2_TEXT = new string[2];
                        if (abilities[1] == "none")
                        {
                            ability2_TEXT[0] = "";
                            ability2_TEXT[1] = "none";
                        }
                        else
                        {
                            ability2_TEXT = abilities[1].Split('%');
                            ability2_TEXT[0] = ability2_TEXT[0] + "% ";
                        }

                        string[] ability3_TEXT = new string[2];
                        if (abilities[2] == "none")
                        {
                            ability3_TEXT[0] = "";
                            ability3_TEXT[1] = "none";
                        }
                        else
                        {
                            ability3_TEXT = abilities[2].Split('%');
                            ability3_TEXT[0] = ability3_TEXT[0] + "% ";
                        }

                        lbl_MagicUnit_Abilities.Text = "   - " + ability1_TEXT[0] + ability1_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability2_TEXT[0] + ability2_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability3_TEXT[0] + ability3_TEXT[1] + Environment.NewLine;
                    }
                }

                if (i.Name == GunUnit_Name)
                {
                    lbl_GunUnit_Health.Text = i.Health.ToString();
                    lbl_GunUnit_Damage.Text = i.Damage.ToString();
                    lbl_GunUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_GunUnit_Range.Text = i.Range;
                    GunUnit_Cost = i.Cost;
                    BTN_GunUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_GunUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    if (i.Abilities == "none")
                    {
                        lbl_GunUnit_Abilities.Text = "   - none" + Environment.NewLine + "   - none" + Environment.NewLine + "   - none";
                    }
                    else
                    {
                        string[] abilities = new string[3];
                        abilities = i.Abilities.Split(' ');

                        string[] ability1_TEXT = new string[2];
                        if (abilities[0] == "none")
                        {
                            ability1_TEXT[0] = "";
                            ability1_TEXT[1] = "none";
                        }
                        else
                        {
                            ability1_TEXT = abilities[0].Split('%');
                            ability1_TEXT[0] = ability1_TEXT[0] + "% ";
                        }

                        string[] ability2_TEXT = new string[2];
                        if (abilities[1] == "none")
                        {
                            ability2_TEXT[0] = "";
                            ability2_TEXT[1] = "none";
                        }
                        else
                        {
                            ability2_TEXT = abilities[1].Split('%');
                            ability2_TEXT[0] = ability2_TEXT[0] + "% ";
                        }

                        string[] ability3_TEXT = new string[2];
                        if (abilities[2] == "none")
                        {
                            ability3_TEXT[0] = "";
                            ability3_TEXT[1] = "none";
                        }
                        else
                        {
                            ability3_TEXT = abilities[2].Split('%');
                            ability3_TEXT[0] = ability3_TEXT[0] + "% ";
                        }

                        lbl_GunUnit_Abilities.Text = "   - " + ability1_TEXT[0] + ability1_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability2_TEXT[0] + ability2_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability3_TEXT[0] + ability3_TEXT[1] + Environment.NewLine;
                    }
                }

                if (i.Name == GiantUnit_Name)
                {
                    lbl_GiantUnit_Health.Text = i.Health.ToString();
                    lbl_GiantUnit_Damage.Text = i.Damage.ToString();
                    lbl_GiantUnit_AttackSpeed.Text = i.Attack_Speed.ToString();
                    lbl_GiantUnit_Range.Text = i.Range;
                    GiantUnit_Cost = i.Cost;
                    BTN_GiantUnit_Purchase1.Text = "Purchase Unit (x1)" + Environment.NewLine + "Cost: " + i.Cost.ToString() + " coins";
                    BTN_GiantUnit_Purchase10.Text = "Purchase Unit (x10)" + Environment.NewLine + "Cost: " + (i.Cost * 10).ToString() + " coins";

                    if (i.Abilities == "none")
                    {
                        lbl_GiantUnit_Abilities.Text = "   - none" + Environment.NewLine + "   - none" + Environment.NewLine + "   - none";
                    }
                    else
                    {
                        string[] abilities = new string[3];
                        abilities = i.Abilities.Split(' ');

                        string[] ability1_TEXT = new string[2];
                        if (abilities[0] == "none")
                        {
                            ability1_TEXT[0] = "";
                            ability1_TEXT[1] = "none";
                        }
                        else
                        {
                            ability1_TEXT = abilities[0].Split('%');
                            ability1_TEXT[0] = ability1_TEXT[0] + "% ";
                        }

                        string[] ability2_TEXT = new string[2];
                        if (abilities[1] == "none")
                        {
                            ability2_TEXT[0] = "";
                            ability2_TEXT[1] = "none";
                        }
                        else
                        {
                            ability2_TEXT = abilities[1].Split('%');
                            ability2_TEXT[0] = ability2_TEXT[0] + "% ";
                        }

                        string[] ability3_TEXT = new string[2];
                        if (abilities[2] == "none")
                        {
                            ability3_TEXT[0] = "";
                            ability3_TEXT[1] = "none";
                        }
                        else
                        {
                            ability3_TEXT = abilities[2].Split('%');
                            ability3_TEXT[0] = ability3_TEXT[0] + "% ";
                        }

                        lbl_GiantUnit_Abilities.Text = "   - " + ability1_TEXT[0] + ability1_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability2_TEXT[0] + ability2_TEXT[1] + Environment.NewLine +
                                                  "   - " + ability3_TEXT[0] + ability3_TEXT[1] + Environment.NewLine;
                    }
                }
            }
        }

        private void BTN_BasicUnit_Purchase1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= BasicUnit_Cost)
            {
                GlobalVariables.Coins = GlobalVariables.Coins - BasicUnit_Cost;
                GlobalVariables.BasicUnit_Count++;

                MessageBox.Show("You have now recived 1 " + BasicUnit_Name + " duck, thank you for wasting " + BasicUnit_Cost +" of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + BasicUnit_Name + " ducks's is now " + GlobalVariables.BasicUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_BasicUnit_Purchase10_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= (BasicUnit_Cost * 10))
            {
                GlobalVariables.Coins = GlobalVariables.Coins - (BasicUnit_Cost * 10);
                GlobalVariables.BasicUnit_Count = GlobalVariables.BasicUnit_Count + 10;

                MessageBox.Show("You have now recived 10 " + BasicUnit_Name + " ducks, thank you for wasting " + (BasicUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + BasicUnit_Name + " ducks's is now " + GlobalVariables.BasicUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_RangeUnit_Purchase1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= RangeUnit_Cost)
            {
                GlobalVariables.Coins = GlobalVariables.Coins - RangeUnit_Cost;
                GlobalVariables.RangeUnit_Count++;

                MessageBox.Show("You have now recived 1 " + RangeUnit_Name + " duck, thank you for wasting " + RangeUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + RangeUnit_Name + " ducks's is now " + GlobalVariables.RangeUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_RangeUnit_Purchase10_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= (RangeUnit_Cost * 10))
            {
                GlobalVariables.Coins = GlobalVariables.Coins - (RangeUnit_Cost * 10);
                GlobalVariables.RangeUnit_Count = GlobalVariables.RangeUnit_Count + 10;

                MessageBox.Show("You have now recived 10 " + RangeUnit_Name + " ducks, thank you for wasting " + (RangeUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + RangeUnit_Name + " ducks's is now " + GlobalVariables.RangeUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_MagicUnit_Purchase1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= BasicUnit_Cost)
            {
                GlobalVariables.Coins = GlobalVariables.Coins - MagicUnit_Cost;
                GlobalVariables.MagicUnit_Count++;

                MessageBox.Show("You have now recived 1 " + MagicUnit_Name + " duck, thank you for wasting " + MagicUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + MagicUnit_Name + " ducks's is now " + GlobalVariables.MagicUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_MagicUnit_Purchase10_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= (MagicUnit_Cost * 10))
            {
                GlobalVariables.Coins = GlobalVariables.Coins - (MagicUnit_Cost * 10);
                GlobalVariables.MagicUnit_Count = GlobalVariables.MagicUnit_Count + 10;

                MessageBox.Show("You have now recived 10 " + MagicUnit_Name + " ducks, thank you for wasting " + (MagicUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + MagicUnit_Name + " ducks's is now " + GlobalVariables.MagicUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GunUnit_Purchase1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= BasicUnit_Cost)
            {
                GlobalVariables.Coins = GlobalVariables.Coins - GunUnit_Cost;
                GlobalVariables.GunUnit_Count++;

                MessageBox.Show("You have now recived 1 " + GunUnit_Name + " duck, thank you for wasting " + GunUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GunUnit_Name + " ducks's is now " + GlobalVariables.GunUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GunUnit_Purchase10_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= (GunUnit_Cost * 10))
            {
                GlobalVariables.Coins = GlobalVariables.Coins - (GunUnit_Cost * 10);
                GlobalVariables.GunUnit_Count = GlobalVariables.GunUnit_Count + 10;

                MessageBox.Show("You have now recived 10 " + GunUnit_Name + " ducks, thank you for wasting " + (GunUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GunUnit_Name + " ducks's is now " + GlobalVariables.GunUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GiantUnit_Purchase1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= GiantUnit_Cost)
            {
                GlobalVariables.Coins = GlobalVariables.Coins - GiantUnit_Cost;
                GlobalVariables.GiantUnit_Count++;

                MessageBox.Show("You have now recived 1 " + GiantUnit_Name + " duck, thank you for wasting " + GiantUnit_Cost + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GiantUnit_Name + " ducks's is now " + GlobalVariables.GiantUnit_Count + ".", "Purchase Successful");
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }

        private void BTN_GiantUnit_Purchase10_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Coins >= (GiantUnit_Cost * 10))
            {
                GlobalVariables.Coins = GlobalVariables.Coins - (GiantUnit_Cost * 10);
                GlobalVariables.GiantUnit_Count = GlobalVariables.GiantUnit_Count + 10;

                MessageBox.Show("You have now recived 10 " + GiantUnit_Name + " ducks, thank you for wasting " + (GiantUnit_Cost * 10) + " of your coins on this unit." + Environment.NewLine + Environment.NewLine + "Your total of " + GiantUnit_Name + " ducks's is now " + GlobalVariables.GiantUnit_Count + ".", "Purchase Successful"); ;
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough coins to purchase this item", "Insufficient funds");
            }
        }
    }
}
