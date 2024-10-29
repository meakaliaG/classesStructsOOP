using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class dude
    {
        public string name;
        public int exp;
        public dude()
        {
            Reset();
        }
        public dude(string name)
        {
            this.name = name;
        }
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("dude: " + name + " - " + exp + " EXP");
        }

        //private method
        private void Reset()
        {
            this.name = "Not yet assigned";
            this.exp = 0;
        }
    }
}
