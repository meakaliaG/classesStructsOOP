using System;

public class Adventurer
{
    public string name;
    public int exp;
    public Adventurer()
    {
        Reset();
    }
    public Adventurer(string name)
    {
        this.name = name;
    }
    public virtual void PrintStatsInfo()
    {
        Console.WriteLine("Adventurer: " + name + " - " + exp + " EXP");
    }

    //private method
    private void Reset()
    {
        this.name = "Not yet assigned";
        this.exp = 0;
    }
}
