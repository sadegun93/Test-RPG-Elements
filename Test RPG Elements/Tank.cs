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
    //Tank - High defense and HP; low speed
    public class Tank:Player
    {
        //When the player's health would get to below zero, set it to zero
        //Include that in a set property
        /*static int tankHealth = 200;
        static int tankRemainingHealth = tankHealth;
        static int tankAttack = 20;
        static int tankDefense = 50;
        static int tankMagicAttack = 15;
        static int tankMagicDefense = 30;
        static int tankSpeed = 10;*/

        //Constructor that will use the parent class as a base
        public Tank(): base(Player.GetName, 200, 200, 50, 50, 20, 50, 15, 30, 10, 1)
        {

        }
    }
}
