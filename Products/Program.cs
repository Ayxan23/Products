namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Store store1 = new();

            Product product1 = new("Bread", 0.5, Types.Baker);
            Product product2 = new("Cola", 1, Types.Drink);
            Product product3 = new("Steak", 50, Types.Meat);
            
            Console.WriteLine(product3.No);

            store1.AddProduct(product1);
            store1.AddProduct(product3);

            store1.FindProductByType(Types.Drink);
            store1.FindProductByName("Cola");

            foreach (var item in store1.FindProductByName("Cola"))
            {
                Console.WriteLine(item);
            }

            store1.RemoveProductByNo(2);
            */

            int selection;
            do
            {
            start:
                Console.WriteLine("\n1. Product eleve etmek");
                Console.WriteLine("2. Type-a gore filterlemek");
                Console.WriteLine("0. Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuService.AddProduct();
                            break;
                        case 2:
                            MenuService.FindProductByType();
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    goto start;
                }
            } while (selection != 0);

        }
    }
}