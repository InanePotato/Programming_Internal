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
        public int width = 120;
        public int height = 120;
        public Image Unit_Image;
        public Rectangle UnitRec;
        public Image BoomImage;
        public Rectangle BoomRec;
        public string Unit_Name;
        public int Health, Damage, Attack_Speed;
        public bool Range;
        public bool move = true;
        public int Range_Distance = 200;
        public Unit UnitTarget;
        public int Speed = 10;
        public int Min_X;
        public bool Boss;
        public int AttackCounter = 0;
        public int AttackWaitTicks;
        public Random rnd = new Random();

        public Enemy_Unit(int X, int Y, string Name, int Multiplier, int minX)
        {
            BoomImage = Properties.Resources.Blank;

            x = X;
            y = Y;
            Unit_Name = Name;
            Min_X = minX;

            Unit_Image = GlobalVariables.Enemy_Lemons[0];
            if (Name == "big") { Unit_Image = GlobalVariables.Enemy_Lemons[1]; }
            else if (Name == "glass") { Unit_Image = GlobalVariables.Enemy_Lemons[2]; }
            else if (Name == "bottle") { Unit_Image = GlobalVariables.Enemy_Lemons[3]; }
            else if (Name == "boss1") { Unit_Image = GlobalVariables.BossPics[0]; Boss = true; }
            else if (Name == "boss2") { Unit_Image = GlobalVariables.BossPics[1]; Boss = true; }
            else if (Name == "boss3") { Unit_Image = GlobalVariables.BossPics[2]; Boss = true; }
            else if (Name == "finalboss") { Unit_Image = GlobalVariables.BossPics[3]; Boss = true; }

            foreach (Get_EUnit_Info i in GlobalVariables.EUnit_Info)
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

        public void Draw_Enemy_Unit(Graphics g)
        {
            UnitRec = new Rectangle(x, y, width, height);
            g.DrawImage(Unit_Image, UnitRec);
        }

        public void Move_Enemy_Unit()
        {
            move = true;

            if (Range == true)
            {
                foreach (Unit unit in GlobalVariables.Units)
                {
                    if (x - Range_Distance - (Speed / 2) <= unit.x + unit.width)
                    {
                        move = false;
                    }
                }

                if (x - (Speed / 2) <= Min_X)
                {
                    move = false;
                }

                if (move == true)
                {
                    x = x - Speed;
                }
            }
            else
            {
                foreach (Unit unit in GlobalVariables.Units)
                {
                    if (x - (Speed / 2) <= unit.x + unit.width)
                    {
                        move = false;
                    }
                }

                if (x - (Speed / 2) <= Min_X)
                {
                    move = false;
                }

                if (move == true)
                {
                    x = x - Speed;
                }
            }
        }

        public void Damage_Enemy_Unit(int damage)
        {
            Health = Health - damage;
            BoomRec = new Rectangle(x - 25, rnd.Next(y, y + width), 50, 50);
            BoomImage = Properties.Resources.Explosion;

            if (Health <= 0)
            {
                Enemy_Unit_Destroy();
                Console.WriteLine(Unit_Name + " has died. Remaining EUnits: " + GlobalVariables.Enemy_Units.Count);
            }
        }

        public void Attack_Unit()
        {
            AttackWaitTicks++;

            if (AttackWaitTicks >= Attack_Speed)
            {
                AttackWaitTicks = 0;

                if (GlobalVariables.Units.Count != 0)
                {
                    UnitTarget = GlobalVariables.Units.Last();

                    if (UnitTarget != null)
                    {

                        if (Range == true)
                        {

                        }
                        else
                        {
                            if (move == false)
                            {
                                UnitTarget.Unit_Damage(Damage);
                            }
                        }
                    }
                }
            }
        }

        public void Enemy_Unit_Destroy()
        {
            GlobalVariables.Enemy_Units.Remove(this);
        }
    }
}
