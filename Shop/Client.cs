using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Client
    {
        public string name;
        double cashAmount;
        List<Product> boughtProducts;

        public Client(string name, double cash)
        {
            this.name = name;
            this.cashAmount = cash;
            boughtProducts = new List<Product>();
        }

        public void PrintClientInfo()
        {
            Console.WriteLine($"Client {name} has {cashAmount}$.");
        }
    }
}
