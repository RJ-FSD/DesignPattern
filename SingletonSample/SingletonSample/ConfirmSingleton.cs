using System;

namespace SingletonSample
{
    public class ConfirmSingleton
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.GetInstance();

            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
