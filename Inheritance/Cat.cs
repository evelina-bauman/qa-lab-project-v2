using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cat : Animal
    {
        public Cat(string name, string breed) : base(name, breed) { }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }

     }
}
