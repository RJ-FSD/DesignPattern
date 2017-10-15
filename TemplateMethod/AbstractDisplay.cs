using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleteMethod
{
    public abstract class AbstractDisplay
    {
        public abstract void Open();
        public abstract void Print();
        public abstract void Close();

        public void display()
        {
            Open();
            for(int i = 0; i < 5; i++)
            {
                Print();
            }
            Close();
        }
    }
}
