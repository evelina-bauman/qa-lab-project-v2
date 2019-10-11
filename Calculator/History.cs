using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class History
    {
        ArrayList sessionHistory = new ArrayList();

        public void PrintHistory()
        {
            Console.WriteLine("History:");
            foreach(string item in sessionHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void AddHistory(CurrentOperation item)
        {
            string historyItem = item.fNumber + " " + item.operation + " " + item.sNumber + " = " + item.result;
            sessionHistory.Add(historyItem);
        }
    }
}
