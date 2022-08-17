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
    public partial class Battleground : Form
    {
        public Battleground()
        {
            InitializeComponent();
        }

        private void Battleground_Load(object sender, EventArgs e)
        {
            foreach (string slot in GlobalVariables.SlotContents)
            {
                if (slot == "basic")
                {
                    if (GlobalVariables.UnitUpgrades_Basic == 2) { GlobalVariables.Units.Add(new Unit(0,50,slot,"axe",GlobalVariables.UnitUpgrades_Basic)); }
                    if (GlobalVariables.UnitUpgrades_Basic == 1) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sword", GlobalVariables.UnitUpgrades_Basic)); }
                    else { GlobalVariables.Units.Add(new Unit(0, 50, slot, "spear", GlobalVariables.UnitUpgrades_Basic)); }
                }
                else if (slot == "range")
                {
                    if (GlobalVariables.UnitUpgrades_Range == 2) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "cannon", GlobalVariables.UnitUpgrades_Range)); }
                    if (GlobalVariables.UnitUpgrades_Range == 1) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "catapult", GlobalVariables.UnitUpgrades_Range)); }
                    else { GlobalVariables.Units.Add(new Unit(0, 50, slot, "archer", GlobalVariables.UnitUpgrades_Range)); }
                }
                else if (slot == "magic")
                {
                    if (GlobalVariables.UnitUpgrades_Magic == 2) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sorcerer", GlobalVariables.UnitUpgrades_Magic)); }
                    if (GlobalVariables.UnitUpgrades_Magic == 1) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "wizard", GlobalVariables.UnitUpgrades_Magic)); }
                    else { GlobalVariables.Units.Add(new Unit(0, 50, slot, "magician", GlobalVariables.UnitUpgrades_Magic)); }
                }
                else if (slot == "gun")
                {
                    if (GlobalVariables.UnitUpgrades_Basic == 2) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "axe", GlobalVariables.UnitUpgrades_Basic)); }
                    if (GlobalVariables.UnitUpgrades_Basic == 1) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sword", GlobalVariables.UnitUpgrades_Basic)); }
                    else { GlobalVariables.Units.Add(new Unit(0, 50, slot, "spear", GlobalVariables.UnitUpgrades_Basic)); }
                }
                else if (slot == "giant")
                {
                    if (GlobalVariables.UnitUpgrades_Basic == 2) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "axe", GlobalVariables.UnitUpgrades_Basic)); }
                    if (GlobalVariables.UnitUpgrades_Basic == 1) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sword", GlobalVariables.UnitUpgrades_Basic)); }
                    else { GlobalVariables.Units.Add(new Unit(0, 50, slot, "spear", GlobalVariables.UnitUpgrades_Basic)); }
                }
            }
        }

        private void Destroy_All_Units()
        {
            foreach (Unit unit in GlobalVariables.Units)
            {
                unit.Unit_Destroy();
            }

            foreach (Enemy_Unit unit in GlobalVariables.Enemy_Units)
            {
                unit.Enemy_Unit_Destroy();
            }
        }
    }
}
