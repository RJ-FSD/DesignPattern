using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleteMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private string stringView { set; get; }
        private int width { set; get; }

        public StringDisplay(string stringView)
        {
            this.stringView = stringView;
            int stringViewLength = System.Text.Encoding.GetEncoding(932).GetByteCount(stringView);
            this.width = stringViewLength;
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine("|" + stringView + "|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for(int i = 0; i < width; i++)
            {
                Console.Write("+");
            }

            Console.WriteLine("+");
        }

    
    }
}
