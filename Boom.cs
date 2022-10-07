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
        //----------------------------------------------//
        // Declares public variables used in this class //
        //----------------------------------------------//
        public Image ImgBoom = Properties.Resources.Explosion; // the image used in the explosion rectangles
        public Rectangle RecBoom = new Rectangle(); // the rectangle used to hold the explosion image
        public bool Drawn; // used to tell wether the explosion has been drawn yet or not

        // when an instance of this is created, it's given a x and y number value
        public Boom(int x, int y)
        {
            // sets the rectangle location (using the x and y points given during creation) and size
            RecBoom = new Rectangle(x, y, 50, 50);
            // sets the drawn value to false
            Drawn = false;
        }

        // when the this event is called upon, it requires a graphics object to be passed to it
        public void DrawBoom(Graphics g)
        {
            // checks if the explosion hasn't been drawn
            if (Drawn == false)
            {
                // the explosion hasn't been drawn,
                // uses the given graphics object to draw the image inside the rectangle
                g.DrawImage(ImgBoom, RecBoom);
                // sets the drawn value to true
                Drawn = true;
            }
            else
            {
                // otherwise the explotion has been drawn so removes it from the Boom list
                GlobalVariables.Boom.Remove(this);
            }
        }
    }
}
