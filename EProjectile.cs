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
        //----------------------------------------------//
        // Declares public variables used in this class //
        //----------------------------------------------//
        public int X, Y, Width, Height, Damage, Min_X; // used to store the coordinates and other infomation about the enemy projectile
        public int Speed = 10; // used to store the speed of the enemy projectile
        public string Type; // used to store the tyoe of enemy projectile
        public Image ProjectileImg; // used to store the projectiles image
        public Rectangle ProjectileRec; // used to store the rectangle / area of the projectile
        public Unit Target; // used to store the projectiles target

        // when a new instance of the EProjectile class is creates, it requires:
        // x & y coordinates, a min x value, a type, a damage value, and a target
        public EProjectile(int x, int min_x, int y, string type, int damage, Unit target)
        {
            // sets the x point to the given x value
            X = x;
            // sets the y point to the given y value
            Y = y;
            // sets the type to the given type value
            Type = type;
            // sets the damage to the given damage value
            Damage = damage;
            // sets the target to the given target
            Target = target;
            // sets the minimum x to the given min x value
            Min_X = min_x;

            // checks what type of projectile it is
            if (Type == "lemonade_ball")
            {
                // if it is a lemonade ball type, the:
                // set the width & height to 25px
                Width = 25;
                Height = 25;

                // set the progectiles image to the lemonade ball image
                ProjectileImg = Properties.Resources.lemonade_ball;
            }
            else if (Type == "lemon")
            {
                // if the projectile type is a lemon
                // set the width to 22px, and the height to 28px
                Width = 22;
                Height = 28;

                // set the projectiles image to the lemon image
                ProjectileImg = Properties.Resources.lemon;
            }
        }

        // whenever the move & draw event is called it requires a graphics object
        public void MoveAndDraw(Graphics g)
        {
            // checks if the projectile has hit the target or gone too far
            if (ProjectileRec.X < Target.UnitRec.X + Target.UnitRec.Width)
            {
                // if the projectile has hit the target then:
                // calls on the targets damage event to damage it
                Target.Unit_Damage(Damage);
                // removes the projectile from the global EProjectiles list
                GlobalVariables.EProjectiles.Remove(this);
            }
            else if (ProjectileRec.X < Min_X)
            {
                // if the projectile has gone too far,
                // remove the projectile from the gloabl EProjectile list
                GlobalVariables.EProjectiles.Remove(this);
            }
            else
            {
                // otherwise the projectile is still on it's way
                // change the x value by the speed
                X = X - Speed;
                // adjust the projectiles rectangle to the new x value
                ProjectileRec = new Rectangle(X, Y, Width, Height);

                // draw the image in the rectangle using the given grphics object
                g.DrawImage(ProjectileImg, ProjectileRec);
            }
        }
    }
}
