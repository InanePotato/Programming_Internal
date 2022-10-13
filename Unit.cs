using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Internal
{
    internal class Unit
    {
        //----------------------------------------------//
        // Declares public variables used in this class //
        //----------------------------------------------//
        public int x, y; // used for the location of the unit
        public int height = 120, width = 120; // used for the size of the units rectangle
        public Image Unit_Image; // used to hold the image used for the unit
        public Rectangle UnitRec; // used for the area the unit is in
        public Enemy_Unit UnitTarget; // used to know the enemy unit target this unit is aiming at
        public string Unit_Type, Unit_Name; // used to know this units name and type
        public int Health, Damage, Attack_Speed, Unit_Level; // used to know the units stats (health, damage, attack speed, unit level)
        public bool Range; // used to know if the unit is ranged or not
        public bool move = true; // used to know if the unit can move / is moving / should be moving
        public int Range_Distance = 200; // used to know how far away from their targets ranged units can be
        public int Speed = 10; // used to control the distance the unit moves each time the move method is called (the speed of movment)
        public int Max_X; // used to know how far right the unit can go
        public int AttackWaitTicks = 0; // used to know how long the unit has waited for since it's last attack
        public int multiplier; // used to know how many units this 1 sprite is representing
        public string ProjectileType; // used to know what type of projectiles this unit uses
        public Random rnd = new Random(); // used for slight variation in the spawning of an explosion

        // whenever a new instance of the unit class is created, it requires:
        // a x and y location, type, name, level, multiplier, and max x
        public Unit(int X, int Y, string Type, string Name, int Level, int Multiplier, int maxX)
        {
            x = X; // sets the x variable to the given value
            y = Y; // sets the y variable to the given value
            Unit_Type = Type; // sets the unit type variable to the given value
            Unit_Name = Name; // sets the unit name variable to the given value
            Unit_Level = Level; // sets the unit level variable to the given value
            Max_X = maxX; // sets the max x variable to the given value
            multiplier = Multiplier; // sets the multiplier variable to the given value

            // finds that type of unit this is, and gets it's correct image (the images are also affected by the unit level)
            if (Unit_Type == "basic") { Unit_Image = GlobalVariables.Basic_Ducks[Unit_Level]; }
            if (Unit_Type == "range") { Unit_Image = GlobalVariables.Range_Ducks[Unit_Level]; }
            if (Unit_Type == "magic") { Unit_Image = GlobalVariables.Magic_Ducks[Unit_Level]; }
            if (Unit_Type == "gun") { Unit_Image = GlobalVariables.Gun_Ducks[Unit_Level]; }
            if (Unit_Type == "giant") { Unit_Image = GlobalVariables.Giant_Ducks[Unit_Level]; }

            // goes through all the units in the global unit info list
            foreach (Get_Unit_Info i in GlobalVariables.Unit_Info)
            {
                // finds the correct name that fits this unit
                if (i.Name == Unit_Name)
                {
                    // finds the health, and damage settings of the unit (this is affected by the multiplier / how many units this one is representing)
                    Health = i.Health * Multiplier;
                    Damage = i.Damage * Multiplier;
                    // finds the attack speed setting of the unit (not affected by the multiplier)
                    Attack_Speed = i.Attack_Speed;

                    // checks wether the unit is ranged or not
                    if (i.Range == "yes")
                    {
                        // if the unit is ranged, sets the ranged value to true
                        Range = true;
                        // finds out what type of projectile the unit uses, and sets that to the projectile type
                        if (i.Name == "archer") { ProjectileType = "arrow"; }
                        else if (i.Name == "catapult" || i.Name == "cannon") { ProjectileType = "cannon_ball"; }
                        else if (i.Name == "wizard" || i.Name == "sorcerer") { ProjectileType = "fire_ball"; }
                        else { ProjectileType = "bullet"; }
                    }
                    else { Range = false; } // if not, then sets ranged to false
                }
            }
        }

        // this is in charge of drawing the unit on the given panel using the given graphics opject
        public void Unit_Draw(Graphics g)
        {
            // updtes the unit rectangle to the x, y, width, height
            UnitRec = new Rectangle(x, y, width, height);
            // uses the graphics object to draw the image in the rectangle
            g.DrawImage(Unit_Image, UnitRec);
        }
        
        // in charge of moving the unit / stopping it when it gets to close to the enemy
        public void Move_Unit()
        {
            // by defaut move is set to true (can move)
            move = true;
            // checks wether the unit is ranged or not (ranged units are treated differently)
            if (Range == true)
            {
                // if the unit is a ranged unit
                // goes through all the enemy units in the global enemy unit list
                foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
                {
                    // checks wether this unit is too close to them (accounting for the extra distance it has being a ranged unit)
                    if (x + width + Range_Distance + (Speed / 2) >= Eunit.x)
                    {
                        // if the unit is too close to the enemys then sets move to false
                        move = false;
                    }
                }

                // checks if the unit is past the max x point
                if (x + (Speed / 2) >= Max_X)
                {
                    // if so, then sets move to false
                    move = false;
                }

                // checks wether the unit is still able to move
                if (move == true)
                {
                    // if the unit is still able to move then moves it along the x axis by the speed value
                    x = x + Speed;
                }
            }
            else
            {
                // otherwise the unit must not be ranged
                // goed through all the enemy units in the gloabl enemy unit list
                foreach (Enemy_Unit Eunit in GlobalVariables.Enemy_Units)
                {
                    // checks wether the unit is too close to the enemy units
                    if (x + width + (Speed / 2) >= Eunit.x)
                    {
                        // if so sets move to false
                        move = false;
                    }
                }

                // checks wether the unit is past the max x point
                if (x + (Speed / 2) >= Max_X)
                {
                    // if so sets move to false
                    move = false;
                }

                // checks wether the move value is still true
                if (move == true)
                {
                    // if it is, that means the unit is still able to move,
                    // so moves the unit along the x axis by the value of speed
                    x = x + Speed;
                }
            }
        }

        // this method is in charge of attacking others
        public void Unit_Attack()
        {
            // add one to the time waited
            AttackWaitTicks++;

            // checks wether the unit has waited long enough since it's last attack
            if (AttackWaitTicks >= Attack_Speed)
            {
                // if so, sets the time waited to 0
                AttackWaitTicks = 0;

                // makes sure there are still enemy units left
                if (GlobalVariables.Enemy_Units.Count != 0)
                {
                    // sets the target to the first one on the list
                    UnitTarget = GlobalVariables.Enemy_Units.Last();

                    // makes sure the target has been set
                    if (UnitTarget != null)
                    {
                        // checks wether the unit is ranged or not
                        if (Range == true)
                        {
                            // if the unit is ranged
                            // checks wether the unit has stopped, so can shoot
                            if (move == false)
                            {
                                // adds a projectile to the global projectiles list with this units location, target, etc
                                GlobalVariables.Projectiles.Add(new Projectile(x + width, Max_X, y + (height / 2), ProjectileType, Damage, UnitTarget));
                            }
                            
                        }
                        else
                        {
                            // otherewise the unit is not ranged
                            // checks that the unit has stopped, so can shoot
                            if (move == false)
                            {
                                // calls on the targets damage method to directly damage the unit
                                UnitTarget.Damage_Enemy_Unit(Damage);
                            }
                        }
                    }
                }
            }
        }

        // this method is in charge of applying the damage of another unit onto this one
        public void Unit_Damage(int damage)
        {
            // takes the damage off the units health
            Health = Health - damage;
            // adds an explosion by the unit for effect
            // (the random number is used to give some variation in the spawn location of the explosion)
            GlobalVariables.Boom.Add(new Boom(((x + width) - 2) + rnd.Next(0, 4), rnd.Next(y, y + width)));

            // checks whether the units health is less than or equal to 0 (the unit is dead)
            if (Health <= 0)
            {
                // if the unit is dead
                // repeat for the number of units this one unit represented (multipliers value)
                for (int i = 0; i < multiplier; i++)
                {
                    // find out what unit type this was, and take the unit of the players total number of them
                    if (Unit_Type == "basic") { GlobalVariables.BasicUnit_Count--; }
                    if (Unit_Type == "range") { GlobalVariables.RangeUnit_Count--; }
                    if (Unit_Type == "magic") { GlobalVariables.MagicUnit_Count--; }
                    if (Unit_Type == "gun") { GlobalVariables.GunUnit_Count--; }
                    if (Unit_Type == "giant") { GlobalVariables.GiantUnit_Count--; }
                }

                // adds the number of units this one unit represented (the ammount that died / mutiplier)
                // to the battle stat for player unit casualties
                GlobalVariables.BattlePlayerCasualties = GlobalVariables.BattlePlayerCasualties + multiplier;

                // call on the destroy unit method
                Unit_Destroy();
            }
        }

        // this method is in charge of getting rid of this instance of the unit class
        public void Unit_Destroy()
        {
            // removes the unit from the global unit list
            GlobalVariables.Units.Remove(this);
        }
    }
}
