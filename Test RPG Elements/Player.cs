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
 * Armor
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
        public static int health;
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
        static int magicAttack;
        public static int GetMagicAttack
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
        public static int magicDefense;
        public static int speed;

        //strings to save the player's equipment
        static string weapon;
        public static string SetWeapon
        {
            set
            {
                weapon = value;
            }
        }
        public static string armor;
        public static string accessory;

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
                StatGrowth(health, attack, defense, magicAttack, magicDefense, speed);

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
            health = (int)(hp * 1.1);
            attack = (int)(atk * 1.1);
            defense = (int)(def * 1.1);
            magicAttack = (int)(matk * 1.1);
            magicDefense = (int)(mdef * 1.1);
            speed = (int)(spd * 1.1);
        }

        //Method to display the player's stats if they want to
        public static void PlayerStats(string playerClass)
        {
            Console.WriteLine("Would you like to view your stats?\nY/N");
            viewStats = Console.ReadLine().Trim().ToUpper();
            if(!(string.IsNullOrEmpty(viewStats)))
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

            if(viewStats == "Y")
            {
                switch(SetUp.playerClass)
                {
                    case "Tank":
                        //Tank Stats
                        Console.WriteLine("Level: " + Tank.level);
                        Console.WriteLine("Hit Points: " + Tank.health);
                        Console.WriteLine("Attack: " + Tank.attack);
                        Console.WriteLine("Defense: " + Tank.defense);
                        Console.WriteLine("Magic Attack: " + Tank.magicAttack);
                        Console.WriteLine("Magic Defense: " + Tank.magicDefense);
                        Console.WriteLine("Speed: " + Tank.speed);
                        break;
                    case "Warrior":
                        //Warrior Stats
                        Console.WriteLine("Level: " + Warrior.level);
                        Console.WriteLine("Hit Points: " + Warrior.health);
                        Console.WriteLine("Attack: " + Warrior.attack);
                        Console.WriteLine("Defense: " + Warrior.defense);
                        Console.WriteLine("Magic Attack: " + Warrior.magicAttack);
                        Console.WriteLine("Magic Defense: " + Warrior.magicDefense);
                        Console.WriteLine("Speed: " + Warrior.speed);
                        break;
                    case "Mage":
                        //Mage Stats
                        Console.WriteLine("Level: " + Mage.level);
                        Console.WriteLine("Hit Points: " + Mage.health);
                        Console.WriteLine("Attack: " + Mage.attack);
                        Console.WriteLine("Defense: " + Mage.defense);
                        Console.WriteLine("Magic Attack: " + Mage.magicAttack);
                        Console.WriteLine("Magic Defense: " + Mage.magicDefense);
                        Console.WriteLine("Speed: " + Mage.speed);
                        break;
                    case "Thief":
                        //Thief Stats
                        Console.WriteLine("Level: " + Thief.level);
                        Console.WriteLine("Hit Points: " + Thief.health);
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
        public Player (int hp, int atk, int def, int matk, int mdef, int spd, int lvl)
        {
            health = hp;
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
