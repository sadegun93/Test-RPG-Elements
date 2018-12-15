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
    //Class for items. Primarily healing items of various qualities
    class Items
    {
        string itemName;
        public string GetItemName
        {
            get
            {
                return itemName;
            }
        }

        //Amount of HP or SP to be restored by fixed restoration items, like potions or ethers
        int hpRestore;
        public int GetHPRestore
        {
            get
            {
                return hpRestore;
            }
        }
        int spRestore;
        public int GetSPRestore
        {
            get
            {
                return spRestore;
            }
        }

        //Amount of HP or SP to be restored by percentage restoration items
        //Think the gels of the tales series
        //As they restore percentages of the player's HP
        //They need to know the player's max and remaining HP or their max and remaining SP
        int playerHPMax;
        public int GetPlayerHPMax
        {
            get
            {
                return playerHPMax;
            }
        }
        int playerHP;
        public int GetPlayerHP
        {
            get
            {
                return playerHP;
            }
        }
        int playerSPMax;
        public int GetPlayerSPMax
        {
            get
            {
                return playerSPMax;
            }
        }
        int playerSP;
        public int GetPlayerSP
        {
            get
            {
                return playerSP;
            }
        }

        //constructor for fixed restorative items that only restore hp or mp
        public Items(string name, int hp_sp)
        {
            itemName = name;
            hpRestore = hp_sp;
            spRestore = hp_sp;
        }

        //Constructor for fixed restorative items that restore both hp and mp
        public Items(string name, int hp, int sp)
        {
            itemName = name;
            hpRestore = hp;
            spRestore = sp;
        }

        //constructor for percentage based restorative items that only restore hp or mp
        public Items(string name, int classHP_SP, int classHP_SPMax, int waste)
        {
            itemName = name;
            playerHP = classHP_SP;
            playerHPMax = classHP_SPMax;
            playerSP = classHP_SP;
            playerSPMax = classHP_SPMax;
        }

        //Constructor for fixed restorative items that restore both hp and mp
        public Items(string name, int classHP, int classHPMax, int classSP, int classSPMax)
        {
            itemName = name;
            playerHP = classHP;
            playerHPMax = classHPMax;
            playerSP = classSP;
            playerSPMax = classSPMax;
        }

    }
}
