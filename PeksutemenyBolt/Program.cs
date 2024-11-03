using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksutemenyBolt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new Bakery("Pékség neve: Kóstoló Pékség");
            Console.WriteLine("kínálat:");

            BakedGood crossaint = new Croissant("Kifli", 150, 300, 20);
            BakedGood bagel = new Bagel("Bagel", "Szezámmag", 180, 250);
            BakedGood muffin = new Muffin("Muffin", "Csokoládé", 200, 350);

            bakery.AddProduct(crossaint);
            bakery.AddProduct(bagel);
            bakery.AddProduct(muffin);

            bakery.DisplayProducts();
            bakery.CalculateTotalCalories();
            bakery.CalculateTotalPrice();

            Console.WriteLine();

            Console.WriteLine("Kinálat emelés után:");
            crossaint.IncreasePrice(50);
            bagel.IncreasePrice(50);
            muffin.IncreasePrice(20);
            bakery.DisplayProducts();
            bakery.CalculateTotalCalories();
            bakery.CalculateTotalPrice();

            Console.ReadLine();
        }
    }
}
