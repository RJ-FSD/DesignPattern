using System.Collections.Generic;
using System.Text;
using AbstractFactory;

namespace ListFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<li>\n");
            sb.Append($"{caption}\n");
            sb.Append("<ul>\n");

            foreach (IItem i in tray)
            {
                sb.Append(i.MakeHTML());
            }

            sb.Append("</ul>\n");
            sb.Append("</li>\n");
            return sb.ToString();
        }
    }
}
