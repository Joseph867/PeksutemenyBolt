using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksutemenyBolt
{
    internal class Croissant : BakedGood
    {
        private int butterContent;

        public Croissant(string name, double price, int calories, int butterContent) : base(name, price, calories)
        {
            this.butterContent = butterContent;
        }

        public override string GetDescription()
        {
            return $"{base.Name} {base.GetDescription()}, vaj mennyiség: {butterContent}g.";
        }

        public override void IncreasePrice(decimal amount)
        {
            Price += 50;
        }
    }
}
