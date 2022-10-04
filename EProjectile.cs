using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class EProjectile
    {
        public int X, Y, Width, Height, Damage, Min_X;
        public int Speed = 10;
        public string Type;
        public Image ProjectileImg;
        public Rectangle ProjectileRec;
        public Unit Target;

        public EProjectile(int x, int min_x, int y, string type, int damage, Unit target)
        {
            X = x;
            Y = y;
            Type = type;
            Damage = damage;
            Target = target;
            Min_X = min_x;

            if (Type == "lemonade_ball")
            {
                Width = 25;
                Height = 25;

                ProjectileImg = Properties.Resources.lemonade_ball;
            }
            else if (Type == "lemon")
            {
                Width = 22;
                Height = 28;

                ProjectileImg = Properties.Resources.lemon;
            }
        }

        public void MoveAndDraw(Graphics g)
        {
            if (ProjectileRec.X < Target.UnitRec.X + Target.UnitRec.Width)
            {
                Target.Unit_Damage(Damage);
                GlobalVariables.EProjectiles.Remove(this);
            }
            else if (ProjectileRec.X < Min_X)
            {
                GlobalVariables.EProjectiles.Remove(this);
            }
            else
            {
                X = X - Speed;
                ProjectileRec = new Rectangle(X, Y, Width, Height);

                g.DrawImage(ProjectileImg, ProjectileRec);
            }
        }
    }
}
