using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Delegation
{
    public interface IPrint
    {
        void PrintWeak();
        void PrintStrong();
    }
}
