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
        public bool BossLevel;
        public int MaxEUnits;
        public int MinEUnits;

        public Level (int LevelNum)
        {
            level = LevelNum;

        }
    }
}
