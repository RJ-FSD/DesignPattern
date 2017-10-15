using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl displayImpl) : base(displayImpl)
        {
        }

        /// <summary>
        /// データを指定回数増幅して出力
        /// </summary>
        /// <param name="times"></param>
        public void MultiDisplay(int times)
        {
            Open();
            for(int i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}
