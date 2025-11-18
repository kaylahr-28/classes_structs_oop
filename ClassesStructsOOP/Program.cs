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
            Reset();
        }

        //constructor overloading- adding another constructor
        public Character(string name)
        {
            this.name = name; 
        }

        //new method
        //"Virtual" tells compiler this method can have many shapes
        //according to the calling class
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }

        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }

    }

    public class Paladin: Character
    {
        public Weapon weapon;
        //calling parent class constructor
        public Paladin(string name, Weapon weapon): base(name)
        {
            this.weapon = weapon;
        }

        public override void PrintStatsInfo()
        {
            Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
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

            //experimenting w/ inheritance
            Paladin knight = new Paladin("Sir Arthur", huntingBow);
            knight.PrintStatsInfo();

            //testing external files
            Adventurer mike = new Adventurer("Mike");
            mike.PrintStatsInfo();

            Dude dave = new Dude("Dave");
            dave.PrintStatsInfo();
        }
    }
}
