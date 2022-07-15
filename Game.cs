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
        Image IMG_FormBackground = Properties.Resources.Duck_GameFormBackground;
        bool paused = false;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 800);
            PNL_Game.Location = new Point(0,0);
            PNL_Game.Size = new Size(886, 762);
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
    }
}
