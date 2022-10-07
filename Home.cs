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
        string Saves_FilePath = Application.StartupPath + @"\Application_Resources\Saves.txt";
        List<string> SaveNames = new List<string>();
        bool NoSaves;
        string SelectedSaveName;

        public Home()
        {
            InitializeComponent();

            //
            // reads the file Saves (using the binPath created earler to find the location)
            //

            var reader = new StreamReader(Saves_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.SaveInfo.Add(new Get_Save_Info(values[0], Int32.Parse(values[1]), Int32.Parse(values[2]), values[3], values[4], values[5], values[6], values[7], bool.Parse(values[8]), Int32.Parse(values[9]), Int32.Parse(values[10]), bool.Parse(values[11]), Int32.Parse(values[12]), Int32.Parse(values[13]), bool.Parse(values[14]), Int32.Parse(values[15]), Int32.Parse(values[16]), bool.Parse(values[17]), Int32.Parse(values[18]), Int32.Parse(values[19]), bool.Parse(values[20]), Int32.Parse(values[21]), Int32.Parse(values[22])));
            }
            reader.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.SaveInfo.Count == 0 || GlobalVariables.SaveInfo == null) { NoSaves = true; }
            else
            {
                NoSaves = false;
                SaveNames.Clear();

                foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
                {
                    SaveNames.Add(save.Name);
                }

                if (SaveNames.Count > 0) { BTN_Save1.Text = SaveNames[0]; }
                if (SaveNames.Count > 1) { BTN_Save2.Text = SaveNames[1]; }
                if (SaveNames.Count > 2) { BTN_Save3.Text = SaveNames[2]; }
                if (SaveNames.Count > 3) { BTN_Save4.Text = SaveNames[3]; }
            }

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
            GlobalVariables.CurrentSaveName = SelectedSaveName;

            foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
            {
                if (save.Name == GlobalVariables.CurrentSaveName)
                {
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

            ResetSelectedSave();

            new Game().Show();
            GlobalVariables.frmHome.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
            {
                //{0} is for the Name, {1} is for the Coins ...
                builder.Append(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22}{23}",save.Name, save.Coins, save.Levels_Unlocked, save.Slot1_Contents, save.Slot2_Contents, save.Slot3_Contents, save.Slot4_Contents, save.Slot5_Contents, save.Basic_Unlocked, save.Basic_Count, save.Basic_Level, save.Range_Unlocked, save.Range_Count, save.Range_Level, save.Magic_Unlocked, save.Magic_Count, save.Magic_Level, save.Gun_Unlocked, save.Gun_Count, save.Gun_Level, save.Giant_Unlocked, save.Giant_Count, save.Giant_Level, Environment.NewLine));
            }
            File.WriteAllText(Saves_FilePath, builder.ToString());

            Application.Exit();
        }

        private void TMR_Controls_Tick(object sender, EventArgs e)
        {
            if (SelectedSaveName == null || SelectedSaveName == "" || NoSaves == true)
            {
                BTN_Play.Enabled = false;
            }
            else
            {
                BTN_Play.Enabled = true;
            }

            if (TXT_CreateSaveName.Text == "" || TXT_CreateSaveName.Text == null)
            {
                BTN_CreateNewSave.Enabled = false;
            }
            else
            {
                BTN_CreateNewSave.Enabled = true;
            }

            if (GlobalVariables.AdminAccount == true)
            {
                CBTN_AdminAccess.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                if (TXT_AdminPassword.Visible == true) { CBTN_AdminAccess.BackColor = Color.Gainsboro; }
                else { CBTN_AdminAccess.BackColor = Color.Silver; }
            }
        }

        public void ResetSelectedSave()
        {
            SelectedSaveName = null;
            CBTN_DeleteSelectedSave.Visible = false;

            BTN_Save1.Enabled = true;
            BTN_Save2.Enabled = true;
            BTN_Save3.Enabled = true;
            BTN_Save4.Enabled = true;

            BTN_Save1.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Save2.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Save3.BackColor = Color.FromArgb(150, 0, 0, 0);
            BTN_Save4.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void BTN_Save1_Click(object sender, EventArgs e)
        {
            ResetSelectedSave();

            if (BTN_Save1.Text != "[ New Save ]")
            {
                SelectedSaveName = BTN_Save1.Text;
                BTN_Save1.Enabled = false;
                BTN_Save1.BackColor = Color.FromArgb(80, 0, 0, 0);
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                SelectedSaveName = null;
                SetupCreateSave();
            }
        }

        private void BTN_Save2_Click(object sender, EventArgs e)
        {
            ResetSelectedSave();

            if (BTN_Save2.Text != "[ New Save ]")
            {
                SelectedSaveName = BTN_Save2.Text;
                BTN_Save2.Enabled = false;
                BTN_Save2.BackColor = Color.FromArgb(80, 0, 0, 0);
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                SelectedSaveName = null;
                SetupCreateSave();
            }
        }

        private void BTN_Save3_Click(object sender, EventArgs e)
        {
            ResetSelectedSave();

            if (BTN_Save3.Text != "[ New Save ]")
            {
                SelectedSaveName = BTN_Save3.Text;
                BTN_Save3.Enabled = false;
                BTN_Save3.BackColor = Color.FromArgb(80, 0, 0, 0);
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                SelectedSaveName = null;
                SetupCreateSave();
            }
        }

        private void BTN_Save4_Click(object sender, EventArgs e)
        {
            ResetSelectedSave();

            if (BTN_Save4.Text != "[ New Save ]")
            {
                SelectedSaveName = BTN_Save4.Text;
                BTN_Save4.Enabled = false;
                BTN_Save4.BackColor = Color.FromArgb(80, 0, 0, 0);
                CBTN_DeleteSelectedSave.Visible = true;
            }
            else
            {
                SelectedSaveName = null;
                SetupCreateSave();
            }
        }

        public void SetupCreateSave()
        {
            BTN_Save1.Visible = false;
            BTN_Save2.Visible = false;
            BTN_Save3.Visible = false;
            BTN_Save4.Visible = false;
            BTN_Play.Visible = false;

            TXT_CreateSaveName.Visible = true;
            LBL_CreateSave.Visible = true;
            BTN_BackToSelect.Visible = true;
            BTN_CreateNewSave.Visible = true;
        }

        public void SetupSelectSave()
        {
            BTN_Save1.Visible = true;
            BTN_Save2.Visible = true;
            BTN_Save3.Visible = true;
            BTN_Save4.Visible = true;
            BTN_Play.Visible = true;

            TXT_CreateSaveName.Visible = false;
            LBL_CreateSave.Visible = false;
            BTN_BackToSelect.Visible = false;
            BTN_CreateNewSave.Visible = false;
        }

        private void BTN_BackToSelect_Click(object sender, EventArgs e)
        {
            SetupSelectSave();

            TXT_CreateSaveName.Text = "";
        }

        private void BTN_CreateNewSave_Click(object sender, EventArgs e)
        {
            SetupSelectSave();

            GlobalVariables.SaveInfo.Add(new Get_Save_Info(TXT_CreateSaveName.Text, 100, 1, "basic", "range", "", "", "", true, 5, 0, true, 2, 0, false, 0, 0, false, 0, 0, false, 0, 0));

            TXT_CreateSaveName.Text = "";

            RefreshSavesDisplay();
        }

        private void TXT_CreateSaveName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void RefreshSavesDisplay()
        {
            if (GlobalVariables.SaveInfo.Count == 0 || GlobalVariables.SaveInfo == null)
            {
                NoSaves = true;

                BTN_Save1.Text = "[ New Save ]";
                BTN_Save2.Text = "[ New Save ]";
                BTN_Save3.Text = "[ New Save ]";
                BTN_Save4.Text = "[ New Save ]";
            }
            else
            {
                NoSaves = false;
                SaveNames.Clear();

                foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
                {
                    SaveNames.Add(save.Name);
                }

                if (SaveNames.Count > 0) { BTN_Save1.Text = SaveNames[0]; }
                else { BTN_Save1.Text = "[ New Save ]"; }
                if (SaveNames.Count > 1) { BTN_Save2.Text = SaveNames[1]; }
                else { BTN_Save2.Text = "[ New Save ]"; }
                if (SaveNames.Count > 2) { BTN_Save3.Text = SaveNames[2]; }
                else { BTN_Save3.Text = "[ New Save ]"; }
                if (SaveNames.Count > 3) { BTN_Save4.Text = SaveNames[3]; }
                else { BTN_Save4.Text = "[ New Save ]"; }
            }
        }

        private void CBTN_DeleteSelectedSave_Click(object sender, EventArgs e)
        {
            if (SelectedSaveName != null && SelectedSaveName != "")
            {
                DialogResult ConfirmDeleteResult = MessageBox.Show("Are you sure you want to delete this saved game? This action can't be reversed.", "Confirm save deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ConfirmDeleteResult == DialogResult.Yes)
                {
                    foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
                    {
                        if (save.Name == SelectedSaveName)
                        {
                            GlobalVariables.SaveInfo.Remove(save);
                            break;
                        }
                    }
                }
            }

            
            RefreshSavesDisplay();
            ResetSelectedSave();
        }

        private void CBTN_AdminAccess_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.AdminAccount == true) { GlobalVariables.AdminAccount = false; }
            else
            {
                if (TXT_AdminPassword.Visible == false) { TXT_AdminPassword.Visible = true; }
                else { TXT_AdminPassword.Visible = false; }
            }
        }

        private void CBTN_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The aim of the game is to defeat all 20 levels of evil lemons on your quest to receive grapes."
                + Environment.NewLine + Environment.NewLine + "How to play:" + Environment.NewLine +
                "The game is mostly self-explanatory, you can build your army and order your troops by clicking the plusses in each troop slot in your army camp. " +
                "If you wish to purchase more units or upgrade your current ones, you can click onto the shop sign in your army camp. " +
                "To fight, just click on the map sign in your army camp, select a level, and you’re on your way to victory or certain death." +
                "Be carful when you fight and advancing through levels, if the troops die during battle, there is no bringing them back", "Instructions",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TXT_AdminPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                

                if (TXT_AdminPassword.Text == "@InanePotato1")
                {
                    TXT_AdminPassword.Text = "";
                    TXT_AdminPassword.Visible = false;
                    GlobalVariables.AdminAccount = true;
                }
                else
                {
                    TXT_AdminPassword.Text = "";
                    TXT_AdminPassword.Visible = false;
                    MessageBox.Show("Incorrect password, please try again later!", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
