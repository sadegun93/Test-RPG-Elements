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
    //Thief - Very high Speed and low HP
    public class Thief:Player
    {
        //When the player's health would get to below zero, set it to zero
        //Include that in a set property
        /*static int thiefHealth = 75;
        static int thiefRemainingHealth = thiefHealth;
        static int thiefAttack = 15;
        static int thiefDefense = 15;
        static int thiefMagicAttack = 10;
        static int thiefMagicDefense = 10;
        static int thiefSpeed = 30;*/

        //Constructor that will use the parent class as a base
        public Thief() : base(Player.GetName, 75, 75, 15, 15, 10, 10, 30, 1)
        {

        }
    }
}
