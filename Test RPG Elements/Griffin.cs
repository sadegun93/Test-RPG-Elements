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
    //Test Enemy Class to see if they work correctly
    public class Griffin:Enemies
    {
        /*static int griffinHealth = 100;
        static int griffinRemainingHealth = mageHealth;
        static int griffinAttack = 15;
        static int griffinDefense = 15;
        static int griffinMagicAttack = 20;
        static int griffinMagicDefense = 20;
        static int griffinSpeed = 20;*/

        //Constructor that will use the parent class as a base
        public Griffin(string GriffinName, int hp, int atk, int def, int matk, int mdef, int spd, int lvl) : base("Griffin", 100, 15, 15, 20, 20, 20, 1)
        {

        }

        //Overriden method that will choose and execute the griffin's attacks
        public override void Attack()
        {
            //Griffin will have 3+ attacks
            //Gust (Weak) (50%)
            //Tackle (Medium) (35%)
            //Peck (Heavy) (15%)

            enemyAttack = SetUp.GetUniversalDice.Next(1, 100 + 1);

            //if statements to choose which attack the griffin uses
            if(enemyAttack >= 1 && enemyAttack <= 50)
            {
                //Gust Attack
                enemyDamage = SetUp.GetUniversalDice.Next(1, 10);
                Console.WriteLine("The griffin beat its wings furiously.\nA strong gust blew " + Player.GetName + " back, knocking them over. " + Player.GetName + " took " + enemyDamage + " damage.");
                Player.GetRemainingHealth -= enemyDamage;
                Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
            }
            if (enemyAttack >= 51 && enemyAttack <= 85)
            {
                //Tackle Attack
                enemyDamage = SetUp.GetUniversalDice.Next(5, 13);
                Console.WriteLine("The griffin rushed forward, slamming into " + Player.GetName + ". They hit the ground with a hard thud. " + Player.GetName + " took " + enemyDamage + " damage.");
                Player.GetRemainingHealth -= enemyDamage;
                Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
            }
            if (enemyAttack >= 86 && enemyAttack <= 100)
            {
                //Peck Attack
                enemyDamage = SetUp.GetUniversalDice.Next(10, 20);
                Console.WriteLine("The griffin bent for a moment then lunged forward. Its sharp beak plunged into " + Player.GetName + "'s shoulder.\n It ripped its beak out, and " + Player.GetName + " held onto their bloodied shoulder.\n" + Player.GetName + " took " + enemyDamage + " damage.");
                Player.GetRemainingHealth -= enemyDamage;
                Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
            }
        }

    }
}
