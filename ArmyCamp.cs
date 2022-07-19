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
    public partial class ArmyCamp : Form
    {
        Graphics g;

        int SlotRecGap;
        int SlotRecWidth;
        int SlotRecHeight;
        Rectangle[] Slot0 = new Rectangle[10];
        Rectangle[] Slot1 = new Rectangle[10];
        Rectangle[] Slot2 = new Rectangle[10];
        Rectangle[] Slot3 = new Rectangle[10];
        Rectangle[] Slot4 = new Rectangle[10];
        Image Slot0Image;
        Image Slot1Image;
        Image Slot2Image;
        Image Slot3Image;
        Image Slot4Image;


        public ArmyCamp()
        {
            InitializeComponent();
        }

        private void ArmyCamp_Load(object sender, EventArgs e)
        {
            PNL_PauseCover.Visible = false;

            UpdateSlots();
        }

        public void UpdateSlots()
        {
            SlotRecGap = 10;
            SlotRecHeight = (PNL_Slot0.Height - (6 * SlotRecGap)) / 5;
            SlotRecWidth = SlotRecHeight;

            Slot0[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot0[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot0[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot0[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot0[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot0[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            if (GlobalVariables.SlotContents[0] == "basic")
            {
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot0Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[0] == "range")
            {
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot0Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[0] == "magic")
            {
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot0Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[0] == "gun")
            {
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot0Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[0] == "giant")
            {
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot0Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                PNL_Slot0.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                Slot0Image = Properties.Resources.Blank;

                Slot0[0] = new Rectangle(0, 0, 1, 1);
                Slot0[1] = new Rectangle(0, 0, 1, 1);
                Slot0[2] = new Rectangle(0, 0, 1, 1);
                Slot0[3] = new Rectangle(0, 0, 1, 1);
                Slot0[4] = new Rectangle(0, 0, 1, 1);
            }

            //Slot0Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_Slot0.Invalidate();

            Slot1[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot1[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot1[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot1[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot1[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot1[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            if (GlobalVariables.SlotContents[1] == "basic")
            {
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot1Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[1] == "range")
            {
                Slot1Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[1] == "magic")
            {
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot1Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[1] == "gun")
            {
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot1Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[1] == "giant")
            {
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot1Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                PNL_Slot1.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                Slot1Image = Properties.Resources.Blank;

                Slot1[0] = new Rectangle(0, 0, 1, 1);
                Slot1[1] = new Rectangle(0, 0, 1, 1);
                Slot1[2] = new Rectangle(0, 0, 1, 1);
                Slot1[3] = new Rectangle(0, 0, 1, 1);
                Slot1[4] = new Rectangle(0, 0, 1, 1);
            }

            //Slot1Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_Slot1.Invalidate();

            Slot2[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot2[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot2[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot2[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot2[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot2[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            if (GlobalVariables.SlotContents[2] == "basic")
            {
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot2Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[2] == "range")
            {
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot2Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[2] == "magic")
            {
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot2Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[2] == "gun")
            {
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot2Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[2] == "giant")
            {
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot2Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                PNL_Slot2.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                Slot2Image = Properties.Resources.Blank;

                Slot2[0] = new Rectangle(0, 0, 1, 1);
                Slot2[1] = new Rectangle(0, 0, 1, 1);
                Slot2[2] = new Rectangle(0, 0, 1, 1);
                Slot2[3] = new Rectangle(0, 0, 1, 1);
                Slot2[4] = new Rectangle(0, 0, 1, 1);
            }

            //Slot2Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_Slot2.Invalidate();

            Slot3[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot3[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot3[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot3[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot3[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot3[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            if (GlobalVariables.SlotContents[3] == "basic")
            {
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot3Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[3] == "range")
            {
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot3Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[3] == "magic")
            {
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot3Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[3] == "gun")
            {
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot3Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[3] == "giant")
            {
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot3Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                PNL_Slot3.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                Slot3Image = Properties.Resources.Blank;

                Slot3[0] = new Rectangle(0, 0, 1, 1);
                Slot3[1] = new Rectangle(0, 0, 1, 1);
                Slot3[2] = new Rectangle(0, 0, 1, 1);
                Slot3[3] = new Rectangle(0, 0, 1, 1);
                Slot3[4] = new Rectangle(0, 0, 1, 1);
            }

            //Slot3Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_Slot3.Invalidate();

            Slot4[0] = new Rectangle(0, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot4[1] = new Rectangle(0, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot4[2] = new Rectangle(0, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[3] = new Rectangle(0, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[4] = new Rectangle(0, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[5] = new Rectangle(SlotRecWidth + 2, SlotRecGap, SlotRecWidth, SlotRecHeight);
            Slot4[6] = new Rectangle(SlotRecWidth + 2, (2 * SlotRecGap) + SlotRecHeight, SlotRecWidth, SlotRecHeight);
            Slot4[7] = new Rectangle(SlotRecWidth + 2, (3 * SlotRecGap) + (2 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[8] = new Rectangle(SlotRecWidth + 2, (4 * SlotRecGap) + (3 * SlotRecHeight), SlotRecWidth, SlotRecHeight);
            Slot4[9] = new Rectangle(SlotRecWidth + 2, (5 * SlotRecGap) + (4 * SlotRecHeight), SlotRecWidth, SlotRecHeight);

            if (GlobalVariables.SlotContents[4] == "basic")
            {
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot4Image = GlobalVariables.Basic_Ducks_FR[GlobalVariables.UnitUpgrades_Basic];
            }
            else if (GlobalVariables.SlotContents[4] == "range")
            {
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot4Image = GlobalVariables.Range_Ducks_FR[GlobalVariables.UnitUpgrades_Range];
            }
            else if (GlobalVariables.SlotContents[4] == "magic")
            {
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot4Image = GlobalVariables.Magic_Ducks_FR[GlobalVariables.UnitUpgrades_Magic];
            }
            else if (GlobalVariables.SlotContents[4] == "gun")
            {
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot4Image = GlobalVariables.Gun_Ducks_FR[GlobalVariables.UnitUpgrades_Gun];
            }
            else if (GlobalVariables.SlotContents[4] == "giant")
            {
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBckground;
                Slot4Image = GlobalVariables.Giant_Ducks_FR[GlobalVariables.UnitUpgrades_Giant];
            }
            else
            {
                PNL_Slot4.BackgroundImage = Properties.Resources.AC_SlotBackground_Plus;
                Slot4Image = Properties.Resources.Blank;

                Slot4[0] = new Rectangle(0, 0, 1, 1);
                Slot4[1] = new Rectangle(0, 0, 1, 1);
                Slot4[2] = new Rectangle(0, 0, 1, 1);
                Slot4[3] = new Rectangle(0, 0, 1, 1);
                Slot4[4] = new Rectangle(0, 0, 1, 1);
            }

            //Slot4Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            PNL_Slot4.Invalidate();
        }

        private void PNL_Slot0_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in Slot0)
            {
                g.DrawImage(Slot0Image, rec);
            }
        }

        private void PNL_Slot1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in Slot1)
            {
                g.DrawImage(Slot1Image, rec);
            }
        }

        private void PNL_Slot2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in Slot2)
            {
                g.DrawImage(Slot2Image, rec);
            }
        }

        private void PNL_Slot3_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in Slot3)
            {
                g.DrawImage(Slot3Image, rec);
            }
        }

        private void PNL_Slot4_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach (Rectangle rec in Slot4)
            {
                g.DrawImage(Slot4Image, rec);
            }
        }

        private void PIC_ShopButton_Click(object sender, EventArgs e)
        {
            GlobalVariables.ChildToOpen = "shop";
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

        private void TMR_PausePlayCheck_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.Paused == true)
            {
                PNL_PauseCover.Location = new Point(GlobalVariables.PauseCoverX, GlobalVariables.PauseCoverY);
                PNL_PauseCover.Size = new Size(GlobalVariables.PauseCoverWidth, GlobalVariables.PauseCoverHeight);

                PNL_PauseCover.Visible = true;
                PNL_PauseCover.BackColor = Color.FromArgb(100, 0, 0, 0);
                PNL_PauseCover.BringToFront();
            }
            else
            {
                PNL_PauseCover.Location = new Point(0, PNL_ArmyCamp.Height - PNL_PauseCover.Height);
                PNL_PauseCover.Visible = false;
                PNL_PauseCover.SendToBack();
            }
        }
    }
}
