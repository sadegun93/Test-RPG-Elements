using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Author: Stephen Adegun
 * Created: November 22nd, 2018
 * Purpose: Test to see if various RPG elements can work
 * Elements to be tested:
 * Player (Stats) (Works)
 * Enemies
 * Items
 * Weapons (Mostly Works; Magic Attack Augment is being added to attack along with the normal Attack Augment)
 * Armor and Accessories (Works)
 * Magic
 * Experience Points (Works)
 * Leveling Up (Works)
 * Combat
 */

namespace Test_RPG_Elements
{
    /*This will start off as an abstract parent class 
    To share all of the stats with its children
    Those children will be specialized classes whose starting stats will differ
    Child classes will be:
    Tank - High defense and HP; low speed
    Warrior - High attack and hp (less thank Tank)
    Mage - High Magic Attack and Magic Defense
    Thief - Very high Speed and low HP
    */
    public abstract class Player
    {
        //When the player's health would get to below zero, set it to zero
        //Include that in a set property
        static int maxHealth;
        public static int GetMaxHealth
        {
            get
            {
                return maxHealth;
            }
            set
            {
                maxHealth = value;
            }
        }
        static int remainingHealth;
        public static int GetRemainingHealth
        {
            get
            {
                return remainingHealth;
            }
            set
            {
                remainingHealth = value;
            }
        }
        static int attack;
        public static int GetAttack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }
        static int defense;
        public static int GetDefense
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
            }
        }
        static int magicAttack;
        public static int GetMagicAttack
        {
            get
            {
                return magicAttack;
            }
            set
            {
                magicAttack = value;
            }
        }
        static int magicDefense;
        public static int GetMagicDefense
        {
            get
            {
                return magicDefense;
            }
            set
            {
                magicDefense = value;
            }
        }
        public static int speed;
        public static int GetSpeed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        //strings to save the player's equipment
        static string weapon;
        public static string SetWeapon
        {
            set
            {
                weapon = value;
            }
        }
        static string armor;
        public static string SetArmor
        {
            set
            {
                armor = value;
            }
        }
        static string accessory;
        public static string SetAccessory
        {
            set
            {
                accessory = value;
            }
        }

        //String to save whether or not the player wants to view their stats
        public static string viewStats;

        //baseExp will set the amount of Experience that a player needs to level up
        //remainingExp will keep track of their experience as they fight
        //extraExp will be the remaining experience if the enemy experience is greater than the remaining experience.
        //baseExp will always be the amount of experience that the player needs at the START of a new level
        //remainingExp will always be the amoung of experience that the player needs AS they fight and get closer to a level
        static int baseExp = 100;
        public static int GetBaseExp
        {
            get
            {
                return baseExp;
            }
        }
        static int remainingExp = baseExp;
        public static int GetRemainingExp
        {
            get
            {
                return remainingExp;
            }
        }
        static int extraExp;
        public static int GetExtraExp
        {
            get
            {
                return extraExp;
            }
        }

        //The player's level, and a constant to control the max level they can be.
        static int level = 1;
        public static int GetLevel
        {
            get
            {
                return level;
            }
        }
        const int MAX_LEVEL = 100;

        //Method to control experience points
        //Requires base and remaining exp. 
        //The method will also need to know the number of experience points that each enemy is worth
        //The last piece of information it needs is how much leftover experience there is, if any
        public static int Experience(int baseExp, int remainingExp, int enemyExp, int extraExp)
        {
            Console.WriteLine("You received " + enemyExp + " EXP from this battle.");

            remainingExp = remainingExp - enemyExp;
            extraExp = remainingExp * -1;

            if (remainingExp <= 0 && level < MAX_LEVEL)
            {

                level = level + 1;
                StatGrowth(maxHealth, attack, defense, magicAttack, magicDefense, speed);

                Console.WriteLine("You've leveled up! You are now Level " + level + ".");
                PlayerStats(SetUp.playerClass);
            }

            baseExp = (int)(baseExp * 1.2);
            remainingExp = baseExp;
            remainingExp = remainingExp - extraExp;

            Console.WriteLine("You need " + remainingExp + " experience before your next level up.");
            return remainingExp;
        }

        //This method is meant to increase the player stats upon level up
        //Will be included in the Experience method under the level up
        public static void StatGrowth(int hp, int atk, int def, int matk, int mdef, int spd)
        {
            maxHealth = (int)Math.Round(hp * 1.1 + 0.05);
            remainingHealth = maxHealth;
            attack = (int)Math.Round(atk * 1.1 + 0.05);
            defense = (int)Math.Round(def * 1.1 + 0.05);
            magicAttack = (int)Math.Round(matk * 1.1 + 0.05);
            magicDefense = (int)Math.Round(mdef * 1.1 + 0.05);
            speed = (int)Math.Round(spd * 1.1 + 0.05);
        }

        //Method to display the player's stats if they want to
        public static void PlayerStats(string playerClass)
        {
            Console.WriteLine("Would you like to view your stats?\nY/N");
            viewStats = Console.ReadLine().Trim().ToUpper();
            if (!(string.IsNullOrEmpty(viewStats)))
            {
                viewStats = viewStats.Substring(0, 1);
            }

            while (string.IsNullOrEmpty(viewStats) || viewStats != "Y" && viewStats != "N")
            {
                Console.WriteLine("Your input was invalid. Would you like to view your stats?\nY/N");
                viewStats = Console.ReadLine().Trim().ToUpper();
                if (!(string.IsNullOrEmpty(viewStats)))
                {
                    viewStats = viewStats.Substring(0, 1);
                }
            }

            if (viewStats == "Y")
            {
                switch (SetUp.playerClass)
                {
                    case "Tank":
                        //Tank Stats
                        Console.WriteLine("Level: " + Tank.level);
                        Console.WriteLine("Hit Points: " + Tank.remainingHealth + "/" + Tank.maxHealth);
                        Console.WriteLine("Attack: " + Tank.attack);
                        Console.WriteLine("Defense: " + Tank.defense);
                        Console.WriteLine("Magic Attack: " + Tank.magicAttack);
                        Console.WriteLine("Magic Defense: " + Tank.magicDefense);
                        Console.WriteLine("Speed: " + Tank.speed);
                        break;
                    case "Warrior":
                        //Warrior Stats
                        Console.WriteLine("Level: " + Warrior.level);
                        Console.WriteLine("Hit Points: " + Warrior.maxHealth);
                        Console.WriteLine("Attack: " + Warrior.attack);
                        Console.WriteLine("Defense: " + Warrior.defense);
                        Console.WriteLine("Magic Attack: " + Warrior.magicAttack);
                        Console.WriteLine("Magic Defense: " + Warrior.magicDefense);
                        Console.WriteLine("Speed: " + Warrior.speed);
                        break;
                    case "Mage":
                        //Mage Stats
                        Console.WriteLine("Level: " + Mage.level);
                        Console.WriteLine("Hit Points: " + Mage.maxHealth);
                        Console.WriteLine("Attack: " + Mage.attack);
                        Console.WriteLine("Defense: " + Mage.defense);
                        Console.WriteLine("Magic Attack: " + Mage.magicAttack);
                        Console.WriteLine("Magic Defense: " + Mage.magicDefense);
                        Console.WriteLine("Speed: " + Mage.speed);
                        break;
                    case "Thief":
                        //Thief Stats
                        Console.WriteLine("Level: " + Thief.level);
                        Console.WriteLine("Hit Points: " + Thief.maxHealth);
                        Console.WriteLine("Attack: " + Thief.attack);
                        Console.WriteLine("Defense: " + Thief.defense);
                        Console.WriteLine("Magic Attack: " + Thief.magicAttack);
                        Console.WriteLine("Magic Defense: " + Thief.magicDefense);
                        Console.WriteLine("Speed: " + Thief.speed);
                        break;
                    default:
                        //Exit
                        break;
                }
            }

        }

        //Constructor of Player to set initial stats
        public Player (int hp, int rhp, int atk, int def, int matk, int mdef, int spd, int lvl)
        {
            maxHealth = hp;
            remainingHealth = rhp;
            attack = atk;
            defense = def;
            magicAttack = matk;
            magicDefense = mdef;
            speed = spd;
            level = lvl;
        }

        //Default Constructor just in case
        public Player ()
        {

        }
    }
}
