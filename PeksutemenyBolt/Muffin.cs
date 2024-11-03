using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksutemenyBolt
{
    internal class Muffin : BakedGood
    {
        private string flavor;

        public Muffin(string name, string flavor, double price, int calories) : base(name, price, calories)
        {
            this.flavor = flavor;
        }

        public override string GetDescription()
        {
            return $"{base.Name} ({flavor}) {base.GetDescription()}";
        }

        public override void IncreasePrice(decimal amount)
        {
            Price *= 1.10;
        }
    }
}
