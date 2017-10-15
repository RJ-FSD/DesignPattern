using DesignPattern_Prototype.framework;
using System;

namespace DesignPattern_Prototype
{
    /// <summary>
    /// ConcretePrototype：特定の文字を利用し、文字列を飾枠のように囲うクラス
    /// </summary>
    class MessageBox : IProduct
    {
        private char _decochar;

        public MessageBox(char decochar)
        {
            _decochar = decochar;
        }

        public IProduct CreateClone()
        {
            // Javaのcloneメソッドに対応するメソッドを利用し、自身のコピーを作成している
            // このメソッドはObjectクラスで定義・実装されているため、Objectを暗黙的に継承するすべてのクラスで利用可能である。
            // なお、Javaとは異なり、try-catchによるエラーハンドリングは不要
            return (IProduct)MemberwiseClone();
        }

        /// <summary>
        /// 特定の文字を利用し、文字列を飾枠のように囲う
        /// </summary>
        /// <param name="s"></param>
        public void Use(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine("");
            Console.WriteLine(_decochar + " " + s + " " + _decochar);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine("");
        }
    }
}
