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
            BTN_Home.BackColor = Color.FromArgb(46, 51, 73);
            BTN_Home.Cursor = Cursors.Default;
            openChildAdminForm(new Admin_Home());

            BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
            BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
            BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
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

                openChildAdminForm(new Admin_Home());
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

                openChildAdminForm(new Admin_LiveVariables());
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
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeAdminForm = null;
        private void openChildAdminForm(Form childAdminForm)
        {
            if (activeAdminForm != null)
            {
                activeAdminForm.Close();
            }
            activeAdminForm = childAdminForm;
            childAdminForm.TopLevel = false;
            childAdminForm.FormBorderStyle = FormBorderStyle.None;
            childAdminForm.Dock = DockStyle.Fill;
            PNL_Body.Controls.Add(childAdminForm);
            PNL_Body.Tag = childAdminForm;
            childAdminForm.BringToFront();
            childAdminForm.Show();
        }

        private void closeChildForm()
        {
            if (activeAdminForm != null)
            {
                activeAdminForm.Close();
            }
        }
    }
}
