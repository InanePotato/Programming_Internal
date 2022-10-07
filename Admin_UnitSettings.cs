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
    public partial class Admin_UnitSettings : Form
    {
        //--------------------------------------------//
        // Declare public variables used in this form //
        //--------------------------------------------//
        bool WindowSnapped; // used to tell if the form is suposed to be 'snapped' and if it accualy is or not
        string filepath = Application.StartupPath + @"\Application_Resources\Unit_Settings.txt"; // set the filepath of the unit settings text file
        bool UnitSelected = false; // used to tell if a unit has been selected to view/edit from the list

        // used to tell if the form is suposed to be 'snapped' and if it accualy is or not
        public Admin_UnitSettings(bool SnappedWindow)
        {
            InitializeComponent();
            // Sets the public variable to the one set when this instance of the form was created
            WindowSnapped = SnappedWindow;
        }

        private void Admin_UnitSettings_Load(object sender, EventArgs e)
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
                PNL_List.Size = new Size(278, this.Height - PNL_Info.Height);
                PNL_List.Location = new Point(0, 0);
                PNL_Info.Location = new Point(0, this.Height - PNL_Info.Height);
                LIST_UnitSettngs.Size = new Size(278, PNL_List.Height - label1.Height);
            }

            // clear the listbox that stores the unit settings
            LIST_UnitSettngs.Items.Clear();

            // goes through all the units in the global variable for unit info
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // adds the unit name to the list box
                LIST_UnitSettngs.Items.Add(i.Name);
            }
        }

        private void LIST_UnitSettngs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sets a variable to store the current selected item in the list box
            string SelectedVariable = LIST_UnitSettngs.GetItemText(LIST_UnitSettngs.SelectedItem);

            // goes through all the units in the global variable for unit info
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // finds the selected varible (via name)
                if (i.Name == SelectedVariable)
                {
                    lbl_Name.Text = i.Name; // updates the text in the name label to the units name
                    txt_Damage.Text = i.Damage.ToString(); // updates the text in the damage label to the units damage
                    txt_Health.Text = i.Health.ToString(); // updates the text in the health label to the units health
                    txt_AttackSpeed.Text = i.Attack_Speed.ToString(); // updates the text in the attack speed label to the units attack speed
                    CB_Range.Text = i.Range; // updates the text in the range label to wether or not the unit is a ranged one
                    txt_Cost.Text = i.Cost.ToString(); // updates the text in the cost label to the purchase cost of the unit

                    //gets the string of abilities from the unit information and splits it by the commas
                    string[] abilities = new string[3];
                    abilities = i.Abilities.Split(' ');

                    // creates new string arrays for each ability, this is for the type and chance
                    string[] ability1_Name = new string[2];
                    string[] ability2_Name = new string[2];
                    string[] ability3_Name = new string[2];

                    // sets each abilities string aray to the name and chance, splitting it by the %
                    if (abilities[0] == "none") { ability1_Name[1] = "none"; }
                    else { ability1_Name = abilities[0].Split('%'); }
                    if (abilities[1] == "none") { ability2_Name[1] = "none"; }
                    else { ability2_Name = abilities[1].Split('%'); }
                    if (abilities[2] == "none") { ability3_Name[1] = "none"; }
                    else { ability3_Name = abilities[2].Split('%'); }

                    // updates the abilities label to the units abilities, using the string arrays from above
                    lbl_Abilities.Text = ability1_Name[1] + Environment.NewLine + ability2_Name[1] + Environment.NewLine + ability3_Name[1];
                    
                    // sets the variable that stores wether a unit is selected or not to true (a unit is selected)
                    UnitSelected = true;
                }
            }
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            // gets the currently selected unit in the list box
            string SelectedVariable = LIST_UnitSettngs.GetItemText(LIST_UnitSettngs.SelectedItem);

            // checks if there is accualy a unit selected
            if (SelectedVariable != null)
            {
                // if there is then:
                // goes through all the units in the global variable Unit_Info
                foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
                {
                    // finds the unit selected (using the names)
                    if (i.Name == SelectedVariable)
                    {
                        // updates the list to the new values for each of the units information (damage, health, attack speed, etc)
                        i.Damage = int.Parse(txt_Damage.Text);
                        i.Health = int.Parse(txt_Health.Text);
                        i.Attack_Speed = int.Parse(txt_AttackSpeed.Text);
                        i.Range = CB_Range.Text;
                        i.Cost = int.Parse(txt_Cost.Text);
                    }
                }

                // creates a new stringbuilder to help write all the new information to the text file
                StringBuilder builder = new StringBuilder();
                // goe through all the units in the global variable Unit_Info
                foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
                {
                    // uses the builder to create a string format with a comma seperating each value
                    // and then puts in wach value (the order listed is the order in the format)
                    //{0} is for the Name, {1} is for the Damage and {2} etc
                    builder.Append(string.Format("{0},{1},{2},{3},{4},{5},{6}{7}", i.Name, i.Damage, i.Health, i.Attack_Speed, i.Range, i.Abilities, i.Cost, Environment.NewLine));
                }
                // once the builder has been set
                // writes the string into the file path given by the filepath variable
                File.WriteAllText(filepath, builder.ToString());
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            // gets the currently selected unit name from the list box
            string SelectedVariable = LIST_UnitSettngs.GetItemText(LIST_UnitSettngs.SelectedItem);

            // checks if there is accualy a unit selected
            if (SelectedVariable != null)
            {
                // goes through all the units in the global variable for unit info
                foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
                {
                    // finds the selected varible (via name)
                    if (i.Name == SelectedVariable)
                    {
                        lbl_Name.Text = i.Name; // updates the text in the name label to the units name
                        txt_Damage.Text = i.Damage.ToString(); // updates the text in the damage label to the units damage
                        txt_Health.Text = i.Health.ToString(); // updates the text in the health label to the units health
                        txt_AttackSpeed.Text = i.Attack_Speed.ToString(); // updates the text in the attack speed label to the units attack speed
                        CB_Range.Text = i.Range; // updates the text in the range label to wether or not the unit is a ranged one
                        txt_Cost.Text = i.Cost.ToString(); // updates the text in the cost label to the purchase cost of the unit

                        //gets the string of abilities from the unit information and splits it by the commas
                        string[] abilities = new string[3];
                        abilities = i.Abilities.Split(' ');

                        // creates new string arrays for each ability, this is for the type and chance
                        string[] ability1_Name = new string[2];
                        string[] ability2_Name = new string[2];
                        string[] ability3_Name = new string[2];

                        // sets each abilities string aray to the name and chance, splitting it by the %
                        if (abilities[0] == "none") { ability1_Name[1] = "none"; }
                        else { ability1_Name = abilities[0].Split('%'); }
                        if (abilities[1] == "none") { ability2_Name[1] = "none"; }
                        else { ability2_Name = abilities[1].Split('%'); }
                        if (abilities[2] == "none") { ability3_Name[1] = "none"; }
                        else { ability3_Name = abilities[2].Split('%'); }

                        // updates the abilities label to the units abilities, using the string arrays from above
                        lbl_Abilities.Text = ability1_Name[1] + Environment.NewLine + ability2_Name[1] + Environment.NewLine + ability3_Name[1];

                        // sets the variable that stores wether a unit is selected or not to true (a unit is selected)
                        UnitSelected = true;
                    }
                }
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            // checks if there is a unit selected from the list box
            if (UnitSelected == true)
            {
                // if there is then:
                // enables the submit edit button
                BTN_Submit.Enabled = true;
                // enables the refresh info button
                BTN_Refresh.Enabled = true;
                // changes the submit buttons cursor to a hand
                BTN_Submit.Cursor = Cursors.Hand;
                // changes the refresh buttons cursor to a hand
                BTN_Refresh.Cursor = Cursors.Hand;
            }
            else
            {
                // otherwise, no unit is selected to view / edit so:
                // dissables the submit edit button
                BTN_Submit.Enabled = false;
                // dissables the refresh info button
                BTN_Refresh.Enabled = false;
                // changes the cursor on the submit button to the default
                BTN_Submit.Cursor = Cursors.Default;
                // changes the cursor on the refresh button to the default
                BTN_Refresh.Cursor = Cursors.Default;
            }

            // checks if the child admin windows should be snapped to the side of the screen,
            // and if this shouldn't be the child admin window open
            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "unit_settings")
            {
                // if so, then closes the form
                this.Close();
            }

            // checks if the admin forms should be closed
            if (GlobalVariables.CloseAdmin == true)
            {
                // is so, then closes the form
                this.Close();
            }
        }

        //-------------------------------------------------//
        // valadates / restrcts the input in the textboxes //
        //-------------------------------------------------//
        private void txt_Damage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if a key is pressed in the damage text box, makes sure the key pressed is either a control (eg. backspace), or a number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // if the key pressed is not a control or number
                // sets the handled variable of the event to true
                // this makes the textbox ignore the keys input
                e.Handled = true;
            }
        }

        private void txt_Health_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if a key is pressed in the health text box, makes sure the key pressed is either a control (eg. backspace), or a number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // if the key pressed is not a control or number
                // sets the handled variable of the event to true
                // this makes the textbox ignore the keys input
                e.Handled = true;
            }
        }

        private void txt_AttackSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if a key is pressed in the attack speed text box, makes sure the key pressed is either a control (eg. backspace), or a number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // if the key pressed is not a control or number
                // sets the handled variable of the event to true
                // this makes the textbox ignore the keys input
                e.Handled = true;
            }
        }

        private void txt_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if a key is pressed in the cost text box, makes sure the key pressed is either a control (eg. backspace), or a number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // if the key pressed is not a control or number
                // sets the handled variable of the event to true
                // this makes the textbox ignore the keys input
                e.Handled = true;
            }
        }
    }
}
