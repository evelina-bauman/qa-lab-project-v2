using System;
using System.Collections.Generic;
using System.Text;

namespace Files
{
    public static class Helper
    {
        public static int GetRandomNumber ()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }

        public static void AllStringToConsole (StringBuilder sb)
        {
            Console.WriteLine(sb.ToString());
        }
    }
}
