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
        public bool move = true;
        public int Range_Distance = 200;
        public int Speed = 10;
        public int Max_X;
        public int AttackWaitTicks = 0;
        public int multiplier;
        public Random rnd = new Random();

        public Unit(int X, int Y, string Type, string Name, int Level, int Multiplier, int maxX)
        {
            x = X;
            y = Y;
            Unit_Type = Type;
            Unit_Name = Name;
            Unit_Level = Level;
            Max_X = maxX;
            multiplier = Multiplier;

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
            move = true;
            if (Range == true)
            {
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

                if (GlobalVariables.Enemy_Units.Count != 0)
                {
                    UnitTarget = GlobalVariables.Enemy_Units.Last();

                    if (UnitTarget != null)
                    {

                        if (Range == true)
                        {

                        }
                        else
                        {
                            if (move == false)
                            {
                                UnitTarget.Damage_Enemy_Unit(Damage);
                            }
                        }
                    }
                }
            }
        }

        public void Unit_Damage(int damage)
        {
            Health = Health - damage;
            GlobalVariables.Boom.Add(new Boom(((x + width) - 2) + rnd.Next(0, 4), rnd.Next(y, y + width)));

            if (Health <= 0)
            {
                for (int i = 0; i < multiplier; i++)
                {
                    if (Unit_Type == "basic") { GlobalVariables.BasicUnit_Count--; }
                    if (Unit_Type == "range") { GlobalVariables.RangeUnit_Count--; }
                    if (Unit_Type == "magic") { GlobalVariables.MagicUnit_Count--; }
                    if (Unit_Type == "gun") { GlobalVariables.GunUnit_Count--; }
                    if (Unit_Type == "giant") { GlobalVariables.GiantUnit_Count--; }
                }

                Console.WriteLine(Unit_Name + " has died. Remaining Units: " + GlobalVariables.Units.Count);
                Unit_Destroy();
            }
        }

        public void Unit_Destroy()
        {
            GlobalVariables.Units.Remove(this);
        }
    }
}
