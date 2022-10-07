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
    public partial class ArmyCamp : Form
    {
        //---------------------------------------------//
        // Declares public variables used in this form //
        //---------------------------------------------//
        Graphics g; // declares the graphics variable used later

        // declares the variables used for putting the units in each 'slot' in the form
        int SlotRecGap;
        int SlotRecWidth;
        int SlotRecHeight;
        Rectangle[] Slot0 = new Rectangle[10];
        Rectangle[] Slot1 = new Rectangle[10];
        Rectangle[] Slot2 = new Rectangle[10];
        Rectangle[] Slot3 = new Rectangle[10];
        Rectangle[] Slot4 = new Rectangle[10];
        Image Slot0Image;
        Image Slot1Image;
        Image Slot2Image;
        Image Slot3Image;
        Image Slot4Image;

        // declares the variable used to store the form where the player selects a unit to put in each slot
        Form frmSelectUnit;

        public ArmyCamp()
        {
            InitializeComponent();

            // sets the panel to be dublebuffered
            // this helps with the drawing of objects in the form making it less 'flickery'
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_ArmyCamp, new object[] { true });
        }

        private void ArmyCamp_Load(object sender, EventArgs e)
        {
            int count = 0; // declares the int count variable used in the foreach loop, and sets it to 0
            // goes through all the slots in the SlotContents global variable
            foreach (string slot in GlobalVariables.SlotContents)
            {
                // checks if each slot contians a unit with none or negitive ammounts of troops
                if (slot == "basic" && GlobalVariables.BasicUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.BasicUnit_Count = 0; }
                else if (slot == "range" && GlobalVariables.RangeUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.RangeUnit_Count = 0; }
                else if (slot == "magic" && GlobalVariables.MagicUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.MagicUnit_Count = 0; }
                else if (slot == "gun" && GlobalVariables.GunUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.GunUnit_Count = 0; }
                else if (slot == "giant" && GlobalVariables.GiantUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.GiantUnit_Count = 0; }
                count++; // adds one to the count
            }

            // sets the pause cover panel to not be visible
            PNL_PauseCover.Visible = false;

            // calls on the UpdateSlots public void
            UpdateSlots();
        }

        public void UpdateSlots()
        {
            // sets all the hover cursor's for each slot to the hand cursor
            PNL_Slot0.Cursor = Cursors.Hand;
            PNL_Slot1.Cursor = Cursors.Hand;
            PNL_Slot2.Cursor = Cursors.Hand;
            PNL_Slot3.Cursor = Cursors.Hand;
            PNL_Slot4.Cursor = Cursors.Hand;

            // sets the variable that keeps the gap between each unit's rectangle
            SlotRecGap = 10;
            // sets the bariable that stores the unit rectangles height
            SlotRecHeight = (PNL_Slot0.Height - (6 * SlotRecGap)) / 5;
            // sets the variable that keeps the unit rectangles width (makes it the same as the height, so it's a square)
            SlotRecWidth = SlotRecHeight;


            //--------------------------------//
            // sets up the contents of slot 0 //
            //--------------------------------//

            // sets the location and size for each of the first slots unit rectangles
            Slot0[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot0[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot0[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot0[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot0[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            // sets an image to be used when drawing the units in sot 0
            if (GlobalVariables.SlotContents[0] == "basic")
            {
                // if it's a basic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the basic duck, and use the one for the correct level basic duck the player has
                Slot0Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[0] == "range")
            {
                // if it's a range unit:
                // set the background image of the slot to one without a plus
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the range duck, and use the one for the correct level range duck the player has
                Slot0Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[0] == "magic")
            {
                // if it's a magic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the magic duck, and use the one for the correct level magic duck the player has
                Slot0Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[0] == "gun")
            {
                // if it's a gun unit:
                // set the background image of the slot to one without a plus
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the gun duck, and use the one for the correct level gun duck the player has
                Slot0Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[0] == "giant")
            {
                // if it's a giant unit:
                // set the background image of the slot to one without a plus
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the giant duck, and use the one for the correct level giant duck the player has
                Slot0Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                // otherwise no unit is supposed to be in the slot
                // make sure the background image for the slot is one with a plus
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                // set the cursor of the slot to a hand
                PNL_Slot0.Cursor = Cursors.Hand;
                // set the images drawen in the rectangles to a blank
                Slot0Image = Properties.Resources.Blank;

                // set the sizes and locations of the rectangles to be at the point 0,0 and with a size of 1,1
                Slot0[0] = new Rectangle(0, 0, 1, 1);
                Slot0[1] = new Rectangle(0, 0, 1, 1);
                Slot0[2] = new Rectangle(0, 0, 1, 1);
                Slot0[3] = new Rectangle(0, 0, 1, 1);
                Slot0[4] = new Rectangle(0, 0, 1, 1);
            }
            // call the invalidate event for the slot0 panel, this draws the rectangles in the slot
            PNL_Slot0.Invalidate();


            //--------------------------------//
            // sets up the contents of slot 1 //
            //--------------------------------//

            // sets the location and size for each of slot1 unit rectangles
            Slot1[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot1[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot1[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot1[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot1[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            // sets an image to be used when drawing the units in sot 1
            if (GlobalVariables.SlotContents[1] == "basic")
            {
                // if it's a basic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the basic duck, and use the one for the correct level basic duck the player has
                Slot1Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[1] == "range")
            {
                // if it's a range unit:
                // set the background image of the slot to one without a plus
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the range duck, and use the one for the correct level range duck the player has
                Slot1Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[1] == "magic")
            {
                // if it's a magic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the magic duck, and use the one for the correct level magic duck the player has
                Slot1Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[1] == "gun")
            {
                // if it's a gun unit:
                // set the background image of the slot to one without a plus
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the gun duck, and use the one for the correct level gun duck the player has
                Slot1Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[1] == "giant")
            {
                // if it's a giant unit:
                // set the background image of the slot to one without a plus
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the giant duck, and use the one for the correct level giant duck the player has
                Slot1Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                // otherwise no unit is supposed to be in the slot
                // make sure the background image for the slot is one with a plus
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                // make the hover cursor for the slot to be a hand
                PNL_Slot1.Cursor = Cursors.Hand;
                // make the image of the rectangles in the slot to be blank
                Slot1Image = Properties.Resources.Blank;

                // set the sizes and locations of the rectangles to be at the point 0,0 and with a size of 1,1
                Slot1[0] = new Rectangle(0, 0, 1, 1);
                Slot1[1] = new Rectangle(0, 0, 1, 1);
                Slot1[2] = new Rectangle(0, 0, 1, 1);
                Slot1[3] = new Rectangle(0, 0, 1, 1);
                Slot1[4] = new Rectangle(0, 0, 1, 1);
            }
            // call the invalidate event for the slot1 panel, this draws the units in the slot
            PNL_Slot1.Invalidate();


            //--------------------------------//
            // sets up the contents of slot 2 //
            //--------------------------------//

            // sets the location and size for each of slot2 unit rectangles
            Slot2[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot2[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot2[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot2[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot2[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            // sets an image to be used when drawing the units in sot 2
            if (GlobalVariables.SlotContents[2] == "basic")
            {
                // if it's a basic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the basic duck, and use the one for the correct level basic duck the player has
                Slot2Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[2] == "range")
            {
                // if it's a range unit:
                // set the background image of the slot to one without a plus
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the range duck, and use the one for the correct level range duck the player has
                Slot2Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[2] == "magic")
            {
                // if it's a magic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the magic duck, and use the one for the correct level magic duck the player has
                Slot2Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[2] == "gun")
            {
                // if it's a gun unit:
                // set the background image of the slot to one without a plus
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the gun duck, and use the one for the correct level gun duck the player has
                Slot2Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[2] == "giant")
            {
                // if it's a giant unit:
                // set the background image of the slot to one without a plus
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the giant duck, and use the one for the correct level giant duck the player has
                Slot2Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                // otherwise no unit is supposed to be in the slot
                // make sure the background image for the slot is one with a plus
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                // set the hover cursor to a hand
                PNL_Slot2.Cursor = Cursors.Hand;
                // set the iamge for the unit rectangles to a blank
                Slot2Image = Properties.Resources.Blank;

                // set the sizes and locations of the rectangles to be at the point 0,0 and with a size of 1,1
                Slot2[0] = new Rectangle(0, 0, 1, 1);
                Slot2[1] = new Rectangle(0, 0, 1, 1);
                Slot2[2] = new Rectangle(0, 0, 1, 1);
                Slot2[3] = new Rectangle(0, 0, 1, 1);
                Slot2[4] = new Rectangle(0, 0, 1, 1);
            }
            // call on the invalidate event for the slot2 panel, this draws the units in the slot
            PNL_Slot2.Invalidate();


            //--------------------------------//
            // sets up the contents of slot 3 //
            //--------------------------------//

            // sets the location and size for each of slot3 unit rectangles
            Slot3[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot3[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot3[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot3[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot3[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            // sets an image to be used when drawing the units in sot 3
            if (GlobalVariables.SlotContents[3] == "basic")
            {
                // if it's a basic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the basic duck, and use the one for the correct level basic duck the player has
                Slot3Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[3] == "range")
            {
                // if it's a range unit:
                // set the background image of the slot to one without a plus
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the range duck, and use the one for the correct level range duck the player has
                Slot3Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[3] == "magic")
            {
                // if it's a magic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the magic duck, and use the one for the correct level magic duck the player has
                Slot3Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[3] == "gun")
            {
                // if it's a gun unit:
                // set the background image of the slot to one without a plus
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the gun duck, and use the one for the correct level gun duck the player has
                Slot3Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[3] == "giant")
            {
                // if it's a giant unit:
                // set the background image of the slot to one without a plus
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the giant duck, and use the one for the correct level giant duck the player has
                Slot3Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                // otherwise no unit is supposed to be in the slot
                // make sure the background image for the slot is one with a plus
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                // set the hover cursor to a hand
                PNL_Slot3.Cursor = Cursors.Hand;
                // set the image for the rectangles to be blank
                Slot3Image = Properties.Resources.Blank;

                // set the sizes and locations of the rectangles to be at the point 0,0 and with a size of 1,1
                Slot3[0] = new Rectangle(0, 0, 1, 1);
                Slot3[1] = new Rectangle(0, 0, 1, 1);
                Slot3[2] = new Rectangle(0, 0, 1, 1);
                Slot3[3] = new Rectangle(0, 0, 1, 1);
                Slot3[4] = new Rectangle(0, 0, 1, 1);
            }
            // calls on the invalidate event for the slot3 panel, this draws the units in the slot
            PNL_Slot3.Invalidate();


            //--------------------------------//
            // sets up the contents of slot 4 //
            //--------------------------------//

            // sets the location and size for each of slot4 unit rectangles
            Slot4[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot4[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot4[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot4[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot4[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            // sets an image to be used when drawing the units in sot 4
            if (GlobalVariables.SlotContents[4] == "basic")
            {
                // if it's a basic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the basic duck, and use the one for the correct level basic duck the player has
                Slot4Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[4] == "range")
            {
                // if it's a range unit:
                // set the background image of the slot to one without a plus
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the range duck, and use the one for the correct level range duck the player has
                Slot4Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[4] == "magic")
            {
                // if it's a magic unit:
                // set the background image of the slot to one without a plus
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the magic duck, and use the one for the correct level magic duck the player has
                Slot4Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[4] == "gun")
            {
                // if it's a gun unit:
                // set the background image of the slot to one without a plus
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the gun duck, and use the one for the correct level gun duck the player has
                Slot4Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[4] == "giant")
            {
                // if it's a giant unit:
                // set the background image of the slot to one without a plus
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                // set the image to be used to the giant duck, and use the one for the correct level giant duck the player has
                Slot4Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                // otherwise no unit is supposed to be in the slot
                // make sure the background image for the slot is one with a plus
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                // sets the hover cursor to a hand
                PNL_Slot4.Cursor = Cursors.Hand;
                // sets the image for the rectangles to be blank
                Slot4Image = Properties.Resources.Blank;

                // set the sizes and locations of the rectangles to be at the point 0,0 and with a size of 1,1
                Slot4[0] = new Rectangle(0, 0, 1, 1);
                Slot4[1] = new Rectangle(0, 0, 1, 1);
                Slot4[2] = new Rectangle(0, 0, 1, 1);
                Slot4[3] = new Rectangle(0, 0, 1, 1);
                Slot4[4] = new Rectangle(0, 0, 1, 1);
            }
            // calls on the invalidate event for the slot4 panel, this draws the units in the panel
            PNL_Slot4.Invalidate();
        }

        private void PNL_Slot0_Paint(object sender, PaintEventArgs e)
        {
            // declares the graphics object
            g = e.Graphics;

            // goes through all the rectangles in the slot0 rectangle array
            foreach (Rectangle rec in Slot0)
            {
                // draws the rectangle with the image uning the graphics object
                g.DrawImage(Slot0Image, rec);
            }
        }

        private void PNL_Slot1_Paint(object sender, PaintEventArgs e)
        {
            // declares the graphics object
            g = e.Graphics;

            // goes through all the rectangles in the slot1 rectangle array
            foreach (Rectangle rec in Slot1)
            {
                // draws the rectangle with the image using the graphics object
                g.DrawImage(Slot1Image, rec);
            }
        }

        private void PNL_Slot2_Paint(object sender, PaintEventArgs e)
        {
            // declares the graphics object
            g = e.Graphics;

            // goes through all the rectangles in the slot2 rectangle array
            foreach (Rectangle rec in Slot2)
            {
                // draws the rectangle with the image using the graphics object
                g.DrawImage(Slot2Image, rec);
            }
        }

        private void PNL_Slot3_Paint(object sender, PaintEventArgs e)
        {
            // declares the graphics object
            g = e.Graphics;

            // goes through all the rectangles in the slot3 rectangle array
            foreach (Rectangle rec in Slot3)
            {
                // draws the rectangle with the image using the graphics object
                g.DrawImage(Slot3Image, rec);
            }
        }

        private void PNL_Slot4_Paint(object sender, PaintEventArgs e)
        {
            // declares the graphics object
            g = e.Graphics;

            // goes through all the rectangles in the slot4 rectangle array
            foreach (Rectangle rec in Slot4)
            {
                // draws the rectangle with the image using the graphics object
                g.DrawImage(Slot4Image, rec);
            }
        }

        private void PIC_ShopButton_Click(object sender, EventArgs e)
        {
            // when the button is clicked set the global variable ChildToOpen to open the shop
            // this is because the game form controls all the child forms so this is how it's told what to do
            GlobalVariables.ChildToOpen = "shop";
        }

        private void PIC_ShopButton_MouseHover(object sender, EventArgs e)
        {
            // when the picturebox with the shop sign is hovered over
            // enlarge the picturebox and change it's location
            // this is because it gives it a good hover effect
            PIC_ShopButton.Size = new Size(138, 138); // makes the picturebox 10px wider and higher
            PIC_ShopButton.Location = new Point(555, 120); // adjusts it's location due to the size change
        }

        private void PIC_ShopButton_MouseLeave(object sender, EventArgs e)
        {
            // when the picturebox with the shop sign isn't being hovered over
            // decrease the picturebox's size and change it's location
            // this gets rid of the hover effect
            PIC_ShopButton.Size = new Size(128, 128); // returns the picturebox to it's origonal size
            PIC_ShopButton.Location = new Point(560, 130); // returns the picturebox to it's origonal location
        }

        private void TMR_PausePlayCheck_Tick(object sender, EventArgs e)
        {
            // checks if the game is supposed to be paused / the side menu is open
            if (GlobalVariables.Paused == true)
            {
                // if the game is ment to be paused
                // moves the pause cover panel to the correct location and makes it cover everything
                PNL_PauseCover.Location = new Point(GlobalVariables.PauseCoverX, GlobalVariables.PauseCoverY);
                PNL_PauseCover.Size = new Size(GlobalVariables.PauseCoverWidth, GlobalVariables.PauseCoverHeight);

                // shows the pause cover
                PNL_PauseCover.Visible = true;
                // changes the panels background color to one that is slightly transparent
                PNL_PauseCover.BackColor = Color.FromArgb(100, 0, 0, 0);
                // bring the panel to the frount of the page
                PNL_PauseCover.BringToFront();
            }
            else
            {
                // otherwise the game should be unpaused
                // moves the pause cover away from everything
                PNL_PauseCover.Location = new Point(0, PNL_ArmyCamp.Height - PNL_PauseCover.Height);
                // hides the panel
                PNL_PauseCover.Visible = false;
                // sends the panel to the back
                PNL_PauseCover.SendToBack();
            }
        }

        private void TMR_Update_Tick(object sender, EventArgs e)
        {
            // checks if there has been a change in the contents of the slots
            if (GlobalVariables.SlotChange == true)
            {
                // there has been a change
                // set the global variable that stores whether there has been a change or not to fales (no change)
                GlobalVariables.SlotChange = false;

                // update the slots to make the change by calling on the UpdateSlots event
                UpdateSlots();
            }

            // chnages the text in the label below slot0 to say the ammount of units in the slot
            // this is done by checking what type of unit is in the slot and then setting the slot0 label to be the count of that unit with the text of units after the number
            if (GlobalVariables.SlotContents[0] == "basic") { LBL_Slot0Units.Text = GlobalVariables.BasicUnit_Count.ToString() +" Units"; }
            else if (GlobalVariables.SlotContents[0] == "range") { LBL_Slot0Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "magic") { LBL_Slot0Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "gun") { LBL_Slot0Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "giant") { LBL_Slot0Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "") { LBL_Slot0Units.Text = "0000 Units"; }

            // chnages the text in the label below slot1 to say the ammount of units in the slot
            // this is done by checking what type of unit is in the slot and then setting the slot1 label to be the count of that unit with the text of units after the number
            if (GlobalVariables.SlotContents[1] == "basic") { LBL_Slot1Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "range") { LBL_Slot1Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "magic") { LBL_Slot1Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "gun") { LBL_Slot1Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "giant") { LBL_Slot1Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "") { LBL_Slot1Units.Text = "0000 Units"; }

            // chnages the text in the label below slot2 to say the ammount of units in the slot
            // this is done by checking what type of unit is in the slot and then setting the slot2 label to be the count of that unit with the text of units after the number
            if (GlobalVariables.SlotContents[2] == "basic") { LBL_Slot2Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "range") { LBL_Slot2Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "magic") { LBL_Slot2Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "gun") { LBL_Slot2Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "giant") { LBL_Slot2Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "") { LBL_Slot2Units.Text = "0000 Units"; }

            // chnages the text in the label below slot3 to say the ammount of units in the slot
            // this is done by checking what type of unit is in the slot and then setting the slot3 label to be the count of that unit with the text of units after the number
            if (GlobalVariables.SlotContents[3] == "basic") { LBL_Slot3Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "range") { LBL_Slot3Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "magic") { LBL_Slot3Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "gun") { LBL_Slot3Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "giant") { LBL_Slot3Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "") { LBL_Slot3Units.Text = "0000 Units"; }

            // chnages the text in the label below slot4 to say the ammount of units in the slot
            // this is done by checking what type of unit is in the slot and then setting the slot4 label to be the count of that unit with the text of units after the number
            if (GlobalVariables.SlotContents[4] == "basic") { LBL_Slot4Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "range") { LBL_Slot4Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "magic") { LBL_Slot4Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "gun") { LBL_Slot4Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "giant") { LBL_Slot4Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "") { LBL_Slot4Units.Text = "0000 Units"; }

        }

        private void PNL_Slot0_Click(object sender, EventArgs e)
        {
            // when the slot0 panel is clcked,
            // check if it is supposed to do anytihng (by checking the cursor is a hand)
            if (PNL_Slot0.Cursor == Cursors.Hand)
            {
                // if somthing is supposed to happen, then:
                // close the select unit form that is currentl open (if any)
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                // open a new select unit form with the slot number 0 to select a unit for
                frmSelectUnit = new Select_Unit(0);
                // show the new select unit form
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot1_Click(object sender, EventArgs e)
        {
            // when the slot1 panel is clcked,
            // check if it is supposed to do anytihng (by checking the cursor is a hand)
            if (PNL_Slot1.Cursor == Cursors.Hand)
            {
                // if somthing is supposed to happen, then:
                // close the select unit form that is currentl open (if any)
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                // open a new select unit form with the slot number 1 to select a unit for
                frmSelectUnit = new Select_Unit(1);
                // show the new select unit form
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot2_Click(object sender, EventArgs e)
        {
            // when the slot2 panel is clcked,
            // check if it is supposed to do anytihng (by checking the cursor is a hand)
            if (PNL_Slot2.Cursor == Cursors.Hand)
            {
                // if somthing is supposed to happen, then:
                // close the select unit form that is currentl open (if any)
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                // open a new select unit form with the slot number 2 to select a unit for
                frmSelectUnit = new Select_Unit(2);
                // show the new select unit form
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot3_Click(object sender, EventArgs e)
        {
            // when the slot3 panel is clcked,
            // check if it is supposed to do anytihng (by checking the cursor is a hand)
            if (PNL_Slot3.Cursor == Cursors.Hand)
            {
                // if somthing is supposed to happen, then:
                // close the select unit form that is currentl open (if any)
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                // open a new select unit form with the slot number 3 to select a unit for
                frmSelectUnit = new Select_Unit(3);
                // show the new select unit form
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot4_Click(object sender, EventArgs e)
        {
            // when the slot4 panel is clcked,
            // check if it is supposed to do anytihng (by checking the cursor is a hand)
            if (PNL_Slot4.Cursor == Cursors.Hand)
            {
                // if somthing is supposed to happen, then:
                // close the select unit form that is currentl open (if any)
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                // open a new select unit form with the slot number 4 to select a unit for
                frmSelectUnit = new Select_Unit(4);
                // show the new select unit form
                frmSelectUnit.Show();
            }
        }

        private void PIC_MapButton_Click(object sender, EventArgs e)
        {
            // when the map sign picturebox is clicked, check if there is atleast 1 slot with some units in
            // if there is then set the globalvariable for child to open to map
            // if all the slots are empty do nothing
            if (GlobalVariables.SlotContents[0] != null && GlobalVariables.SlotContents[0] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[1] != null && GlobalVariables.SlotContents[1] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[2] != null && GlobalVariables.SlotContents[2] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[3] != null && GlobalVariables.SlotContents[3] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[4] != null && GlobalVariables.SlotContents[4] != "") { GlobalVariables.ChildToOpen = "map"; }
        }

        private void PIC_MapButton_MouseHover(object sender, EventArgs e)
        {
            // when the picturebox with the shop sign is hovered over
            // enlarge the picturebox and change it's location
            // this is because it gives it a good hover effect
            PIC_MapButton.Size = new Size(138, 138); //increase the size of the picturebox by 10px in both width and height
            PIC_MapButton.Location = new Point(333, 93); // adjust the location of the picturebox
        }

        private void PIC_MapButton_MouseLeave(object sender, EventArgs e)
        {
            // when the picturebox with the shop sign isn't being hovered over
            // decrease the picturebox's size and change it's location
            // this gets rid of the hover effect
            PIC_MapButton.Size = new Size(128, 128); // revert the size of the picturebox back to what it was before
            PIC_MapButton.Location = new Point(338, 103); // revert the location of the picturebox back to what it was before
        }

        private void ArmyCamp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when this is closing make sure there is no select unit form open
            if (frmSelectUnit != null) { frmSelectUnit.Close(); }
        }
    }
}
