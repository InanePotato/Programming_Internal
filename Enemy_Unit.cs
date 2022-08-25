﻿using System;
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
        public int Health, Damage, Attack_Speed;
        public bool Range;
        public int Range_Distance = 200;
        public Unit UnitTarget;
        public int Speed = 10;
        public int Min_X;
        public bool Boss;

        public Enemy_Unit(int X, int Y, string Name, int Multiplier, int minX)
        {
            x = X;
            y = Y;
            Unit_Name = Name;
            Min_X = minX;

            Unit_Image = GlobalVariables.Enemy_Lemons[0];
            if (Name == "big") { Unit_Image = GlobalVariables.Enemy_Lemons[1]; }
            else if (Name == "glass") { Unit_Image = GlobalVariables.Enemy_Lemons[2]; }
            else if (Name == "bottle") { Unit_Image = GlobalVariables.Enemy_Lemons[3]; }

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
            if (Range == true)
            {
                bool move = true;
                foreach (Unit unit in GlobalVariables.Units)
                {
                    if (x - Range_Distance - (Speed / 2) <= unit.x)
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
                bool move = true;
                foreach (Unit unit in GlobalVariables.Units)
                {
                    if (x - (Speed / 2) <= unit.x)
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
