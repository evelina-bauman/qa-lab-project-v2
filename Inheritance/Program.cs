using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Helper.Multiply(6, 8));

            Cat a = new Cat("John", "The cat");
            a.Price = Helper.Randomize();
            a.Meow();

            Dog b = new Dog("Mike", "The dog");
            b.Price = Helper.Randomize();
            b.Bark();            
        }
    }
}
