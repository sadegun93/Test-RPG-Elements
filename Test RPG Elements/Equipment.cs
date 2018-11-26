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
        //String for equipping items
        string itemEquip;

        //Object of the Weapon Class; Sword
        public Weapons WoodenSword = new Weapons("Wooden Sword", "Sword", 5, 1);

        //Object of the Armor Class; Chestplate
        public Armor HauteCoutre = new Armor("Haute Coutre", "Chestplate", 5, 3);

        //Object of the Accessory Class; Boots
        public Accessories Boots = new Accessories("Boots", "Boots", 0, 0, 0, 3, 1, 4);

        public void EquipWeapon(Weapons Weapon)
        {
            Console.WriteLine("Would you like to equip the " + Weapon.GetWeaponName + "?\nY/N");
            itemEquip = Console.ReadLine().Trim().ToUpper();
            if (!(string.IsNullOrEmpty(itemEquip)))
            {
                itemEquip = itemEquip.Substring(0, 1);
            }

            while (string.IsNullOrEmpty(itemEquip) || itemEquip != "Y" && itemEquip != "N")
            {
                Console.WriteLine("Your input was invalid. Would you like to equip the " + Weapon.GetWeaponName + "?\nY/N");
                itemEquip = Console.ReadLine().Trim().ToUpper();
                if (!(string.IsNullOrEmpty(itemEquip)))
                {
                    itemEquip = itemEquip.Substring(0, 1);
                }
            }

            if (itemEquip == "Y")
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

        public void EquipArmor(Armor Armor)
        {
            Console.WriteLine("Would you like to equip the " + Armor.GetArmorName + "?\nY/N");
            itemEquip = Console.ReadLine().Trim().ToUpper();
            if (!(string.IsNullOrEmpty(itemEquip)))
            {
                itemEquip = itemEquip.Substring(0, 1);
            }

            while (string.IsNullOrEmpty(itemEquip) || itemEquip != "Y" && itemEquip != "N")
            {
                Console.WriteLine("Your input was invalid. Would you like to equip the " + Armor.GetArmorName + "?\nY/N");
                itemEquip = Console.ReadLine().Trim().ToUpper();
                if (!(string.IsNullOrEmpty(itemEquip)))
                {
                    itemEquip = itemEquip.Substring(0, 1);
                }
            }

            if (itemEquip == "Y")
            {
                Console.WriteLine(Armor.GetAugmentDefense);
                Console.WriteLine(Armor.GetAugmentMagicDefense);

                Console.WriteLine("You have equipped the " + Armor.GetArmorName + ".");
                Player.SetArmor = Armor.GetArmorName;
                Player.GetDefense += Armor.GetAugmentDefense;
                Player.GetMagicDefense += Armor.GetAugmentMagicDefense;
                Player.PlayerStats(SetUp.playerClass);
            }
        }

        public void EquipAccessory(Accessories Accessory)
        {
            Console.WriteLine("Would you like to equip the " + Accessory.GetAccessoryName + "?\nY/N");
            itemEquip = Console.ReadLine().Trim().ToUpper();
            if (!(string.IsNullOrEmpty(itemEquip)))
            {
                itemEquip = itemEquip.Substring(0, 1);
            }

            while (string.IsNullOrEmpty(itemEquip) || itemEquip != "Y" && itemEquip != "N")
            {
                Console.WriteLine("Your input was invalid. Would you like to equip the " + Accessory.GetAccessoryName + "?\nY/N");
                itemEquip = Console.ReadLine().Trim().ToUpper();
                if (!(string.IsNullOrEmpty(itemEquip)))
                {
                    itemEquip = itemEquip.Substring(0, 1);
                }
            }

            if (itemEquip == "Y")
            {
                Console.WriteLine(Accessory.GetAugmentHealth);
                Console.WriteLine(Accessory.GetAugmentAttack);
                Console.WriteLine(Accessory.GetAugmentMagicAttack);
                Console.WriteLine(Accessory.GetAugmentDefense);
                Console.WriteLine(Accessory.GetAugmentMagicDefense);
                Console.WriteLine(Accessory.GetAugmentSpeed);

                Console.WriteLine("You have equipped the " + Accessory.GetAccessoryName + ".");
                Player.SetAccessory = Accessory.GetAccessoryName;
                Player.GetHealth += Accessory.GetAugmentHealth;
                Player.GetAttack += Accessory.GetAugmentAttack;
                Player.GetMagicAttack += Accessory.GetAugmentMagicAttack;
                Player.GetDefense += Accessory.GetAugmentDefense;
                Player.GetMagicDefense += Accessory.GetAugmentMagicDefense;
                Player.GetSpeed += Accessory.GetAugmentSpeed;
                Player.PlayerStats(SetUp.playerClass);
            }
        }
    }
}
