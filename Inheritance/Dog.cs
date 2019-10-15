using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Dog : Animal
    {
        public Dog(string name, string breed) : base(name, breed) { }

        public void Bark()
        {
            Console.WriteLine("Bark!");
        }
    }
}
