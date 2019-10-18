using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public static class Helper
    {
        public static void PrintDriveableThings (List <IDrivable> items)
        {
            foreach(IDrivable i in items)
            {
                Console.WriteLine($"Driveable thing {i.TypeName} is in move: {i.IsInMove}");
            }
        }
    }
}
