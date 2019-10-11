using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop();
            while (true)
            {
                ReadOperation(myShop);
            }
        }

        public static void ReadOperation(Shop myShop)
        {
            string operation = Console.ReadLine();
            switch (operation)
            {
                case ("1"):
                    myShop.AddProduct();
                    break;
                case ("2"):
                    myShop.RemoveProduct();
                    break;
                case ("3"):
                    myShop.ListAllProducts();
                    break;
                case ("4"):
                    myShop.AddClient();
                    break;
                case ("5"):
                    myShop.RemoveClient();
                    break;
                case ("6"):
                    myShop.ListAllClients();
                    break;
                case ("7"):
                    myShop.SellAnItem();
                    break;
                default:
                    Console.WriteLine("You have entered the wrong code.\b\n==================");
                    break;
            }
        }
    }
}
