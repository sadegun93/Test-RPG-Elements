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
    class Program
    {
        //object of equipment to test weapons
        static Equipment Equips = new Equipment();

        static void Main(string[] args)
        {
            //Calls the Class choose method
            SetUp.ChooseClass();

            Console.ReadLine();

            Player.PlayerStats(SetUp.playerClass);

            Console.ReadLine();

            //Tests the experience method and the augmentation of stats
            Player.Experience(Player.GetBaseExp, Player.GetRemainingExp, 128, Player.GetExtraExp);

            Console.ReadLine();

            Equips.EquipWeapon(Equips.WoodenSword);

            Console.ReadLine();

            Equips.EquipArmor(Equips.HauteCoutre);

            Console.ReadLine();

            Equips.EquipAccessory(Equips.Boots);

            Console.ReadLine();

            Console.WriteLine("You took 30 damage!");
            Player.GetRemainingHealth -= 30;

            Console.WriteLine(Player.GetRemainingHealth + "/" + Player.GetMaxHealth);
            
        }
    }
}
