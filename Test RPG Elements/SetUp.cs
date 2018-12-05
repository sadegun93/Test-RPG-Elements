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
    public class SetUp
    {
        //Random Object and method to be used throughout the program
        static Random UniversalDice = new Random();
        public static Random GetUniversalDice
        {
            get
            {
                return UniversalDice;
            }
        }
        /*public static void UniversalRoll(int start, int end)
        {
            int result;

            Random UniversalDice = new Random();

            result = UniversalDice.Next(start, end + 1);
        }*/

        //Class  objects to be created depending on what the player chooses.
        static Tank PlayerTank;
        public static Tank GetPlayerTank
        {
            get
            {
                return PlayerTank;
            }
        }
        static Warrior PlayerWarrior;
        public static Warrior GetPlayerWarrior
        {
            get
            {
                return PlayerWarrior;
            }
        }
        static Mage PlayerMage;
        public static Mage GetPlayerMage
        {
            get
            {
                return PlayerMage;
            }
        }
        static Thief PlayerThief;
        public static Thief GetPlayerThief
        {
            get
            {
                return PlayerThief;
            }
        }

        //int to save what class the player chose
        public static int classSelection;
        //string to save the class that the player chooses
        public static  string playerClass;
        //bool to verify if the player chose one of the available choices
        public static bool verifyPlayerClass;

        //Method to choose what class the player will be
        public static string ChooseClass()
        {
            SetName();

            Console.WriteLine("Please choose what class you would like to be. You have four options.");
            Console.WriteLine("1. The Tank - This fighter is great at taking hits and weathering the storm\n" +
                "2. The Warrior - This fighter knows how to fight and bring their enemies to their knees\n" +
                "3. The Mage - This scholarly warrior brings the elements under their control and uses them to ravage their enemies\n" +
                "Or\n" +
                "4. The Thief - This swift fighter is quick on their feet and hard to hit. They're frail, however.");
            playerClass = Console.ReadLine();
            verifyPlayerClass = int.TryParse(playerClass, out classSelection);
            while(verifyPlayerClass == false || classSelection> 4)
            {
                Console.WriteLine("Your input was invalid. Please choose one of the four classes.\n" +
                    "1. Tank\n" +
                    "2. Warrior\n" +
                    "3. Mage\n" +
                    "Or\n" +
                    "4. Thief");
                playerClass = Console.ReadLine();
                verifyPlayerClass = int.TryParse(playerClass, out classSelection);
            }
            switch(classSelection)
            {
                case 1:
                    //Tank
                    PlayerTank = new Tank();
                    Console.WriteLine("You are now a Tank.");
                    playerClass = "Tank";
                    return playerClass;
                case 2:
                    //Warrior
                    PlayerWarrior = new Warrior();
                    Console.WriteLine("You are now a Warrior.");
                    playerClass = "Warrior";
                    return playerClass;
                case 3:
                    //Mage
                    PlayerMage = new Mage();
                    Console.WriteLine("You are now a Mage.");
                    playerClass = "Mage";
                    return playerClass;
                case 4:
                    //Thief
                    PlayerThief = new Thief();
                    Console.WriteLine("You are now a Thief.");
                    playerClass = "Thief";
                    return playerClass;
                default:
                    //Tank
                    Tank DefaultTank = new Tank();
                    Console.WriteLine("You are now a Tank.");
                    playerClass = "Tank";
                    return playerClass;
            }
        }

        public static string SetName()
        {
            Console.WriteLine("What is your name?");
            Player.GetName = Console.ReadLine();

            while(string.IsNullOrEmpty(Player.GetName))
            {
                Console.WriteLine("You didn't enter a name. Please enter a name before continuing.");
                Player.GetName = Console.ReadLine();
            }

            return Player.GetName;
        }
    }
}
