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
    //This class exists solely to be a place where different kinds of weapons can be created to be used at a later date
    class Equipment
    {
        //temp string to test equipment
        string weaponEquip;

        //Object of the Weapon Class; Sword
        public Weapons WoodenSword = new Weapons("Wooden Sword", "Sword", 5, 1);

        public void EquipWeapon(Weapons Weapon)
        {
            Console.WriteLine("Would you like to equip the " + Weapon.GetWeaponName + "?\nY/N");
            weaponEquip = Console.ReadLine().Trim().ToUpper();
            if (!(string.IsNullOrEmpty(weaponEquip)))
            {
                weaponEquip = weaponEquip.Substring(0, 1);
            }

            while (string.IsNullOrEmpty(weaponEquip) || weaponEquip != "Y" && weaponEquip != "N")
            {
                Console.WriteLine("Your input was invalid. Would you like to equip the " + Weapon.GetWeaponName + "?\nY/N");
                weaponEquip = Console.ReadLine().Trim().ToUpper();
                if (!(string.IsNullOrEmpty(weaponEquip)))
                {
                    weaponEquip = weaponEquip.Substring(0, 1);
                }
            }

            if (weaponEquip == "Y")
            {
                Console.WriteLine(Weapon.GetAugmentAttack);
                Console.WriteLine(Weapon.GetAugmentMagicAttack);

                Console.WriteLine("You have equipped the " + Weapon.GetWeaponName + ".");
                Player.SetWeapon = Weapon.GetWeaponName;
                Player.GetAttack += Weapon.GetAugmentAttack;
                Player.GetMagicAttack += Weapon.GetAugmentMagicAttack;
                Player.PlayerStats(SetUp.playerClass);
            }
        }
    }
}
