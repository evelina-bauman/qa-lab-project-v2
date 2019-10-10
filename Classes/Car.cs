using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Car
    {
        string name, color;
        int year, position = 0;

        public Car(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public void PrintSpaces()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (position > 0)
            {
                for (int i = 0; i < position; i++)
                    Console.Write(" ");
            }
        }

        public void GoLeft()
        {
            PrintSpaces();
            Console.Write("<-" + Environment.NewLine);
            position--;
        }

        public void GoRight()
        {
            PrintSpaces();
            Console.Write("->" + Environment.NewLine);
            position++;
        }

        public void GoDown()
        {
            PrintSpaces();
            Console.Write(Char.ConvertFromUtf32(0x2193) + Environment.NewLine);
        }
    }
}
