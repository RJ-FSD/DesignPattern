using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Delegation
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint print = new PrintBanner("Hello");
            print.PrintWeak();
            print.PrintStrong();

            Console.ReadLine();
        }
    }
}
