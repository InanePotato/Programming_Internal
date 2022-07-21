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

            BTN_PurchaseUnit_Window.Size = new Size(690 / 3, 40);
            BTN_UpgradeUnit_Window.Size = new Size(690 / 3, 40);
            BTN_Commander_Window.Size = new Size(690 / 3, 40);
            BTN_PurchaseUnit_Window.Location = new Point(5,90);
            BTN_UpgradeUnit_Window.Location = new Point(BTN_PurchaseUnit_Window.Location.X + BTN_PurchaseUnit_Window.Width, 90);
            BTN_Commander_Window.Location = new Point(BTN_UpgradeUnit_Window.Location.X + BTN_UpgradeUnit_Window.Width, 90);

            BTN_PurchaseUnit_Window.Enabled = false;
            BTN_PurchaseUnit_Window.Cursor = Cursors.Default;
            BTN_PurchaseUnit_Window.BackColor = Color.FromArgb(84, 63, 55);
            openShopWindow(new ShopWindow_PurchaseUnits());
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

        private Form activeWindowForm = null;
        private void openShopWindow(Form ShopWindow)
        {
            if (activeWindowForm != null)
            {
                activeWindowForm.Close();
            }
            activeWindowForm = ShopWindow;
            ShopWindow.TopLevel = false;
            ShopWindow.FormBorderStyle = FormBorderStyle.None;
            ShopWindow.Dock = DockStyle.Fill;
            PNL_ShopWindow.Controls.Add(ShopWindow);
            PNL_ShopWindow.Tag = ShopWindow;
            ShopWindow.BringToFront();
            ShopWindow.Show();
        }

        private void closeShopWindow()
        {
            if (activeWindowForm != null)
            {
                activeWindowForm.Close();
            }
        }

        private void BTN_PurchaseUnit_Window_Click(object sender, EventArgs e)
        {
            if (BTN_PurchaseUnit_Window.Cursor == Cursors.Hand)
            {
                Reset_Open_Window_Buttons();

                BTN_PurchaseUnit_Window.Enabled = false;
                BTN_PurchaseUnit_Window.Cursor = Cursors.Default;
                BTN_PurchaseUnit_Window.BackColor = Color.FromArgb(84, 63, 55);
                openShopWindow(new ShopWindow_PurchaseUnits());
            }
        }

        private void BTN_UpgradeUnit_Window_Click(object sender, EventArgs e)
        {
            if (BTN_UpgradeUnit_Window.Cursor == Cursors.Hand)
            {
                Reset_Open_Window_Buttons();

                BTN_UpgradeUnit_Window.Enabled = false;
                BTN_UpgradeUnit_Window.Cursor = Cursors.Default;
                BTN_UpgradeUnit_Window.BackColor = Color.FromArgb(84, 63, 55);
                closeShopWindow(); // change to openshop window when the window accualy exists :)
            }
        }

        private void BTN_Commander_Window_Click(object sender, EventArgs e)
        {
            if (BTN_Commander_Window.Cursor == Cursors.Hand)
            {
                Reset_Open_Window_Buttons();

                BTN_Commander_Window.Enabled = false;
                BTN_Commander_Window.Cursor = Cursors.Default;
                BTN_Commander_Window.BackColor = Color.FromArgb(84, 63, 55);
                closeShopWindow(); // change to openshop window when the window accualy exists :)
            }
        }

        public void Reset_Open_Window_Buttons()
        {
            BTN_PurchaseUnit_Window.BackColor = Color.FromArgb(121, 85, 72);
            BTN_UpgradeUnit_Window.BackColor = Color.FromArgb(121, 85, 72);
            BTN_Commander_Window.BackColor = Color.FromArgb(121, 85, 72);

            BTN_PurchaseUnit_Window.Cursor = Cursors.Hand;
            BTN_UpgradeUnit_Window.Cursor = Cursors.Hand;
            BTN_Commander_Window.Cursor = Cursors.Hand;

            BTN_PurchaseUnit_Window.Enabled = true;
            BTN_UpgradeUnit_Window.Enabled = true;
            BTN_Commander_Window.Enabled = true;
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            // helps decrease stress on  the device
            closeShopWindow();
        }
    }
}
