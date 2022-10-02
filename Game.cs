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
        Image IMG_FormBackground = Properties.Resources.Duck_GameFormBackground;
        string UnitSeting_FilePath = Application.StartupPath + @"\Application_Resources\Unit_Settings.txt";
        string EUnitSeting_FilePath = Application.StartupPath + @"\Application_Resources\EUnit_Settings.txt";
        string LevelSeting_FilePath = Application.StartupPath + @"\Application_Resources\Level_Settings.txt";

        public Game()
        {
            InitializeComponent();

            //
            // reads the file Login_info (using the binPath created earler to find the location)
            //

            var reader = new StreamReader(UnitSeting_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.Unit_Info.Add(new Get_Unit_Info(values[0], Int32.Parse(values[1]), Int32.Parse(values[2]), Int32.Parse(values[3]), values[4], values[5], Int32.Parse(values[6])));
            }
            reader.Close();

            var reader2 = new StreamReader(EUnitSeting_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader2.EndOfStream)
            {
                var line = reader2.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.EUnit_Info.Add(new Get_EUnit_Info(values[0], Int32.Parse(values[1]), Int32.Parse(values[2]), Int32.Parse(values[3]), values[4]));
            }
            reader2.Close();

            var reader3 = new StreamReader(LevelSeting_FilePath);

            // While the reader still has something to read, this code will execute.
            while (!reader3.EndOfStream)
            {
                var line = reader3.ReadLine();
                // Split into the diffrent things.
                var values = line.Split(',');
                GlobalVariables.Level_Info.Add(new Get_Level_Info(Int32.Parse(values[0]), values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]));
            }
            reader3.Close();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 800);
            PNL_Game.Location = new Point(0, 0);
            PNL_Game.Size = new Size(886, 762);

            // get duck Images
            GlobalVariables.Basic_Ducks[0] = Properties.Resources.Duck_Spear;
            GlobalVariables.Basic_Ducks[1] = Properties.Resources.Duck_Sword;
            GlobalVariables.Basic_Ducks[2] = Properties.Resources.Duck_Axe;
            GlobalVariables.Basic_Ducks_FR[0] = Properties.Resources.Duck_Spear;
            GlobalVariables.Basic_Ducks_FR[0].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Basic_Ducks_FR[1] = Properties.Resources.Duck_Sword;
            GlobalVariables.Basic_Ducks_FR[1].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Basic_Ducks_FR[2] = Properties.Resources.Duck_Axe;
            GlobalVariables.Basic_Ducks_FR[2].RotateFlip(RotateFlipType.RotateNoneFlipX);

            GlobalVariables.Range_Ducks[0] = Properties.Resources.Blank;
            GlobalVariables.Range_Ducks[1] = Properties.Resources.Blank;
            GlobalVariables.Range_Ducks[2] = Properties.Resources.Blank;
            GlobalVariables.Range_Ducks_FR[0] = Properties.Resources.Blank;
            GlobalVariables.Range_Ducks_FR[0].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Range_Ducks_FR[1] = Properties.Resources.Blank;
            GlobalVariables.Range_Ducks_FR[1].RotateFlip(RotateFlipType.RotateNoneFlipX);
            GlobalVariables.Range_Ducks_FR[2] = Properties.Resources.Blank;
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
            GlobalVariables.BossPics[2] = Properties.Resources.Blank;
            GlobalVariables.BossPics[3] = Properties.Resources.Boss_Final;

            //
            // ---------  TEMP  ------------
            //
            GlobalVariables.Level = 1;
            GlobalVariables.Coins = 0;

            GlobalVariables.AdminAccount = true;

            GlobalVariables.BasicUnit_Count = 5;
            GlobalVariables.BasicUnitUnlocked = true;
            GlobalVariables.UnitUpgrades_Basic = 0;
            GlobalVariables.SlotContents[0] = "basic";
            //
            // ------------------------------
            //

            GlobalVariables.ChildOpen = "army_camp";
            openChildForm(new ArmyCamp());

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                Console.WriteLine(i.Name + ": " + i.Cost);
            }
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
            closeChildForm();

            if (this.WindowState == FormWindowState.Normal)
            {
                this.BackgroundImage = null;
                PNL_Game.Location = new Point(0, 0);
                PNL_Game.BorderStyle = BorderStyle.None;
            }
            else
            {
                this.BackgroundImage = IMG_FormBackground;
                PNL_Game.Location = new Point((Screen.FromHandle(this.Handle).WorkingArea.Width - PNL_Game.Width) / 2, (Screen.FromHandle(this.Handle).WorkingArea.Height - PNL_Game.Height) / 2);
                PNL_Game.BorderStyle = BorderStyle.FixedSingle;
            }

            if (GlobalVariables.ChildOpen == "battleground")
            {

            }
            else if (GlobalVariables.ChildOpen == "map")
            {

            }
            else if (GlobalVariables.ChildOpen == "shop")
            {
                openChildForm(new Shop());
            }
            else // if the other two arn't set then it has to ether be army camp or nothing set, and if nothing get then make sure it shows somthing (army camp)
            {
                GlobalVariables.ChildOpen = "army_camp";
                openChildForm(new ArmyCamp());
            }
        }

        private void BTN_Menu_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Paused == false)
            {
                GlobalVariables.Paused = true;

                PNL_Menu.Location = new Point(0, PNL_Top.Height);
                PNL_Menu.Size = new Size(200, PNL_Game.Height - PNL_Top.Height);
                PNL_Menu.BringToFront();
                PNL_Menu.Enabled = true;
                PNL_Menu.Visible = true;

                GlobalVariables.PauseCoverX = PNL_Menu.Width;
                GlobalVariables.PauseCoverY = 0;
                GlobalVariables.PauseCoverWidth = PNL_Game.Width - PNL_Menu.Width;
                GlobalVariables.PauseCoverHeight = PNL_Game.Height - PNL_Top.Height;
            }
            else
            {
                GlobalVariables.Paused = false;

                PNL_Menu.Enabled = false;
                PNL_Menu.Visible = false;

                PNL_Menu.SendToBack();

                PNL_Menu.Location = new Point(0, 1000);
                PNL_Menu.Size = new Size(10, 10);
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PNL_ChildForm.Controls.Add(childForm);
            PNL_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void closeChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void TMR_ChildFromControl_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.ChildToOpen == "army_camp")
            {
                GlobalVariables.ChildToOpen = null;

                GlobalVariables.ChildOpen = "army_camp";
                openChildForm(new ArmyCamp());
            }
            else if (GlobalVariables.ChildToOpen == "map")
            {
                GlobalVariables.ChildToOpen = null;

                GlobalVariables.ChildOpen = "map";
                openChildForm(new Map());
            }
            else if (GlobalVariables.ChildToOpen == "battleground")
            {
                GlobalVariables.ChildToOpen = null;

                GlobalVariables.ChildOpen = "battleground";
                openChildForm(new Battleground());
            }
            else if (GlobalVariables.ChildToOpen == "shop")
            {
                GlobalVariables.ChildToOpen = null;

                GlobalVariables.ChildOpen = "shop";
                openChildForm(new Shop());
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TMR_TopBarDisplay_Refresh_Tick(object sender, EventArgs e)
        {
            LBL_Coins.Text = GlobalVariables.Coins.ToString();

            GlobalVariables.Strength = 0;
            GlobalVariables.Health = 0;

            string[] basicNames = new string[3]; basicNames[0] = "spear"; basicNames[1] = "sword"; basicNames[2] = "axe";
            string[] rangeNames = new string[3]; rangeNames[0] = "archer"; rangeNames[1] = "catapult"; rangeNames[2] = "cannon";
            string[] magicNames = new string[3]; magicNames[0] = "magician"; magicNames[1] = "wizard"; magicNames[2] = "sorcerer";
            string[] gunNames = new string[3]; gunNames[0] = "agent"; gunNames[1] = "gunner"; gunNames[2] = "sniper";
            string[] giantNames = new string[3]; giantNames[0] = "stacked"; giantNames[1] = "tall"; giantNames[2] = "buff";

            int basicStrength = 0, basicHealth = 0;
            int rangeStrength = 0, rangeHealth = 0;
            int magicStrength = 0, magicHealth = 0;
            int gunStrength = 0, gunHealth = 0;
            int giantStrength = 0, giantHealth = 0;

            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                if (i.Name == basicNames[GlobalVariables.UnitUpgrades_Basic]) { basicStrength = i.Damage; basicHealth = i.Health; }
                if (i.Name == rangeNames[GlobalVariables.UnitUpgrades_Range]) { rangeStrength = i.Damage; rangeHealth = i.Health; }
                if (i.Name == magicNames[GlobalVariables.UnitUpgrades_Magic]) { magicStrength = i.Damage; magicHealth = i.Health; }
                if (i.Name == gunNames[GlobalVariables.UnitUpgrades_Gun]) { gunStrength = i.Damage; gunHealth = i.Health; }
                if (i.Name == giantNames[GlobalVariables.UnitUpgrades_Giant]) { giantStrength = i.Damage; giantHealth = i.Health; }
            }

            foreach (string slot in GlobalVariables.SlotContents)
            {
                if (slot == "basic") { for (int i = 0; i < GlobalVariables.BasicUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + basicStrength; GlobalVariables.Health = GlobalVariables.Health + basicHealth; } }
                if (slot == "range") { for (int i = 0; i < GlobalVariables.RangeUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + rangeStrength; GlobalVariables.Health = GlobalVariables.Health + rangeHealth; } }
                if (slot == "magic") { for (int i = 0; i < GlobalVariables.MagicUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + magicStrength; GlobalVariables.Health = GlobalVariables.Health + magicHealth; } }
                if (slot == "gun") { for (int i = 0; i < GlobalVariables.GunUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + gunStrength; GlobalVariables.Health = GlobalVariables.Health + gunHealth; } }
                if (slot == "giant") { for (int i = 0; i < GlobalVariables.GiantUnit_Count; i++) { GlobalVariables.Strength = GlobalVariables.Strength + giantStrength; GlobalVariables.Health = GlobalVariables.Health + giantHealth; } }
            }

            LBL_Health.Text = GlobalVariables.Health.ToString();
            LBL_Strength.Text = GlobalVariables.Strength.ToString();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void TMR_AdminChcker_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.AdminAccount == true)
            {
                BTN_OpenAdmin.Visible = true;
            }
            else
            {
                BTN_OpenAdmin.Visible = false;
            }

            if (GlobalVariables.AdminMode == true && GlobalVariables.AdminSnap == true)
            {
                if (GlobalVariables.SnappedAdminWindowOpen == "" || GlobalVariables.SnappedAdminWindowOpen == null)
                {
                    this.MaximizedBounds = new Rectangle(186, 0, Screen.FromHandle(this.Handle).WorkingArea.Width - 186, Screen.FromHandle(this.Handle).WorkingArea.Height);

                }
                else
                {
                    this.MaximizedBounds = new Rectangle(186, 0, Screen.FromHandle(this.Handle).WorkingArea.Width - 464, Screen.FromHandle(this.Handle).WorkingArea.Height);
                }

                if (this.WindowState == FormWindowState.Maximized)
                {
                    PNL_Game.Location = new Point((this.Width - PNL_Game.Width) / 2, (this.Height - PNL_Game.Height) / 2);
                }
            }
            else
            {
                this.MaximizedBounds = new Rectangle(0, 0, Screen.FromHandle(this.Handle).WorkingArea.Width, Screen.FromHandle(this.Handle).WorkingArea.Height);
            }
        }

        private void BTN_Quit_Click(object sender, EventArgs e)
        {

        }

        private void BTN_OpenAdmin_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.AdminMode == false)
            {
                GlobalVariables.AdminMode = true;
                new Admin().Show();
            }
        }

        private void BTN_MainMenu_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Help_Click(object sender, EventArgs e)
        {

        }
    }
}
