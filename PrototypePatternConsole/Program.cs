using DesignPattern_Prototype.framework;
using System;

namespace DesignPattern_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // 下準備：ひな形インスタンスの生成・格納
            Manager manager = new Manager();
            UnderlinePen upen = new UnderlinePen('-');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');

            manager.Register("strong message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            // ひな形インスタンスからのコピー作成
            IProduct p1 = manager.Create("strong message");
            p1.Use("Hello, world");
            IProduct p2 = manager.Create("warning box");
            p2.Use("Hello, world");
            IProduct p3 = manager.Create("slash box");
            p3.Use("Hello, world");

            Console.ReadKey();
        }
    }
}
