using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    internal class Unit
    {
        public int x, y;
        public int height = 120;
        public int width = 120;
        public Image Unit_Image;
        public Rectangle UnitRec;
        public Enemy_Unit UnitTarget;
        public string Unit_Type, Unit_Name;
        public int Health, Damage, Attack_Speed, Unit_Level;
        public bool Range;
        public int Range_Distance = 200;
        public int Speed = 10;
        public int Max_X;
        public List<Abilities>abilities = new List<Abilities>();
        public int AttackWaitTicks = 0;

        public Unit(int X, int Y, string Type, string Name, int Level, int Multiplier, int maxX)
        {
            x = X;
            y = Y;
            Unit_Type = Type;
            Unit_Name = Name;
            Unit_Level = Level;
            Max_X = maxX;

            if (Unit_Type == "basic") { Unit_Image = GlobalVariables.Basic_Ducks[Unit_Level]; }
            if (Unit_Type == "range") { Unit_Image = GlobalVariables.Range_Ducks[Unit_Level]; }
            if (Unit_Type == "magic") { Unit_Image = GlobalVariables.Magic_Ducks[Unit_Level]; }
            if (Unit_Type == "gun") { Unit_Image = GlobalVariables.Gun_Ducks[Unit_Level]; }
            if (Unit_Type == "giant") { Unit_Image = GlobalVariables.Giant_Ducks[Unit_Level]; }

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == Unit_Name)
                {
                    Health = i.Health * Multiplier;
                    Damage = i.Damage * Multiplier;
                    Attack_Speed = i.Attack_Speed;

                    if (i.Range == "yes") { Range = true; }
                    else { Range = false; }

                    //if (i.Abilities == "none" || i.Abilities == "none none none")
                    //{
                    //    abilities = null;
                    //}
                    //else
                    //{
                    //    string[] Abilities_Split = i.Abilities.Split(' ');
                    //    foreach (string s in Abilities_Split)
                    //    {
                    //        if (s != "none")
                    //        {
                    //            string[] Ability = s.Split('%');
                    //            abilities.Add(new Abilities(Ability[0], int.Parse(Ability[1])));
                    //        }
                    //    }
                    //}
                }
            }
        }

        public void Unit_Draw(Graphics g)
        {
            UnitRec = new Rectangle(x, y, width, height);
            g.DrawImage(Unit_Image, UnitRec);
        }

        public void Move_Unit()
        {
            if (Range == true)
            {
                bool move = true;
                foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
                {
                    if (x + width + Range_Distance + (Speed / 2) >= Eunit.x)
                    {
                        move = false;
                    }
                }

                if (x + (Speed / 2) >= Max_X)
                {
                    move = false;
                }

                if (move == true)
                {
                    x = x + Speed;
                }
            }
            else
            {
                bool move = true;
                foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
                {
                    if (x + width + (Speed / 2) >= Eunit.x)
                    {
                        move = false;
                    }
                }

                if (x + (Speed / 2) >= Max_X)
                {
                    move = false;
                }

                if (move == true)
                {
                    x = x + Speed;
                }
            }
        }

        public void Unit_Attack()
        {
            AttackWaitTicks++;

            if (AttackWaitTicks >= Attack_Speed)
            {
                AttackWaitTicks = 0;

                foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
                {
                    if (UnitTarget == null) { UnitTarget = Eunit; }
                    else
                    {
                        if (x - Eunit.UnitRec.Location.X < x - UnitTarget.UnitRec.Location.X)
                        {
                            UnitTarget = Eunit;
                        }
                    }
                }

                if (Range == true)
                {

                }
                else
                {
                    UnitTarget.Damage_Enemy_Unit(Damage);
                }
            }
        }

        public void Unit_Damage(int damage)
        {
            Health = Health - damage;
            //GlobalVariables.Explosions.Add(new Explosion(x, y + (width / 2)));

            if (Health <= 0)
            {
                Unit_Destroy();
                Console.WriteLine(Unit_Name + " has died. Remaining Units: " + GlobalVariables.Units.Count);
            }
        }

        public void Unit_Destroy()
        {
            GlobalVariables.Units.Remove(this);
        }
    }
}
