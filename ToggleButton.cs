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
    public class ToggleButton : CheckBox
    {
        private Color onBackColor = Color.FromArgb(158, 161, 176);
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.FromArgb(55, 62, 92);
        private Color offToggleColor = Color.Gainsboro;

        public ToggleButton()
        {
            this.MinimumSize = new Size(45,22);
        }

        private GraphicsPath GetFigurePah()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270,180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //true
            {
                // surface
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePah());
                // toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
            else //false
            {
                // surface
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePah());
                // toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
        }
    }
}
