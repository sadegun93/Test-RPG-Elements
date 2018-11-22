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
    //Mage - High Magic Attack and Magic Defense
    public class Mage:Player
    {
        //When the player's health would get to below zero, set it to zero
        //Include that in a set property
        static int mageHealth = 100;
        static int mageAttack = 10;
        static int mageDefense = 10;
        static int mageMagicAttack = 50;
        static int mageMagicDefense = 50;
        static int mageSpeed = 15;

        //Constructor that will use the parent class as a base
        public Mage() : base(mageHealth, mageAttack, mageDefense, mageMagicAttack, mageMagicDefense, mageSpeed, GetLevel)
        {

        }
    }
}
