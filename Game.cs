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
        //General Form Varables
        int UnitUpgrades_Gun = 0;
        int UnitUpgrades_Basic = 0;
        int UnitUpgrades_Range = 0;
        int UnitUpgrades_Magic = 0;
        int UnitUpgrades_Giant = 0;
        bool paused = false;
        Graphics g;
        Image IMG_FormBackground = Properties.Resources.Duck_GameFormBackground;

        //PNL_ArmyCamp Variables
        int AC_SlotRecGap;
        int AC_SlotRecWidth;
        int AC_SlotRecHeight;
        string[] AC_SlotContents = new string[5];
        Rectangle[] AC_Slot0 = new Rectangle[10];
        Rectangle[] AC_Slot1 = new Rectangle[10];
        Rectangle[] AC_Slot2 = new Rectangle[10];
        Rectangle[] AC_Slot3 = new Rectangle[10];
        Rectangle[] AC_Slot4 = new Rectangle[10];
        Image[] Basic_Ducks = new Image[3];
        Image[] Range_Ducks = new Image[3];
        Image[] Magic_Ducks = new Image[3];
        Image[] Gun_Ducks = new Image[3];
        Image[] Giant_Ducks = new Image[3];
        Image AC_Slot0Image;
        Image AC_Slot1Image;
        Image AC_Slot2Image;
        Image AC_Slot3Image;
        Image AC_Slot4Image;

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
            Basic_Ducks[0] = Properties.Resources.Duck_Spear;
            Basic_Ducks[1] = Properties.Resources.Duck_Sword;
            Basic_Ducks[2] = Properties.Resources.Duck_Axe;

            Range_Ducks[0] = Properties.Resources.Blank;
            Range_Ducks[1] = Properties.Resources.Blank;
            Range_Ducks[2] = Properties.Resources.Blank;

            Magic_Ducks[0] = Properties.Resources.Blank;
            Magic_Ducks[1] = Properties.Resources.Blank;
            Magic_Ducks[2] = Properties.Resources.Blank;

            Gun_Ducks[0] = Properties.Resources.Duck_Agent;
            Gun_Ducks[1] = Properties.Resources.Duck_Gunner;
            Gun_Ducks[2] = Properties.Resources.Duck_Sniper;

            Giant_Ducks[0] = Properties.Resources.Duck_Stacked;
            Giant_Ducks[1] = Properties.Resources.Duck_Tall;
            Giant_Ducks[2] = Properties.Resources.Duck_Buff;

            //
            // ---------  TEMP  ------------
            //

                UnitUpgrades_Gun = 0;
                UnitUpgrades_Basic = 0;
                UnitUpgrades_Range = 0;
                UnitUpgrades_Magic = 0;
                UnitUpgrades_Giant = 2;

                AC_SlotContents[0] = "giant";
                AC_SlotContents[1] = "basic";
                AC_SlotContents[2] = "gun";
                AC_SlotContents[3] = "gun";
                AC_SlotContents[4] = "gun";

            //
            // ------------------------------
            //

            AC_UpdateSlots();
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
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
        }

        private void BTN_Menu_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                Pause_Game();
                //28, 740
                PNL_Menu.Location = new Point(0,PNL_Top.Height);
                PNL_Menu.Size = new Size(200, PNL_Game.Height - PNL_Top.Height);
                if (PNL_ArmyCamp.Visible == true)
                {
                    PNL_ACPausedCover.Location = new Point(PNL_Menu.Width, 0);
                    PNL_ACPausedCover.Size = new Size(PNL_ArmyCamp.Width - PNL_Menu.Width, PNL_ArmyCamp.Height);

                    PNL_ACPausedCover.BringToFront();

                    PNL_ACPausedCover.Enabled = true;
                    PNL_ACPausedCover.Visible = true;

                    PNL_ACPausedCover.BackColor = Color.FromArgb(100, 0, 0, 0);
                }
                else
                {
                    PNL_PausedCover.Location = new Point(PNL_Menu.Width, PNL_Top.Height);
                    PNL_PausedCover.Size = new Size(PNL_Game.Width - PNL_Menu.Width, PNL_Game.Height - PNL_Top.Height);

                    PNL_PausedCover.BringToFront();

                    PNL_PausedCover.Enabled = true;
                    PNL_PausedCover.Visible = true;

                    PNL_PausedCover.BackColor = Color.FromArgb(100, 0, 0, 0);
                }

                PNL_Menu.BringToFront();

                PNL_Menu.Enabled = true;
                PNL_Menu.Visible = true;
            }
            else
            {
                Play_Game();

                if(PNL_ArmyCamp.Visible == true)
                {
                    PNL_ACPausedCover.Enabled = false;
                    PNL_ACPausedCover.Visible = false;

                    PNL_ACPausedCover.SendToBack();

                    PNL_ACPausedCover.Location = new Point(12, 952);
                    PNL_ACPausedCover.Size = new Size(10, 10);
                }
                else
                {
                    PNL_PausedCover.Enabled = false;
                    PNL_PausedCover.Visible = false;

                    PNL_PausedCover.SendToBack();

                    PNL_PausedCover.Location = new Point(12, 1000);
                    PNL_PausedCover.Size = new Size(10, 10);
                }

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
            paused = true;
        }

        public void Play_Game()
        {
            paused = false;
        }

        public void AC_UpdateSlots()
        {
            AC_SlotRecGap = 10;
            AC_SlotRecHeight = (PNL_AC_Slot0.Height - (6 * AC_SlotRecGap)) / 5;
            AC_SlotRecWidth = AC_SlotRecHeight;

            AC_Slot0[0] = new Rectangle(0, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[1] = new Rectangle(0, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[2] = new Rectangle(0, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[3] = new Rectangle(0, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[4] = new Rectangle(0, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[5] = new Rectangle(AC_SlotRecWidth + 2, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[6] = new Rectangle(AC_SlotRecWidth + 2, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[7] = new Rectangle(AC_SlotRecWidth + 2, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[8] = new Rectangle(AC_SlotRecWidth + 2, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot0[9] = new Rectangle(AC_SlotRecWidth + 2, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);

            if (AC_SlotContents[0] == "basic")
            {
                PNL_AC_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot0Image = Basic_Ducks[UnitUpgrades_Basic];
            }
            else if (AC_SlotContents[0] == "range")
            {
                PNL_AC_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot0Image = Range_Ducks[UnitUpgrades_Range];
            }
            else if (AC_SlotContents[0] == "magic")
            {
                PNL_AC_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot0Image = Magic_Ducks[UnitUpgrades_Magic];
            }
            else if (AC_SlotContents[0] == "gun")
            {
                PNL_AC_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot0Image = Gun_Ducks[UnitUpgrades_Gun];
            }
            else if (AC_SlotContents[0] == "giant")
            {
                PNL_AC_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot0Image = Giant_Ducks[UnitUpgrades_Giant];
            }
            else
            {
                PNL_AC_Slot0.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                AC_Slot0Image = Properties.Resources.Blank;

                AC_Slot0[0] = new Rectangle(0, 0, 1, 1);
                AC_Slot0[1] = new Rectangle(0, 0, 1, 1);
                AC_Slot0[2] = new Rectangle(0, 0, 1, 1);
                AC_Slot0[3] = new Rectangle(0, 0, 1, 1);
                AC_Slot0[4] = new Rectangle(0, 0, 1, 1);
            }

            AC_Slot0Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_AC_Slot0.Invalidate();

            AC_Slot1[0] = new Rectangle(0, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[1] = new Rectangle(0, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[2] = new Rectangle(0, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[3] = new Rectangle(0, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[4] = new Rectangle(0, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[5] = new Rectangle(AC_SlotRecWidth + 2, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[6] = new Rectangle(AC_SlotRecWidth + 2, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[7] = new Rectangle(AC_SlotRecWidth + 2, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[8] = new Rectangle(AC_SlotRecWidth + 2, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot1[9] = new Rectangle(AC_SlotRecWidth + 2, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);

            if (AC_SlotContents[1] == "basic")
            {
                PNL_AC_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot1Image = Basic_Ducks[UnitUpgrades_Basic];
            }
            else if (AC_SlotContents[1] == "range")
            {
                AC_Slot1Image = Range_Ducks[UnitUpgrades_Range];
            }
            else if (AC_SlotContents[1] == "magic")
            {
                PNL_AC_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot1Image = Magic_Ducks[UnitUpgrades_Magic];
            }
            else if (AC_SlotContents[1] == "gun")
            {
                PNL_AC_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot1Image = Gun_Ducks[UnitUpgrades_Gun];
            }
            else if (AC_SlotContents[1] == "giant")
            {
                PNL_AC_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot1Image = Giant_Ducks[UnitUpgrades_Giant];
            }
            else
            {
                PNL_AC_Slot1.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                AC_Slot1Image = Properties.Resources.Blank;

                AC_Slot1[0] = new Rectangle(0, 0, 1, 1);
                AC_Slot1[1] = new Rectangle(0, 0, 1, 1);
                AC_Slot1[2] = new Rectangle(0, 0, 1, 1);
                AC_Slot1[3] = new Rectangle(0, 0, 1, 1);
                AC_Slot1[4] = new Rectangle(0, 0, 1, 1);
            }

            AC_Slot1Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_AC_Slot1.Invalidate();

            AC_Slot2[0] = new Rectangle(0, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[1] = new Rectangle(0, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[2] = new Rectangle(0, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[3] = new Rectangle(0, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[4] = new Rectangle(0, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[5] = new Rectangle(AC_SlotRecWidth + 2, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[6] = new Rectangle(AC_SlotRecWidth + 2, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[7] = new Rectangle(AC_SlotRecWidth + 2, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[8] = new Rectangle(AC_SlotRecWidth + 2, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot2[9] = new Rectangle(AC_SlotRecWidth + 2, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);

            if (AC_SlotContents[2] == "basic")
            {
                PNL_AC_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot2Image = Basic_Ducks[UnitUpgrades_Basic];
            }
            else if (AC_SlotContents[2] == "range")
            {
                PNL_AC_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot2Image = Range_Ducks[UnitUpgrades_Range];
            }
            else if (AC_SlotContents[2] == "magic")
            {
                PNL_AC_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot2Image = Magic_Ducks[UnitUpgrades_Magic];
            }
            else if (AC_SlotContents[2] == "gun")
            {
                PNL_AC_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot2Image = Gun_Ducks[UnitUpgrades_Gun];
            }
            else if (AC_SlotContents[2] == "giant")
            {
                PNL_AC_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot2Image = Giant_Ducks[UnitUpgrades_Giant];
            }
            else
            {
                PNL_AC_Slot2.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                AC_Slot2Image = Properties.Resources.Blank;

                AC_Slot2[0] = new Rectangle(0, 0, 1, 1);
                AC_Slot2[1] = new Rectangle(0, 0, 1, 1);
                AC_Slot2[2] = new Rectangle(0, 0, 1, 1);
                AC_Slot2[3] = new Rectangle(0, 0, 1, 1);
                AC_Slot2[4] = new Rectangle(0, 0, 1, 1);
            }

            AC_Slot2Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_AC_Slot2.Invalidate();

            AC_Slot3[0] = new Rectangle(0, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[1] = new Rectangle(0, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[2] = new Rectangle(0, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[3] = new Rectangle(0, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[4] = new Rectangle(0, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[5] = new Rectangle(AC_SlotRecWidth + 2, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[6] = new Rectangle(AC_SlotRecWidth + 2, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[7] = new Rectangle(AC_SlotRecWidth + 2, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[8] = new Rectangle(AC_SlotRecWidth + 2, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot3[9] = new Rectangle(AC_SlotRecWidth + 2, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);

            if (AC_SlotContents[3] == "basic")
            {
                PNL_AC_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot3Image = Basic_Ducks[UnitUpgrades_Basic];
            }
            else if (AC_SlotContents[3] == "range")
            {
                PNL_AC_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot3Image = Range_Ducks[UnitUpgrades_Range];
            }
            else if (AC_SlotContents[3] == "magic")
            {
                PNL_AC_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot3Image = Magic_Ducks[UnitUpgrades_Magic];
            }
            else if (AC_SlotContents[3] == "gun")
            {
                PNL_AC_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot3Image = Gun_Ducks[UnitUpgrades_Gun];
            }
            else if (AC_SlotContents[3] == "giant")
            {
                PNL_AC_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot3Image = Giant_Ducks[UnitUpgrades_Giant];
            }
            else
            {
                PNL_AC_Slot3.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                AC_Slot3Image = Properties.Resources.Blank;

                AC_Slot3[0] = new Rectangle(0, 0, 1, 1);
                AC_Slot3[1] = new Rectangle(0, 0, 1, 1);
                AC_Slot3[2] = new Rectangle(0, 0, 1, 1);
                AC_Slot3[3] = new Rectangle(0, 0, 1, 1);
                AC_Slot3[4] = new Rectangle(0, 0, 1, 1);
            }

            AC_Slot3Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_AC_Slot3.Invalidate();

            AC_Slot4[0] = new Rectangle(0, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[1] = new Rectangle(0, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[2] = new Rectangle(0, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[3] = new Rectangle(0, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[4] = new Rectangle(0, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[5] = new Rectangle(AC_SlotRecWidth + 2, AC_SlotRecGap, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[6] = new Rectangle(AC_SlotRecWidth + 2, (2 * AC_SlotRecGap) + AC_SlotRecHeight, AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[7] = new Rectangle(AC_SlotRecWidth + 2, (3 * AC_SlotRecGap) + (2 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[8] = new Rectangle(AC_SlotRecWidth + 2, (4 * AC_SlotRecGap) + (3 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);
            AC_Slot4[9] = new Rectangle(AC_SlotRecWidth + 2, (5 * AC_SlotRecGap) + (4 * AC_SlotRecHeight), AC_SlotRecWidth, AC_SlotRecHeight);

            if (AC_SlotContents[4] == "basic")
            {
                PNL_AC_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot4Image = Basic_Ducks[UnitUpgrades_Basic];
            }
            else if (AC_SlotContents[4] == "range")
            {
                PNL_AC_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot4Image = Range_Ducks[UnitUpgrades_Range];
            }
            else if (AC_SlotContents[4] == "magic")
            {
                PNL_AC_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot4Image = Magic_Ducks[UnitUpgrades_Magic];
            }
            else if (AC_SlotContents[4] == "gun")
            {
                PNL_AC_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot4Image = Gun_Ducks[UnitUpgrades_Gun];
            }
            else if (AC_SlotContents[4] == "giant")
            {
                PNL_AC_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                AC_Slot4Image = Giant_Ducks[UnitUpgrades_Giant];
            }
            else
            {
                PNL_AC_Slot4.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                AC_Slot4Image = Properties.Resources.Blank;

                AC_Slot4[0] = new Rectangle(0, 0, 1, 1);
                AC_Slot4[1] = new Rectangle(0, 0, 1, 1);
                AC_Slot4[2] = new Rectangle(0, 0, 1, 1);
                AC_Slot4[3] = new Rectangle(0, 0, 1, 1);
                AC_Slot4[4] = new Rectangle(0, 0, 1, 1);
            }

            AC_Slot4Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_AC_Slot4.Invalidate();
        }

        private void PNL_AC_Slot0_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in AC_Slot0)
            {
                g.DrawImage(AC_Slot0Image, rec);
            }
        }

        private void PNL_AC_Slot1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in AC_Slot1)
            {
                g.DrawImage(AC_Slot1Image, rec);
            }
        }

        private void PNL_AC_Slot2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in AC_Slot2)
            {
                g.DrawImage(AC_Slot2Image, rec);
            }
        }

        private void PNL_AC_Slot3_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in AC_Slot3)
            {
                g.DrawImage(AC_Slot3Image, rec);
            }
        }

        private void PNL_AC_Slot4_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in AC_Slot4)
            {
                g.DrawImage(AC_Slot4Image, rec);
            }
        }

        private void PIC_ShopButton_MouseHover(object sender, EventArgs e)
        {
            PIC_ShopButton.Size = new Size(PIC_ShopButton.Width + 10, PIC_ShopButton.Height + 10);
            PIC_ShopButton.Location = new Point(PIC_ShopButton.Location.X - 5, PIC_ShopButton.Location.Y - 10);
        }

        private void PIC_ShopButton_MouseLeave(object sender, EventArgs e)
        {
            PIC_ShopButton.Size = new Size(PIC_ShopButton.Width - 10, PIC_ShopButton.Height - 10);
            PIC_ShopButton.Location = new Point(PIC_ShopButton.Location.X + 5, PIC_ShopButton.Location.Y + 10);
        }

        private void PIC_ShopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
