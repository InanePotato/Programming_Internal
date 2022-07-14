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
        Image IMG_FormBackground = Image.FromFile(Application.StartupPath + @"\images\Game_Form_Background_Image.png");
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.BackgroundImage = null;
                PNL_Game.Location = new Point(0,0);
            }
            else
            {
                this.BackgroundImage = IMG_FormBackground;
                PNL_Game.Location = new Point((Screen.FromHandle(this.Handle).WorkingArea.Width - PNL_Game.Width)/2, (Screen.FromHandle(this.Handle).WorkingArea.Height - PNL_Game.Height)/2);
            }
        }
    }
}
