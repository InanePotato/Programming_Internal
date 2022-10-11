using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Level
    {
        //----------------------------------------------//
        // Declares public variables used in this class //
        //----------------------------------------------//
        public int level; // used to tell what level is being loaded and played
        public bool AllowSmall, AllowBig, AllowGlass, AllowBottle; // used to tell what enmemy units will spawn during the level
        public int[] SmallRange = new int[2]; // used to tell the max and min range of the random ammount of small units that will spawn during the round
        public int[] BigRange = new int[2]; // used to tell the max and min range of the random ammount of big units that will spawn during the round
        public int[] GlassRange = new int[2]; // used to tell the max and min range of the random ammount of glass units that will spawn during the round
        public int[] BottleRange = new int[2]; // used to tell the max and min range of the random ammount of bottle units that will spawn during the round
        public bool BossLevel; // used to tell if the level is a boss level
        public string BossName; // used to tell what boss is spawned (if any)

        public int ESpawnX, ESpawnY, ESpawnGap, ETypeGap, ETypeGapY, EMinX; // used for spawning in the enemy units
        public int SpawnX, SpawnY, SpawnGap, SlotGap, MaxX; // used for spawning in the players units

        Random random = new Random(); // used (along with the ranges) to randimize how much units that will spawn in the battle

        // when a new instance of the leel class is created, it requires a level number to be inputted
        public Level (int LevelNum)
        {
            // sets the level variable to the inputted value
            level = LevelNum;

            // goes through all the information in the global level info list,
            // this gets all the information about everything that will spawn during the level
            foreach (Get_Level_Info i in GlobalVariables.Level_Info)
            {
                // finds the level number in the list
                if (i.Level == level)
                {
                    // checks what enemy units will be spawning during the level
                    if (i.AllowSmall == "yes") { AllowSmall = true; }
                    else { AllowSmall = false; }

                    if (i.AllowBig == "yes") { AllowBig = true; }
                    else { AllowBig = false; }

                    if (i.AllowGlass == "yes") { AllowGlass = true; }
                    else { AllowGlass = false; }

                    if (i.AllowBottle == "yes") { AllowBottle = true; }
                    else { AllowBottle = false; }

                    // checks if a boss will spawn in the level, and if so then what boss it is
                    if (i.Boss == "none" || i.Boss == "") { BossLevel = false; }
                    else { BossLevel = true; BossName = i.Boss; }

                    // gets the min and max ranges of each enemy units spawning
                    // the min and max in the range are used in the random number generator to help provide
                    // some inconsistancy to the level
                    var Values1 = i.SmallRange.Split('-'); // splits the single string into 2 by the - between the numbers
                    SmallRange[0] = int.Parse(Values1[0]); // sets the small units spawn range to the newly split numbers
                    SmallRange[1] = int.Parse(Values1[1]); // sets the small units spawn range to the newly split numbers

                    var Values2 = i.BigRange.Split('-'); // splits the single string into 2 by the - between the numbers
                    BigRange[0] = int.Parse(Values2[0]); // sets the big units spawn range to the newly split numbers
                    BigRange[1] = int.Parse(Values2[1]); // sets the big units spawn range to the newly split numbers

                    var Values3 = i.GlassRange.Split('-'); // splits the single string into 2 by the - between the numbers
                    GlassRange[0] = int.Parse(Values3[0]); // sets the glass units spawn range to the newly split numbers
                    GlassRange[1] = int.Parse(Values3[1]); // sets the glass units spawn range to the newly split numbers

                    var Values4 = i.BottleRange.Split('-'); // splits the single string into 2 by the - between the numbers
                    BottleRange[0] = int.Parse(Values4[0]); // sets the bottle units spawn range to the newly split numbers
                    BottleRange[1] = int.Parse(Values4[1]); // sets the bottle units spawn range to the newly split numbers
                }
            }
        }

        // when this method is called it requires a startx an y, spawn gap, slot gap, and max x
        // this method is in charge of spawning in all the players duck units into the level
        public void Spawn_Players_Units (int StartX, int StartY, int spawnGap, int slotGap, int maxX)
        {
            SpawnX = StartX; // sets the spawn x variable using the inputted value
            SpawnY = StartY; // stes the spawn y variable using the inputted value
            SpawnGap = spawnGap; // sets the spawn gap variable using the inputted value
            SlotGap = slotGap; // sets the slot gap variable using the inputted value
            MaxX = maxX; // sets the max x variable using the inputted value

            // clears all the players units in the global player units list
            GlobalVariables.Units.Clear();

            // goes through all the players slots
            for (int slot = 4; slot >= 0; slot--)
            {
                // checks what the slot contains
                if (GlobalVariables.SlotContents[slot] == "basic")
                {
                    // if it contains basic units, checks what level basic units they are
                    if (GlobalVariables.UnitUpgrades_Basic == 2)
                    {
                        // if they are level 2 basic units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.BasicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "axe", GlobalVariables.UnitUpgrades_Basic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.BasicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "axe", GlobalVariables.UnitUpgrades_Basic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Basic == 1)
                    {
                        // if they are level 1 basic units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.BasicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sword", GlobalVariables.UnitUpgrades_Basic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.BasicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sword", GlobalVariables.UnitUpgrades_Basic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        // if they are level 0 basic units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.BasicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "spear", GlobalVariables.UnitUpgrades_Basic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.BasicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "spear", GlobalVariables.UnitUpgrades_Basic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "range")
                {
                    // if it contains range units, checks what level range units they are
                    if (GlobalVariables.UnitUpgrades_Range == 2)
                    {
                        // if they are level 2 range units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.RangeUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "cannon", GlobalVariables.UnitUpgrades_Range, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "cannon", GlobalVariables.UnitUpgrades_Range, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Range == 1)
                    {
                        // if they are level 1 range units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.RangeUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "catapult", GlobalVariables.UnitUpgrades_Range, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "catapult", GlobalVariables.UnitUpgrades_Range, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        // if they are level 0 range units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.RangeUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "archer", GlobalVariables.UnitUpgrades_Range, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.RangeUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "archer", GlobalVariables.UnitUpgrades_Range, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "magic")
                {
                    // if the slot contains magic units, checks what level they are
                    if (GlobalVariables.UnitUpgrades_Magic == 2)
                    {
                        // if they are level 2 magic units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.MagicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sorcerer", GlobalVariables.UnitUpgrades_Magic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sorcerer", GlobalVariables.UnitUpgrades_Magic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Magic == 1)
                    {
                        // if they are level 1 magic units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.MagicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "wizard", GlobalVariables.UnitUpgrades_Magic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "wizard", GlobalVariables.UnitUpgrades_Magic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        // if they are level 0 magic units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.MagicUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "magician", GlobalVariables.UnitUpgrades_Magic, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.MagicUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "magician", GlobalVariables.UnitUpgrades_Magic, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "gun")
                {
                    // if the slot contains gun units, checks what level they are
                    if (GlobalVariables.UnitUpgrades_Gun == 2)
                    {
                        // if they are level 2 gun units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.GunUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sniper", GlobalVariables.UnitUpgrades_Gun, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "sniper", GlobalVariables.UnitUpgrades_Gun, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Gun == 1)
                    {
                        // if they are level 1 gun units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.GunUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "gunner", GlobalVariables.UnitUpgrades_Gun, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "gunner", GlobalVariables.UnitUpgrades_Gun, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        // if they are level 0 gun units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.GunUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "agent", GlobalVariables.UnitUpgrades_Gun, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GunUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "agent", GlobalVariables.UnitUpgrades_Gun, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }
                else if (GlobalVariables.SlotContents[slot] == "giant")
                {
                    // if the slot contains giant units, checks what level they are
                    if (GlobalVariables.UnitUpgrades_Giant == 2)
                    {
                        // if they are level 2 giant units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.GiantUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "buff", GlobalVariables.UnitUpgrades_Giant, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "buff", GlobalVariables.UnitUpgrades_Giant, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    if (GlobalVariables.UnitUpgrades_Giant == 1)
                    {
                        // if they are level 1 giant units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.GiantUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "tall", GlobalVariables.UnitUpgrades_Giant, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "tall", GlobalVariables.UnitUpgrades_Giant, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                    else
                    {
                        // if they are level 0 giant units, spawn in each unit (if there are more than 10 then spawns them in in groups of 10)
                        if (GlobalVariables.GiantUnit_Count <= 10) { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "stacked", GlobalVariables.UnitUpgrades_Giant, 1, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                        else { for (int i = 0; i < (GlobalVariables.GiantUnit_Count / 10); i++) { GlobalVariables.Units.Add(new Unit(SpawnX, SpawnY, GlobalVariables.SlotContents[slot], "stacked", GlobalVariables.UnitUpgrades_Giant, 10, MaxX)); SpawnX = SpawnX + SpawnGap; } }
                    }
                }

                // after the whole slot has been drawn, add a gap between the slots to the spawn x
                SpawnX = SpawnX + SlotGap;
                // and, have the next slot be drawn lower.
                SpawnY = SpawnY + 20;
            }
        }

        // whenever this method is called, it requires a start x and y, spawn gap, type gap, and min x
        // this method is in charge of spawning all of the enemy lemon units into the level
        public void Spawn_Enemy_Units(int StartX, int StartY, int SpawnGap, int TypeGap, int MinX)
        {
            ESpawnX = StartX; // sets the enemy spawn x to the value given
            ESpawnY = StartY; // sets the enemy spawn y to the value given
            ESpawnGap = SpawnGap; // sets the enemy spawn gap to the value given
            ETypeGap = TypeGap; // sets the enemy x type gap to the value given
            ETypeGapY = 20; // sets the enemy y type gap to a set value
            EMinX = MinX; // sets the enemy minimux x to the value given

            // clears all the enemy units in the global enemy unit list
            GlobalVariables.Enemy_Units.Clear();

            // spawn in all the levels enemy units in order of weakest to strongest (small, big, glass, bottle, boss)

            // checks if small units are suposed to be spawned into this level
            if (AllowSmall == true)
            {
                // if small units are a part of this level,
                // get a random number of small units to spawn (using the levels range from earlier)
                int SpawnNum = random.Next(SmallRange[0], SmallRange[1]);

                // if there are more than 10 small units bunches them into groups of 10, otherwise spawns them individually
                if (SpawnNum > 10)
                {
                    // if there are more then 10, repeats the correct ammount of times
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 10, this means that this 1 unit represents 10)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "small", 10, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    // otherwise there must be less than 10, so repeats the ammount of times as to how many small units there are
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 1, this means that they represent individual units)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "small", 1, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                // adds the x type gap onto the spawn x variable
                ESpawnX = ESpawnX + ETypeGap;
                // adds the y type gap onto the spawn y variable
                ESpawnY = ESpawnY - ETypeGapY;
            }

            // checks if big units are suposed to be spawned into this level
            if (AllowBig == true)
            {
                // if big units are a part of this level,
                // get a random number of big units to spawn (using the levels range from earlier)
                int SpawnNum = random.Next(BigRange[0], BigRange[1]);

                // if there are more than 10 big units bunches them into groups of 10, otherwise spawns them individually
                if (SpawnNum > 10)
                {
                    // if there are more then 10, repeats the correct ammount of times
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 10, this means that this 1 unit represents 10)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "big", 10, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    // otherwise there must be less than 10, so repeats the ammount of times as to how many big units there are
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 1, this means that they represent individual units)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "big", 1, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                // adds the x type gap onto the spawn x variable
                ESpawnX = ESpawnX + ETypeGap;
                // adds the y type gap onto the spawn y variable
                ESpawnY = ESpawnY - (ETypeGapY * 2);
            }

            // checks if glass units are suposed to be spwned into this level
            if (AllowGlass == true)
            {
                // if glass units are a part of this level,
                // get a random number of glass units to spawn (using the levels range from earlier)
                int SpawnNum = random.Next(GlassRange[0], GlassRange[1]);

                // if there are more than 10 glass units bunches them into groups of 10, otherwise spawns them individually
                if (SpawnNum > 10)
                {
                    // if there are more then 10, repeats the correct ammount of times
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 10, this means that this 1 unit represents 10)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "glass", 10, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    // otherwise there must be less than 10, so repeats the ammount of times as to how many glass units there are
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 1, this means that they represent individual units)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "glass", 1, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                // adds the x type gap onto the spawn x variable
                ESpawnX = ESpawnX + ETypeGap;
                // adds the y type gap onto the spawn y variable
                ESpawnY = ESpawnY + ETypeGapY;
            }

            // checks if bottle units are suposed to be spawned into this level
            if (AllowBottle == true)
            {
                // if bottle units are a part of this level,
                // get a random number of bottle units to spawn (using the levels range from earlier)
                int SpawnNum = random.Next(BottleRange[0], BottleRange[1]);

                // if there are more than 10 bottle units bunches them into groups of 10, otherwise spawns them individually
                if (SpawnNum > 10)
                {
                    // if there are more then 10, repeats the correct ammount of times
                    for (int i = (SpawnNum / 10); i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 10, this means that this 1 unit represents 10)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "bottle", 10, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }
                else
                {
                    // otherwise there must be less than 10, so repeats the ammount of times as to how many bottle units there are
                    for (int i = SpawnNum; i > 0; i--)
                    {
                        // adds a enemy unit to the global enemy units list
                        // (gives the enemy unit a multiplier value of 1, this means that they represent individual units)
                        GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, "bottle", 1, EMinX));
                        // adds the spawn gap onto the enemy spawn variable
                        ESpawnX = ESpawnX + ESpawnGap;
                    }
                }

                // adds the x type gap onto the spawn x variable
                ESpawnX = ESpawnX + ETypeGap;
                // adds the y type gap onto the spawn y variable
                ESpawnY = ESpawnY + (ETypeGapY * 2);
            }

            // checks if a boss is spuosed to spawn in this level
            if (BossLevel == true)
            {
                // if so, then adds a enemy unit to the gloal enemy units list
                // uses the boss's name found during the creation of this unstance of the class
                GlobalVariables.Enemy_Units.Add(new Enemy_Unit(ESpawnX, ESpawnY, BossName, 1, EMinX));
            }

            // once all the enemy units have been added to the list, reverses the order of them in the list
            // this meand, that when it comes to drawing them, the units at the back of the group will be behind everything else
            GlobalVariables.Enemy_Units.Reverse();
        }

        // when this method is called upon, it requires a unit max x, and enemy unit min x value
        // this method re-adjusts the min and max x locations after the panel the units will be drawn in is resized
        public void ReAjust_Unit_MinXMaxX(int Unit_MaxX, int EUnit_MinX)
        {
            MaxX = Unit_MaxX; // sets the max x variable to the given value
            EMinX = EUnit_MinX; // sets the enemy min x variable to the given value

            // goes through all the players units and gives them the new max x
            foreach (Unit unit in GlobalVariables.Units) { unit.Max_X = MaxX; }
            // goes through all the enemy untis and gives them the new min x
            foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units) { Eunit.Min_X = EMinX; }
        }

        // this method is in charge of removing all the units from the global unit and enemy units lists at the end of the level/battle
        public void EndLevel()
        {
            // goes through all the units in the global units list
            foreach (Unit unit in GlobalVariables.Units)
            {
                // calls on the units destroy method
                unit.Unit_Destroy();
                break;
            }

            // goes through all the enemy units in the global enemy units list
            foreach (Enemy_Unit unit in GlobalVariables.Enemy_Units)
            {
                // calls on the enemy units destroy method
                unit.Enemy_Unit_Destroy();
                break;
            }
        }
    }
}
