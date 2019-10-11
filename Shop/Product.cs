using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Product
    {
        public string name, notes="";
        int amountAvailable = 0;
        double price;

        public Product(string name, double price, int amount, string notes)
        {
            this.name = name;
            this.price = price;
            this.amountAvailable = amount;
            this.notes = notes;
        }

        public void PrintProductInfo()
        {
            Console.Write($"Product {name} has the price {price} and available amount is {amountAvailable}.");
            if(notes != "")
            {
                Console.WriteLine($" Notes: {notes}.");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
