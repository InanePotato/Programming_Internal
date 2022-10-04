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
        //---------------------------------------------//
        // Declares public variables used in this form //
        //---------------------------------------------//
        bool showingSnap = false; // used to tell if the form is suposed to be 'snapped' and if it accualy is or not

        //--------------------------------------------------------------//
        // Declares variables used for rounding the corners of the form //
        //--------------------------------------------------------------//
        
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
            // sets the form border style property of the form to none (no border)
            this.FormBorderStyle = FormBorderStyle.None;
            // Rounds corners of the form using code from above
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // sets values for the global variables regarding this form
            GlobalVariables.AdminSnap = true;
            GlobalVariables.CloseAdmin = false;
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            if (BTN_Home.Cursor == Cursors.Hand) // checks if the admin home form isn't already showing
            {
                // change background color and hover cursor of the home button
                BTN_Home.BackColor = Color.FromArgb(46, 51, 73);
                BTN_Home.Cursor = Cursors.Default;

                // makes sure all the other buttons are able to be clicked & are with default properties
                BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
                BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
                BTN_LiveVariables.Cursor = Cursors.Hand;
                BTN_UnitSettings.Cursor = Cursors.Hand;
                BTN_Users.Cursor = Cursors.Hand;

                // calls on the child form openChildAdminForm event with a new instance of the Admin_Home form
                openChildAdminForm(new Admin_Home(GlobalVariables.AdminSnap));
                // sets the value for the global variabe used to store what admin page is currently open to 'home'
                GlobalVariables.SnappedAdminWindowOpen = "home";

                // sets the title at the top of the page to display "Home" as it's text
                // note: this will only show if the admin forms are not 'snapped'
                lbl_Title.Text = "Home";
            }
        }

        private void BTN_LiveVariables_Click(object sender, EventArgs e)
        {
            if (BTN_LiveVariables.Cursor == Cursors.Hand) // checks if the admin live variables form isn't already showing
            {
                // change background color and hover cursor of the live variables button
                BTN_LiveVariables.BackColor = Color.FromArgb(46, 51, 73);
                BTN_LiveVariables.Cursor = Cursors.Default;

                // makes sure all the other buttons are able to be clicked & are with default properties
                BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
                BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Home.Cursor = Cursors.Hand;
                BTN_UnitSettings.Cursor = Cursors.Hand;
                BTN_Users.Cursor = Cursors.Hand;

                // calls on the child form openChildAdminForm event with a new instance of the Admin_liveVariables form
                openChildAdminForm(new Admin_LiveVariables(GlobalVariables.AdminSnap));
                // sets the value for the global variabe used to store what admin page is currently open to 'live_vars'
                GlobalVariables.SnappedAdminWindowOpen = "live_vars";

                // sets the title at the top of the page to display "Live variables" as it's text
                // note: this will only show if the admin forms are not 'snapped'
                lbl_Title.Text = "Live Variables";
            }
        }

        private void BTN_UnitSettings_Click(object sender, EventArgs e)
        {
            if (BTN_UnitSettings.Cursor == Cursors.Hand) // checks if the admin unit settings form isn't already showing
            {
                // change background color and hover cursor of the unit settings button
                BTN_UnitSettings.BackColor = Color.FromArgb(46, 51, 73);
                BTN_UnitSettings.Cursor = Cursors.Default;

                // makes sure all the other buttons are able to be clicked & are with default properties
                BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
                BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Users.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Home.Cursor = Cursors.Hand;
                BTN_LiveVariables.Cursor = Cursors.Hand;
                BTN_Users.Cursor = Cursors.Hand;
                // calls on the child form openChildAdminForm event with a new instance of the Admin_UnitSettings form
                openChildAdminForm(new Admin_UnitSettings(GlobalVariables.AdminSnap));
                // sets the value for the global variabe used to store what admin page is currently open to 'unit_settings'
                GlobalVariables.SnappedAdminWindowOpen = "unit_settings";

                // sets the title at the top of the page to display "Unit Settings" as it's text
                // note: this will only show if the admin forms are not 'snapped'
                lbl_Title.Text = "Unit Settings";
            }
        }

        private void BTN_Users_Click(object sender, EventArgs e)
        {
            if (BTN_Users.Cursor == Cursors.Hand) // checks if the admin users / game saves form isn't already showing
            {
                // change background color and hover cursor of the users / game saves button
                BTN_Users.BackColor = Color.FromArgb(46, 51, 73);
                BTN_Users.Cursor = Cursors.Default;

                // makes sure all the other buttons are able to be clicked & are with default properties
                BTN_Home.BackColor = Color.FromArgb(24, 30, 54);
                BTN_LiveVariables.BackColor = Color.FromArgb(24, 30, 54);
                BTN_UnitSettings.BackColor = Color.FromArgb(24, 30, 54);
                BTN_Home.Cursor = Cursors.Hand;
                BTN_LiveVariables.Cursor = Cursors.Hand;
                BTN_UnitSettings.Cursor = Cursors.Hand;

                // calls on the child form openChildAdminForm event with a new instance of the Admin_Saves form
                openChildAdminForm(new Admin_Saves(GlobalVariables.AdminSnap));
                // sets the value for the global variabe used to store what admin page is currently open to 'saves'
                GlobalVariables.SnappedAdminWindowOpen = "saves";

                // sets the title at the top of the page to display "Game Saves" as it's text
                // note: this will only show if the admin forms are not 'snapped'
                lbl_Title.Text = "Game Saves";
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            // sets all global bariables invloved in the closing of the admin forms to what they should be
            // this ensures everything that needs to close does so, and helps restrict any issues on the re-opening
            GlobalVariables.CloseAdmin = true;
            GlobalVariables.AdminMode = false;
            GlobalVariables.AdminSnap = false;

            // closes the Admin form
            this.Close();
        }

        // declares the private variable used for storing the current admin chuld form (sub-form) that is open
        private Form activeAdminForm = null;


        //-----------------------------------------------------------------//
        // The event called / used for opening new child forms (sub-forms) //
        //-----------------------------------------------------------------//
        private void openChildAdminForm(Form childAdminForm) // when this event is called (requires a instance of a form to be inputted when called)
        {
            if (activeAdminForm != null) // checks if there is currently a child form open
            {
                // if another child form is currently open, this closes it before continuing on with opening the new one
                activeAdminForm.Close();
            }

            if (GlobalVariables.AdminSnap == true) // checks if the child form is supposed to be 'snapped' to the side of the screen
            {
                // opens the child form normaly, without any extra change of properties
                childAdminForm.Show();
            }
            else
            {
                activeAdminForm = childAdminForm; // sets the active child form to the form about to be opened
                childAdminForm.TopLevel = false; // makes sure the child form is correctly placed
                childAdminForm.FormBorderStyle = FormBorderStyle.None; // makes sure the child form has no border
                childAdminForm.Dock = DockStyle.Fill; // makes sure the chuld form is resized to fully fit the panel
                PNL_Body.Controls.Add(childAdminForm); // places the child form into the panel
                PNL_Body.Tag = childAdminForm; // gives the panel the tag of the child form
                childAdminForm.BringToFront(); // makes sure the child form is at the frount of everything else in the panel
                childAdminForm.Show(); // shows / opens the child form
            }
        }

        //-----------------------------------------------------------------//
        // The event called / used for closing new child forms (sub-forms) //
        //-----------------------------------------------------------------//
        private void closeChildForm() // when this event is called
        {
            if (activeAdminForm != null) // checks if there is currently a child form open
            {
                // if there is currently a child form open, closes the current open child form
                activeAdminForm.Close();
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            //----------------------------------------------------------//
            // Handles the resizing and change of layouts of the child  //
            // forms depending on whether they should be snapped or not //
            //----------------------------------------------------------//

            // checks if the global variable for whether the admin forms should be snapped to the side is true (the forms should be snapped)
            if (GlobalVariables.AdminSnap == true)
            {
                // checks if the admin forms are currently snapped to the side
                if (showingSnap == false)
                {
                    // if they aren't currently snapped to the side but because they are supposed to (according to the privious if statment) start showing them as snapped
                    showingSnap = true;

                    // closes the current 'unsnapped' child form
                    closeChildForm();
                }
            }
            // if the first statment is false, then check if the forms are currently snapped
            // and if according to the appropriate global variable, they arn't supposed to be snapped
            else if (GlobalVariables.AdminSnap == false && showingSnap == true)
            {
                // stop showing them as snapped
                showingSnap = false;

                // get rid of the current snapped child form
                GlobalVariables.SnappedAdminWindowOpen = null;

                // finds out what child form is supposed to be showing, and re-opens the correct child form un-snapped
                if (BTN_LiveVariables.Cursor == Cursors.Default) { openChildAdminForm(new Admin_LiveVariables(GlobalVariables.AdminSnap)); }
                else if (BTN_UnitSettings.Cursor == Cursors.Default) { openChildAdminForm(new Admin_UnitSettings(GlobalVariables.AdminSnap)); }
                else if (BTN_Users.Cursor == Cursors.Default) { openChildAdminForm(new Admin_Saves(GlobalVariables.AdminSnap)); }
                else // home window should be opened (only other option, one must always be open at any given time)
                {
                    openChildAdminForm(new Admin_Home(GlobalVariables.AdminSnap));
                }
            }


            //---------------------------------------------------------//
            //  Resizes and changes the proterties of the admin form   //
            // depending on wether it is supposed to be snapped or not //
            //---------------------------------------------------------//

            if (GlobalVariables.AdminSnap == true) // uses the appropriate global variable to check if the admin forms should be snapped
            {
                // if they are supposed to be snapped then...

                // declares the variable used to store the appropriate size for things when the forms are snapped
                Size snappedsize = new Size(186, Screen.FromHandle(this.Handle).WorkingArea.Height);

                // checks if the forms size is not currently the size it should be when snapped
                if (this.Size != snappedsize)
                {
                    // sets the current size of the form to the pre-determined, correct, snapped size
                    this.Size = snappedsize;
                    // places the main admin form in the top left corner of the users screen
                    this.Location = new Point(0, 0);

                    // makes the corners of the form no longer curved / rounded
                    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));

                    // makes sure the admin form is the furtherest top form out of everything on the users screen
                    this.TopMost = true;
                }
            }
            // otherwise if the admin forms arn't ment to be snapped
            else if (GlobalVariables.AdminSnap == false)
            {
                // declare and set a value to the variable that stores the correct normal size for the admin form
                Size normsize = new Size(935, 538);

                // checks if the size of the admin form is the correct size that it is supposed to be
                if (this.Size != normsize)
                { 
                    // if it isn't then it makes it the correct size
                    this.Size = normsize;

                    // rounds the corners of the form
                    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

                    // makes the form no longer the top most form on the users screen
                    this.TopMost = false;
                }
            }


            //--------------------------------------------------//
            //   if their is currently no child form, set the   //
            // buttons back to their default proterties / style //
            //--------------------------------------------------//

            // checks if there is currently no active child form
            if (activeAdminForm == null)
            {
                // if their is no currently active / admin window open child form then...
                // sets all the buttons style back to what the defaults are
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
