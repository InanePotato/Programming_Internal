using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Get_Level_Info
    {
        public Get_Level_Info(int level, string allowSmall, string allowBig, string allowGlass, string allowBottle, string bossLevel, int maxEUnits, int minEUnits)
        {
            Level = level;
            AllowSmall = allowSmall;
            AllowBig = allowBig;
            AllowGlass = allowGlass;
            AllowBottle = allowBottle;
            BossLevel = bossLevel;
            MaxEUnits = maxEUnits;
            MinEUnits = minEUnits;
        }

        public int Level { get; set; }
        public string AllowSmall { get; set; }
        public string AllowBig { get; set; }
        public string AllowGlass { get; set; }
        public string AllowBottle { get; set; }
        public string BossLevel { get; set; }
        public int MaxEUnits { get; set; }
        public int MinEUnits { get; set; }
    }
}
