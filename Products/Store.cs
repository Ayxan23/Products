using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Products
{
    internal class Store
    {
        Product[] _products;

        public Store()
        {
            _products = new Product[0];
        }


        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }


        public void RemoveProductByNo(int no)
        {
            Product? result = null;
            Product[] find = _products.Where(s => s.No == no).ToArray();

            if (find.Length != 0)
            {
                result = find[0];
            }

            if (result != null)
            {
                int index = Array.IndexOf(_products, result);
                _products = _products.Where((prod, i) => i != index).ToArray();
                Console.WriteLine($"{result.Name} silindi!");
            }
            else
            {
                Console.WriteLine($"{no} bu nomreye uygun Product yoxdur!");
            }
        }


        public Product[] FindProductByType(Types type)
        {
            Product[] result = _products.Where(s => s.Type == type).ToArray();

            if (result.Length == 0)
            {
                Console.WriteLine("Bu novde product yoxdur!");
            }
            return result;

        }


        public Product[] FindProductByName(string name)
        {
            Product[] result = _products.Where(s => s.Name == name).ToArray();

            if (result.Length == 0)
            {
                Console.WriteLine("Bu adda product yoxdur!");
            }
            return result;
        }

    }
}
