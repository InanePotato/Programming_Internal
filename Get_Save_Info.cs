using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Get_Save_Info
    {
        public Get_Save_Info(string name, int coins, int levels_unlocked, string slot1_contents, string slot2_contents, string slot3_contents, string slot4_contents, string slot5_contents, bool basic_unocked, int basic_count, int basic_level, bool range_unlocked, int range_count, int range_level, bool magic_unlocked, int magic_count, int magic_level, bool gun_unlocked, int gun_count, int gun_level, bool giant_unlocked, int giant_count, int giant_level)
        {
            Name = name;
            Coins = coins;
            Levels_Unlocked = levels_unlocked;
            Slot1_Contents = slot1_contents;
            Slot2_Contents = slot2_contents;
            Slot3_Contents = slot3_contents;
            Slot4_Contents = slot4_contents;
            Slot5_Contents = slot5_contents;
            Basic_Unlocked = basic_unocked;
            Basic_Count = basic_count;
            Basic_Level = basic_level;
            Range_Unlocked = range_unlocked;
            Range_Count = range_count;
            Range_Level = range_level;
            Magic_Unlocked = magic_unlocked;
            Magic_Count = magic_count;
            Magic_Level = magic_level;
            Gun_Unlocked = gun_unlocked;
            Gun_Count = gun_count;
            Gun_Level = gun_level;
            Giant_Unlocked = giant_unlocked;
            Giant_Count = giant_count;
            Giant_Level = giant_level;
        }

        public string Name { get; set; }
        public int Coins { get; set; }
        public int Levels_Unlocked { get; set; }
        public string Slot1_Contents { get; set; }
        public string Slot2_Contents { get; set; }
        public string Slot3_Contents { get; set; }
        public string Slot4_Contents { get; set; }
        public string Slot5_Contents { get; set; }
        public bool Basic_Unlocked { get; set; }
        public int Basic_Count { get; set; }
        public int Basic_Level { get; set; }
        public bool Range_Unlocked { get; set; }
        public int Range_Count { get; set; }
        public int Range_Level { get; set; }
        public bool Magic_Unlocked { get; set; }
        public int Magic_Count { get; set; }
        public int Magic_Level { get; set; }
        public bool Gun_Unlocked { get; set; }
        public int Gun_Count { get; set; }
        public int Gun_Level { get; set; }
        public bool Giant_Unlocked { get; set; }
        public int Giant_Count { get; set; }
        public int Giant_Level { get; set; }
    }
}
