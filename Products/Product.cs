using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class Product
    {
        static int _no = 1;
        public readonly int No;
        public readonly string Name;
        public readonly double Price;
        public readonly Types Type;

        public Product(string name, double price, Types type)
        {
            No = _no++;
            Name = name;
            Price = price;
            Type = type;
        }

        public override string ToString()
        {
            return $"Name:{Name} Price:{Price}$";
        }
    }
}
