using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Level
    {
        public int level;
        public bool AllowSmall, AllowBig, AllowGlass, AllowBottle;
        public int[] SmallRange = new int[2];
        public int[] BigRange = new int[2];
        public int[] GlassRange = new int[2];
        public int[] BottleRange = new int[2];
        public bool BossLevel;
        public string BossName;

        public int ESpawnX, ESpawnY, ESpawnGap, ETypeGap, ETypeGapY, EMinX;
        public int SpawnX, SpawnY, SpawnGap, SlotGap, MaxX;

        Random random = new Random();

        public Level (int LevelNum)
        {
            level = LevelNum;
            foreach (Get_Level_Info i in GlobalVariables.Level_Info)
            {
                if (i.Level == level)
                {

                    if (i.AllowSmall == "yes") { AllowSmall = true; }
                    else { AllowSmall = false; }

                    if (i.AllowBig == "yes") { AllowBig = true; }
                    else { AllowBig = false; }

                    if (i.AllowGlass == "yes") { AllowGlass = true; }
                    else { AllowGlass = false; }

                    if (i.AllowBottle == "yes") { AllowBottle = true; }
                    else { AllowBottle = false; }

                    if (i.Boss == "none" || i.Boss == "") { BossLevel = false; }
                    else { BossLevel = true; BossName = i.Boss; }

                    var Values1 = i.SmallRange.Split('-');
                    SmallRange[0] = int.Parse(Values1[0]);
                    SmallRange[1] = int.Parse(Values1[1]);

                    var Values2 = i.BigRange.Split('-');
                    BigRange[0] = int.Parse(Values2[0]);
                    BigRange[1] = int.Parse(Values2[1]);

                    var Values3 = i.GlassRange.Split('-');
                    GlassRange[0] = int.Parse(Values3[0]);
                    GlassRange[1] = int.Parse(Values3[1]);

                    var Values4 = i.BottleRange.Split('-');
                    BottleRange[0] = int.Parse(Values4[0]);
                    BottleRange[1] = int.Parse(Values4[1]);
                }
            }
        }

        public void Spawn_Players_Units (int StartX, int StartY, int spawnGap, int slotGap, int maxX)
        {
            SpawnX = StartX;
            SpawnY = StartY;
            SpawnGap = spawnGap;
            SlotGap = slotGap;
            MaxX = maxX;

            GlobalVariables.Units.Clear();

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
        }

        public void Spawn_Enemy_Units(int StartX, int StartY, int SpawnGap, int TypeGap, int MinX)
        {
            ESpawnX = StartX;
            ESpawnY = StartY;
            ESpawnGap = SpawnGap;
            ETypeGap = TypeGap;
            ETypeGapY = 20;
            EMinX = MinX;

            GlobalVariables.Enemy_Units.Clear();

            if (AllowSmall == true)
            {
                int SpawnNum = random.Next(SmallRange[0], SmallRange[1]);

                if (SpawnNum > 10)
                {
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "small", 10, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "small", 1, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                ESpawnX = ESpawnX + ETypeGap;
                ESpawnY = ESpawnY - ETypeGapY;
            }

            if (AllowBig == true)
            {
                int SpawnNum = random.Next(BigRange[0], BigRange[1]);

                if (SpawnNum > 10)
                {
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "big", 10, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "big", 1, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                ESpawnX = ESpawnX + ETypeGap;
                ESpawnY = ESpawnY - (ETypeGapY * 2);
            }

            if (AllowGlass == true)
            {
                int SpawnNum = random.Next(GlassRange[0], GlassRange[1]);

                if (SpawnNum > 10)
                {
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "glass", 10, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "glass", 1, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                ESpawnX = ESpawnX + ETypeGap;
                ESpawnY = ESpawnY + ETypeGapY;
            }

            if (AllowBottle == true)
            {
                int SpawnNum = random.Next(BottleRange[0], BottleRange[1]);

                if (SpawnNum > 10)
                {
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "bottle", 10, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "bottle", 1, EMinX));
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                ESpawnX = ESpawnX + ETypeGap;
                ESpawnY = ESpawnY + (ETypeGapY * 2);
            }

            if (BossLevel == true)
            {
                GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, BossName, 1, EMinX));
            }

            GlobalVariables.Enemy_Units.Reverse();
        }

        public void ReAjust_Unit_MinXMaxX(int Unit_MaxX, int EUnit_MinX)
        {
            MaxX = Unit_MaxX;
            EMinX = EUnit_MinX;

            foreach (Unit unit in GlobalVariables.Units) { unit.Max_X = MaxX; }
            foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units) { Eunit.Min_X = EMinX; }
        }

        public void EndLevel()
        {
            foreach (Unit unit in GlobalVariables.Units)
            {
                unit.Unit_Destroy();
                break;
            }

            foreach (Enemy_Unit unit in GlobalVariables.Enemy_Units)
            {
                unit.Enemy_Unit_Destroy();
                break;
            }
        }
    }
}
