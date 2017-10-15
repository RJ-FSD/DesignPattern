using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Delegation
{
    public class PrintBanner : IPrint
    {
        private readonly Banner banner;
        public PrintBanner(string str)
        {
            banner = new Banner(str);
        }

        public void PrintWeak()
        {
            banner.ShowWIthParen();
        }
        public void PrintStrong()
        {
            banner.ShowWithAster();
        }
    }
}
