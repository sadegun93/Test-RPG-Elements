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
    public class Accessories
    {
        //accessoryType string will differntiate the kinds of accessory, such as capes or boots
        //The accessoryName string will just keep the name
        public string accessoryType;
        static string accessoryName;
        public string GetAccessoryName
        {
            get
            {
                return accessoryName;
            }
        }
        //augmentHealth ints will be the stat increase that the accessory provides
        static int augmentHealth;
        public int GetAugmentHealth
        {
            get
            {
                return augmentHealth;
            }
        }
        //augmentAttack and augmentMagicAttack ints will be the stat increase that the accessory provides
        static int augmentAttack;
        public int GetAugmentAttack
        {
            get
            {
                return augmentAttack;
            }
        }
        static int augmentMagicAttack;
        public int GetAugmentMagicAttack
        {
            get
            {
                return augmentMagicAttack;
            }
        }
        //augmentDefense and augmentMagicDefense ints will be the stat increase that the accessory provides
        static int augmentDefense;
        public int GetAugmentDefense
        {
            get
            {
                return augmentDefense;
            }
        }
        static int augmentMagicDefense;
        public int GetAugmentMagicDefense
        {
            get
            {
                return augmentMagicDefense;
            }
        }
        //augmentSpeed ints will be the stat increase that the accessory provides
        static int augmentSpeed;
        public int GetAugmentSpeed
        {
            get
            {
                return augmentSpeed;
            }
        }

        //Constructor to take in the information for the weapon
        public Accessories(string inputName, string inputType, int inputHealthAugment, int inputAttackAugment, int inputMagicAttackAugment, int inputDefenseAugment, int inputMagicDefenseAugment, int inputAugmentSpeed)
        {
            accessoryName = inputName;
            accessoryType = inputType;
            augmentHealth = inputHealthAugment;
            augmentAttack = inputAttackAugment;
            augmentMagicAttack = inputMagicAttackAugment;
            augmentDefense = inputDefenseAugment;
            augmentMagicDefense = inputMagicDefenseAugment;
            augmentSpeed = inputAugmentSpeed;
        }
    }
}
