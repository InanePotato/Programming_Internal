using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class DragControl : Component
    {
        private Control HandleControl;

        public Control SelectControl
        {
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
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                DragControl.ReleaseCapture();
                DragControl.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }

        public DragControl()
        {
            InitializeComponent();
        }

        public DragControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
