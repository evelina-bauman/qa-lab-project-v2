using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public static class Helper
    {
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static int Randomize()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
    }
}
