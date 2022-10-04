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
        bool WindowSnapped;

        public Admin_Saves(bool SnappedWindow)
        {
            InitializeComponent();
            WindowSnapped = SnappedWindow;
        }

        private void Admin_Saves_Load(object sender, EventArgs e)
        {
            if (WindowSnapped == true)
            {
                this.TopMost = true;

                this.Size = new Size(278, Screen.FromHandle(this.Handle).WorkingArea.Height);
                this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width - this.Width, 0);

                PNL_Saves.Location = new Point(0, 0);
                PNL_Saves.Size = new Size(this.Width, this.Height);
            }

            foreach (Get_Save_Info save in GlobalVariables.SaveInfo)
            {
                ListViewItem addSave = new ListViewItem(save.Name);
                addSave.SubItems.Add(save.Coins.ToString());
                addSave.SubItems.Add(save.Levels_Unlocked.ToString());
                addSave.SubItems.Add(save.Slot1_Contents + ", " + save.Slot2_Contents + ", " + save.Slot3_Contents + ", " + save.Slot4_Contents + ", " + save.Slot5_Contents);
                addSave.SubItems.Add(save.Basic_Unlocked.ToString() + ", " + save.Basic_Count.ToString() + ", " + save.Basic_Level.ToString());
                addSave.SubItems.Add(save.Range_Unlocked.ToString() + ", " + save.Range_Count.ToString() + ", " + save.Range_Level.ToString());
                addSave.SubItems.Add(save.Magic_Unlocked.ToString() + ", " + save.Magic_Count.ToString() + ", " + save.Magic_Level.ToString());
                addSave.SubItems.Add(save.Gun_Unlocked.ToString() + ", " + save.Gun_Count.ToString() + ", " + save.Gun_Level.ToString());
                addSave.SubItems.Add(save.Giant_Unlocked.ToString() + ", " + save.Giant_Count.ToString() + ", " + save.Giant_Level.ToString());

                listview.Items.Add(addSave);
            }
        }

        private void TMR_Checker_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.AdminSnap == true && GlobalVariables.SnappedAdminWindowOpen != "saves")
            {
                this.Close();
            }

            if (WindowSnapped == true && GlobalVariables.AdminSnap == false)
            {
                this.Close();
            }

            if (GlobalVariables.CloseAdmin == true)
            {
                this.Close();
            }
        }
    }
}
