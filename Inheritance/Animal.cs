using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Animal
    {
        public string Name { get; set;}
        public string Breed { get; set; }
        public int Price { get; set; }

        public Animal(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }
}
