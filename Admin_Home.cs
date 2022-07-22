using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class Admin_Home : Form
    {
        bool WindowSnapped;

        public Admin_Home(bool SnappedWindow)
        {
            InitializeComponent();
            WindowSnapped = SnappedWindow;
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            if (WindowSnapped == true)
            {
                this.TopMost = true;

                this.Size = new Size(278, Screen.FromHandle(this.Handle).WorkingArea.Height);
                this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width - this.Width, 0);

                PNL_Settings.Location = new Point(0,0);
                PNL_Settings.Size = new Size(PNL_Settings.Width, this.Height);

                PIC_Duck.Visible = false;
            }

            toggle_Snap.Checked = GlobalVariables.AdminSnap;
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "home")
            {
                this.Close();
            }

            if (WindowSnapped == true && GlobalVariables.AdminSnap == false)
            {
                this.Close();
            }

            if (GlobalVariables.CloseAdmin == true)
            {
                this.Close();
            }
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            GlobalVariables.AdminSnap = toggle_Snap.Checked;
        }
    }
}
