using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HTMLBuilder : IBuilder<FileInfo>
    {
        private FileInfo fileName;
        private StreamWriter writer; 

        public void makeTitle(string title)
        {
            fileName = new FileInfo(title + ".html");

            using (StreamWriter writer = File.CreateText(fileName.FullName))
            {
                this.writer = writer;
                writer.WriteLine($"<html><head><title>{title}</title></head><body>");
                writer.WriteLine($"<h1>{title}</h1>");
            }
        }

        public void makeString(string str)
        {
            using (StreamWriter writer = new StreamWriter(fileName.FullName, true, Encoding.GetEncoding("shift-jis")))
            {
                writer.WriteLine($"<p>{str}</p>");
            }
        }

        public void makeItems(String[] items)
        {
            using (StreamWriter writer = new StreamWriter(fileName.FullName, true, Encoding.GetEncoding("shift-jis")))
            {
                writer.WriteLine("<ul>");

                for (int i = 0; i < items.Length; i++)
                {
                    writer.WriteLine($"<li>{items[i]}</li>");
                }

                writer.WriteLine("</ul>");
            }
        }

        public void close()
        {
            using (StreamWriter writer = new StreamWriter(fileName.FullName, true, Encoding.GetEncoding("shift-jis")))
            {
                writer.WriteLine("</body></html>");
            }
        }

        public FileInfo GetResult()
        {
            return fileName;
        }
    }
}
