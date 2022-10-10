using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    public partial class Game : Form
    {
        //---------------------------------------------//
        // Declares public variables used in this form //
        //---------------------------------------------//
        Image IMG_FormBackground = Properties.Resources.Duck_GameFormBackground; // sets image used to cover background of the form
        string UnitSeting_FilePath = Application.StartupPath + @"\Application_Resources\Unit_Settings.txt"; // sets filepath for the unit setings text file
        string EUnitSeting_FilePath = Application.StartupPath + @"\Application_Resources\EUnit_Settings.txt"; // sets filepath for the enemy unit settings text file
        string LevelSeting_FilePath = Application.StartupPath + @"\Application_Resources\Level_Settings.txt"; // sets filepath for the level settings text file

        public Game()
        {
            InitializeComponent();

            //-------------------------------------------------------------------------------//
            // reads the text files (using the filepath created earler to find the location) //
            //-------------------------------------------------------------------------------//

            // sets up the reader for the unit settings text file
            var reader = new StreamReader(UnitSeting_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.Unit_Info.Add(new Get_Unit_Info(values[0], Int32.Parse(values[1]), Int32.Parse(values[2]), Int32.Parse(values[3]), values[4], values[5], Int32.Parse(values[6])));
            }
            reader.Close(); // closes the reader

            // sets up the reader for the enemy unit settings text file
            var reader2 = new StreamReader(EUnitSeting_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader2.EndOfStream)
            {
                var line = reader2.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.EUnit_Info.Add(new Get_EUnit_Info(values[0], Int32.Parse(values[1]), Int32.Parse(values[2]), Int32.Parse(values[3]), values[4]));
            }
            reader2.Close(); // closes the reader

            // sets up the reader for the level settings text file
            var reader3 = new StreamReader(LevelSeting_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader3.EndOfStream)
            {
                var line = reader3.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.Level_Info.Add(new Get_Level_Info(Int32.Parse(values[0]), values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]));
            }
            reader3.Close(); // closes the reader
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // reszes the form to the correct size
            this.Size = new Size(900, 800);

            //puts the game panel in the top left corner of the form
            PNL_Game.Location = new Point(0, 0);
            // resizes the game panel to fit correctly
            PNL_Game.Size = new Size(886, 762);

            //----------------------------------------------------//
            // sets up all the duck & lemmon images for later use //
            //----------------------------------------------------//
            GlobalVariables.Basic_Ducks[0] = Properties.Resources.Duck_Spear;
            GlobalVariables.Basic_Ducks[1] = Properties.Resources.Duck_Sword;
            GlobalVariables.Basic_Ducks[2] = Properties.Resources.Duck_Axe;
            GlobalVariables.Basic_Ducks_FR[0] = Properties.Resources.Duck_Spear;
            GlobalVariables.Basic_Ducks_FR[0].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Basic_Ducks_FR[1] = Properties.Resources.Duck_Sword;
            GlobalVariables.Basic_Ducks_FR[1].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Basic_Ducks_FR[2] = Properties.Resources.Duck_Axe;
            GlobalVariables.Basic_Ducks_FR[2].RotateFlip(RotateFlipType.RotateNoneFlipX);

            GlobalVariables.Range_Ducks[0] = Properties.Resources.Duck_Archer;
            GlobalVariables.Range_Ducks[1] = Properties.Resources.Duck_Catapult;
            GlobalVariables.Range_Ducks[2] = Properties.Resources.Duck_Canon;
            GlobalVariables.Range_Ducks_FR[0] = Properties.Resources.Duck_Archer;
            GlobalVariables.Range_Ducks_FR[0].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Range_Ducks_FR[1] = Properties.Resources.Duck_Catapult;
            GlobalVariables.Range_Ducks_FR[1].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Range_Ducks_FR[2] = Properties.Resources.Duck_Canon;
            GlobalVariables.Range_Ducks_FR[2].RotateFlip(RotateFlipType.RotateNoneFlipX);

            GlobalVariables.Magic_Ducks[0] = Properties.Resources.Duck_Magician;
            GlobalVariables.Magic_Ducks[1] = Properties.Resources.Duck_Wizard;
            GlobalVariables.Magic_Ducks[2] = Properties.Resources.Duck_Sorcerer;
            GlobalVariables.Magic_Ducks_FR[0] = Properties.Resources.Duck_Magician;
            GlobalVariables.Magic_Ducks_FR[0].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Magic_Ducks_FR[1] = Properties.Resources.Duck_Wizard;
            GlobalVariables.Magic_Ducks_FR[1].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Magic_Ducks_FR[2] = Properties.Resources.Duck_Sorcerer;
            GlobalVariables.Magic_Ducks_FR[2].RotateFlip(RotateFlipType.RotateNoneFlipX);

            GlobalVariables.Gun_Ducks[0] = Properties.Resources.Duck_Agent;
            GlobalVariables.Gun_Ducks[1] = Properties.Resources.Duck_Gunner;
            GlobalVariables.Gun_Ducks[2] = Properties.Resources.Duck_Sniper;
            GlobalVariables.Gun_Ducks_FR[0] = Properties.Resources.Duck_Agent;
            GlobalVariables.Gun_Ducks_FR[0].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Gun_Ducks_FR[1] = Properties.Resources.Duck_Gunner;
            GlobalVariables.Gun_Ducks_FR[1].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Gun_Ducks_FR[2] = Properties.Resources.Duck_Sniper;
            GlobalVariables.Gun_Ducks_FR[2].RotateFlip(RotateFlipType.RotateNoneFlipX);

            GlobalVariables.Giant_Ducks[0] = Properties.Resources.Duck_Stacked;
            GlobalVariables.Giant_Ducks[1] = Properties.Resources.Duck_Tall;
            GlobalVariables.Giant_Ducks[2] = Properties.Resources.Duck_Buff;
            GlobalVariables.Giant_Ducks_FR[0] = Properties.Resources.Duck_Stacked;
            GlobalVariables.Giant_Ducks_FR[0].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Giant_Ducks_FR[1] = Properties.Resources.Duck_Tall;
            GlobalVariables.Giant_Ducks_FR[1].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Giant_Ducks_FR[2] = Properties.Resources.Duck_Buff;
            GlobalVariables.Giant_Ducks_FR[2].RotateFlip(RotateFlipType.RotateNoneFlipX);

            GlobalVariables.Enemy_Lemons[0] = Properties.Resources.Lemon_Small;
            GlobalVariables.Enemy_Lemons[1] = Properties.Resources.Lemon_Big;
            GlobalVariables.Enemy_Lemons[2] = Properties.Resources.Lemon_Glass;
            GlobalVariables.Enemy_Lemons[3] = Properties.Resources.Lemon_Bottle;

            GlobalVariables.BossPics[0] = Properties.Resources.Boss1;
            GlobalVariables.BossPics[1] = Properties.Resources.Boss2;
            GlobalVariables.BossPics[2] = Properties.Resources.Boss3;
            GlobalVariables.BossPics[3] = Properties.Resources.Boss_Final;

            // sets the child form to open to the army camp
            GlobalVariables.ChildOpen = "army_camp";
            // calls on the open child form event to open an instance of the army camp form as a child, inside this form
            openChildForm(new ArmyCamp());
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
            // whenever the size of this form changes, eg. the form is maximized, returned to normal size, etc

            // calls on the close child form event to close whatever child form is open (if any)
            closeChildForm();

            // finds out what windowstate the form is in (eg. maximized, normal size, etc)
            if (this.WindowState == FormWindowState.Normal)
            {
                // if the form is the normal size:
                // gets rid of the background image, not needed (won't see it)
                this.BackgroundImage = null;
                // puts the game panel back to the top left corner of the form
                PNL_Game.Location = new Point(0, 0);
                // sets the panels borderstyle to nothing
                PNL_Game.BorderStyle = BorderStyle.None;
            }
            else
            {
                // otherwise, the form must be maximized (resizing the form the normal way is dissabled, therefore must be maximized)
                // adds the background image on to full in the blank space
                this.BackgroundImage = IMG_FormBackground;
                // centers the game panel in the middle of the form
                PNL_Game.Location = new Point((Screen.FromHandle(this.Handle).WorkingArea.Width - PNL_Game.Width) / 2, (Screen.FromHandle(this.Handle).WorkingArea.Height - PNL_Game.Height) / 2);
                // gives the game panel a border
                PNL_Game.BorderStyle = BorderStyle.FixedSingle;
            }

            // reopens whatever child form was open before (the reset is needed to refresh the placment of the form)
            // finds the form that was open before and calls on the open child form event to open a new instance of it
            if (GlobalVariables.ChildOpen == "battleground")
            {
                // if the battleground form was open before
                // calls on the open child form event to open a new instance of the battleground form
                openChildForm(new Battleground());
            }
            else if (GlobalVariables.ChildOpen == "map")
            {
                // if the map form was open before
                // open a new instane of the map form, using the open child form event
                openChildForm(new Map());
            }
            else if (GlobalVariables.ChildOpen == "shop")
            {
                // if the shop form was open before
                // use the open child form event to open a new instance of the shop form
                openChildForm(new Shop());
            }
            else // if the other two arn't set then it has to ether be army camp or nothing set, and if nothing get then make sure it shows somthing (army camp)
            {
                // otherwise open the army camp form, this will open by default if nothing else is open
                GlobalVariables.ChildOpen = "army_camp";
                openChildForm(new ArmyCamp());
            }
        }

        private void BTN_Menu_Click(object sender, EventArgs e)
        {
            // whenever the menu button is clicked
            // find out if the menu is already open using the paused variable
            // the only way the game can be paused is by opening the menu
            if (GlobalVariables.Paused == false)
            {
                // if the game wasn't already paused (the menu isn't open)
                // pause the game
                GlobalVariables.Paused = true;

                // move and resize the menu accordngly to put it in the correct place
                PNL_Menu.Location = new Point(0, PNL_Top.Height);
                PNL_Menu.Size = new Size(200, PNL_Game.Height - PNL_Top.Height);
                // bring the menu form to the frount of everything
                PNL_Menu.BringToFront();
                // enable and show the menu panel
                PNL_Menu.Enabled = true;
                PNL_Menu.Visible = true;

                // set the 'pause cover' to show and cover everything while the game is paused
                GlobalVariables.PauseCoverX = PNL_Menu.Width;
                GlobalVariables.PauseCoverY = 0;
                GlobalVariables.PauseCoverWidth = PNL_Game.Width - PNL_Menu.Width;
                GlobalVariables.PauseCoverHeight = PNL_Game.Height - PNL_Top.Height;
            }
            else
            {
                // otherwise, the game must already be paused, meaning the menu panel mus already be showing
                // unpause the game
                GlobalVariables.Paused = false;

                // dissable and hide the menu panel
                PNL_Menu.Enabled = false;
                PNL_Menu.Visible = false;

                // push the menu panel to the back of everything
                PNL_Menu.SendToBack();

                // move and resize the menu panel so it's out of the way
                PNL_Menu.Location = new Point(0, 1000);
                PNL_Menu.Size = new Size(10, 10);
            }
        }

        private Form activeForm = null; // used to store the currently open child form
        // whenever the open child form event is called it requires an instance of a form to be passed to it (to be opened as the child form)
        private void openChildForm(Form childForm)
        {
            // checks if their is already a child form open
            if (activeForm != null)
            {
                // if there is then closes it
                activeForm.Close();
            }
            // sets the currently open child form to the instance of the form given
            activeForm = childForm;
            //makes this form not at the top
            childForm.TopLevel = false;
            // gets rid of the default form border
            childForm.FormBorderStyle = FormBorderStyle.None;
            // sets the child form to full the given space
            childForm.Dock = DockStyle.Fill;
            // places the child form in the appropriate panel
            PNL_ChildForm.Controls.Add(childForm);
            // gives the panel the tag of this form
            PNL_ChildForm.Tag = childForm;
            // brings the form to the top of the panel
            childForm.BringToFront();
            // shows the child form
            childForm.Show();
        }

        // whenever the event to close the child form is called
        private void closeChildForm()
        {
            // check if their is accualy a child form open
            if (activeForm != null)
            {
                // if there is then close it
                activeForm.Close();
            }
        }

        private void TMR_ChildFromControl_Tick(object sender, EventArgs e)
        {
            // whenever the timer ticks, check if there has been a request to open a new child form
            if (GlobalVariables.ChildToOpen == "army_camp")
            {
                // if there has been a request to open the army camp form as a child then,
                // set the child to open to nothing (it's being handled currently)
                GlobalVariables.ChildToOpen = null;

                // set the currently open child form to the army camp
                GlobalVariables.ChildOpen = "army_camp";
                // call on the open child form event with an instance of the army camp form
                openChildForm(new ArmyCamp());
            }
            else if (GlobalVariables.ChildToOpen == "map")
            {
                // if there has been a request to open the map form as a child then,
                // set the child to open to nothing (it's being handled currently)
                GlobalVariables.ChildToOpen = null;

                // set the currently open child form to the map
                GlobalVariables.ChildOpen = "map";
                // call on the open child form event with an instance of the map form
                openChildForm(new Map());
            }
            else if (GlobalVariables.ChildToOpen == "battleground")
            {
                // if there has been a request to open the battleground form as a child then,
                // set the child to open to nothing (it's being handled currently)
                GlobalVariables.ChildToOpen = null;

                // set the currently open child form to the battleground
                GlobalVariables.ChildOpen = "battleground";
                // call on the open child form event with an instance of the battle ground form
                openChildForm(new Battleground());
            }
            else if (GlobalVariables.ChildToOpen == "shop")
            {
                // if there has been a request to open the shop form as a child then,
                // set the child to open to nothing (it's being handled currently)
                GlobalVariables.ChildToOpen = null;

                // set the currently open child form to the shop
                GlobalVariables.ChildOpen = "shop";
                // call on the open child form event with an instance of the shop form
                openChildForm(new Shop());
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when this form is closing:
            // close all the currently open child forms
            closeChildForm();

            // goes through all the game saves
            foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
            {
                // finds the currently open game save
                if (save.Name == GlobalVariables.CurrentSaveName)
                {
                    // updates all the information under the currently open game save
                    // using what is stored on the appropriate global variables
                    save.Coins = GlobalVariables.Coins;
                    save.Levels_Unlocked = GlobalVariables.LevelsUnlocked;
                    save.Slot1_Contents = GlobalVariables.SlotContents[0];
                    save.Slot2_Contents = GlobalVariables.SlotContents[1];
                    save.Slot3_Contents = GlobalVariables.SlotContents[2];
                    save.Slot4_Contents = GlobalVariables.SlotContents[3];
                    save.Slot5_Contents = GlobalVariables.SlotContents[4];
                    save.Basic_Unlocked = GlobalVariables.BasicUnitUnlocked;
                    save.Basic_Count = GlobalVariables.BasicUnit_Count;
                    save.Basic_Level = GlobalVariables.UnitUpgrades_Basic;
                    save.Range_Unlocked = GlobalVariables.RangeUnitUnlocked;
                    save.Range_Count = GlobalVariables.RangeUnit_Count;
                    save.Range_Level = GlobalVariables.UnitUpgrades_Range;
                    save.Magic_Unlocked = GlobalVariables.MagicUnitUnlocked;
                    save.Magic_Count = GlobalVariables.MagicUnit_Count;
                    save.Magic_Level = GlobalVariables.UnitUpgrades_Magic;
                    save.Gun_Unlocked = GlobalVariables.GunUnitUnlocked;
                    save.Gun_Count = GlobalVariables.GunUnit_Count;
                    save.Gun_Level = GlobalVariables.UnitUpgrades_Gun;
                    save.Giant_Unlocked = GlobalVariables.GiantUnitUnlocked;
                    save.Giant_Count = GlobalVariables.GiantUnit_Count;
                    save.Giant_Level = GlobalVariables.UnitUpgrades_Giant;
                }
            }

            // sets the currently open save name to nothing
            GlobalVariables.CurrentSaveName = null;

            // shows the home form
            GlobalVariables.frmHome.Show();
        }

        private void TMR_TopBarDisplay_Refresh_Tick(object sender, EventArgs e)
        {
            // updates the coins label text to the players current ammount of coins
            LBL_Coins.Text = GlobalVariables.Coins.ToString();

            // sets the global variables for the players army strength and health to 0
            GlobalVariables.Strength = 0;
            GlobalVariables.Health = 0;

            // declares and sets up the string arrays used to get the correct unit names
            string[] basicNames = new string[3]; basicNames[0] = "spear"; basicNames[1] = "sword"; basicNames[2] = "axe";
            string[] rangeNames = new string[3]; rangeNames[0] = "archer"; rangeNames[1] = "catapult"; rangeNames[2] = "cannon";
            string[] magicNames = new string[3]; magicNames[0] = "magician"; magicNames[1] = "wizard"; magicNames[2] = "sorcerer";
            string[] gunNames = new string[3]; gunNames[0] = "agent"; gunNames[1] = "gunner"; gunNames[2] = "sniper";
            string[] giantNames = new string[3]; giantNames[0] = "stacked"; giantNames[1] = "tall"; giantNames[2] = "buff";

            // declares and sets the ints for each units strength and health to 0
            int basicStrength = 0, basicHealth = 0;
            int rangeStrength = 0, rangeHealth = 0;
            int magicStrength = 0, magicHealth = 0;
            int gunStrength = 0, gunHealth = 0;
            int giantStrength = 0, giantHealth = 0;

            // goes through all the unit info
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // finds the unit using the correct name of the one the player has and
                // sets the appropriate strength and health variables to the units damage and health
                if (i.Name == basicNames[GlobalVariables.UnitUpgrades_Basic]) { basicStrength = i.Damage; basicHealth = i.Health; }
                if (i.Name == rangeNames[GlobalVariables.UnitUpgrades_Range]) { rangeStrength = i.Damage; rangeHealth = i.Health; }
                if (i.Name == magicNames[GlobalVariables.UnitUpgrades_Magic]) { magicStrength = i.Damage; magicHealth = i.Health; }
                if (i.Name == gunNames[GlobalVariables.UnitUpgrades_Gun]) { gunStrength = i.Damage; gunHealth = i.Health; }
                if (i.Name == giantNames[GlobalVariables.UnitUpgrades_Giant]) { giantStrength = i.Damage; giantHealth = i.Health; }
            }

            // goes through all the army camp slots
            foreach (string slot in GlobalVariables.SlotContents)
            {
                // finds out the contence of the slot and then adds the strength anf health of the slot onto the appropriate global variables
                if (slot == "basic") { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + basicStrength; GlobalVariables.Health = GlobalVariables.Health + basicHealth; } }
                if (slot == "range") { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + rangeStrength; GlobalVariables.Health = GlobalVariables.Health + rangeHealth; } }
                if (slot == "magic") { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + magicStrength; GlobalVariables.Health = GlobalVariables.Health + magicHealth; } }
                if (slot == "gun") { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + gunStrength; GlobalVariables.Health = GlobalVariables.Health + gunHealth; } }
                if (slot == "giant") { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + giantStrength; GlobalVariables.Health = GlobalVariables.Health + giantHealth; } }
            }

            // updates the health label to show the correct total army health
            LBL_Health.Text = GlobalVariables.Health.ToString();
            // updates the strength label to show the correct total army strength
            LBL_Strength.Text = GlobalVariables.Strength.ToString();
        }

        private void TMR_AdminChcker_Tick(object sender, EventArgs e)
        {
            // if the correct password was put in on the home form, the adminaccount global variable will be true
            // this will allow the button to open the admin / debug form to show

            // checks if the admin / debug is logged in
            if (GlobalVariables.AdminAccount == true)
            {
                // if so, then shows the button to open the admin / debug form
                BTN_OpenAdmin.Visible = true;
            }
            else
            {
                // otherwise, make sure it stays hidden
                BTN_OpenAdmin.Visible = false;
            }

            // checks if the admin/debug form is open and snapped to the side
            if (GlobalVariables.AdminMode == true && GlobalVariables.AdminSnap == true)
            {
                // checks if there is no admin child window snapped to the side
                if (GlobalVariables.SnappedAdminWindowOpen == "" || GlobalVariables.SnappedAdminWindowOpen == null)
                {
                    // if so then appropriately adjusts the forms maximized bounds to not be hidden by the main admin/debug form
                    this.MaximizedBounds = new Rectangle(186, 0, Screen.FromHandle(this.Handle).WorkingArea.Width - 186, Screen.FromHandle(this.Handle).WorkingArea.Height);
                }
                else
                {
                    // otherwise there must be a snapped window open
                    // so appropriately adjust the forms maximized bounds so it's not hidden by either admin/debug form
                    this.MaximizedBounds = new Rectangle(186, 0, Screen.FromHandle(this.Handle).WorkingArea.Width - 464, Screen.FromHandle(this.Handle).WorkingArea.Height);
                }

                // checks if this form is currently maximized
                if (this.WindowState == FormWindowState.Maximized)
                {
                    // if it is then, appropriately adjusts the game panels location to account for the maximized bounds chages
                    PNL_Game.Location = new Point((this.Width - PNL_Game.Width) / 2, (this.Height - PNL_Game.Height) / 2);
                }
            }
            else
            {
                // otherwise leave the maximized form size as it is
                this.MaximizedBounds = new Rectangle(0, 0, Screen.FromHandle(this.Handle).WorkingArea.Width, Screen.FromHandle(this.Handle).WorkingArea.Height);
            }
        }

        private void BTN_OpenAdmin_Click(object sender, EventArgs e)
        {
            // when the button to open the admin/debug form is clicked
            // check if the admin/debug form is already open
            if (GlobalVariables.AdminMode == false)
            {
                // if it isn't, open it
                GlobalVariables.AdminMode = true;
                new Admin().Show(); // opens & shows the admin form
            }
        }

        private void BTN_MainMenu_Click(object sender, EventArgs e)
        {
            // when the main menu button is clicked
            // unpause the game
            GlobalVariables.Paused = false;
            // close this form
            this.Close();
        }

        private void BTN_Help_Click(object sender, EventArgs e)
        {
            // when the help button is clicked
            // show the message box with the games instructions and aim
            MessageBox.Show("The aim of the game is to defeat all 20 levels of evil lemons on your quest to receive grapes."
                + Environment.NewLine + Environment.NewLine + "How to play:" + Environment.NewLine +
                "The game is mostly self-explanatory, you can build your army and order your troops by clicking the plusses in each troop slot in your army camp. " +
                "If you wish to purchase more units or upgrade your current ones, you can click onto the shop sign in your army camp. " +
                "To fight, just click on the map sign in your army camp, select a level, and you’re on your way to victory or certain death." +
                "Be careful when you fight and advancing through levels, if the troops die during battle, there is no bringing them back. " +
                "In the top bar of the game next to the coin's icon, you will be able to see a live update of your army's total strength & total health, " +
                "this can be used, along with the level overview on the map, to help you decide if your army is ready for battle."
                + Environment.NewLine + Environment.NewLine + "Good luck on your adventure commander duck, were counting on you!!", "Instructions",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
