using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Idcard
{
    public class IDCard : Product
    {
        private string owner;

        public IDCard(string owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            this.owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine(owner + "のカードを使います。");
        }

        public String GetOwner()
        {
            return owner;
        }
    }
}
