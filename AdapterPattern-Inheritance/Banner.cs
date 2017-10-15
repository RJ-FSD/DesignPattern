using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Inheritance
{
    public class Banner
    {
        private readonly string str;
        public Banner(string str)
        {
            this.str = str;
        }
        public void ShowWithParen()
        {
            Console.WriteLine($"({str})");
        }
        public void ShowWithAster()
        {
            Console.WriteLine($"*{str}*");
        }
    }
}
