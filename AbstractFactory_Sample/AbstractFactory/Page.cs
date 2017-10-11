using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<IItem> content = new List<IItem>();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(IItem item)
        {
            this.content.Add(item);
        }

        public void Output(string HtmlFileName)
        {
            try
            {
                string filename = HtmlFileName + ".html";
                using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
                {
                    writer.Write(this.MakeHTML());
                }
                Console.WriteLine($"{filename}を作成しました。");
            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e);
            }
        }

        public abstract string MakeHTML();
    }

}
