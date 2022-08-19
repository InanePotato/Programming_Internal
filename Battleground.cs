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
    public partial class Battleground : Form
    {
        public Battleground()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battleground, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battle, new object[] { true });
        }

        private void Battleground_Load(object sender, EventArgs e)
        {
            foreach (string slot in GlobalVariables.SlotContents)
            {
                if (slot == "basic")
                {
                    if (GlobalVariables.UnitUpgrades_Basic == 2)
                    {
                        if (GlobalVariables.BasicUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "axe", GlobalVariables.UnitUpgrades_Basic, 1)); } }
                        else { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "axe", GlobalVariables.UnitUpgrades_Basic, 10)); } }
                    }
                    if (GlobalVariables.UnitUpgrades_Basic == 1)
                    {
                        if (GlobalVariables.BasicUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sword", GlobalVariables.UnitUpgrades_Basic, 1)); } }
                        else { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sword", GlobalVariables.UnitUpgrades_Basic, 10)); } }
                    }
                    else
                    {
                        if (GlobalVariables.BasicUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "spear", GlobalVariables.UnitUpgrades_Basic, 1)); } }
                        else { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "spear", GlobalVariables.UnitUpgrades_Basic, 10)); } }
                    }
                }
                else if (slot == "range")
                {
                    if (GlobalVariables.UnitUpgrades_Range == 2)
                    {
                        if (GlobalVariables.RangeUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "cannon", GlobalVariables.UnitUpgrades_Range, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "cannon", GlobalVariables.UnitUpgrades_Range, 10)); } }
                    }
                    if (GlobalVariables.UnitUpgrades_Range == 1)
                    {
                        if (GlobalVariables.RangeUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "catapult", GlobalVariables.UnitUpgrades_Range, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "catapult", GlobalVariables.UnitUpgrades_Range, 10)); } }
                    }
                    else
                    {
                        if (GlobalVariables.RangeUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "archer", GlobalVariables.UnitUpgrades_Range, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "archer", GlobalVariables.UnitUpgrades_Range, 10)); } }
                    }
                }
                else if (slot == "magic")
                {
                    if (GlobalVariables.UnitUpgrades_Magic == 2)
                    {
                        if (GlobalVariables.MagicUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sorcerer", GlobalVariables.UnitUpgrades_Magic, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sorcerer", GlobalVariables.UnitUpgrades_Magic, 10)); } }
                    }
                    if (GlobalVariables.UnitUpgrades_Magic == 1)
                    {
                        if (GlobalVariables.MagicUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "wizard", GlobalVariables.UnitUpgrades_Magic, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "wizard", GlobalVariables.UnitUpgrades_Magic, 10)); } }
                    }
                    else
                    {
                        if (GlobalVariables.MagicUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "magician", GlobalVariables.UnitUpgrades_Magic, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "magician", GlobalVariables.UnitUpgrades_Magic, 10)); } }
                    }
                }
                else if (slot == "gun")
                {
                    if (GlobalVariables.UnitUpgrades_Gun == 2)
                    {
                        if (GlobalVariables.GunUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sniper", GlobalVariables.UnitUpgrades_Gun, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "sniper", GlobalVariables.UnitUpgrades_Gun, 10)); } }
                    }
                    if (GlobalVariables.UnitUpgrades_Gun == 1)
                    {
                        if (GlobalVariables.GunUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "gunner", GlobalVariables.UnitUpgrades_Gun, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "gunner", GlobalVariables.UnitUpgrades_Gun, 10)); } }
                    }
                    else
                    {
                        if (GlobalVariables.GunUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "agent", GlobalVariables.UnitUpgrades_Gun, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "agent", GlobalVariables.UnitUpgrades_Gun, 10)); } }
                    }
                }
                else if (slot == "giant")
                {
                    if (GlobalVariables.UnitUpgrades_Giant == 2)
                    {
                        if (GlobalVariables.GiantUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "buff", GlobalVariables.UnitUpgrades_Giant, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "buff", GlobalVariables.UnitUpgrades_Giant, 10)); } }
                    }
                    if (GlobalVariables.UnitUpgrades_Giant == 1)
                    {
                        if (GlobalVariables.GiantUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "tall", GlobalVariables.UnitUpgrades_Giant, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "tall", GlobalVariables.UnitUpgrades_Giant, 10)); } }
                    }
                    else
                    {
                        if (GlobalVariables.GiantUnit_Count >= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "stacked", GlobalVariables.UnitUpgrades_Giant, 1)); } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(0, 50, slot, "stacked", GlobalVariables.UnitUpgrades_Giant, 10)); } }
                    }
                }
            }

            //Start_Battle();
            PNL_Battle.Invalidate();
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

        private void Start_Battle()
        {
            TMR_Battle.Enabled = true;
        }

        private void TMR_Battle_Tick(object sender, EventArgs e)
        {
            foreach(Unit unit in GlobalVariables.Units)
            {
                unit.Move_Unit();
            }

            PNL_Battle.Invalidate();
        }

        private void TMR_Controls_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.Paused == true) { TMR_Battle.Enabled = false; }
            else { TMR_Battle.Enabled = true; }
        }

        private void PNL_Battle_Paint(object sender, PaintEventArgs e)
        {
            foreach(Unit unit in GlobalVariables.Units)
            {
                unit.Unit_Draw(e.Graphics);
            }
        }
    }
}
