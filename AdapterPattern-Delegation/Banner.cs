using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Delegation
{
    public class Banner
    {
        private readonly string str;
        public Banner(string str)
        {
            this.str = str;
        }
        public void ShowWIthParen()
        {
            Console.WriteLine($"({str})");
        }
        public void ShowWithAster()
        {
            Console.WriteLine($"*{str}*");
        }
    }
}
