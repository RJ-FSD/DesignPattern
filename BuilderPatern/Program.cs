using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage();
                Environment.Exit(0);
            }

            if (args[0].Equals("plain"))
            {
                TextBuilder textBuilder = new TextBuilder();
                var director = new Director<string>(textBuilder);

                var result = director.construct();
                Console.WriteLine(result);
            }else if (args[0].Equals("html"))
            {
                HTMLBuilder htmlbuilder = new HTMLBuilder();
                var director = new Director<FileInfo>(htmlbuilder);

                var filePath = director.construct();
                Console.WriteLine(filePath.Name + "が作成されました。");
            }
            else
            {
                Usage();
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
        
        public static void Usage()
        {
            Console.WriteLine("Usage: C# Main plain  プレーンテキストで文書作成");
            Console.WriteLine("Usage: C# Main html   htmlファイルで文書作成");
        }
    }
}
