using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_RPG_Elements
{
    //Test Enemy Class to see if they work correctly
    class Griffin:Enemies
    {
        /*static int griffinHealth = 100;
        static int griffinRemainingHealth = mageHealth;
        static int griffinAttack = 15;
        static int griffinDefense = 15;
        static int griffinMagicAttack = 20;
        static int griffinMagicDefense = 20;
        static int griffinSpeed = 20;*/

        //Int to save result of attack roll
        public int enemyAttack;
        //int to save the damage that the enemy deals to the player
        public int enemyDamage;

        //Constructor that will use the parent class as a base
        public Griffin() : base(100, 15, 15, 20, 20, 20, 1)
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
            }
            if (enemyAttack >= 51 && enemyAttack <= 85)
            {
                //Tackle Attack
            }
            if (enemyAttack >= 86 && enemyAttack <= 100)
            {
                //Peck Attack
            }
        }

    }
}
