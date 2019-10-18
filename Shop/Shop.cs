using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Shop
    {
        public List<Product> products;
        public List<Client> clients;

        public Shop()
        {
            products = new List<Product>();
            clients = new List<Client>();
            PrintMenu();
        }

        public void PrintMenu()
        {
            Console.WriteLine("=========AVAILABLE OPTIONS=========");
            Console.WriteLine("1 Add Product");
            Console.WriteLine("2 Remove Product");
            Console.WriteLine("3 See the list of Products");
            Console.WriteLine("4 Add Client");
            Console.WriteLine("5 Remove Client");
            Console.WriteLine("6 See the list of Clients");
            Console.WriteLine("7 Sell a Product");
            Console.WriteLine("==================");
        }

        public void AddProduct()
        {
            Product productToAdd;
            string name = "";
            string notes = "";
            int amount = 0;
            double price = 0;

            Console.WriteLine("Input Product name, price, amount of items and notes (if needed) separated by ;");
            string[] productDetails = Console.ReadLine().Split(';');

            if (productDetails.Length == 3 || productDetails.Length == 4)
            {
                name = productDetails[0].ToLower();
                price = Convert.ToDouble(productDetails[1]);
                amount = Convert.ToInt32(productDetails[2]);
                if (productDetails.Length == 4)
                {
                    notes = productDetails[3];
                }
            }
            if (amount < 0 || price < 0)
            {
                Console.WriteLine("Amount and price can not be less than 0.\b\n==================");
                return;
            }
            productToAdd = new Product(name, price, amount, notes);
            foreach (Product item in products)
            {
                if (item.Name.Equals(productToAdd.Name))
                {
                    Console.WriteLine("Product already exists.\b\n==================");
                    return;
                }
            }
            products.Add(productToAdd);
            Console.WriteLine($"Product {name} is successfully added\b\n==================");
        }

        public void ListAllProducts()
        {
            Console.WriteLine("=========AVAILABLE PRODUCTS=========");
            if (products.Count > 0)
            {
                foreach (Product item in products)
                {
                    item.PrintProductInfo();
                }
                Console.WriteLine("==================");
            }
            else
            {
                Console.WriteLine("=========No products available=========");
            }
        }

        public void AddClient()
        {
            Client clientToAdd;
            string name = "";
            double cashAmount = 0;

            Console.WriteLine("Input Client name and cash amount separated by ;");
            string[] clientDetails = Console.ReadLine().Split(';');
            name = clientDetails[0].ToLower();
            cashAmount = Convert.ToDouble(clientDetails[1]);
 
            if (cashAmount < 0)
            {
                Console.WriteLine("Cash amount can not be less than 0.\b\n==================");
                return;
            }

            clientToAdd = new Client(name, cashAmount);
            if (!clients.Contains(clientToAdd))
            {
                clients.Add(clientToAdd);
            }
            else
            {
                Console.WriteLine("Client already exists.\b\n==================");
                return;
            }
            Console.WriteLine($"Client {name} is successfully added\b\n==================");
        }

        public void ListAllClients()
        {
            Console.WriteLine("=========AVAILABLE CLIENTS=========");
            if (clients.Count > 0)
            {
                foreach (Client item in clients)
                {
                    item.PrintClientInfo();
                }
                Console.WriteLine("==================");
            }
            else
            {
                Console.WriteLine("=========No clients available=========");
            }
        }

        public T FindItem<T>(string name, List<T> listOfThings) where T : INamable
        {
            foreach (var item in listOfThings)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            Console.WriteLine("Item not found.\b\n==================");
            return default(T);
        }

        public void RemoveItem<T>(List<T> listOfThings) where T : INamable
        {
            Console.WriteLine("Input the name of the client or product, which you would like to remove.");
            T itemToRemove = FindItem(Console.ReadLine().ToLower(), listOfThings);
            if (itemToRemove != default)
            {
                listOfThings.Remove(itemToRemove);
                Console.WriteLine($"Item {itemToRemove.Name} is successfully removed.\b\n==================");
            }
         }

        public void SellAnItem ()
        {

        }
    }
}
