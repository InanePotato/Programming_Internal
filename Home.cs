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
    public partial class Home : Form
    {
        //---------------------------------------------//
        // Declares public variables used in this form //
        //---------------------------------------------//
        string Saves_FilePath = Application.StartupPath + @"\Application_Resources\Saves.txt"; // sets the file path used to access the saves text file
        List<string> SaveNames = new List<string>(); // declres the list used to hold all the game saves names
        bool NoSaves; // declares the bool used to tell if there are no saves
        string SelectedSaveName; // declares the string used to tell what save name is currently selected

        public Home()
        {
            InitializeComponent();

            //
            // reads the file Saves (using the file path created earler to find the location)
            //

            // creates a new reader for the saves text file
            var reader = new StreamReader(Saves_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.SaveInfo.Add(new Get_Save_Info(values[0], Int32.Parse(values[1]), Int32.Parse(values[2]), values[3], values[4], values[5], values[6], values[7], bool.Parse(values[8]), Int32.Parse(values[9]), Int32.Parse(values[10]), bool.Parse(values[11]), Int32.Parse(values[12]), Int32.Parse(values[13]), bool.Parse(values[14]), Int32.Parse(values[15]), Int32.Parse(values[16]), bool.Parse(values[17]), Int32.Parse(values[18]), Int32.Parse(values[19]), bool.Parse(values[20]), Int32.Parse(values[21]), Int32.Parse(values[22])));
            }
            reader.Close(); // closes the reader
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // checks whether there are currently any saves
            if (GlobalVariables.SaveInfo.Count == 0 || GlobalVariables.SaveInfo == null) { NoSaves = true; } // if there are no saves, set the nosaves bool to true
            else
            {
                // if there are saves saved to the text file
                // set the no saves bool to false
                NoSaves = false;
                // clear all the save names in the list
                SaveNames.Clear();

                // go through all the saves in the global save info list
                foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
                {
                    // add each saves name into the saves name list
                    SaveNames.Add(save.Name);
                }

                // checks how much saves there are, and appropriately sets the names of the saves buttons to each save name
                // note: if there isn't 4 saves, the non changed buttons will be left saying "[ New Game ]"
                if (SaveNames.Count > 0) { BTN_Save1.Text = SaveNames[0]; }
                if (SaveNames.Count > 1) { BTN_Save2.Text = SaveNames[1]; }
                if (SaveNames.Count > 2) { BTN_Save3.Text = SaveNames[2]; }
                if (SaveNames.Count > 3) { BTN_Save4.Text = SaveNames[3]; }
            }

            // Relocates all the components on the form to be perfectly centered on the x axis in the form
            PIC_Title.Location = new Point((this.Width - PIC_Title.Width) / 2, PIC_Title.Location.Y);
            BTN_Play.Location = new Point((this.Width - BTN_Play.Width) / 2, BTN_Play.Location.Y);
            BTN_Save1.Location = new Point((this.Width - BTN_Save1.Width) / 2, BTN_Save1.Location.Y);
            BTN_Save2.Location = new Point((this.Width - BTN_Save2.Width) / 2, BTN_Save2.Location.Y);
            BTN_Save3.Location = new Point((this.Width - BTN_Save3.Width) / 2, BTN_Save3.Location.Y);
            BTN_Save4.Location = new Point((this.Width - BTN_Save4.Width) / 2, BTN_Save4.Location.Y);
            TXT_CreateSaveName.Location = new Point((this.Width - TXT_CreateSaveName.Width) / 2, TXT_CreateSaveName.Location.Y);
            LBL_CreateSave.Location = new Point(TXT_CreateSaveName.Location.X, LBL_CreateSave.Location.Y);
            BTN_BackToSelect.Location = new Point(TXT_CreateSaveName.Location.X, BTN_BackToSelect.Location.Y);
            BTN_CreateNewSave.Location = new Point((TXT_CreateSaveName.Location.X + TXT_CreateSaveName.Width) - BTN_CreateNewSave.Width, BTN_BackToSelect.Location.Y);
        }

        private void BTN_Play_Click(object sender, EventArgs e)
        {
            // when the play button is clicked, get all the information assoaited with the game save and set it to the appropriate global variables
            // note: this button can not be clicked when no game save is selected,
            // this is because when nothing is selected the button is dissabled

            // sets the global variable currently selected save name
            GlobalVariables.CurrentSaveName = SelectedSaveName;

            // goes through all the game saves in the save info global list
            foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
            {
                // finds the currently selected game save
                if (save.Name == GlobalVariables.CurrentSaveName)
                {
                    // sets all the appropriate global variables to the information in the selected save
                    GlobalVariables.Coins = save.Coins;
                    GlobalVariables.LevelsUnlocked = save.Levels_Unlocked;
                    GlobalVariables.SlotContents[0] = save.Slot1_Contents;
                    GlobalVariables.SlotContents[1] = save.Slot2_Contents;
                    GlobalVariables.SlotContents[2] = save.Slot3_Contents;
                    GlobalVariables.SlotContents[3] = save.Slot4_Contents;
                    GlobalVariables.SlotContents[4] = save.Slot5_Contents;
                    GlobalVariables.BasicUnitUnlocked = save.Basic_Unlocked;
                    GlobalVariables.BasicUnit_Count = save.Basic_Count;
                    GlobalVariables.UnitUpgrades_Basic = save.Basic_Level;
                    GlobalVariables.RangeUnitUnlocked = save.Range_Unlocked;
                    GlobalVariables.RangeUnit_Count = save.Range_Count;
                    GlobalVariables.UnitUpgrades_Range = save.Range_Level;
                    GlobalVariables.MagicUnitUnlocked = save.Magic_Unlocked;
                    GlobalVariables.MagicUnit_Count = save.Magic_Count;
                    GlobalVariables.UnitUpgrades_Magic = save.Magic_Level;
                    GlobalVariables.GunUnitUnlocked = save.Gun_Unlocked;
                    GlobalVariables.GunUnit_Count = save.Gun_Count;
                    GlobalVariables.UnitUpgrades_Gun = save.Gun_Level;
                    GlobalVariables.GiantUnitUnlocked = save.Giant_Unlocked;
                    GlobalVariables.GiantUnit_Count = save.Giant_Count;
                    GlobalVariables.UnitUpgrades_Giant = save.Giant_Level;
                }
            }

            // calls on the reset selected saves mathod
            ResetSelectedSave();

            // carates a new instance of the game form
            new Game().Show();
            // hides this instance of the home form
            GlobalVariables.frmHome.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when this form is closing, save down all the current game saves to the text file

            // creaes  new string builder
            StringBuilder builder = new StringBuilder();
            // goes through all the saves in the gloabl save info list
            foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
            {
                // uses the given format to build strings for each of the game saves
                //{0} is for the Name, {1} is for the Coins ...
                builder.Append(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22}{23}",save.Name, save.Coins, save.Levels_Unlocked, save.Slot1_Contents, save.Slot2_Contents, save.Slot3_Contents, save.Slot4_Contents, save.Slot5_Contents, save.Basic_Unlocked, save.Basic_Count, save.Basic_Level, save.Range_Unlocked, save.Range_Count, save.Range_Level, save.Magic_Unlocked, save.Magic_Count, save.Magic_Level, save.Gun_Unlocked, save.Gun_Count, save.Gun_Level, save.Giant_Unlocked, save.Giant_Count, save.Giant_Level, Environment.NewLine));
            }
            // writes the newly built string to the filepath declared earlier
            File.WriteAllText(Saves_FilePath, builder.ToString());

            // exits the application (this closes all other forms, as well as this one)
            Application.Exit();
        }

        private void TMR_Controls_Tick(object sender, EventArgs e)
        {
            // checks if any of the game saves are selected
            if (SelectedSaveName == null || SelectedSaveName == "" || NoSaves == true)
            {
                // if no saves are selected then dissable the play button,
                // this stops it from being clicked and the player from causing an issue with the game
                BTN_Play.Enabled = false;
            }
            else
            {
                // otherwise, if a game save is selected, enable the play button,
                // this allows it to be clicked and for the player to continue onto the game
                BTN_Play.Enabled = true;
            }

            // checks wether there is tex inside the create save name textbox
            if (TXT_CreateSaveName.Text == "" || TXT_CreateSaveName.Text == null)
            {
                // if htere is no text, then dissable the create new save button,
                // this stops players from creating a new save without a name
                BTN_CreateNewSave.Enabled = false;
            }
            else
            {
                // otherwise there must be text in the textbox so enable the create save button,
                // this allows the user to click the button and create a save with their inputed name
                BTN_CreateNewSave.Enabled = true;
            }

            // reformats /  changes the background color of the admin access button depending on what is happening with it
            // checks if the admin/debug account has been signed into
            if (GlobalVariables.AdminAccount == true)
            {
                // if it has then...
                // changes the buttons background color to a darker grey
                CBTN_AdminAccess.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                // otherwise it hasn't so...
                // check wether the textbox for the password is showing or not
                // if the textbox is showing show a lighter grey, otherwise show a silver grey as the background color of the button
                if (TXT_AdminPassword.Visible == true) { CBTN_AdminAccess.BackColor = Color.Gainsboro; }
                else { CBTN_AdminAccess.BackColor = Color.Silver; }
            }
        }

        public void ResetSelectedSave()
        {
            // this method resets the formatting on the select saves buttons to their default proterties

            // sets the selected save name to nothing
            SelectedSaveName = null;
            // hides the delete selected save button
            CBTN_DeleteSelectedSave.Visible = false;

            // enables all the select save buttons
            BTN_Save1.Enabled = true;
            BTN_Save2.Enabled = true;
            BTN_Save3.Enabled = true;
            BTN_Save4.Enabled = true;

            // changes all the selected save buttons back to their default background color of light black / dark grey
            BTN_Save1.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Save2.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Save3.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Save4.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void BTN_Save1_Click(object sender, EventArgs e)
        {
            // when this save button is clicked:
            // note: this can only be clicked when the button is enabled,
            // meaning that if it is aready selected it can't be selected again.

            // reset all the save buttons back to default
            ResetSelectedSave();

            // checks wether this save button has a save name assoaited with it
            if (BTN_Save1.Text != "[ New Game ]")
            {
                // if not (the text isn't "[ New Game ]")
                // set the selected save name to the text of this
                SelectedSaveName = BTN_Save1.Text;
                // dissable and change the back color of this button
                BTN_Save1.Enabled = false;
                BTN_Save1.BackColor = Color.FromArgb(80, 0, 0, 0);
                // show the delete selected save button
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                // otherwise, this button hasn't been assoaited a save (the text is still "[ New Game ]")
                // set the selected save name to nothing
                SelectedSaveName = null;
                // call the setup create save method
                SetupCreateSave();
            }
        }

        private void BTN_Save2_Click(object sender, EventArgs e)
        {
            // when this save button is clicked:
            // note: this can only be clicked when the button is enabled,
            // meaning that if it is aready selected it can't be selected again.

            // reset all the save buttons back to default
            ResetSelectedSave();

            // checks wether this save button has a save name assoaited with it
            if (BTN_Save2.Text != "[ New Game ]")
            {
                // if not (the text isn't "[ New Game ]")
                // set the selected save name to the text of this
                SelectedSaveName = BTN_Save2.Text;
                // dissable and change the back color of this button
                BTN_Save2.Enabled = false;
                BTN_Save2.BackColor = Color.FromArgb(80, 0, 0, 0);
                // show the delete selected save button
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                // otherwise, this button hasn't been assoaited a save (the text is still "[ New Game ]")
                // set the selected save name to nothing
                SelectedSaveName = null;
                // call the setup create save method
                SetupCreateSave();
            }
        }

        private void BTN_Save3_Click(object sender, EventArgs e)
        {
            // when this save button is clicked:
            // note: this can only be clicked when the button is enabled,
            // meaning that if it is aready selected it can't be selected again.

            // reset all the save buttons back to default
            ResetSelectedSave();

            // checks wether this save button has a save name assoaited with it
            if (BTN_Save3.Text != "[ New Game ]")
            {
                // if not (the text isn't "[ New Game ]")
                // set the selected save name to the text of this
                SelectedSaveName = BTN_Save3.Text;
                // dissable and change the back color of this button
                BTN_Save3.Enabled = false;
                BTN_Save3.BackColor = Color.FromArgb(80, 0, 0, 0);
                // show the delete selected save button
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                // otherwise, this button hasn't been assoaited a save (the text is still "[ New Game ]")
                // set the selected save name to nothing
                SelectedSaveName = null;
                // call the setup create save method
                SetupCreateSave();
            }
        }

        private void BTN_Save4_Click(object sender, EventArgs e)
        {
            // when this save button is clicked:
            // note: this can only be clicked when the button is enabled,
            // meaning that if it is aready selected it can't be selected again.

            // reset all the save buttons back to default
            ResetSelectedSave();

            // checks wether this save button has a save name assoaited with it
            if (BTN_Save4.Text != "[ New Game ]")
            {
                // if not (the text isn't "[ New Game ]")
                // set the selected save name to the text of this
                SelectedSaveName = BTN_Save4.Text;
                // dissable and change the back color of this button
                BTN_Save4.Enabled = false;
                BTN_Save4.BackColor = Color.FromArgb(80, 0, 0, 0);
                // show the delete selected save button
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                // otherwise, this button hasn't been assoaited a save (the text is still "[ New Game ]")
                // set the selected save name to nothing
                SelectedSaveName = null;
                // call the setup create save method
                SetupCreateSave();
            }
        }

        public void SetupCreateSave()
        {
            // when this method is called:
            // hide all the buttons and labels assoaited with the select save system,
            // and show all the buttons and labels assoaited with the create save system

            // hides the select save buttons
            BTN_Save1.Visible = false;
            BTN_Save2.Visible = false;
            BTN_Save3.Visible = false;
            BTN_Save4.Visible = false;
            BTN_Play.Visible = false;

            // shows the create save buttons / labels
            TXT_CreateSaveName.Visible = true;
            LBL_CreateSave.Visible = true;
            BTN_BackToSelect.Visible = true;
            BTN_CreateNewSave.Visible = true;
        }

        public void SetupSelectSave()
        {
            // when this method is called:
            // hide all the buttons and labels assoaited with the create save system,
            // and show all the buttons and labels assoaited with the select save system

            // shows the select save buttons
            BTN_Save1.Visible = true;
            BTN_Save2.Visible = true;
            BTN_Save3.Visible = true;
            BTN_Save4.Visible = true;
            BTN_Play.Visible = true;

            // hides the create save buttons
            TXT_CreateSaveName.Visible = false;
            LBL_CreateSave.Visible = false;
            BTN_BackToSelect.Visible = false;
            BTN_CreateNewSave.Visible = false;
        }

        private void BTN_BackToSelect_Click(object sender, EventArgs e)
        {
            // when the back button is selected:
            // calls on the setup select saves method, this hides all the create save components, and shows all the select save ones
            SetupSelectSave();

            // resets the create save name's text back to nothing
            TXT_CreateSaveName.Text = "";
        }

        private void BTN_CreateNewSave_Click(object sender, EventArgs e)
        {
            // when the create save button is clicked:
            // revert the form back to how it origonaly was, and add a new item the the save info list with the inputted save name
            // note: this button can't be clicked unless there is text inside the create save name text box

            // calls on the setup select saves method, this hides all the create save components, and shows all the select save ones
            SetupSelectSave();

            // Adds a new instance of the Get_Save_Info class to the save info list, this uses default values, and the inputted save name
            GlobalVariables.SaveInfo.Add(new Get_Save_Info(TXT_CreateSaveName.Text, 100, 1, "basic", "range", "", "", "", true, 5, 0, true, 2, 0, false, 0, 0, false, 0, 0, false, 0, 0));

            // sets the text in the create save name textbox to nothing
            TXT_CreateSaveName.Text = "";

            // calls on the refresh saves display method,
            // this refreshes the text inside the select save buttons to allow for the newly created save to be showed
            RefreshSavesDisplay();
        }

        private void TXT_CreateSaveName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // whenever a key is pressed while focused on the create save name textbox (the player is trying to input somthing into the text box)
            // only allow the input to go through if it is either a control (eg. backspace) or a letter/number

            // checks if the key data of the key pressed is either a control or letter/number
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                // if it isn't either one of the given options, then set the handled value for this instance of the event to true
                // this makes the textbox ignore the input of the key
                e.Handled = true;
            }
        }

        public void RefreshSavesDisplay()
        {
            // whenever this method is called, it refreshes the text of the select save buttons,
            // this is to account for any deleted or added game saves

            // checks if there is anything in the save info list
            if (GlobalVariables.SaveInfo.Count == 0 || GlobalVariables.SaveInfo == null)
            {
                // if there isn't then:
                // sets the no saves to true
                NoSaves = true;

                // sets all the buttons text to the default of "[ New Game ]"
                BTN_Save1.Text = "[ New Game ]";
                BTN_Save2.Text = "[ New Game ]";
                BTN_Save3.Text = "[ New Game ]";
                BTN_Save4.Text = "[ New Game ]";
            }
            else
            {
                // otherwise, there are some saves in the list so:
                // sets the no saves to false
                NoSaves = false;
                // clears everyhing in the save names list
                SaveNames.Clear();

                // goes through all the saves in the global save info list
                foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
                {
                    // adds the name of each save to the save names ist
                    SaveNames.Add(save.Name);
                }

                // adds each save name to a button, and if there isn't 4 saves then it fulls the rest of the buttons with the default text
                if (SaveNames.Count > 0) { BTN_Save1.Text = SaveNames[0]; }
                else { BTN_Save1.Text = "[ New Game ]"; }
                if (SaveNames.Count > 1) { BTN_Save2.Text = SaveNames[1]; }
                else { BTN_Save2.Text = "[ New Game ]"; }
                if (SaveNames.Count > 2) { BTN_Save3.Text = SaveNames[2]; }
                else { BTN_Save3.Text = "[ New Game ]"; }
                if (SaveNames.Count > 3) { BTN_Save4.Text = SaveNames[3]; }
                else { BTN_Save4.Text = "[ New Game ]"; }
            }
        }

        private void CBTN_DeleteSelectedSave_Click(object sender, EventArgs e)
        {
            // when the delete save button is pressed, it makes sure the player has somthing selected,
            // makes sure the player knows they are deleting it (that this isn't a mistake), and the
            // removes the save from the save info list

            // checks that there is a save selected
            if (SelectedSaveName != null && SelectedSaveName != "")
            {
                // shows a messagebox asking for conformation of the deleion
                DialogResult ConfirmDeleteResult = MessageBox.Show("Are you sure you want to delete this saved game? This action can't be reversed.", "Confirm save deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // checks what the reslut / answer of the message box was
                if (ConfirmDeleteResult == DialogResult.Yes)
                {
                    // if the player clicked yes, then:
                    // goes through all the saves in the global save info list
                    foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
                    {
                        // finds the selected save
                        if (save.Name == SelectedSaveName)
                        {
                            // removes the selected save from the list
                            GlobalVariables.SaveInfo.Remove(save);
                            break;
                        }
                    }
                }
                // if the answer is anything but yes (no, or exiting), then the save is not deleted
            }

            // calls on the refresh and reset selected saves methods, this refreshes and changes the buttons, to allow for the change just made
            RefreshSavesDisplay();
            ResetSelectedSave();
        }

        private void CBTN_AdminAccess_Click(object sender, EventArgs e)
        {
            // if the button to sign into admin / debug mode is clicked:
            // either signs out of the admin/debug mode (if already signed in) or
            // toggles the view of the password textbox

            // checks if the admin/debug mode is already signed in, if it is, then signs it out
            if (GlobalVariables.AdminAccount == true) { GlobalVariables.AdminAccount = false; }
            else
            {
                // otherwsie checks if the password textbox is already visible or not
                // this toggles the view of the textbox on and off
                if (TXT_AdminPassword.Visible == false) { TXT_AdminPassword.Visible = true; }
                else { TXT_AdminPassword.Visible = false; }
            }
        }

        private void CBTN_Help_Click(object sender, EventArgs e)
        {
            // whenever the help button is clicked, shows this messagebox with the aim and instructions on how to play the game

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

        private void TXT_AdminPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // whenever a key is pressed while focused on the admin/debug password textbox (the player is trying to input somthing into the text box)
            // only allow the input to go through if it isn't a space

            // checks if the key data of the key pressed is enter, this will submit the password
            if (e.KeyChar == (char)Keys.Enter)
            {
                // if the enter key is pressed, then ignore the input of the key
                e.Handled = true;

                // submit the password / check if the password is correct
                if (TXT_AdminPassword.Text == "@InanePotato1")
                {
                    // if it is correct then, set the text of the textbox to nothing
                    TXT_AdminPassword.Text = "";
                    // hide the textbox
                    TXT_AdminPassword.Visible = false;
                    // set the admin account to true, this shows that the admn/debug has been signed into
                    GlobalVariables.AdminAccount = true;
                }
                else
                {
                    // otherwise if the password is wrong:
                    // clear the contents of the textbox
                    TXT_AdminPassword.Text = "";
                    // hide the textbox
                    TXT_AdminPassword.Visible = false;
                    // show a messagebox telling the player that the password is wrong
                    MessageBox.Show("Incorrect password, please try again later!", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } // otherwise checks if the key data of the key pressed is a space, this will ignore the input
            else if (e.KeyChar == (char)Keys.Space)
            {
                // if the key pressed was a space, then ignores the input of the key by setting the handled value to true
                e.Handled = true;
            }
        }
    }
}