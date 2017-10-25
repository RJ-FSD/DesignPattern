using System;
using Framework;
using IDCard;

namespace Main
{
    public class MainTest
    {
        public static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("結城浩");
            Product card2 = factory.Create("とむら");
            Product card3 = factory.Create("佐藤花子");

            card1.Use();
            card2.Use();
            card3.Use();
            Console.ReadLine();
        }
    }
}
