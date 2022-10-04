using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Programming_Internal
{
    public partial class Admin : Form
    {
        bool showingSnap = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Admin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            GlobalVariables.AdminSnap = true;
            GlobalVariables.CloseAdmin = false;
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            if (BTN_Home.Cursor == Cursors.Hand)
            {
                BTN_Home.BackColor = Color.FromArgb(46, 51, 73);
                BTN_Home.Cursor = Cursors.Default;

                BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
                BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
                BTN_LiveVariables.Cursor = Cursors.Hand;
                BTN_UnitSettings.Cursor = Cursors.Hand;
                BTN_Users.Cursor = Cursors.Hand;

                openChildAdminForm(new Admin_Home(GlobalVariables.AdminSnap));
                GlobalVariables.SnappedAdminWindowOpen = "home";

                lbl_Title.Text = "Home";
            }
        }

        private void BTN_LiveVariables_Click(object sender, EventArgs e)
        {
            if (BTN_LiveVariables.Cursor == Cursors.Hand)
            {
                BTN_LiveVariables.BackColor = Color.FromArgb(46, 51, 73);
                BTN_LiveVariables.Cursor = Cursors.Default;

                BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
                BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Home.Cursor = Cursors.Hand;
                BTN_UnitSettings.Cursor = Cursors.Hand;
                BTN_Users.Cursor = Cursors.Hand;

                openChildAdminForm(new Admin_LiveVariables(GlobalVariables.AdminSnap));
                GlobalVariables.SnappedAdminWindowOpen = "live_vars";

                lbl_Title.Text = "Live Variables";
            }
        }

        private void BTN_UnitSettings_Click(object sender, EventArgs e)
        {
            if (BTN_UnitSettings.Cursor == Cursors.Hand)
            {
                BTN_UnitSettings.BackColor = Color.FromArgb(46, 51, 73);
                BTN_UnitSettings.Cursor = Cursors.Default;

                BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
                BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Home.Cursor = Cursors.Hand;
                BTN_LiveVariables.Cursor = Cursors.Hand;
                BTN_Users.Cursor = Cursors.Hand;

                openChildAdminForm(new Admin_UnitSettings(GlobalVariables.AdminSnap));
                GlobalVariables.SnappedAdminWindowOpen = "unit_settings";

                lbl_Title.Text = "Unit Settings";
            }
        }

        private void BTN_Users_Click(object sender, EventArgs e)
        {
            if (BTN_Users.Cursor == Cursors.Hand)
            {
                BTN_Users.BackColor = Color.FromArgb(46, 51, 73);
                BTN_Users.Cursor = Cursors.Default;

                BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
                BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
                BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Home.Cursor = Cursors.Hand;
                BTN_LiveVariables.Cursor = Cursors.Hand;
                BTN_UnitSettings.Cursor = Cursors.Hand;

                openChildAdminForm(new Admin_Saves(GlobalVariables.AdminSnap));
                GlobalVariables.SnappedAdminWindowOpen = "saves";

                lbl_Title.Text = "Saves";
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            GlobalVariables.CloseAdmin = true;
            GlobalVariables.AdminMode = false;
            GlobalVariables.AdminSnap = false;

            this.Close();
        }

        private Form activeAdminForm = null;
        private void openChildAdminForm(Form childAdminForm)
        {
            if (activeAdminForm != null)
            {
                activeAdminForm.Close();
            }

            if (GlobalVariables.AdminSnap == true)
            {
                childAdminForm.Show();
            }
            else
            {
                activeAdminForm = childAdminForm;
                childAdminForm.TopLevel = false;
                childAdminForm.FormBorderStyle = FormBorderStyle.None;
                childAdminForm.Dock = DockStyle.Fill;
                PNL_Body.Controls.Add(childAdminForm);
                PNL_Body.Tag = childAdminForm;
                childAdminForm.BringToFront();
                childAdminForm.Show();
            }
        }

        private void closeChildForm()
        {
            if (activeAdminForm != null)
            {
                activeAdminForm.Close();
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.AdminSnap == true)
            {
                if (showingSnap == false)
                {
                    showingSnap = true;

                    closeChildForm();
                }
            }
            else if (GlobalVariables.AdminSnap == false && showingSnap == true)
            {
                showingSnap = false;

                GlobalVariables.SnappedAdminWindowOpen = null;

                if (BTN_LiveVariables.Cursor == Cursors.Default) { openChildAdminForm(new Admin_LiveVariables(GlobalVariables.AdminSnap)); }
                else if (BTN_UnitSettings.Cursor == Cursors.Default) { }
                else if (BTN_Users.Cursor == Cursors.Default) { }
                else // home window should be opened
                {
                    openChildAdminForm(new Admin_Home(GlobalVariables.AdminSnap));
                }
            }

            if (GlobalVariables.AdminSnap == true)
            {
                Size snappedsize = new Size(186, Screen.FromHandle(this.Handle).WorkingArea.Height);

                if (this.Size != snappedsize)
                {
                    this.Size = new Size(186, Screen.FromHandle(this.Handle).WorkingArea.Height);
                    this.Location = new Point(0, 0);

                    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));

                    this.TopMost = true;
                }
            }
            else if (GlobalVariables.AdminSnap == false)
            {
                Size normsize = new Size(935, 538);

                if (this.Size != normsize)
                { 
                    this.Size = new Size(935, 538);

                    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

                    this.TopMost = false;
                }
            }

            if (activeAdminForm == null)
            {
                BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
                BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
                BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Home.Cursor = Cursors.Hand;
                BTN_LiveVariables.Cursor = Cursors.Hand;
                BTN_UnitSettings.Cursor = Cursors.Hand;
                BTN_Users.Cursor = Cursors.Hand;
            }
        }
    }
}
