using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Enemy_Unit
    {
        //----------------------------------------------//
        // Declares public variables used in this class //
        //----------------------------------------------//
        public int x, y; // used to keep x and y coordinates of the enemy unit
        public int width = 120; // used to keep the width of the enemy unit
        public int height = 120; // used to keep the height of the enemy unit
        public Image Unit_Image; // uesd to keep the enemy units image to draw onto the rectangle
        public Rectangle UnitRec; // used to keep the enemy units rectangle / area
        public string Unit_Name; // used to keep the enemy units name
        public int Health, Damage, Attack_Speed; // used to keep the enemy units info (health, damage, attack speed)
        public bool Range; // used to tell if the enemy unit is ranged or not
        public bool move = true; // used to tell if the enemy unit can move
        public int Range_Distance = 200; // used to tell how far that ranged enemy units can target from
        public Unit UnitTarget; // used to keep the players unit that it being targeted by the specific instance of the enemy untis
        public int Speed = 10; // used to keep the speed of the enemy unit
        public int Min_X; // used to keep the minimum x coordinates the enemy unit can go to
        public bool Boss; // used to tell if the enemy unit is a boss or not
        public int AttackWaitTicks; // used to tell how long since the last attack
        public string ProjectileType; // used to know what type of projectiles the unit uses (if any)
        public Random rnd = new Random(); // used to produce random numbers (for the spawning of explosions)

        // when a new instance of the Enemy unit class is creates, it requires a: x point, y point, name, multiplier value, and min x point
        public Enemy_Unit(int X, int Y, string Name, int Multiplier, int minX)
        {
            // sets the x coordinate to the given x point
            x = X;
            // sets the y coordinate to the given y point
            y = Y;
            // sets the Units name to the given name
            Unit_Name = Name;
            // sets the minimum x value to the given min x
            Min_X = minX;

            // by default the image is set to the global variable image array value 0 (the image of the small duck)
            Unit_Image = GlobalVariables.Enemy_Lemons[0];
            // if the name of the unit to spawn is any of the following it selects the appropriate image to represent it
            if (Name == "big") { Unit_Image = GlobalVariables.Enemy_Lemons[1]; }
            else if (Name == "glass") { Unit_Image = GlobalVariables.Enemy_Lemons[2]; }
            else if (Name == "bottle") { Unit_Image = GlobalVariables.Enemy_Lemons[3]; }
            else if (Name == "boss1") { Unit_Image = GlobalVariables.BossPics[0]; Boss = true; }
            else if (Name == "boss2") { Unit_Image = GlobalVariables.BossPics[1]; Boss = true; }
            else if (Name == "boss3") { Unit_Image = GlobalVariables.BossPics[2]; Boss = true; }
            else if (Name == "finalboss") { Unit_Image = GlobalVariables.BossPics[3]; Boss = true; }

            // goes through all the enemy unit settings in the EUnit_Info global variable list
            foreach (Get_EUnit_Info i in GlobalVariables.EUnit_Info)
            {
                // finds the item with the name of this enemy unit
                if (i.Name == Unit_Name)
                {
                    // once found:
                    // sets the health value to the health setting (affected by the multiplier)
                    Health = i.Health * Multiplier;
                    // sets the damage value to the damage setting (affected by the multiplier)
                    Damage = i.Damage * Multiplier;
                    // sets the attack speed value to the attack speed setting
                    Attack_Speed = i.Attack_Speed;

                    // finds out wether the unit is supposed to be ranged or not
                    if (i.Range == "yes")
                    {
                        // if it is:
                        // sets the range value to true
                        Range = true;
                        // checks what projectile types to use
                        if (i.Name == "finalboss") { ProjectileType = "lemon"; }
                        else { ProjectileType = "lemonade_ball"; }
                    }
                    else { Range = false; } // otherwise, if the unit isn't ranged it sets the range value to false
                }
            }
        }

        // whenever the draw event is called upon, it requires a graphics object
        public void Draw_Enemy_Unit(Graphics g)
        {
            // sets the unit rectangles location and size using the x, y, width, and height variables
            UnitRec = new Rectangle(x, y, width, height);
            // uses the given graphics object to draw the image in the rectangle's area
            g.DrawImage(Unit_Image, UnitRec);
        }

        public void Move_Enemy_Unit()
        {
            // by default the move value is set to true
            move = true;

            // checks wether the unit is ranged or not
            if (Range == true)
            {
                // if it is ranged,
                // checks if it is withen the ranged attack distance from any of the players units (stored in the Units global variable list)
                // if it is then it sets the move value to false
                foreach (Unit unit in GlobalVariables.Units)
                {
                    if (x - Range_Distance - (Speed / 2) <= unit.x + unit.width)
                    {
                        move = false;
                    }
                }

                // checks if it will go past the minimum x coordinate
                if (x - (Speed / 2) <= Min_X)
                {
                    // if it will then it sets move to false
                    move = false;
                }

                // if the move value is true
                if (move == true)
                {
                    // moves the unit's x coordinate according to the speed value
                    x = x - Speed;
                }
            }
            else
            {
                // otherwise the unit is not ranged
                // checks if it is withen normal attacking range from any of the players units (stored in the Units global variable list)
                // if it is then it sets the move value to false
                foreach (Unit unit in GlobalVariables.Units)
                {
                    if (x - (Speed / 2) <= unit.x + unit.width)
                    {
                        move = false;
                    }
                }

                // checks if the unit will move past the minimum x value
                if (x - (Speed / 2) <= Min_X)
                {
                    // if it will then sets the move value to false
                    move = false;
                }

                // if the move value is still true
                if (move == true)
                {
                    // moves the unit according to the speed value
                    x = x - Speed;
                }
            }
        }

        // whenever the damage event is called upon it requires a number value of the damage taken
        public void Damage_Enemy_Unit(int damage)
        {
            // reduces the units health by the damage given
            Health = Health - damage;
            // adds an explosion to the global boom list
            GlobalVariables.Boom.Add(new Boom((x - 27) + rnd.Next(0, 4), rnd.Next(y, y + width)));

            // checks if the health is less that 0
            if (Health <= 0)
            {
                // if so the unit is 'dead'
                // finds out what unit it is, and awards the apropriate ammount of coins (also keeps track of this in the battle stat for coins earned)
                if (Unit_Name == "big") { GlobalVariables.Coins = GlobalVariables.Coins + 10; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 10; }
                else if (Unit_Name == "glass") { GlobalVariables.Coins = GlobalVariables.Coins + 20; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 20; }
                else if (Unit_Name == "bottle") { GlobalVariables.Coins = GlobalVariables.Coins + 40; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 40; }
                else if (Unit_Name == "boss1") { GlobalVariables.Coins = GlobalVariables.Coins + 80; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 80; }
                else if (Unit_Name == "boss2") { GlobalVariables.Coins = GlobalVariables.Coins + 110; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 110; }
                else if (Unit_Name == "boss3") { GlobalVariables.Coins = GlobalVariables.Coins + 150; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 150; }
                else if (Unit_Name == "finalboss") { GlobalVariables.Coins = GlobalVariables.Coins + 200; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 200; }
                else { GlobalVariables.Coins = GlobalVariables.Coins + 5; GlobalVariables.BattleCoinsEarned = GlobalVariables.BattleCoinsEarned + 5; }

                // adds this enemy 'death' the the battle stat for enemy casualties
                GlobalVariables.BattleEnemyCasualties = GlobalVariables.BattleEnemyCasualties + 1;

                // calls on the destroy event
                Enemy_Unit_Destroy();
            }
        }

        public void Attack_Unit()
        {
            // adds one to the time waited since the last attack
            AttackWaitTicks++;

            // checks if the unit has waited the correct ammount of time
            if (AttackWaitTicks >= Attack_Speed)
            {
                // if so, then:
                // sets the attack wait time back to 0
                AttackWaitTicks = 0;

                // if there isn't 0 units in the global units list
                if (GlobalVariables.Units.Count != 0)
                {
                    // selects the closest unit to attack
                    UnitTarget = GlobalVariables.Units.Last();

                    // if it dosn't have a unit to attack
                    if (UnitTarget != null)
                    {
                        // checks wether the unit is ranged or not
                        if (Range == true)
                        {
                            // the unit is ranges, so check if it isn't moving
                            if (move == false)
                            {
                                // if the unit isn't moving, then add a projectile to the global EProjectile list
                                GlobalVariables.EProjectiles.Add(new EProjectile(x, Min_X, y + (height / 2), ProjectileType, Damage, UnitTarget));
                            }
                        }
                        else
                        {
                            // otherwise the unit isn't ranged
                            // checks if the unit isn't moveing
                            if (move == false)
                            {
                                // if the unit isn't moving then, directly damages the unit
                                UnitTarget.Unit_Damage(Damage);
                            }
                        }
                    }
                }
            }
        }

        public void Enemy_Unit_Destroy()
        {
            // removes this from the enemy units list
            GlobalVariables.Enemy_Units.Remove(this);
        }
    }
}
