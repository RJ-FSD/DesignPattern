using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class StarDisplayImpl : DisplayImpl
    {
        private string _string;
        private int _width;
        
        public StarDisplayImpl(string s)
        {
            _string = s;
            _width = s.Length;
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine("★" + _string + "★");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("★");
            for( int i = 0; i < _width; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine("★");
        }
    }
}
