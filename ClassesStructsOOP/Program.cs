using System.ComponentModel;

namespace ClassesStructsOOP
{
    public class Character
    {
        //vars aka fields
        public string name;
        public int exp = 0;

        //constructor
        public Character()
        {
            name = "Not assigned";
        }

        //constructor overloading- adding another constructor
        public Character(string name)
        {
            this.name = name;
        }

        //new method
        public void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }

    }

    public struct Weapon
    {
        public string name;
        public int damage;

        //constructor
        public Weapon(string name, int damage) { 
        this.name = name;
        this.damage = damage;
        }

        //print method
        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            hero.PrintStatsInfo();
            //new character
            Character heroine = new Character("Agatha");
            heroine.PrintStatsInfo();

            //new weapon
            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            //test ref types
            Character villain = hero;

            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            villain.name = "Sir Kane the Brave";
            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            //testing value types
            //hunting bow declared above alr
            Weapon warBow = huntingBow;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

        }
    }
}
