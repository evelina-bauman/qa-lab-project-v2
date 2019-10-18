using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Client : INamable
    {
        double cashAmount;
        List<Product> boughtProducts;

        public string Name { get; set; }

        public Client(string name, double cash)
        {
            this.Name = name;
            this.cashAmount = cash;
            boughtProducts = new List<Product>();
        }

        public void PrintClientInfo()
        {
            Console.WriteLine($"Client {Name} has {cashAmount}$.");
        }
    }
}
