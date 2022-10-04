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
        List<Get_LiveVars> LiveVars = new List<Get_LiveVars>();
        bool VarSelected = false;
        string SelectedVariableType;
        bool WindowSnapped;

        public Admin_LiveVariables(bool SnappedWindow)
        {
            InitializeComponent();
            WindowSnapped = SnappedWindow;
        }

        private void Admin_LiveVariables_Load(object sender, EventArgs e)
        {
            if (WindowSnapped == true)
            {
                this.TopMost = true;

                this.Size = new Size(278, Screen.FromHandle(this.Handle).WorkingArea.Height);
                this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width - this.Width, 0);

                PNL_List.Size = new Size(278, this.Height - PNL_Info.Height);
                PNL_List.Location = new Point(0, 0);
                PNL_Info.Location = new Point(0, this.Height - PNL_Info.Height);

                LIST_Variables.Size = new Size(278, PNL_List.Height - label1.Height);
            }

            Get_Vars();
        }

        private void LIST_Variables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedVariable = LIST_Variables.GetItemText(LIST_Variables.SelectedItem);

            foreach (Get_LiveVars var in LiveVars)
            {
                if (var.Name == SelectedVariable)
                {
                    lbl_Name.Text = var.Name;
                    lbl_Type.Text = var.Type;
                    SelectedVariableType = var.Type;

                    if (var.Type == "bool")
                    {
                        Toggle_Value.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        txt_Value.Visible = false;
                        LB_Value.Visible = false;

                        if (var.Value == "true") { Toggle_Value.Checked = true; }
                        else { Toggle_Value.Checked = false; }

                        VarSelected = true;
                    }
                    else if (var.Type == "string_array")
                    {
                        Toggle_Value.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        txt_Value.Visible = false;
                        LB_Value.Visible = true;

                        LB_Value.Items.Clear();

                        var values = var.Value.Split(',');

                        foreach (var value in values)
                        {
                            LB_Value.Items.Add(value);
                        }

                        VarSelected = true;
                    }
                    else
                    {
                        Toggle_Value.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        txt_Value.Visible = true;
                        LB_Value.Visible = false;

                        txt_Value.Text = var.Value;

                        VarSelected = true;
                    }
                }
            }
        }

        public void Get_Vars()
        {
            LiveVars.Clear();

            // intergers
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

            // booleans
            LiveVars.Add(new Get_LiveVars("Paused", "bool", GlobalVariables.Paused.ToString()));

            LiveVars.Add(new Get_LiveVars("BasicUnitUnlocked", "bool", GlobalVariables.BasicUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("RangeUnitUnlocked", "bool", GlobalVariables.RangeUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("MagicUnitUnlocked", "bool", GlobalVariables.MagicUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("GunUnitUnlocked", "bool", GlobalVariables.GunUnitUnlocked.ToString()));
            LiveVars.Add(new Get_LiveVars("GiantUnitUnlocked", "bool", GlobalVariables.GiantUnitUnlocked.ToString()));

            // strings

            // string arrays
            LiveVars.Add(new Get_LiveVars("SlotContents ", "string_array", GlobalVariables.SlotContents[0] + "," + GlobalVariables.SlotContents[1] + "," + GlobalVariables.SlotContents[2] + "," + GlobalVariables.SlotContents[3] + "," + GlobalVariables.SlotContents[4]));


            // update list
            foreach(Get_LiveVars var in LiveVars)
            {
                LIST_Variables.Items.Add(var.Name);
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            if (VarSelected == true)
            {
                BTN_Submit.Enabled = true;
                BTN_Refresh.Enabled = true;
                txt_Value.Enabled = true;
                BTN_Submit.Cursor = Cursors.Hand;
                BTN_Refresh.Cursor = Cursors.Hand;
            }
            else
            {
                BTN_Submit.Enabled = false;
                BTN_Refresh.Enabled = false;
                txt_Value.Enabled = false;
                BTN_Submit.Cursor = Cursors.Default;
                BTN_Refresh.Cursor = Cursors.Default;
            }

            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "live_vars")
            {
                this.Close();
            }

            if (GlobalVariables.CloseAdmin == true)
            {
                this.Close();
            }
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Toggle_Value.Checked.ToString());

            string SelectedVariable = LIST_Variables.GetItemText(LIST_Variables.SelectedItem);

            if (SelectedVariable != null)
            {
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
            string SelectedVariable = LIST_Variables.GetItemText(LIST_Variables.SelectedItem);

            if (SelectedVariable != null)
            {
                foreach (Get_LiveVars var in LiveVars)
                {
                    if (var.Name == SelectedVariable)
                    {
                        lbl_Name.Text = var.Name;
                        lbl_Type.Text = var.Type;
                        SelectedVariableType = var.Type;

                        if (var.Type == "bool")
                        {
                            Toggle_Value.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            txt_Value.Visible = false;
                            LB_Value.Visible = false;

                            if (var.Value == "true") { Toggle_Value.Checked = true; }
                            else { Toggle_Value.Checked = false; }

                            VarSelected = true;
                        }
                        else if (var.Type == "string_array")
                        {
                            Toggle_Value.Visible = false;
                            label6.Visible = false;
                            label7.Visible = false;
                            txt_Value.Visible = false;
                            LB_Value.Visible = true;

                            LB_Value.Items.Clear();

                            var values = var.Value.Split(',');

                            foreach (var value in values)
                            {
                                LB_Value.Items.Add(value);
                            }

                            VarSelected = true;
                        }
                        else
                        {
                            Toggle_Value.Visible = false;
                            label6.Visible = false;
                            label7.Visible = false;
                            txt_Value.Visible = true;
                            LB_Value.Visible = false;

                            txt_Value.Text = var.Value;

                            VarSelected = true;
                        }
                    }
                }
            }
        }

        private void txt_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SelectedVariableType == "int")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
