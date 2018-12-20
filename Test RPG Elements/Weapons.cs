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
    public class Weapons
    {
        //WeaponType string will differntiate the kinds of weapons, such as sword or lance
        //The WeaponName string will just keep the name
        public string weaponType;
        string weaponName;
        public string GetWeaponName
        {
            get
            {
                return weaponName;
            }
        }
        //augmentAttack and augmentMagicAttack ints will be the stat increase that the weapon provides
        int augmentAttack;
        public int GetAugmentAttack
        {
            get
            {
                return augmentAttack;
            }
        }
        int augmentMagicAttack;
        public int GetAugmentMagicAttack
        {
            get
            {
                return augmentMagicAttack;
            }
        }

        //Constructor to take in the information for the weapon
        public Weapons(string inputName, string inputType, int inputAttackAugment, int inputMagicAttackAugment)
        {
            weaponName = inputName;
            weaponType = inputType;
            augmentAttack = inputAttackAugment;
            augmentMagicAttack = inputMagicAttackAugment;
        }
    }
}
