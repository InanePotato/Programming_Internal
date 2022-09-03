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
    public partial class Battleground : Form
    {
        Level LevelControl;

        public Battleground()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battleground, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battle, new object[] { true });
        }

        private void Battleground_Load(object sender, EventArgs e)
        {
            //------------------------------------------------------------//
            //------------------------ Prep level ------------------------//
            //------------------------------------------------------------//

            LevelControl = new Level(GlobalVariables.Level);
            LevelControl.Spawn_Players_Units(0,0,20,100,10000);

            PNL_Battle.Size = new Size(PNL_Battle.Width + LevelControl.SpawnX, PNL_Battle.Height);
            PNL_Battle.Location = new Point(PNL_Battle.Location.X - LevelControl.SpawnX, PNL_Battle.Location.Y);

            LevelControl.Spawn_Enemy_Units(PNL_Battle.Width - 150, 80, 20, 100, PNL_Battle.Width - this.Width);

            LevelControl.ReAjust_Unit_MinXMaxX(PNL_Battle.Width - 120, PNL_Battle.Width - this.Width);

            //------------------------------------------------------------//
            //------------------------ Start Game ------------------------//
            //------------------------------------------------------------//

            PNL_Battle.Invalidate();

            //TMR_Battle.Enabled = true;
            //TMR_Controls.Enabled = true;
        }

        private void TMR_Battle_Tick(object sender, EventArgs e)
        {
            foreach(Unit unit in GlobalVariables.Units)
            {
                unit.Move_Unit();
            }

            foreach (Enemy_Unit unit in GlobalVariables.Enemy_Units)
            {
                unit.Move_Enemy_Unit();
            }

            PNL_Battle.Invalidate();
        }

        private void TMR_Controls_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.Paused == true) { TMR_Battle.Enabled = false; }
            else { TMR_Battle.Enabled = true; }
        }

        private void PNL_Battle_Paint(object sender, PaintEventArgs e)
        {
            foreach(Unit unit in GlobalVariables.Units)
            {
                unit.Unit_Draw(e.Graphics);
            }

            foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
            {
                Eunit.Draw_Enemy_Unit(e.Graphics);
            }
        }
    }
}
