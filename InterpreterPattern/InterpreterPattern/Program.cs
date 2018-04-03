using System;
using System.IO;
using System.Xml.Serialization;

namespace InterpreterPattern
{
    class Program
    {
        static void Main()
        {
            using (var stream = new FileStream("expressions.xml", FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(ExpressionContext));
                var expressionContext = (ExpressionContext)serializer.Deserialize(stream);
                var expression = expressionContext.BuildExpression();
                Console.WriteLine($"expression.Operate() : {expression.Operate()}");
            }
            Console.ReadLine();
        }
    }
}
