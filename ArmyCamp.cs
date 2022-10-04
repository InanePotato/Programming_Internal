using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        Form frmSelectUnit;

        public ArmyCamp()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_ArmyCamp, new object[] { true });
        }

        private void ArmyCamp_Load(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string slot in GlobalVariables.SlotContents)
            {
                if (slot == "basic" && GlobalVariables.BasicUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.BasicUnit_Count = 0; }
                else if (slot == "range" && GlobalVariables.RangeUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.RangeUnit_Count = 0; }
                else if (slot == "magic" && GlobalVariables.MagicUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.MagicUnit_Count = 0; }
                else if (slot == "gun" && GlobalVariables.GunUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.GunUnit_Count = 0; }
                else if (slot == "giant" && GlobalVariables.GiantUnit_Count <= 0) { GlobalVariables.SlotContents[count] = ""; GlobalVariables.GiantUnit_Count = 0; }
                count++;
            }

            PNL_PauseCover.Visible = false;

            UpdateSlots();
        }

        public void UpdateSlots()
        {
            PNL_Slot0.Cursor = Cursors.Hand;
            PNL_Slot1.Cursor = Cursors.Hand;
            PNL_Slot2.Cursor = Cursors.Hand;
            PNL_Slot3.Cursor = Cursors.Hand;
            PNL_Slot4.Cursor = Cursors.Hand;

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
                PNL_Slot0.Cursor = Cursors.Hand;
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
                PNL_Slot1.Cursor = Cursors.Hand;
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
                PNL_Slot2.Cursor = Cursors.Hand;
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
                PNL_Slot3.Cursor = Cursors.Hand;
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
                PNL_Slot4.Cursor = Cursors.Hand;
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
            PIC_ShopButton.Size = new Size(138, 138);
            PIC_ShopButton.Location = new Point(555, 120);
        }

        private void PIC_ShopButton_MouseLeave(object sender, EventArgs e)
        {
            PIC_ShopButton.Size = new Size(128, 128);
            PIC_ShopButton.Location = new Point(560, 130);
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

        private void TMR_Update_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.SlotChange == true)
            {
                GlobalVariables.SlotChange = false;

                UpdateSlots();
            }

            if (GlobalVariables.SlotContents[0] == "basic") { LBL_Slot0Units.Text = GlobalVariables.BasicUnit_Count.ToString() +" Units"; }
            else if (GlobalVariables.SlotContents[0] == "range") { LBL_Slot0Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "magic") { LBL_Slot0Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "gun") { LBL_Slot0Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "giant") { LBL_Slot0Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[0] == "") { LBL_Slot0Units.Text = "0000 Units"; }

            if (GlobalVariables.SlotContents[1] == "basic") { LBL_Slot1Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "range") { LBL_Slot1Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "magic") { LBL_Slot1Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "gun") { LBL_Slot1Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "giant") { LBL_Slot1Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[1] == "") { LBL_Slot1Units.Text = "0000 Units"; }

            if (GlobalVariables.SlotContents[2] == "basic") { LBL_Slot2Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "range") { LBL_Slot2Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "magic") { LBL_Slot2Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "gun") { LBL_Slot2Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "giant") { LBL_Slot2Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[2] == "") { LBL_Slot2Units.Text = "0000 Units"; }

            if (GlobalVariables.SlotContents[3] == "basic") { LBL_Slot3Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "range") { LBL_Slot3Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "magic") { LBL_Slot3Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "gun") { LBL_Slot3Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "giant") { LBL_Slot3Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[3] == "") { LBL_Slot3Units.Text = "0000 Units"; }

            if (GlobalVariables.SlotContents[4] == "basic") { LBL_Slot4Units.Text = GlobalVariables.BasicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "range") { LBL_Slot4Units.Text = GlobalVariables.RangeUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "magic") { LBL_Slot4Units.Text = GlobalVariables.MagicUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "gun") { LBL_Slot4Units.Text = GlobalVariables.GunUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "giant") { LBL_Slot4Units.Text = GlobalVariables.GiantUnit_Count.ToString() + " Units"; }
            else if (GlobalVariables.SlotContents[4] == "") { LBL_Slot4Units.Text = "0000 Units"; }

        }

        private void PNL_Slot0_Click(object sender, EventArgs e)
        {
            if (PNL_Slot0.Cursor == Cursors.Hand)
            {
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                frmSelectUnit = new Select_Unit(0);
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot1_Click(object sender, EventArgs e)
        {
            if (PNL_Slot1.Cursor == Cursors.Hand)
            {
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                frmSelectUnit = new Select_Unit(1);
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot2_Click(object sender, EventArgs e)
        {
            if (PNL_Slot2.Cursor == Cursors.Hand)
            {
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                frmSelectUnit = new Select_Unit(2);
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot3_Click(object sender, EventArgs e)
        {
            if (PNL_Slot3.Cursor == Cursors.Hand)
            {
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                frmSelectUnit = new Select_Unit(3);
                frmSelectUnit.Show();
            }
        }

        private void PNL_Slot4_Click(object sender, EventArgs e)
        {
            if (PNL_Slot4.Cursor == Cursors.Hand)
            {
                if (frmSelectUnit != null) { frmSelectUnit.Close(); }

                frmSelectUnit = new Select_Unit(4);
                frmSelectUnit.Show();
            }
        }

        private void PIC_MapButton_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.SlotContents[0] != null && GlobalVariables.SlotContents[0] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[1] != null && GlobalVariables.SlotContents[1] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[2] != null && GlobalVariables.SlotContents[2] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[3] != null && GlobalVariables.SlotContents[3] != "") { GlobalVariables.ChildToOpen = "map"; }
            else if (GlobalVariables.SlotContents[4] != null && GlobalVariables.SlotContents[4] != "") { GlobalVariables.ChildToOpen = "map"; }
        }

        private void PIC_MapButton_MouseHover(object sender, EventArgs e)
        {
            PIC_MapButton.Size = new Size(138, 138);
            PIC_MapButton.Location = new Point(333, 93);
        }

        private void PIC_MapButton_MouseLeave(object sender, EventArgs e)
        {
            PIC_MapButton.Size = new Size(128, 128);
            PIC_MapButton.Location = new Point(338, 103);
        }

        private void ArmyCamp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmSelectUnit != null) { frmSelectUnit.Close(); }
        }
    }
}
