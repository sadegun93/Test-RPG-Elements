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
 * Enemies (Attacks) (Works)
 * Items (Gels) (Works)
 * Weapons (Works)
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
        static string name;
        public static string GetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

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
                if (value > maxHealth)
                {
                    remainingHealth = maxHealth;
                }
                else if(!(value > maxHealth))
                {
                    remainingHealth = value;
                }
            }
        }
        static int maxSkillPoints;
        public static int GetMaxSkillPoints
        {
            get
            {
                return maxSkillPoints;
            }
            set
            {
                if (value > maxSkillPoints)
                {
                    remainingSkillPoints = maxSkillPoints;
                }
                else if (!(value > maxSkillPoints))
                {
                    remainingSkillPoints = value;
                }
            }
        }
        static int remainingSkillPoints;
        public static int GetRemainingSkillPoints
        {
            get
            {
                return remainingSkillPoints;
            }
            set
            {
                remainingSkillPoints = value;
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

        //int to save the damage that the player deals
        public int attackDamage;

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
                        Console.WriteLine(SetUp.GetPlayerTank);
                        break;
                    case "Warrior":
                        //Warrior Stats
                        Console.WriteLine(SetUp.GetPlayerWarrior);
                        break;
                    case "Mage":
                        //Mage Stats
                        Console.WriteLine(SetUp.GetPlayerMage);
                        break;
                    case "Thief":
                        //Thief Stats
                        Console.WriteLine(SetUp.GetPlayerThief);
                        break;
                    default:
                        //Exit
                        break;
                }
            }

        }

        public override string ToString()
        {
            return
                "Name: " + GetName + 
                "\nLevel: " + GetLevel +
                "\nHit Points: " + remainingHealth + "/" + maxHealth +
                "\nSkill Points: " + maxSkillPoints + "/" + maxSkillPoints +
                "\nAttack: " + attack +
                "\nDefense: " + defense +
                "\nMagic Attack: " + magicAttack +
                "\nMagic Defense: " + magicDefense +
                "\nSpeed: " + speed;
                
        }

        //Constructor of Player to set initial stats
        public Player (string playerName, int hp, int rhp, int sp, int rsp, int atk, int def, int matk, int mdef, int spd, int lvl)
        {
            name = playerName;
            maxHealth = hp;
            remainingHealth = rhp;
            maxSkillPoints = sp;
            remainingSkillPoints = rsp;
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
