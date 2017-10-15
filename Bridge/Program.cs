using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new NormalDisplayImpl("Hello,Japan."));
            Display d2 = new CountDisplay(new StarDisplayImpl("Hello,World."));
            CountDisplay d3 = new CountDisplay(new NormalDisplayImpl("Hello,Universe."));
            CountDisplay d4 = new CountDisplay(new StarDisplayImpl("Hello,Universe."));

            d1.ExecuteDisplay();
            d2.ExecuteDisplay();
            
            d3.MultiDisplay(5);
            d4.MultiDisplay(3);

            Console.ReadLine();
        }
    }
}
