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
        int SpawnX, SpawnY, SpawnGap, SlotGap, MaxX;
        int ESpawnX, ESpawnY, ESpawnGap, ETypeGap, EMinX;

        public Battleground()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battleground, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battle, new object[] { true });
        }

        private void Battleground_Load(object sender, EventArgs e)
        {
            //------------------------------------------------------------//
            //-------------------- Prep players units --------------------//
            //------------------------------------------------------------//

            GlobalVariables.Units.Clear();

            SpawnGap = 20;
            SlotGap = 100;

            SpawnX = 0;
            SpawnY = 0;
            MaxX = 10000;

            for (int slot = 4; slot >= 0; slot--)
            {
                if (GlobalVariables.SlotContents[slot] == "basic")
                {
                    if (GlobalVariables.UnitUpgrades_Basic == 2)
                    {
                        if (GlobalVariables.BasicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "axe", GlobalVariables.UnitUpgrades_Basic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.BasicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "axe", GlobalVariables.UnitUpgrades_Basic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Basic == 1)
                    {
                        if (GlobalVariables.BasicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sword", GlobalVariables.UnitUpgrades_Basic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.BasicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sword", GlobalVariables.UnitUpgrades_Basic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        if (GlobalVariables.BasicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "spear", GlobalVariables.UnitUpgrades_Basic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.BasicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "spear", GlobalVariables.UnitUpgrades_Basic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "range")
                {
                    if (GlobalVariables.UnitUpgrades_Range == 2)
                    {
                        if (GlobalVariables.RangeUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "cannon", GlobalVariables.UnitUpgrades_Range, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "cannon", GlobalVariables.UnitUpgrades_Range, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Range == 1)
                    {
                        if (GlobalVariables.RangeUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "catapult", GlobalVariables.UnitUpgrades_Range, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "catapult", GlobalVariables.UnitUpgrades_Range, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        if (GlobalVariables.RangeUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "archer", GlobalVariables.UnitUpgrades_Range, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "archer", GlobalVariables.UnitUpgrades_Range, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "magic")
                {
                    if (GlobalVariables.UnitUpgrades_Magic == 2)
                    {
                        if (GlobalVariables.MagicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sorcerer", GlobalVariables.UnitUpgrades_Magic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sorcerer", GlobalVariables.UnitUpgrades_Magic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Magic == 1)
                    {
                        if (GlobalVariables.MagicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "wizard", GlobalVariables.UnitUpgrades_Magic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "wizard", GlobalVariables.UnitUpgrades_Magic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        if (GlobalVariables.MagicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "magician", GlobalVariables.UnitUpgrades_Magic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "magician", GlobalVariables.UnitUpgrades_Magic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "gun")
                {
                    if (GlobalVariables.UnitUpgrades_Gun == 2)
                    {
                        if (GlobalVariables.GunUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sniper", GlobalVariables.UnitUpgrades_Gun, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sniper", GlobalVariables.UnitUpgrades_Gun, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Gun == 1)
                    {
                        if (GlobalVariables.GunUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "gunner", GlobalVariables.UnitUpgrades_Gun, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "gunner", GlobalVariables.UnitUpgrades_Gun, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        if (GlobalVariables.GunUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "agent", GlobalVariables.UnitUpgrades_Gun, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "agent", GlobalVariables.UnitUpgrades_Gun, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "giant")
                {
                    if (GlobalVariables.UnitUpgrades_Giant == 2)
                    {
                        if (GlobalVariables.GiantUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "buff", GlobalVariables.UnitUpgrades_Giant, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "buff", GlobalVariables.UnitUpgrades_Giant, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Giant == 1)
                    {
                        if (GlobalVariables.GiantUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "tall", GlobalVariables.UnitUpgrades_Giant, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "tall", GlobalVariables.UnitUpgrades_Giant, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        if (GlobalVariables.GiantUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "stacked", GlobalVariables.UnitUpgrades_Giant, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "stacked", GlobalVariables.UnitUpgrades_Giant, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }

                SpawnX = SpawnX + SlotGap;

                SpawnY = SpawnY + 20;
            }

            PNL_Battle.Size = new Size(PNL_Battle.Width + SpawnX, PNL_Battle.Height);
            PNL_Battle.Location = new Point(PNL_Battle.Location.X - SpawnX, PNL_Battle.Location.Y);
            foreach (Unit unit in GlobalVariables.Units) { unit.Max_X = PNL_Battle.Width - 120; }

            //------------------------------------------------------------//
            //--------------------- Prep enemy units ---------------------//
            //------------------------------------------------------------//

            GlobalVariables.Enemy_Units.Clear();

            ESpawnX = PNL_Battle.Width - 150;
            ESpawnY = 80;
            ESpawnGap = 20;
            ETypeGap = 100;
            EMinX = PNL_Battle.Width - this.Width;

            GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "small", 1, EMinX));

            //------------------------------------------------------------//
            //------------------------ Start Game ------------------------//
            //------------------------------------------------------------//

            PNL_Battle.Invalidate();

            //TMR_Battle.Enabled = true;
            //TMR_Controls.Enabled = true;
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

        private void TMR_Battle_Tick(object sender, EventArgs e)
        {
            foreach(Unit unit in GlobalVariables.Units)
            {
                unit.Move_Unit();
            }

            foreach (Enemy_Unit unit in GlobalVariables.Enemy_Units)
            {
                unit.Move_Enemy_Unit();
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

            foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
            {
                Eunit.Draw_Enemy_Unit(e.Graphics);
            }
        }
    }
}
