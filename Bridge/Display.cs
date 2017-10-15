using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Display
    {
        private DisplayImpl _displayImpl;

        public Display(DisplayImpl displayImpl)
        {
            _displayImpl = displayImpl;
        }

        /// <summary>
        /// 出力の前処理
        /// </summary>
        public void Open()
        {
            _displayImpl.RawOpen();
        }

        /// <summary>
        /// データの出力
        /// </summary>
        public void Print()
        {
            _displayImpl.RawPrint();
        }

        /// <summary>
        /// 出力の後処理
        /// </summary>
        public void Close()
        {
            _displayImpl.RawClose();
        }

        /// <summary>
        /// 出力実行
        /// </summary>
        public void ExecuteDisplay()
        {
            Open();
            Print();
            Close();
        }
    }
}
