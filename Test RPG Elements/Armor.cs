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
    public class Armor
    {
        //armorType string will differntiate the kinds of armor, such as chestplates or helmets
        //The armorName string will just keep the name
        public string armorType;
        string armorName;
        public string GetArmorName
        {
            get
            {
                return armorName;
            }
        }
        //augmentDefense and augmentMagicDefense ints will be the stat increase that the weapon provides
        int augmentDefense;
        public int GetAugmentDefense
        {
            get
            {
                return augmentDefense;
            }
        }
        int augmentMagicDefense;
        public int GetAugmentMagicDefense
        {
            get
            {
                return augmentMagicDefense;
            }
        }

        //Constructor to take in the information for the weapon
        public Armor(string inputName, string inputType, int inputDefenseAugment, int inputMagicDefenseAugment)
        {
            armorName = inputName;
            armorType = inputType;
            augmentDefense = inputDefenseAugment;
            augmentMagicDefense = inputMagicDefenseAugment;
        }
    }
}
