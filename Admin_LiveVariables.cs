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
    public partial class Admin_LiveVariables : Form
    {
        //--------------------------------------------//
        // Declare public variables used in this form //
        //--------------------------------------------//
        List<Get_LiveVars> LiveVars = new List<Get_LiveVars>(); //Used to store information about each global variable
        bool VarSelected = false; // Used to store what variable has been selected from the list to view / edit
        string SelectedVariableType; // Used to store the type of variable being viewed so the panel can be correctly ajusted
        bool WindowSnapped; // Used to tell wether this form should be snapped to the side of the screen or not

        // requires to know if in needs to be 'snapped' to the side of the screen or not when creating a new instance of this form
        public Admin_LiveVariables(bool SnappedWindow)
        {
            InitializeComponent();
            // Sets the public variable to the one set when this instance of the form was created
            WindowSnapped = SnappedWindow;
        }

        private void Admin_LiveVariables_Load(object sender, EventArgs e)
        {
            // checks if the form should be snapped to the side of the screen or not
            if (WindowSnapped == true)
            {
                // if it is, then ajust the layout of the form accordingly

                // make this form the top most form on the players screen
                this.TopMost = true;

                // change the size of the form to take up the whole hight of the screen and a set width
                this.Size = new Size(278, Screen.FromHandle(this.Handle).WorkingArea.Height);
                // change the location of the form to be in the top right corner of the players screen
                this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width - this.Width, 0);

                // adjusts the components of the form to account for the new size
                PNL_List.Size = new Size(278, this.Height - PNL_Info.Height);
                PNL_List.Location = new Point(0, 0);
                PNL_Info.Location = new Point(0, this.Height - PNL_Info.Height);
                LIST_Variables.Size = new Size(278, PNL_List.Height - label1.Height);
            }

            // call on the public void that gets the information about the global variables
            Get_Vars();
        }

        private void LIST_Variables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the list to be used below
            string SelectedVariable = LIST_Variables.GetItemText(LIST_Variables.SelectedItem);

            // finds the variable selected in the list
            foreach (Get_LiveVars var in LiveVars)
            {
                // checks for a match in the variable names
                if (var.Name == SelectedVariable)
                {
                    // once the variable has been found:

                    lbl_Name.Text = var.Name; // changes the label for the variable's name to the correct name
                    lbl_Type.Text = var.Type; // changes the label for the variable's type (bool, int, scring, etc) to the correct type
                    SelectedVariableType = var.Type; // updates the variable that stores the type of variable selected

                    // adjusts the forms layout depending on what type of variable is selected
                    if (var.Type == "bool")
                    {
                        // if a type bool is selected:

                        Toggle_Value.Visible = true; // shows the true/false toggle button
                        label6.Visible = true; // shows the label that shows what side of the toggle button corresponds to true
                        label7.Visible = true; // shows the label that shows what side of the toggle button corresponds to false
                        txt_Value.Visible = false; // hides the type int/string input textbox
                        LB_Value.Visible = false; // hides the list box used for the array types

                        // sets the toggle buttons value to the correct option
                        if (var.Value == "true") { Toggle_Value.Checked = true; }
                        else { Toggle_Value.Checked = false; }

                        // sets the variable that stores whether a variable is selected or not to true (one is selected)
                        VarSelected = true;
                    }
                    else if (var.Type == "string_array")
                    {
                        // if a type string array is selected:

                        Toggle_Value.Visible = false; // hides the toggle button that shows used for the bool variable type
                        label6.Visible = false; // hides the label used along with the toggle button with the bool's
                        label7.Visible = false; // hides the label used along with the toggle button with the bool's
                        txt_Value.Visible = false; // hides the type int/string input textbox
                        LB_Value.Visible = true; // shows the list box that displays each item of the string array

                        // clears all the items in the list box
                        LB_Value.Items.Clear();

                        // seperates all the values that belong to the string array
                        var values = var.Value.Split(',');

                        // adds each value into the list box
                        foreach (var value in values)
                        {
                            LB_Value.Items.Add(value);
                        }

                        // sets the variable that stores whether a variable is selected or not to true (one is selected)
                        VarSelected = true;
                    }
                    else
                    {
                        // If the variable type selected isn't one of the ubove types, it then must either be a int or string (both treated the same)

                        Toggle_Value.Visible = false; // hides the toggle button that shows used for the bool variable type
                        label6.Visible = false; // hides the label used along with the toggle button with the bool's
                        label7.Visible = false; // hides the label used along with the toggle button with the bool's
                        txt_Value.Visible = true; // shows the text box used for the string or int variable types
                        LB_Value.Visible = false; // hides the list box used for the array types

                        // sets the text inside the textbox to the current value of the selected variable
                        txt_Value.Text = var.Value;

                        // sets the variable that stores whether a variable is selected or not to true (one is selected)
                        VarSelected = true;
                    }
                }
            }
        }

        // whenever the Get_Vars event is called
        public void Get_Vars()
        {
            // clears everything in the list
            LiveVars.Clear();

            // Goes through all the global variable type ints and adds them to the list
            LiveVars.Add(new Get_LiveVars("UnitUpgrades_Basic", "int", GlobalVariables.UnitUpgrades_Basic.ToString()));
            LiveVars.Add(new Get_LiveVars("UnitUpgrades_Range", "int", GlobalVariables.UnitUpgrades_Range.ToString()));
            LiveVars.Add(new Get_LiveVars("UnitUpgrades_Magic", "int", GlobalVariables.UnitUpgrades_Magic.ToString()));
            LiveVars.Add(new Get_LiveVars("UnitUpgrades_Gun", "int", GlobalVariables.UnitUpgrades_Gun.ToString()));
            LiveVars.Add(new Get_LiveVars("UnitUpgrades_Giant", "int", GlobalVariables.UnitUpgrades_Giant.ToString()));

            LiveVars.Add(new Get_LiveVars("Coins", "int", GlobalVariables.Coins.ToString()));
            LiveVars.Add(new Get_LiveVars("Strength", "int", GlobalVariables.Strength.ToString()));
            LiveVars.Add(new Get_LiveVars("Health", "int", GlobalVariables.Health.ToString()));
            LiveVars.Add(new Get_LiveVars("Levels_Unlocked", "int", GlobalVariables.LevelsUnlocked.ToString()));

            LiveVars.Add(new Get_LiveVars("BasicUnit_Count", "int", GlobalVariables.BasicUnit_Count.ToString()));
            LiveVars.Add(new Get_LiveVars("RangeUnit_Count", "int", GlobalVariables.RangeUnit_Count.ToString()));
            LiveVars.Add(new Get_LiveVars("MagicUnit_Count", "int", GlobalVariables.MagicUnit_Count.ToString()));
            LiveVars.Add(new Get_LiveVars("GunUnit_Count", "int", GlobalVariables.GunUnit_Count.ToString()));
            LiveVars.Add(new Get_LiveVars("GiantUnit_Count", "int", GlobalVariables.GiantUnit_Count.ToString()));

            // Goes through all the global variable type bools and adds them to the list
            LiveVars.Add(new Get_LiveVars("Paused", "bool", GlobalVariables.Paused.ToString()));

            LiveVars.Add(new Get_LiveVars("BasicUnitUnlocked", "bool", GlobalVariables.BasicUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("RangeUnitUnlocked", "bool", GlobalVariables.RangeUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("MagicUnitUnlocked", "bool", GlobalVariables.MagicUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("GunUnitUnlocked", "bool", GlobalVariables.GunUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("GiantUnitUnlocked", "bool", GlobalVariables.GiantUnitUnlocked.ToString()));

            // Goes through all the global variable type string arrays and adds them to the list
            LiveVars.Add(new Get_LiveVars("SlotContents ", "string_array", GlobalVariables.SlotContents[0] + "," + GlobalVariables.SlotContents[1] + "," + GlobalVariables.SlotContents[2] + "," + GlobalVariables.SlotContents[3] + "," + GlobalVariables.SlotContents[4]));

            // clears everything in the display list box
            LIST_Variables.Items.Clear();

            // updates the list that displays all the current variables in the just updated list
            foreach(Get_LiveVars var in LiveVars)
            {
                LIST_Variables.Items.Add(var.Name);
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            // checks if there is currently a variable selected to view / edit
            if (VarSelected == true)
            {
                // if a variable is currently selected to view / edit:

                BTN_Submit.Enabled = true; // enables the submit edit button
                BTN_Refresh.Enabled = true; // enables the refresh value button
                txt_Value.Enabled = true; // enables the textbox where the player can edit the value
                BTN_Submit.Cursor = Cursors.Hand; // changes the submit buttons hover cursor to a hand
                BTN_Refresh.Cursor = Cursors.Hand; // changes the refresh buttons hover cursor to a hand
            }
            else
            {
                // otherwise if no variable is selected:

                BTN_Submit.Enabled = false; // dissables the submis edit button
                BTN_Refresh.Enabled = false; // dissables the refresh value button
                txt_Value.Enabled = false; // dissables the textbox the player uses to edit the value
                BTN_Submit.Cursor = Cursors.Default; // changes the submit buttons hover cursor the default cursor
                BTN_Refresh.Cursor = Cursors.Default; // changes the refresh buttons hover cursor the default cursor
            }

            // checks if the open admin child window should be snapped but shouldn't be this window
            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "live_vars")
            {
                // if it is, then closes the form
                this.Close();
            }

            // checks if the admin forms should be closed
            if (GlobalVariables.CloseAdmin == true)
            {
                // if they should, then closes the form
                this.Close();
            }
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            // gets the currently selected variable from the list box
            string SelectedVariable = LIST_Variables.GetItemText(LIST_Variables.SelectedItem);

            // checks if the value isn't set to anything
            if (SelectedVariable != null)
            {
                // if the selected variable isn't nothing then:

                // goes through all the variables in the list and checks if they are the selected one
                // if it is the selected variable then it's corresponding global variable will be updated
                if (SelectedVariable == "UnitUpgrades_Basic") { GlobalVariables.UnitUpgrades_Basic = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "UnitUpgrades_Range") { GlobalVariables.UnitUpgrades_Range = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "UnitUpgrades_Magic") { GlobalVariables.UnitUpgrades_Magic = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "UnitUpgrades_Gun") { GlobalVariables.UnitUpgrades_Gun = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "UnitUpgrades_Giant") { GlobalVariables.UnitUpgrades_Giant = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "Coins") { GlobalVariables.Coins = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "Strength") { GlobalVariables.Strength = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "Health") { GlobalVariables.Health = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "Levels_Unlocked") { GlobalVariables.LevelsUnlocked = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "BasicUnit_Count") { GlobalVariables.BasicUnit_Count = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "RangeUnit_Count") { GlobalVariables.RangeUnit_Count = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "MagicUnit_Count") { GlobalVariables.MagicUnit_Count = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "GunUnit_Count") { GlobalVariables.GunUnit_Count = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "GiantUnit_Count") { GlobalVariables.GiantUnit_Count = int.Parse(txt_Value.Text); }
                else if (SelectedVariable == "Paused")
                { 
                    if (Toggle_Value.Checked == true) { GlobalVariables.Paused = true; }
                    else { GlobalVariables.Paused = false; }
                }
                else if (SelectedVariable == "BasicUnitUnlocked")
                {
                    if (Toggle_Value.Checked == true) { GlobalVariables.BasicUnitUnlocked = true; }
                    else { GlobalVariables.BasicUnitUnlocked = false; }
                }
                else if (SelectedVariable == "RangeUnitUnlocked")
                {
                    if (Toggle_Value.Checked == true) { GlobalVariables.BasicUnitUnlocked = true; }
                    else { GlobalVariables.BasicUnitUnlocked = false; }
                }
                else if (SelectedVariable == "MagicUnitUnlocked")
                {
                    if (Toggle_Value.Checked == true) { GlobalVariables.BasicUnitUnlocked = true; }
                    else { GlobalVariables.BasicUnitUnlocked = false; }
                }
                else if (SelectedVariable == "GunUnitUnlocked")
                {
                    if (Toggle_Value.Checked == true) { GlobalVariables.BasicUnitUnlocked = true; }
                    else { GlobalVariables.BasicUnitUnlocked = false; }
                }
                else if (SelectedVariable == "GiantUnitUnlocked")
                {
                    if (Toggle_Value.Checked == true) { GlobalVariables.BasicUnitUnlocked = true; }
                    else { GlobalVariables.BasicUnitUnlocked = false; }
                }
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            // gets the currently selected item in the list box
            string SelectedVariable = LIST_Variables.GetItemText(LIST_Variables.SelectedItem);

            // checks if there is no selected value
            if (SelectedVariable != null)
            {
                // goes through all the values in the list
                foreach (Get_LiveVars var in LiveVars)
                {
                    // finds the selected variable in the list
                    if (var.Name == SelectedVariable)
                    {
                        // updates the name of the variable
                        lbl_Name.Text = var.Name;
                        // updates the type of the variable
                        lbl_Type.Text = var.Type;
                        // updates the variable that stores the type of variable that is selected
                        SelectedVariableType = var.Type;

                        // adjusts the forms layout depending on what type of variable is selected
                        if (var.Type == "bool")
                        {
                            // if a type bool is selected:

                            Toggle_Value.Visible = true; // shows the true/false toggle button
                            label6.Visible = true; // shows the label that shows what side of the toggle button corresponds to true
                            label7.Visible = true; // shows the label that shows what side of the toggle button corresponds to false
                            txt_Value.Visible = false; // hides the type int/string input textbox
                            LB_Value.Visible = false; // hides the list box used for the array types

                            // sets the toggle buttons value to the correct option
                            if (var.Value == "true") { Toggle_Value.Checked = true; }
                            else { Toggle_Value.Checked = false; }

                            // sets the variable that stores whether a variable is selected or not to true (one is selected)
                            VarSelected = true;
                        }
                        else if (var.Type == "string_array")
                        {
                            // if a type string array is selected:

                            Toggle_Value.Visible = false; // hides the toggle button that shows used for the bool variable type
                            label6.Visible = false; // hides the label used along with the toggle button with the bool's
                            label7.Visible = false; // hides the label used along with the toggle button with the bool's
                            txt_Value.Visible = false; // hides the type int/string input textbox
                            LB_Value.Visible = true; // shows the list box that displays each item of the string array

                            // clears all the items in the list box
                            LB_Value.Items.Clear();

                            // seperates all the values that belong to the string array
                            var values = var.Value.Split(',');

                            // adds each value into the list box
                            foreach (var value in values)
                            {
                                LB_Value.Items.Add(value);
                            }

                            // sets the variable that stores whether a variable is selected or not to true (one is selected)
                            VarSelected = true;
                        }
                        else
                        {
                            // If the variable type selected isn't one of the ubove types, it then must either be a int or string (both treated the same)

                            Toggle_Value.Visible = false; // hides the toggle button that shows used for the bool variable type
                            label6.Visible = false; // hides the label used along with the toggle button with the bool's
                            label7.Visible = false; // hides the label used along with the toggle button with the bool's
                            txt_Value.Visible = true; // shows the text box used for the string or int variable types
                            LB_Value.Visible = false; // hides the list box used for the array types

                            // sets the text inside the textbox to the current value of the selected variable
                            txt_Value.Text = var.Value;

                            // sets the variable that stores whether a variable is selected or not to true (one is selected)
                            VarSelected = true;
                        }
                    }
                }
            }
        }

        private void txt_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            // whenever a key is pressed and the player is focused on the value texbox
            // checks if the selected variable type is an int
            if (SelectedVariableType == "int")
            {
                // if a type int is selected then, checks if the key pressed ISN'T a control (eg. backspace) or number
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    // if it isn't either one of the allowed types of keys, then sets the handles value of the key press to true
                    // this makes the textbox ignore the input of the key pressed
                    e.Handled = true;
                }
            }
        }
    }
}
