using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Programming_Internal
{
    // uses the checkbox as a template / base
    public class ToggleButton : CheckBox
    {
        // declares & sets the colors for the toggle button
        private Color onBackColor = Color.FromArgb(158, 161, 176);
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.FromArgb(55, 62, 92);
        private Color offToggleColor = Color.Gainsboro;

        public ToggleButton()
        {
            // sets a minimum size for the toggle  button
            this.MinimumSize = new Size(45,22);
        }

        //rounds the edges in the toggle button
        private GraphicsPath GetFigurePah()
        {
            // creates a right and left side arc to round the edges
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            // adds the arcs to a graphics path
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270,180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // sets up the toggle button ready for the circle to go in
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            // depending on if the toggle button is 'checked' the circle will either be drawn on the right or left side
            if (this.Checked) //true
            {
                // surface - draws and colors the backgound of the button
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePah());
                // toggle - draws and colors the circle in the toggle button (on the left side)
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
            else //false
            {
                // surface - draws and colors the background of the button
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePah());
                // toggle - draws and colors the circle in the toggle button (on the right side)
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
        }
    }
}
