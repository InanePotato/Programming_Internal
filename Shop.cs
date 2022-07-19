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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            PNL_Shop.Location = new Point((this.Width - PNL_Shop.Width)/2, (this.Height - PNL_Shop.Height) / 2);
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
                PNL_PauseCover.Location = new Point(0, this.Height - PNL_PauseCover.Height);
                PNL_PauseCover.Visible = false;
                PNL_PauseCover.SendToBack();
            }
        }

        private void PIC_ExitBTN_Click(object sender, EventArgs e)
        {
            GlobalVariables.ChildToOpen = "army_camp";
        }

        private void PIC_ExitBTN_MouseHover(object sender, EventArgs e)
        {
            PIC_ExitBTN.Size = new Size(55, 55);
            PIC_ExitBTN.Location = new Point(655, 11);
        }

        private void PIC_ExitBTN_MouseLeave(object sender, EventArgs e)
        {
            PIC_ExitBTN.Size = new Size(50, 50);
            PIC_ExitBTN.Location = new Point(657, 13);
        }
    }
}
