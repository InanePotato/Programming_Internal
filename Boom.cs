using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Boom
    {
        public Image ImgBoom = Properties.Resources.Explosion;
        public Rectangle RecBoom = new Rectangle();
        public bool Drawn;

        public Boom(int x, int y)
        {
            RecBoom = new Rectangle(x, y, 50, 50);
            Drawn = false;
        }

        public void DrawBoom(Graphics g)
        {
            if (Drawn == false)
            {
                g.DrawImage(ImgBoom, RecBoom);
                Drawn = true;
            }
            else
            {
                GlobalVariables.Boom.Remove(this);
            }
        }
    }
}
