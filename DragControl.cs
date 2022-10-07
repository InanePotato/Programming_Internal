using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Programming_Internal
{
    // uses the component template / base
    public partial class DragControl : Component
    {
        // creates a new control
        // this is used to let the selected component in the form control the movment of the form
        private Control HandleControl;

        // creates another new control
        // this is used to select the part of the form that will be involved in this component
        public Control SelectControl
        {
            // used for the selection and use of the selected component on the form
            get
            {
                return this.HandleControl;
            }
            set
            {
                this.HandleControl = value;
                this.HandleControl.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            // checks if the mouse button being held down is the left click button
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                // if it is the left click button held down,
                // calls on the events to move the form
                DragControl.ReleaseCapture();
                DragControl.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }

        public DragControl()
        {
            InitializeComponent();
        }

        // sets up the form to control the location of
        public DragControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
