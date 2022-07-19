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
    public partial class Game : Form
    {
        Graphics g;
        Image IMG_FormBackground = Properties.Resources.Duck_GameFormBackground;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 800);
            PNL_Game.Location = new Point(0,0);
            PNL_Game.Size = new Size(886, 762);

            // get duck Images
            GlobalVariables.Basic_Ducks[0] = Properties.Resources.Duck_Spear;
            GlobalVariables.Basic_Ducks[1] = Properties.Resources.Duck_Sword;
            GlobalVariables.Basic_Ducks[2] = Properties.Resources.Duck_Axe;

            GlobalVariables.Range_Ducks[0] = Properties.Resources.Blank;
            GlobalVariables.Range_Ducks[1] = Properties.Resources.Blank;
            GlobalVariables.Range_Ducks[2] = Properties.Resources.Blank;

            GlobalVariables.Magic_Ducks[0] = Properties.Resources.Blank;
            GlobalVariables.Magic_Ducks[1] = Properties.Resources.Blank;
            GlobalVariables.Magic_Ducks[2] = Properties.Resources.Blank;

            GlobalVariables.Gun_Ducks[0] = Properties.Resources.Duck_Agent;
            GlobalVariables.Gun_Ducks[1] = Properties.Resources.Duck_Gunner;
            GlobalVariables.Gun_Ducks[2] = Properties.Resources.Duck_Sniper;

            GlobalVariables.Giant_Ducks[0] = Properties.Resources.Duck_Stacked;
            GlobalVariables.Giant_Ducks[1] = Properties.Resources.Duck_Tall;
            GlobalVariables.Giant_Ducks[2] = Properties.Resources.Duck_Buff;

            //
            // ---------  TEMP  ------------
            //

                GlobalVariables.UnitUpgrades_Gun = 0;
                GlobalVariables.UnitUpgrades_Basic = 0;
                GlobalVariables.UnitUpgrades_Range = 0;
                GlobalVariables.UnitUpgrades_Magic = 0;
                GlobalVariables.UnitUpgrades_Giant = 2;

                GlobalVariables.SlotContents[0] = "giant";
                GlobalVariables.SlotContents[1] = "basic";
                GlobalVariables.SlotContents[2] = "gun";
                GlobalVariables.SlotContents[3] = "gun";
                GlobalVariables.SlotContents[4] = "gun";

            //
            // ------------------------------
            //

            GlobalVariables.ChildOpen = "army_camp";
            openChildForm(new ArmyCamp());
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
            closeChildForm();

            if (this.WindowState == FormWindowState.Normal)
            {
                this.BackgroundImage = null;
                PNL_Game.Location = new Point(0,0);
                PNL_Game.BorderStyle = BorderStyle.None;
            }
            else
            {
                this.BackgroundImage = IMG_FormBackground;
                PNL_Game.Location = new Point((Screen.FromHandle(this.Handle).WorkingArea.Width - PNL_Game.Width)/2, (Screen.FromHandle(this.Handle).WorkingArea.Height - PNL_Game.Height)/2);
                PNL_Game.BorderStyle = BorderStyle.FixedSingle;
            }

            if (GlobalVariables.ChildOpen == "battleground")
            {

            }
            else if (GlobalVariables.ChildOpen == "map")
            {

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
                Pause_Game();
                PNL_Menu.Location = new Point(0,PNL_Top.Height);
                PNL_Menu.Size = new Size(200, PNL_Game.Height - PNL_Top.Height);
                PNL_Menu.BringToFront();
                PNL_Menu.Enabled = true;
                PNL_Menu.Visible = true;

                GlobalVariables.PauseCoverX = PNL_Menu.Width;
                GlobalVariables.PauseCoverY = PNL_Menu.Height;
                GlobalVariables.PauseCoverWidth = PNL_Game.Width - PNL_Menu.Width;
                GlobalVariables.PauseCoverHeight = PNL_Game.Height - PNL_Top.Height;
            }
            else
            {
                Play_Game();

                PNL_Menu.Enabled = false;
                PNL_Menu.Visible = false;
                
                PNL_Menu.SendToBack();
                
                PNL_Menu.Location = new Point(0, 1000);
                PNL_Menu.Size = new Size(10, 10);
            }
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            if (PNL_Game.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 4;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(PNL_Game.Location.X - halfThickness, PNL_Game.Location.Y - halfThickness, PNL_Game.Width + thickness, PNL_Game.Height + thickness));
                }
            }
        }

        public void Pause_Game()
        {
            GlobalVariables.Paused = true;
        }

        public void Play_Game()
        {
            GlobalVariables.Paused = false;
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

                // ----- Open Child Code Here -----
            }
            else if (GlobalVariables.ChildToOpen == "battleground")
            {
                GlobalVariables.ChildToOpen = null;

                // ----- Open Child Code Here -----
            }
            else if (GlobalVariables.ChildToOpen == "shop")
            {
                GlobalVariables.ChildToOpen = null;

                // ----- Open Child Code Here -----
            }
        }
    }
}
