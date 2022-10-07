using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    // uses the general button template
    internal class CircleButton : Button
    {
        // overides the generic paint event
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // greates a new graphics path
            GraphicsPath grPath = new GraphicsPath();
            // adds an elipse to the graphics path, with the location and sizes making it take up the whole area abd becoming a circle
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            // adds the graphics path to the region, this changes the normal shape of the button to now be circular
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
