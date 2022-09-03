using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Get_Level_Info
    {
        public Get_Level_Info(int level, string allowSmall, string smallRange, string allowBig, string bigRange, string allowGlass, string glassRange, string allowBottle, string bottleRange, string bossLevel)
        {
            Level = level;
            AllowSmall = allowSmall;
            SmallRange = smallRange;
            AllowBig = allowBig;
            BigRange = bigRange;
            AllowGlass = allowGlass;
            GlassRange = glassRange;
            AllowBottle = allowBottle;
            BottleRange = bottleRange;
            BossLevel = bossLevel;
        }

        public int Level { get; set; }
        public string AllowSmall { get; set; }
        public string SmallRange { get; set; }
        public string AllowBig { get; set; }
        public string BigRange { get; set; }
        public string AllowGlass { get; set; }
        public string GlassRange { get; set; }
        public string AllowBottle { get; set; }
        public string BottleRange { get; set; }
        public string BossLevel { get; set; }
    }
}
