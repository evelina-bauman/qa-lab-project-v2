using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Session firstTry = new Session();
            while (true)
            {
                firstTry.ReadExpression();
            }
        }
    }
}
