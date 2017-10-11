using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Tray : IItem
    {
        protected string caption;

        protected List<IItem> tray = new List<IItem>();
        public Tray(string caption) : base()
        {
            this.caption = caption;
        }

        public void Add(IItem item)
        {
            tray.Add(item);
        }

        public void SetCaption(string caption)
        {
            this.caption = caption;
        }

        public abstract string MakeHTML();
    }
}
