using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
     public class TextBuilder : IBuilder<string>
    {
        private StringBuilder builder = new StringBuilder();

        public void makeTitle(string title)
        {
            builder.Append("==============================\n");
            builder.Append("『" + title + "』\n");
            builder.Append("\n");
        }

        public void makeString(string str)
        {
            builder.Append("■" + str + "\n");
            builder.Append("\n");
        }

        public void makeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                builder.Append("・" + items[i] + "\n");
            }
            builder.Append("\n");
        }

        public void close()
        {
            builder.Append("==============================\n");
        }

        public string GetResult()
        {
            return builder.ToString();
        }
    }
}
