using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Explosion
    {
        public int TicksShowenCountdown = 5;
        public Rectangle ExplosionRec;
        public Image ExplosionImage = Properties.Resources.Explosion;
        public int X, Y;
        public int Width = 56;
        public int Height = 48;
        public Graphics g = GlobalVariables.ExplosionGraphics;

        public Explosion(int x, int y)
        {
            X = x;
            Y = x;

            ExplosionRec = new Rectangle(X, Y, Width, Height);
        }

        public void ExplosionTick()
        {
            TicksShowenCountdown--;

            if (TicksShowenCountdown <= 0) { GlobalVariables.Explosions.Remove(this); }
            else { g.DrawImage(ExplosionImage, ExplosionRec); }
        }
    }
}
