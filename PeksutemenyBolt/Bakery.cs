using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksutemenyBolt
{
    internal class Bakery
    {
        private string Name;
        private List<BakedGood> Products { get; set; }

        public Bakery(string name)
        {
            Name = name;
            Products = new List<BakedGood>();
        }

        public void AddProduct(BakedGood product)
        {
            Products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in Products) { Console.WriteLine(product.GetDescription()); }
        }

        public void CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (var product in Products)
            {
                totalCalories += product.Calories;
            }
            Console.WriteLine($"Összes kalória: {totalCalories}");
        }

        public void CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }
            Console.WriteLine($"Összes ár: {totalPrice}");
        }
    }
}
