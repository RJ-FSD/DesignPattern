using System;

namespace SingletonSample
{
    public class Singleton
    {
        private static readonly Singleton SingletonInstance = new Singleton();

        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static Singleton GetInstance()
        {
            return SingletonInstance;
        }
    }
}
