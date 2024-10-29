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
        }
    }
}
