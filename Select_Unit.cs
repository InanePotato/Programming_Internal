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
        public Select_Unit(int EditingSlot)
        {
            InitializeComponent();
        }

        private void Select_Unit_Load(object sender, EventArgs e)
        {
            PIC_Basic.Image = GlobalVariables.Basic_Ducks[GlobalVariables.UnitUpgrades_Basic];
            PIC_Range.Image = GlobalVariables.Range_Ducks[GlobalVariables.UnitUpgrades_Range];
            PIC_Magic.Image = GlobalVariables.Magic_Ducks[GlobalVariables.UnitUpgrades_Magic];
            PIC_Gun.Image = GlobalVariables.Gun_Ducks[GlobalVariables.UnitUpgrades_Gun];
            PIC_Giant.Image = GlobalVariables.Giant_Ducks[GlobalVariables.UnitUpgrades_Giant];

            if (GlobalVariables.UnitUpgrades_Basic == 2) { lbl_BasicName.Text = "Axe Duck"; }
            else if (GlobalVariables.UnitUpgrades_Basic == 1) { lbl_BasicName.Text = "Sword Duck"; }
            else { lbl_BasicName.Text = "Spear Duck"; }

            BTN_SelectBasic.Enabled = GlobalVariables.BasicUnitUnlocked;
            BTN_SelectRange.Enabled = GlobalVariables.RangeUnitUnlocked;
            BTN_SelectMagic.Enabled = GlobalVariables.MagicUnitUnlocked;
            BTN_SelectGun.Enabled = GlobalVariables.GunUnitUnlocked;
            BTN_SelectGiant.Enabled = GlobalVariables.GiantUnitUnlocked;
        }

        private void BTN_SelectBasic_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SelectRange_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SelectMagic_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SelectGun_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SelectGiant_Click(object sender, EventArgs e)
        {

        }
    }
}
