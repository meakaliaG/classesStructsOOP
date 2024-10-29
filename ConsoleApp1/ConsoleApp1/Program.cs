namespace classes_structs_oop
{
    public class Character
    {
        public string name;
        public int exp;
        public Character()
        {
            Reset();
        }
        public Character(string name)
        {
            this.name = name;
        }
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + name + " - " + exp + " EXP");
        }

        //private method
        private void Reset()
        {
            this.name = "Not yet assigned";
            this.exp = 0;
        }

    }


    public class Paladin : Character
    {
        public Weapon weapon;

        public Paladin(string name, Weapon weapon) : base(name)
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
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
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

            Character heroine = new Character("Agatha");
            heroine.PrintStatsInfo();

            //weapon draw
            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            //Testing reference types
            Character villain = hero;

            villain.name = "Cloudy Meatballs";

            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            //Testing value types
            //note: hunting bow is declared above
            Weapon warBow = huntingBow;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            //Experimenting with Inheritance
            Paladin knight = new Paladin("Sir Arthur", huntingBow);
            knight.PrintStatsInfo();
        }
    }
}
