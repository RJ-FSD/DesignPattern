using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;


namespace ListFactory
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author) { }
        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><head><title>{title}</title></head>\n");
            sb.Append("<body>\n");
            sb.Append($"<h1>{title}</h1>");
            sb.Append("<ul>\n");

            foreach (IItem i in content)
            {
                sb.Append(i.MakeHTML());
            }

            sb.Append("</ul>\n");
            sb.Append($"<hr><address>{author}</address>");
            sb.Append("</body></html>\n");
            return sb.ToString();
        }
    }
}
