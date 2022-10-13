using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();

            // sets the show window panel to be double buffered
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_ShopWindow, new object[] { true });
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            // centers the shop panel in the middle of the form
            PNL_Shop.Location = new Point((this.Width - PNL_Shop.Width)/2, (this.Height - PNL_Shop.Height) / 2);

            //evenlt sizes and places the shop window buttons
            BTN_PurchaseUnit_Window.Size = new Size(690 / 3, 40);
            BTN_UpgradeUnit_Window.Size = new Size(690 / 3, 40);
            BTN_Commander_Window.Size = new Size(690 / 3, 40);
            BTN_PurchaseUnit_Window.Location = new Point(5,90);
            BTN_UpgradeUnit_Window.Location = new Point(BTN_PurchaseUnit_Window.Location.X + BTN_PurchaseUnit_Window.Width, 90);
            BTN_Commander_Window.Location = new Point(BTN_UpgradeUnit_Window.Location.X + BTN_UpgradeUnit_Window.Width, 90);

            // dissables the purchase unit window button
            BTN_PurchaseUnit_Window.Enabled = false;
            // changes it's cursor to the default
            BTN_PurchaseUnit_Window.Cursor = Cursors.Default;
            // darkens the buttons background color
            BTN_PurchaseUnit_Window.BackColor = Color.FromArgb(84, 63, 55);
            // calls on the open chop window event to open a new instance of the purchase window
            openShopWindow(new ShopWindow_PurchaseUnits());
        }

        private void TMR_PausePlayCheck_Tick(object sender, EventArgs e)
        {
            // checks wether the game is paused, if so then covers the form with a 'pause cover' otherwise hides it
            if (GlobalVariables.Paused == true)
            {
                // if the game is currently paused
                // moves and resizes the pause cover panel appropriately
                PNL_PauseCover.Location = new Point(GlobalVariables.PauseCoverX, GlobalVariables.PauseCoverY);
                PNL_PauseCover.Size = new Size(GlobalVariables.PauseCoverWidth, GlobalVariables.PauseCoverHeight);

                // makes the pause cover panel visible
                PNL_PauseCover.Visible = true;
                // changes the pause cover's background to be slightly transparent
                PNL_PauseCover.BackColor = Color.FromArgb(100, 0, 0, 0);
                // brings the pause cover to the frount of everything
                PNL_PauseCover.BringToFront();
            }
            else
            {
                // otherwise the game isn't paused
                // moves the pause cover panel out of the way
                PNL_PauseCover.Location = new Point(0, this.Height - PNL_PauseCover.Height);
                // hides the panel
                PNL_PauseCover.Visible = false;
                // sends the panel to the back of everything
                PNL_PauseCover.SendToBack();
            }
        }

        // responsible for re-opening the army camp form if the player wants to go back
        private void PIC_ExitBTN_Click(object sender, EventArgs e)
        {
            // sets the appropriate global variable to army_camp, this is because the game form is responsible
            // for changing all the child forms, so a global variable is used to tell it what to open
            GlobalVariables.ChildToOpen = "army_camp";
        }

        private void PIC_ExitBTN_MouseHover(object sender, EventArgs e)
        {
            // adds a hover effect to the picture box
            // increases the sixe by 5px (width & height)
            PIC_ExitBTN.Size = new Size(55, 55);
            // moves the picturebox so it's still centered around the same point
            PIC_ExitBTN.Location = new Point(655, 11);
        }

        private void PIC_ExitBTN_MouseLeave(object sender, EventArgs e)
        {
            // removes the hover effect
            // decreases the size by 5px (width & height)
            PIC_ExitBTN.Size = new Size(50, 50);
            // moves the picturebox so it's still centered around the same point
            PIC_ExitBTN.Location = new Point(657, 13);
        }

        // used to store what show window is currently open
        private Form activeWindowForm = null;
        // this method is called when opening a new shop window and requires an instance of a form to be inputted
        private void openShopWindow(Form ShopWindow)
        {
            // checks wether there is currently a show window open
            if (activeWindowForm != null)
            {
                // if there is then claoses it
                activeWindowForm.Close();
            }
            // sets the active window to the inputted instance of the form
            activeWindowForm = ShopWindow;
            // puts the window at the top of everything
            ShopWindow.TopLevel = false;
            // gets rid of the forms border
            ShopWindow.FormBorderStyle = FormBorderStyle.None;
            // sets the form to full whatever it's in
            ShopWindow.Dock = DockStyle.Fill;
            // adds the form to the show window panel
            PNL_ShopWindow.Controls.Add(ShopWindow);
            // gives the panel the tag of the form
            PNL_ShopWindow.Tag = ShopWindow;
            // brings the form to the frount of the panel
            ShopWindow.BringToFront();
            // shows the form
            ShopWindow.Show();
        }

        // this method is in charge of closing the currently open shop window
        private void closeShopWindow()
        {
            // checks it there is currently a shop window open
            if (activeWindowForm != null)
            {
                // if so then closes it
                activeWindowForm.Close();
            }
        }

        private void BTN_PurchaseUnit_Window_Click(object sender, EventArgs e)
        {
            // when the button is clicked to open the purchase unit shop window
            // checks if the purchase unit window isn't already open
            if (BTN_PurchaseUnit_Window.Cursor == Cursors.Hand)
            {
                // if it isn't opens the purchase unit window
                // calls on the reset open window buttons method
                Reset_Open_Window_Buttons();

                // dissables this button
                BTN_PurchaseUnit_Window.Enabled = false;
                // changes the hover cursor of this button to the drfault
                BTN_PurchaseUnit_Window.Cursor = Cursors.Default;
                // darkens the background color of this button
                BTN_PurchaseUnit_Window.BackColor = Color.FromArgb(84, 63, 55);
                // opens purchase units shop window
                openShopWindow(new ShopWindow_PurchaseUnits());
            }
        }

        private void BTN_UpgradeUnit_Window_Click(object sender, EventArgs e)
        {
            // when the button is clicked to open the upgrade units shop window
            // checks if the upgrade units window isn't already open
            if (BTN_UpgradeUnit_Window.Cursor == Cursors.Hand)
            {
                // if it isn't opens the upgrade unit window
                // calls on the reset open window buttons method
                Reset_Open_Window_Buttons();

                // dissables this button
                BTN_UpgradeUnit_Window.Enabled = false;
                // changes this buttons hover cursor to the default
                BTN_UpgradeUnit_Window.Cursor = Cursors.Default;
                // darkens this buttons background color
                BTN_UpgradeUnit_Window.BackColor = Color.FromArgb(84, 63, 55);
                // opens the upgrade units shop window
                openShopWindow(new ShopWindow_UpgradeUnits());
            }
        }

        // this method is in charge of resetting the properties of the select window buttons back to their defaults
        public void Reset_Open_Window_Buttons()
        {
            // resets the buttons background color back to the default brown
            BTN_PurchaseUnit_Window.BackColor = Color.FromArgb(121, 85, 72);
            BTN_UpgradeUnit_Window.BackColor = Color.FromArgb(121, 85, 72);
            BTN_Commander_Window.BackColor = Color.FromArgb(121, 85, 72);

            // gives all the buttons that can be clicked the hand hover cursor, and the other ones the default
            BTN_PurchaseUnit_Window.Cursor = Cursors.Hand;
            BTN_UpgradeUnit_Window.Cursor = Cursors.Hand;
            BTN_Commander_Window.Cursor = Cursors.Default;

            // enables all the buttons
            BTN_PurchaseUnit_Window.Enabled = true;
            BTN_UpgradeUnit_Window.Enabled = true;
            BTN_Commander_Window.Enabled = true;
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            // closes the currently open shop window
            closeShopWindow();
        }
    }
}
