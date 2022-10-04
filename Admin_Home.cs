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
        //--------------------------------------------------------//
        // declares all public variables used throughout the form //
        //--------------------------------------------------------//

        bool WindowSnapped; // declares the bool used to store whether the form should be snapped or not

        // when the form is called to open, it requires to know if it should be snapped or not
        public Admin_Home(bool SnappedWindow)
        {
            InitializeComponent();

            // sets the priviously declared bool to the vaule that was passed during the creation of the form
            WindowSnapped = SnappedWindow;
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            // checks if the form should be snapped or not
            if (WindowSnapped == true)
            {
                // if the form does need to be snapped, change the layout accordingly
                // make the form the top most form on the users screen
                this.TopMost = true;

                // set the size of the form to take up the entire height of the screen and the appropriately set width
                this.Size = new Size(278, Screen.FromHandle(this.Handle).WorkingArea.Height);
                // set the location of the form to be in the top right corner of the users screen
                this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width - this.Width, 0);

                // moves the settings panel into the top left corner of the form
                PNL_Settings.Location = new Point(0,0);
                // changes the settings panel size to take up the whole form
                PNL_Settings.Size = new Size(PNL_Settings.Width, this.Height);

                // dissable the visibility of the duck image
                PIC_Duck.Visible = false;
            }
            // if the form dosn't need to be snapped it does nothing (it's already layed out in this form)

            // change the value of the snap toggle button to whatever the appropriate global variable says it should be
            toggle_Snap.Checked = GlobalVariables.AdminSnap;
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            //------------------------//
            // Constantly checking... //
            //------------------------//

            // checks if the child form should be snapped, and if the current child form open shouldn't be the home form
            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "home")
            {
                // if the child forms are snapped, and the wrong child form is open (this form shouldn't be open)
                // closes this form
                this.Close();
            }

            // checks if this form is snapped to the side of the screen, but it isn't supposed to
            if (WindowSnapped == true && GlobalVariables.AdminSnap == false)
            {
                // if this form shouldn't be snapped and it is
                // closes this form
                this.Close();
            }

            // checks if the admin forms are supposed to be closed
            if (GlobalVariables.CloseAdmin == true)
            {
                // if this form (and all other admin forms are supposed to be closed)
                // closes this form
                this.Close();
            }
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            // whenever the button is clicked to submit the changes to everything on this form
            // update the global variable for snapped forms to be the same as the selected option by the user
            GlobalVariables.AdminSnap = toggle_Snap.Checked;
        }
    }
}
