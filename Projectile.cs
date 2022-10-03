using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Projectile
    {
        public int X, Y, Width, Height, Damage, Max_X;
        public int Speed = 10;
        public string Type;
        public Image ProjectileImg;
        public Rectangle ProjectileRec;
        public Enemy_Unit Target;

        public Projectile(int x, int max_x, int y, string type, int damage, Enemy_Unit target)
        {
            X = x;
            Y = y;
            Type = type;
            Damage = damage;
            Target = target;
            Max_X = max_x;

            if (Type == "arrow")
            {
                Width = 30;
                Height = 10;

                ProjectileImg = Properties.Resources.arrow;
            }
            else if (Type == "cannon_ball")
            {
                Width = 25;
                Height = 25;

                ProjectileImg = Properties.Resources.cannon_ball;
            }
            else if (Type == "fire_ball")
            {
                Width = 25;
                Height = 25;

                ProjectileImg = Properties.Resources.fire_ball;
            }
            else if (Type == "bullet")
            {
                Width = 20;
                Height = 10;

                ProjectileImg = Properties.Resources.bullet;
            }
        }

        public void MoveAndDraw(Graphics g)
        {
            if (ProjectileRec.X + ProjectileRec.Width > Target.UnitRec.X)
            {
                Target.Damage_Enemy_Unit(Damage);
                GlobalVariables.Projectiles.Remove(this);
            }
            else if (ProjectileRec.X > Max_X)
            {
                GlobalVariables.Projectiles.Remove(this);
            }
            else
            {
                X = X + Speed;
                ProjectileRec = new Rectangle(X, Y, Width, Height);

                g.DrawImage(ProjectileImg, ProjectileRec);
            }
        }
    }
}
