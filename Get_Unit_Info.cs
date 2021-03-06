using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    class Get_Unit_Info
    {
        //creates a Constructor with 6 overloads | name, damage, health, attack_speed, range, abilitys
        public Get_Unit_Info(string name, int damage, int health, int attack_speed, string range, string abilities)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Attack_Speed = attack_speed;
            Range = range;
            Abilities = abilities;
        }

        //set properties so we can access the name and score
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Attack_Speed { get; set; }
        public string Range { get; set; }
        public string Abilities { get; set; }
    }
}
