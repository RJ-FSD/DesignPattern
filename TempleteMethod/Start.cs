using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TempleteMethod
{
    class Start
    {
        static void Main(string[] args)
        {
            AbstractDisplay charDisplay = new CharDisplay('H');
            AbstractDisplay stringDisplayOnce = new StringDisplay("こんにちは");
            AbstractDisplay stringDisplayTwice = new StringDisplay("こんばんわ");

            charDisplay.display();
            stringDisplayOnce.display();
            stringDisplayTwice.display();

            Console.ReadLine();
        }
    }
}
