using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Get_EUnit_Info
    {
        //creates a Constructor with 5 overloads | name, damage, health, attack_speed, range
        public Get_EUnit_Info(string name, int damage, int health, int attack_speed, string range)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Attack_Speed = attack_speed;
            Range = range;
        }

        //set properties so we can access the name, damage, health, attack speed, and range values
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Attack_Speed { get; set; }
        public string Range { get; set; }
    }
}
