using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Session
    {
        CurrentOperation operation = new CurrentOperation();
        History currentHistory = new History();

        public Session()
        {
            PrintDefault();
        }
        public void ReadExpression()
        {
            double fNumber = 0, sNumber = 0;
            string symbol = "";

            string line = Console.ReadLine();
            if (line.Equals("EXIT"))
            {
                System.Environment.Exit(-1);
            }
            string[] items;
            items = line.Split(' ');
            try
            {
                if (items.Length != 3)
                    throw new System.FormatException();
                fNumber = Convert.ToDouble(items[0]);
                sNumber = Convert.ToDouble(items[2]);
                symbol = Convert.ToString(items[1]);
                if (!symbol.Equals("+") && !symbol.Equals("-") && !symbol.Equals("*") && !symbol.Equals("/"))
                    throw new System.FormatException();
            }
            catch (System.FormatException)
            {
                Console.Beep();
                Console.WriteLine("Invalid expression");
                System.Environment.Exit(-1);
            }

            operation = new CurrentOperation(fNumber, sNumber, symbol);
            Reprint();
        }

        public void PrintDefault()
        {
            Console.WriteLine("=========AVAILABLE OPTIONS=========");
            Console.WriteLine(" +");
            Console.WriteLine(" -");
            Console.WriteLine(" /");
            Console.WriteLine(" *");
            Console.WriteLine("EXIT");
            Console.WriteLine("==================");
        }

        public void Reprint()
        {
            currentHistory.AddHistory(operation);
            Console.Clear();
            PrintDefault();
            currentHistory.PrintHistory();
        }
    }
}
