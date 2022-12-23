using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Products
{
    internal class MenuService
    {
        static Store _store;

        static MenuService()
        {
            _store = new Store();
        }

        public static void AddProduct()
        {
            Console.WriteLine("\nAdd Product");
        name:
            Console.WriteLine("enter Name:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                goto name;
            }
        price:
            Console.WriteLine("enter Price:");
            bool priceResult = double.TryParse(Console.ReadLine(), out double price);
            if (!priceResult || price < 0)
            {
                goto price;
            }
        type:
            Console.WriteLine("enter Type: ( Drink, Meat, Baker )");
            Types type1 = new();
            string? type = Console.ReadLine();
            if (type != "Drink" && type != "Meat" && type != "Baker")
            {
                goto type;
            }
            if (type == "Drink")
            {
                type1 = Types.Drink;
            }
            else if (type == "Meat")
            {
                type1 = Types.Meat;
            }
            else if (type == "Baker")
            {
                type1 = Types.Baker;
            }

            Product productNew = new(name, price, type1);
            _store.AddProduct(productNew);
            Console.WriteLine("Product elave edildi!");
        }


        public static void FindProductByType()
        {
            Console.WriteLine("\nFind Product By Type");
        type:
            Console.WriteLine("enter the Type of the product: ( Drink, Meat, Baker )");
            Types type1 = new();
            string? type = Console.ReadLine();
            if (type != "Drink" && type != "Meat" && type != "Baker")
            {
                goto type;
            }
            if (type == "Drink")
            {
                type1 = Types.Drink;
            }
            else if (type == "Meat")
            {
                type1 = Types.Meat;
            }
            else if (type == "Baker")
            {
                type1 = Types.Baker;
            }

            foreach (var item in _store.FindProductByType(type1))
            {
                Console.WriteLine(item);
            }
        }

    }
}
