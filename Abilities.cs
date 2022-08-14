using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Abilities
    {
        public Abilities(string ability, int chance)
        {
            Ability = ability;
            Chance = chance;
        }

        public string Ability { get; set; }
        public int Chance { get; set; }
    }
}
