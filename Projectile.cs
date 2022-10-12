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
        //----------------------------------------------//
        // Declares public variables used in this class //
        //----------------------------------------------//
        public int X, Y, Width, Height, Damage, Max_X; // uesd to create the projectiles rectangle and to tell if the projectile has gone too far
        public int Speed = 10; // sets how much the projectile moves by each time it's movment method is called
        public string Type; // used to tell what type of projectile it is
        public Image ProjectileImg; // used to full the rectangle with the projectiles correct image
        public Rectangle ProjectileRec; // used to create an area for the projectiles image
        public Enemy_Unit Target; // used to know what the projectiles target is

        // when a new instance if this class is created, it requires a x and y point, max x, type, damage, and target
        public Projectile(int x, int max_x, int y, string type, int damage, Enemy_Unit target)
        {
            X = x; // sets the start X location to the given value
            Y = y; // sets the start Y location to the given value
            Type = type; // sets the projectile type to the given value
            Damage = damage; // sets the projectiles damage to the given value
            Target = target; // sets the projectiles target to the given enemy unit
            Max_X = max_x; //  sets the projectiles max x location to the given value

            // finds what type of projectile this instance is, and sets the width, height, and image accordingly
            if (Type == "arrow")
            {
                // if it's an arrow, then set the appropriate width & height
                Width = 30;
                Height = 10;

                // gives it the arrow image
                ProjectileImg = Properties.Resources.arrow;
            }
            else if (Type == "cannon_ball")
            {
                // if it's an canon ball, then set the appropriate width & height
                Width = 25;
                Height = 25;

                // gives it the cannon ball image
                ProjectileImg = Properties.Resources.cannon_ball;
            }
            else if (Type == "fire_ball")
            {
                // if it's an fire ball, then set the appropriate width & height
                Width = 25;
                Height = 25;

                // gives it the fire ball image
                ProjectileImg = Properties.Resources.fire_ball;
            }
            else if (Type == "bullet")
            {
                // if it's an bullet, then set the appropriate width & height
                Width = 20;
                Height = 10;

                // gives it the bullet image
                ProjectileImg = Properties.Resources.bullet;
            }
        }

        // when the move & draw image is called upon, it requires a graphics object to be given
        public void MoveAndDraw(Graphics g)
        {
            // checks if the projectile has reached it's target or gone too far
            if (ProjectileRec.X + ProjectileRec.Width > Target.UnitRec.X)
            {
                // if the projectile has reached it's target,
                // calls on the targets damage event
                Target.Damage_Enemy_Unit(Damage);
                // removes the projectile from the global projectiles list
                GlobalVariables.Projectiles.Remove(this);
            }
            else if (ProjectileRec.X > Max_X)
            {
                // if the projectile has gone too far, removes it from the global projectiles list
                GlobalVariables.Projectiles.Remove(this);
            }
            else
            {
                // otherwise, the projectile is still on it's way to the target,
                // add the speed to it's x value
                X = X + Speed;
                // update the rectangle with the new x location
                ProjectileRec = new Rectangle(X, Y, Width, Height);

                // draw the image inside the rectangel using the given graphics object
                g.DrawImage(ProjectileImg, ProjectileRec);
            }
        }
    }
}
