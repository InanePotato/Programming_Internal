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
        bool WindowSnapped;
        string filepath = Application.StartupPath + @"\Application_Resources\Unit_Settings.txt";
        bool UnitSelected = false;

        public Admin_UnitSettings(bool SnappedWindow)
        {
            InitializeComponent();
            WindowSnapped = SnappedWindow;
        }

        private void Admin_UnitSettings_Load(object sender, EventArgs e)
        {
            if (WindowSnapped == true)
            {
                this.TopMost = true;

                this.Size = new Size(278, Screen.FromHandle(this.Handle).WorkingArea.Height);
                this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width - this.Width, 0);

                PNL_List.Size = new Size(278, this.Height - PNL_Info.Height);
                PNL_List.Location = new Point(0, 0);
                PNL_Info.Location = new Point(0, this.Height - PNL_Info.Height);

                LIST_UnitSettngs.Size = new Size(278, PNL_List.Height - label1.Height);
            }

            LIST_UnitSettngs.Items.Clear();

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                LIST_UnitSettngs.Items.Add(i.Name);
            }
        }

        private void LIST_UnitSettngs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedVariable = LIST_UnitSettngs.GetItemText(LIST_UnitSettngs.SelectedItem);

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == SelectedVariable)
                {
                    lbl_Name.Text = i.Name;
                    txt_Damage.Text = i.Damage.ToString();
                    txt_Health.Text = i.Health.ToString();
                    txt_AttackSpeed.Text = i.Attack_Speed.ToString();
                    CB_Range.Text = i.Range;
                    txt_Cost.Text = i.Cost.ToString();

                    string[] abilities = new string[3];
                    abilities = i.Abilities.Split(' ');

                    string[] ability1_Name = new string[2];
                    string[] ability2_Name = new string[2];
                    string[] ability3_Name = new string[2];

                    if (abilities[0] == "none") { ability1_Name[1] = "none"; }
                    else { ability1_Name = abilities[0].Split('%'); }
                    if (abilities[1] == "none") { ability2_Name[1] = "none"; }
                    else { ability2_Name = abilities[1].Split('%'); }
                    if (abilities[2] == "none") { ability3_Name[1] = "none"; }
                    else { ability3_Name = abilities[2].Split('%'); }

                    lbl_Abilities.Text = ability1_Name[1] + Environment.NewLine + ability2_Name[1] + Environment.NewLine + ability3_Name[1];

                    UnitSelected = true;
                }
            }
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            string SelectedVariable = LIST_UnitSettngs.GetItemText(LIST_UnitSettngs.SelectedItem);
            if (SelectedVariable != null)
            {
                foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
                {
                    if (i.Name == SelectedVariable)
                    {
                        i.Damage = int.Parse(txt_Damage.Text);
                        i.Health = int.Parse(txt_Health.Text);
                        i.Attack_Speed = int.Parse(txt_AttackSpeed.Text);
                        i.Range = CB_Range.Text;
                        i.Cost = int.Parse(txt_Cost.Text);
                    }
                }

                StringBuilder builder = new StringBuilder();
                foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
                {
                    //{0} is for the Name, {1} is for the Score and {2} is for a new line
                    builder.Append(string.Format("{0},{1},{2},{3},{4},{5},{6}{7}", i.Name, i.Damage, i.Health, i.Attack_Speed, i.Range, i.Abilities, i.Cost, Environment.NewLine));
                }
                File.WriteAllText(filepath, builder.ToString());
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            string SelectedVariable = LIST_UnitSettngs.GetItemText(LIST_UnitSettngs.SelectedItem);

            if (SelectedVariable != null)
            {
                foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
                {
                    if (i.Name == SelectedVariable)
                    {
                        lbl_Name.Text = i.Name;
                        txt_Damage.Text = i.Damage.ToString();
                        txt_Health.Text = i.Health.ToString();
                        txt_AttackSpeed.Text = i.Attack_Speed.ToString();
                        CB_Range.Text = i.Range;
                        txt_Cost.Text = i.Cost.ToString();

                        string[] abilities = new string[3];
                        abilities = i.Abilities.Split(' ');

                        string[] ability1_Name = new string[2];
                        string[] ability2_Name = new string[2];
                        string[] ability3_Name = new string[2];

                        if (abilities[0] == "none") { ability1_Name[1] = "none"; }
                        else { ability1_Name = abilities[0].Split('%'); }
                        if (abilities[1] == "none") { ability2_Name[1] = "none"; }
                        else { ability2_Name = abilities[1].Split('%'); }
                        if (abilities[2] == "none") { ability3_Name[1] = "none"; }
                        else { ability3_Name = abilities[2].Split('%'); }

                        lbl_Abilities.Text = ability1_Name[1] + Environment.NewLine + ability2_Name[1] + Environment.NewLine + ability3_Name[1];
                    }
                }
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            if (UnitSelected == true)
            {
                BTN_Submit.Enabled = true;
                BTN_Refresh.Enabled = true;
                BTN_Submit.Cursor = Cursors.Hand;
                BTN_Refresh.Cursor = Cursors.Hand;
            }
            else
            {
                BTN_Submit.Enabled = false;
                BTN_Refresh.Enabled = false;
                BTN_Submit.Cursor = Cursors.Default;
                BTN_Refresh.Cursor = Cursors.Default;
            }

            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "unit_settings")
            {
                this.Close();
            }

            if (GlobalVariables.CloseAdmin == true)
            {
                this.Close();
            }
        }

        private void txt_Damage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Health_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_AttackSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
