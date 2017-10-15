using System;
using DesignPattern_Prototype.framework;

namespace DesignPattern_Prototype
{
    /// <summary>
    /// ConcretePrototype：特定の文字を利用し、文字列に下線を引くクラス
    /// </summary>
    class UnderlinePen : IProduct
    {
        private char _ulchar;

        public UnderlinePen(char ulchar)
        {
            _ulchar = ulchar;
        }

        /// <summary>
        /// 自身のコピーを返す
        /// </summary>
        /// <returns></returns>
        public IProduct CreateClone()
        {
            // Javaのcloneメソッドに対応するメソッドを利用し、自身のコピーを作成している
            // このメソッドはObjectクラスで定義・実装されているため、Objectを暗黙的に継承するすべてのクラスで利用可能である。
            // なお、Javaとは異なり、try-catchによるエラーハンドリングは不要
            return (IProduct)MemberwiseClone();
        }

        /// <summary>
        /// 特定の文字を利用し、文字列に下線を引く
        /// </summary>
        /// <param name="s"></param>
        public void Use(string s)
        {
            int length = s.Length;
            Console.WriteLine("\"" + s + "\"");
            for (int i = 0; i < length + 2; i++)
            {
                Console.Write(_ulchar);
            }
            Console.WriteLine("");
        }
    }
}
