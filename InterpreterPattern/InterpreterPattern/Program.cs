using System;
using System.IO;
using System.Xml.Serialization;

namespace InterpreterPattern
{
    class Program
    {
        static void Main()
        {
            var context = new Context("expressions.xml");
            var expression = context.BuildExpression();
            Console.WriteLine($"expression.Operate() : {expression.Operate()}");
            Console.ReadLine();
        }
    }
}
