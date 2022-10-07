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
        //---------------------------------------------//
        // Declares public variables used in this form //
        //---------------------------------------------//
        Level LevelControl; // used to control the main spawning of the level
        bool BattleOver = false; // used to tell once the battle has finished

        public Battleground()
        {
            InitializeComponent();

            // sets the panels to be dublebuffered
            // this helps with the drawing of objects in the form making it less 'flickery'
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battleground, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PNL_Battle, new object[] { true });
        }

        private void Battleground_Load(object sender, EventArgs e)
        {
            //------------------------------------------------------------//
            //------------------------ Prep level ------------------------//
            //------------------------------------------------------------//

            // resets gobalvariables used for battle statistics back to 0
            GlobalVariables.BattleCoinsEarned = 0;
            GlobalVariables.BattleEnemyCasualties = 0;
            GlobalVariables.BattlePlayerCasualties = 0;

            // clears all the projectiles and explosions in the appropriate global variable lists
            GlobalVariables.Projectiles.Clear();
            GlobalVariables.Boom.Clear();

            // creates a new level control, with the current level inputted
            LevelControl = new Level(GlobalVariables.Level);

            // calls on the spawn player units event in the Level control
            // this spawns in all the player units on the form
            // format: StartX, StartY, spawnGap, slotGap, maxX
            LevelControl.Spawn_Players_Units(0,0,20,100,10000);

            // resizes and relocates the battle panel so the players units all start off screen
            PNL_Battle.Size = new Size(PNL_Battle.Width + LevelControl.SpawnX, PNL_Battle.Height);
            PNL_Battle.Location = new Point(PNL_Battle.Location.X - LevelControl.SpawnX, PNL_Battle.Location.Y);

            // calls on the Spawn enemy units event in the level control
            // this spawns in all the enemy units out of sight to the right of the form
            // format: StartX, StartY, SpawnGap, TypeGap, MinX
            LevelControl.Spawn_Enemy_Units(PNL_Battle.Width - 150, 80, 20, 100, PNL_Battle.Width - this.Width);

            // calls on the ReAdjust unit max and min x's event
            // this Readjusts the player and enemy unit's max and min x locations
            // format: max x, min x
            LevelControl.ReAjust_Unit_MinXMaxX(PNL_Battle.Width - 120, PNL_Battle.Width - this.Width);

            //------------------------------------------------------------//
            //------------------------ Start Game ------------------------//
            //------------------------------------------------------------//

            // calls on the battle panels invalidate event
            // this draws all the units onto the panel
            PNL_Battle.Invalidate();

            // enables the timer that controls the pause / play functions
            // this also starts the game
            TMR_Controls.Enabled = true;
        }
                
        private void TMR_Battle_Tick(object sender, EventArgs e)
        {
            // whenever this timer ticks, it moves the units accordingly and then redraws the panel

            // goes through all the players units in the Units global variable list
            foreach(Unit unit in GlobalVariables.Units)
            {
                // calls on the units move event
                unit.Move_Unit();
            }

            // goes through all the enemys units in the Enemy units global variable list
            foreach (Enemy_Unit unit in GlobalVariables.Enemy_Units)
            {
                // calls on the enemy units move event
                unit.Move_Enemy_Unit();
            }

            // calls on the panels invalidate event, this draws everything onto the panel
            PNL_Battle.Invalidate();
        }

        private void TMR_Controls_Tick(object sender, EventArgs e)
        {
            // whenever this timer ticks it checks if the game should be paused
            // if the game should be paused the battle and attack timers will be dissables
            // otherwise the battle and attack timers will be enabled

            if (GlobalVariables.Paused == true || BattleOver == true) { TMR_Battle.Enabled = false; TMR_Attack.Enabled = false; }
            else { TMR_Battle.Enabled = true; TMR_Attack.Enabled = true; }
        }

        private void PNL_Battle_Paint(object sender, PaintEventArgs e)
        {
            // goes through all the lists of components (units, enemy units, explosions, projectiles)
            // and calls on each of their draw events and passes on the graphics object,
            // this then draws everything on the panel

            // goes through all the players units in the Units global variable list
            foreach (Unit unit in GlobalVariables.Units)
            {
                // calls on the units draw event, and passes the panels graphics obect over
                unit.Unit_Draw(e.Graphics);
            }

            // goes through all the enemys units in the global variable list Enemy_Units
            foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
            {
                // calls on the enemy units draw event, and passes on the panels graphics object
                Eunit.Draw_Enemy_Unit(e.Graphics);
            }

            // goes through all the enemy units in the global variables list again
            foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
            {
                // redraws (using the same method as before) all the enemy units with the boss bool set to true
                // this ensures the boss units are drawn at the very top of all the other enemy units
                if (Eunit.Boss == true) { Eunit.Draw_Enemy_Unit(e.Graphics); }
            }

            // goes through all the explosions in the global variables list Boom
            foreach (Boom boom in GlobalVariables.Boom)
            {
                // checks if the explotion has already been drawn
                if (boom.Drawn == true)
                {
                    // is so then removes that instance of the explosion from the list
                    GlobalVariables.Boom.Remove(boom);
                    break;
                }
            }

            // only if the Boom list has explosions in it
            if (GlobalVariables.Boom.Count > 0)
            {
                //goes through all the explosions in the Boom global variables list again
                for (int i = 0; i <= GlobalVariables.Boom.Count - 1; i++)
                {
                    // draws the explosions using the DrawBoom event and passing through the panels graphics object
                    GlobalVariables.Boom[i].DrawBoom(e.Graphics);
                }
            }

            // only if the Projectiles list has values in it
            if (GlobalVariables.Projectiles.Count != 0)
            {
                // goes through all the Projectiles in the global variable list Projectiles
                for (int i = 0; i <= GlobalVariables.Projectiles.Count - 1; i++)
                {
                    // calls on the move and draw event in the Projectiles, and passes through the graphics object
                    GlobalVariables.Projectiles[i].MoveAndDraw(e.Graphics);
                }
            }

            // only if the EProjectiles list has values in it
            if (GlobalVariables.EProjectiles.Count != 0)
            {
                // goes through all the EProjectiles in the global variable list EProjectiles
                for (int i = 0; i <= GlobalVariables.EProjectiles.Count - 1; i++)
                {
                    // calls on the move and draw event in the EProjectiles, and passes through the graphics object
                    GlobalVariables.EProjectiles[i].MoveAndDraw(e.Graphics);
                }
            }
        }

        private void TMR_Attack_Tick(object sender, EventArgs e)
        {
            // every time the timer ticks, it checks if there are no eemy units left
            if (GlobalVariables.Enemy_Units.Count() == 0)
            {
                // if all the enemy units are gone then:
                // checks if this it the highest level the player had to choose from
                if (GlobalVariables.LevelsUnlocked == GlobalVariables.Level)
                {
                    // if so, then unlocks the next level
                    GlobalVariables.LevelsUnlocked++;
                }

                // sets the battle over bool to true
                BattleOver = true;
                // centers the battle results panel in the middle of the form
                PNL_BattleResults.Location = new Point((this.Width - PNL_BattleResults.Width) / 2, (this.Height - PNL_BattleResults.Height) / 2);
                // shows the battle results panel
                PNL_BattleResults.Show();
                // changes the title label's text to victory
                LBL_Title.Text = "Victory!!";
                // changes the battle results text to the values from the global variable battle statistics variables (casualties, enemy casualties, coins earned)
                LBL_BattleResults.Text = "Casualties: " + GlobalVariables.BattlePlayerCasualties.ToString()
                    + Environment.NewLine + "Enemies Killed: " + GlobalVariables.BattleEnemyCasualties.ToString()
                    + Environment.NewLine + "Coins Earned: " + GlobalVariables.BattleCoinsEarned.ToString();

                // once the battle statistics have been used then, sets them back to 0
                GlobalVariables.BattleCoinsEarned = 0;
                GlobalVariables.BattleEnemyCasualties = 0;
                GlobalVariables.BattlePlayerCasualties = 0;
            }
            else if (GlobalVariables.Units.Count() == 0)
            {
                // if their are still enemies remaining, but the player no longer has any troops remaining, then:
                // sets the battle over to true
                BattleOver = true;
                // centers and shows the battle results panel
                PNL_BattleResults.Location = new Point((this.Width - PNL_BattleResults.Width) / 2, (this.Height - PNL_BattleResults.Height) / 2);
                PNL_BattleResults.Show();
                // sets the results title to defeat
                LBL_Title.Text = "Defeat!!";
                // shows the battle statistics in the battle results label
                LBL_BattleResults.Text = "Casualties: " + GlobalVariables.BattlePlayerCasualties.ToString()
                    + Environment.NewLine + "Enemies Killed: " + GlobalVariables.BattleEnemyCasualties.ToString()
                    + Environment.NewLine + "Coins Earned: " + GlobalVariables.BattleCoinsEarned.ToString();
                // resets the battle statistics to 0
                GlobalVariables.BattleCoinsEarned = 0;
                GlobalVariables.BattleEnemyCasualties = 0;
                GlobalVariables.BattlePlayerCasualties = 0;
            }
            else
            {
                // otherwise the battle isn't over
                // goes through the untis in the global Units list
                foreach (Unit unit in GlobalVariables.Units)
                {
                    // calls on the untis attack event
                    unit.Unit_Attack();
                }

                // goes through the enemy units in the global enemy unit list
                foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
                {
                    // calls on the enemy units attack event
                    Eunit.Attack_Unit();
                }
            }
        }

        private void BTN_BackToAC_Click(object sender, EventArgs e)
        {
            // when this button is clicked it takes the player back to the army camp form
            // note: this button only shows up when the battle is over (it's a part of the battle results panel)

            // sets the child to open global variable to army camp
            // this is then picked up and handled by the game form
            GlobalVariables.ChildToOpen = "army_camp";
        }

        private void Battleground_FormClosing(object sender, FormClosingEventArgs e)
        {
            //when the form is closing, end the level that is being played

            // calls on the end level event in the level control
            LevelControl.EndLevel();
        }
    }
}
