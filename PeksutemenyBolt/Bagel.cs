using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksutemenyBolt
{
    internal class Bagel : BakedGood
    {
        private string Topping;

        public Bagel(string name, string topping, double price, int calories) : base(name, price, calories)
        {
            this.Topping = topping;
        }

        public override string GetDescription()
        {
            return $"{base.Name} ({Topping}) {base.GetDescription()}";
        }

        public override void IncreasePrice(decimal amount)
        {
            Price += 30;
        }
    }
}
