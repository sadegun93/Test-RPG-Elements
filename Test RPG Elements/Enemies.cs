﻿using System;
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
    //This will act as the parent class for any and all enemies. They will all have the same stats in common
    //Include at least one abstract attack method that will then be different for each enemy

    public abstract class Enemies
    {
        //Enemy Attributes
        int name;
        int maxHealth;
        int attack;
        int defense;
        int magicAttack;
        int magicDefense;
        int speed;
        int level;

        //Abstract Attack Method
        //Each enemy will have multiple attacks in the method, all of which are determined by a random dice roll
        public abstract void Attack();

        //Constructor of enemy to set initial stats
        public Enemies(int hp, int atk, int def, int matk, int mdef, int spd, int lvl)
        {
            maxHealth = hp;
            attack = atk;
            defense = def;
            magicAttack = matk;
            magicDefense = mdef;
            speed = spd;
            level = lvl;
        }
    }
}