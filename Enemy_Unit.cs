using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Enemy_Unit
    {
        public int x, y;
        public int width, height = 100;
        public Image Unit_Image;
        public Rectangle UnitRec;
        public string Unit_Name;
        public int Health, Damage, Attack_Speed, Unit_Level;
        public bool Range;
        public int Range_Distance = 200;
        public Unit UnitTarget;
        public int Multiplier;

        public Enemy_Unit(int X, int Y, string Name, int Multiplier)
        {
            x = X;
            y = Y;
            Unit_Name = Name;
        }

        public void Draw_Enemy_Unit(Graphics g)
        {
            UnitRec = new Rectangle(x, y, width, height);
            g.DrawImage(Unit_Image, UnitRec);
        }

        public void Move_Enemy_Unit(Graphics g)
        {

            Draw_Enemy_Unit(g);
        }

        public void Damage_Enemy_Unit(int damage)
        {
            Health = Health - damage;

            if (Health <= 0)
            {
                Enemy_Unit_Destroy();
            }
        }

        public void Attack_Unit()
        {
            foreach (Unit Unit in GlobalVariables.Units)
            {
                if (UnitTarget == null) { UnitTarget.UnitRec = Unit.UnitRec; }
                else
                {
                    if (Unit.UnitRec.Location.X - x < UnitTarget.UnitRec.Location.X - x)
                    {
                        UnitTarget = Unit;
                    }
                }
            }

            UnitTarget.Unit_Damage(Damage);
        }

        public void Enemy_Unit_Destroy()
        {
            GlobalVariables.Enemy_Units.Remove(this);
        }
    }
}
