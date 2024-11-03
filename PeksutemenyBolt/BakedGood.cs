using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksutemenyBolt
{
    abstract class BakedGood
    {
        private string name;
        private double price;
        private int calories;

        protected BakedGood(string name, double price, int calories)
        {
            this.name = name;
            this.price = price;
            this.calories = calories;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Calories { get => calories; set => calories = value; }

        public virtual string GetDescription()
        {
            return $"- Ár:{Price} Ft, Kalória: {Calories} Kcal";
        }
        public abstract void IncreasePrice(decimal amount);
    }
}
