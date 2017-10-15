using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Link : IItem
    {
        protected string url;
        protected string caption;
        
        public Link(string caption, string url) 
        {
            this.caption = caption;
            this.url = url;
        }

        public void SetCaption(string caption)
        {
            this.url = caption;
        }

        public abstract string MakeHTML();
    }
    
}
