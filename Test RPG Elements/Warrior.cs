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
 * Inventory (Dictionary can display a few items, at least)
 * Weapons (Works)
 * Armor and Accessories (Works)
 * Magic
 * Experience Points (Works)
 * Leveling Up (Works)
 * Combat
 */

namespace Test_RPG_Elements
{
    //Thief - Very high Speed and low HP
    public class Warrior:Player
    {
        //When the player's health would get to below zero, set it to zero
        //Include that in a set property
        /*static int warriorHealth = 150;
        static int warriorRemainingHealth = warriorHealth;
        static int warriorAttack = 30;
        static int warriorDefense = 15;
        static int warriorMagicAttack = 5;
        static int warriorMagicDefense = 5;
        static int warriorSpeed = 15;*/

        //Constructor that will use the parent class as a base
        public Warrior() : base(Player.GetName, 150, 150, 10, 10, 30, 15, 5, 5, 15, 1)
        {

        }
    }
}
