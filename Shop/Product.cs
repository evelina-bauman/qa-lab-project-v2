using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Product : INamable
    {
        public string notes="";
        int amountAvailable = 0;
        double price;
        
        public string Name { get; set; }

        public Product(string name, double price, int amount, string notes)
        {
            this.Name = name;
            this.price = price;
            this.amountAvailable = amount;
            this.notes = notes;
        }

        public void PrintProductInfo()
        {
            Console.Write($"Product {Name} has the price {price} and available amount is {amountAvailable}.");
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
