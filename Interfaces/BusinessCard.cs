using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public static class BusinessCard
    {
        public static void Introduce(INameable someone)
        {
            Console.WriteLine($"Hello, my name is { someone.Name }");
        }
    }
}
