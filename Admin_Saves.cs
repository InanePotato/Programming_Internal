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
    public partial class Admin_Saves : Form
    {
        //--------------------------------------------//
        // Declare public variables used in this form //
        //--------------------------------------------//
        bool WindowSnapped; // used to tell if the form is suposed to be 'snapped' and if it accualy is or not

        // requires to know if in needs to be 'snapped' to the side of the screen or not when creating a new instance of this form
        public Admin_Saves(bool SnappedWindow)
        {
            InitializeComponent();
            // Sets the public variable to the one set when this instance of the form was created
            WindowSnapped = SnappedWindow;
        }

        private void Admin_Saves_Load(object sender, EventArgs e)
        {
            // checks if the form should be snapped to the side of the screen or not
            if (WindowSnapped == true)
            {
                // if it is, then adjust the layout of the form accordingly

                // make this form the top most form on the players screen
                this.TopMost = true;

                // change the size of the form to take up the whole hight of the screen and a set width
                this.Size = new Size(278, Screen.FromHandle(this.Handle).WorkingArea.Height);
                // change the location of the form to be in the top right corner of the players screen
                this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width - this.Width, 0);

                // adjusts the components of the form to account for the new size
                PNL_Saves.Location = new Point(0, 0);
                PNL_Saves.Size = new Size(this.Width, this.Height);
            }

            // updates the list with all the information about each of the game saves
            foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
            {
                // creatse a new item with the name of the save
                ListViewItem addSave = new ListViewItem(save.Name);

                // adds all the information associated with the save as subitems of the name
                addSave.SubItems.Add(save.Coins.ToString());
                addSave.SubItems.Add(save.Levels_Unlocked.ToString());
                addSave.SubItems.Add(save.Slot1_Contents + ", " + save.Slot2_Contents + ", " + save.Slot3_Contents + ", " + save.Slot4_Contents + ", " + save.Slot5_Contents);
                addSave.SubItems.Add(save.Basic_Unlocked.ToString() + ", " + save.Basic_Count.ToString() + ", " + save.Basic_Level.ToString());
                addSave.SubItems.Add(save.Range_Unlocked.ToString() + ", " + save.Range_Count.ToString() + ", " + save.Range_Level.ToString());
                addSave.SubItems.Add(save.Magic_Unlocked.ToString() + ", " + save.Magic_Count.ToString() + ", " + save.Magic_Level.ToString());
                addSave.SubItems.Add(save.Gun_Unlocked.ToString() + ", " + save.Gun_Count.ToString() + ", " + save.Gun_Level.ToString());
                addSave.SubItems.Add(save.Giant_Unlocked.ToString() + ", " + save.Giant_Count.ToString() + ", " + save.Giant_Level.ToString());

                // adds the newly created item to the listview
                listview.Items.Add(addSave);
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            // checks if the admin child window forms should be snapped to the side of the screes
            // and if this current form shouldn't be the one open
            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "saves")
            {
                // if so, closes this form
                this.Close();
            }

            // checks if this form is snapped, but it shouldn't be snapped
            if (WindowSnapped == true && GlobalVariables.AdminSnap == false)
            {
                // if so, closes this form
                this.Close();
            }

            // checks if the admin forms should be closed
            if (GlobalVariables.CloseAdmin == true)
            {
                // if so, closes this form
                this.Close();
            }
        }
    }
}
