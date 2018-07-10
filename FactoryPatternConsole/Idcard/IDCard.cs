using System;
using Framework;

namespace IDCard
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

        public string GetOwner()
        {
            return owner;
        }
    }
}
