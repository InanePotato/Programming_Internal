using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    class Get_Unit_Info
    {
        //creates a Constructor with 7 overloads | name, damage, health, attack_speed, range, abilitys, cost
        public Get_Unit_Info(string name, int damage, int health, int attack_speed, string range, string abilities, int cost)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Attack_Speed = attack_speed;
            Range = range;
            Abilities = abilities;
            Cost = cost;
        }

        //set properties so we can access the name, damage, health, attack_speed, range, abilitys, and cost values
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Attack_Speed { get; set; }
        public string Range { get; set; }
        public string Abilities { get; set; }
        public int Cost { get; set; }
    }
}
