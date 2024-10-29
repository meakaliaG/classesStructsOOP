namespace classes_structs_oop
{
    public class Character
    {
        public string name;
        public int exp;
        public Character()
        {
            name = "Not yet assigned";
        }
        public Character(string name)
        {
            this.name = name;
        }
        public void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + name + " - " + exp + " EXP");
        }

        //private method
        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
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
        }
    }
}
