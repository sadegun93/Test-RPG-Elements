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

        //Object of the Item Class; Potion
        public Items HPPotion = new Items("Potion", 50);

        //Object of the Item Class; Ether
        public Items SPEther = new Items("Ether", 15);

        //Object of the Item Class; Elixer
        public Items Elixir = new Items("Elixir", 50, 10);

        //Object of the Item Class; Apple Gel & Lemon Gel
        public Items AppleGel = new Items("Apple Gel", Player.GetRemainingHealth, Player.GetMaxHealth, 0);
        public Items LemonGel = new Items("Lemon Gel", Player.GetRemainingHealth, Player.GetMaxHealth, 0);

        //Object of the Item Class; Orange Gel & Pineapple Gel
        public Items OrangeGel = new Items("Orange Gel", Player.GetRemainingSkillPoints, Player.GetMaxSkillPoints, 0);
        public Items PineappleGel = new Items("Pineapple Gel", Player.GetRemainingSkillPoints, Player.GetMaxSkillPoints, 0);

        //Object of the Item Class; Melange Gel & Miracle Gel
        public Items MelangeGel = new Items("Melange Gel", Player.GetRemainingHealth, Player.GetMaxHealth, Player.GetRemainingSkillPoints, Player.GetMaxSkillPoints);
        public Items MiracleGel = new Items("Miracle Gel", Player.GetRemainingHealth, Player.GetMaxHealth, Player.GetRemainingSkillPoints, Player.GetMaxSkillPoints);

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
                Player.GetMaxHealth += Accessory.GetAugmentHealth;
                Player.GetAttack += Accessory.GetAugmentAttack;
                Player.GetMagicAttack += Accessory.GetAugmentMagicAttack;
                Player.GetDefense += Accessory.GetAugmentDefense;
                Player.GetMagicDefense += Accessory.GetAugmentMagicDefense;
                Player.GetSpeed += Accessory.GetAugmentSpeed;
                Player.PlayerStats(SetUp.playerClass);
            }
        }
        public void UseItem(Items Item)
        {
            Console.WriteLine(Player.GetName + " used " + Item.GetItemName + ".");

            //Checks to see if the item is a gel. If it is, it runs a different set of code to work accordingly
            if(Item.GetItemName.Contains("Gel"))
            {
                //Runs recovery code for either 30% gels
                if (Item.GetItemName.Contains("Apple"))
                {
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxHealth/3) + " health.");
                    Player.GetRemainingHealth += (Player.GetMaxHealth / 3);
                    Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
                }
                if (Item.GetItemName.Contains("Orange"))
                {
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxSkillPoints/3) + " skill points.");
                    Player.GetRemainingSkillPoints += (Player.GetMaxSkillPoints / 3);
                    Console.WriteLine("Skill Points: " + Player.GetRemainingSkillPoints + "/" + Player.GetMaxSkillPoints);
                }
                if (Item.GetItemName.Contains("Melange"))
                {
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxHealth / 3) + " health.");
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxSkillPoints / 3) + " skill points.");
                    Player.GetRemainingHealth += (Player.GetMaxHealth / 3);
                    Player.GetRemainingSkillPoints += (Player.GetMaxSkillPoints / 3);
                    Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
                    Console.WriteLine("Skill Points: " + Player.GetRemainingSkillPoints + "/" + Player.GetMaxSkillPoints);
                }

                //Runs recovery code for either 60% gels
                if (Item.GetItemName.Contains("Lemon"))
                {
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxHealth / 6) + " health.");
                    Player.GetRemainingHealth += (Player.GetMaxHealth / 6);
                    Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
                }
                if (Item.GetItemName.Contains("Pineapple"))
                {
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxSkillPoints / 6) + " skill points.");
                    Player.GetRemainingSkillPoints += (Player.GetMaxSkillPoints / 6);
                    Console.WriteLine("Skill Points: " + Player.GetRemainingSkillPoints + "/" + Player.GetMaxSkillPoints);
                }
                else if (Item.GetItemName.Contains("Miracle"))
                {
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxHealth / 3) + " health.");
                    Console.WriteLine(Player.GetName + " restored " + (Player.GetMaxSkillPoints / 3) + " skill points.");
                    Player.GetRemainingHealth += (Player.GetMaxHealth / 6);
                    Player.GetRemainingSkillPoints += (Player.GetMaxSkillPoints / 6);
                    Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
                    Console.WriteLine("Skill Points: " + Player.GetRemainingSkillPoints + "/" + Player.GetMaxSkillPoints);
                }
            }

            //Checks to see if the item is NOT a gel
            else if (!(Item.GetItemName.Contains("Gel")))
            {
                //Checks to see if the Item's name contains HP, MP, or neither, which means it restores both
                if(Item.GetItemName.Contains("HP"))
                {
                    Console.WriteLine(Player.GetName + " restored " + Item.GetHPRestore + " health.");
                    Player.GetRemainingHealth += Item.GetHPRestore;
                    Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
                }
                if (Item.GetItemName.Contains("SP"))
                {
                    Console.WriteLine(Player.GetName + " restored " + Item.GetSPRestore + " skill points.");
                    Player.GetRemainingSkillPoints += Item.GetSPRestore;
                    Console.WriteLine("Skill Points: " + Player.GetRemainingSkillPoints + "/" + Player.GetMaxSkillPoints);
                }
                else //if (!(Item.GetItemName.Contains("HP") && Item.GetItemName.Contains("SP")))
                {
                    Console.WriteLine(Player.GetName + " restored " + Item.GetHPRestore + " health.");
                    Console.WriteLine(Player.GetName + " restored " + Item.GetSPRestore + " skill points.");
                    Player.GetRemainingHealth += Item.GetHPRestore;
                    Player.GetRemainingSkillPoints += Item.GetSPRestore;
                    Console.WriteLine("Hit Points: " + Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
                    Console.WriteLine("Skill Points: " + Player.GetRemainingSkillPoints + "/" + Player.GetMaxSkillPoints);
                }
            }
        }
    }
}
