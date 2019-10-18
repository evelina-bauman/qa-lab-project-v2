using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calculator
{
    public class History
    {
        readonly string pathToFile = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
        StringBuilder sb;

        public History()
        {
            sb = new StringBuilder();
            var fileContent = File.ReadAllLines(pathToFile);
            foreach (var i in fileContent)
            {
                sb.AppendLine(i);
            }
        }

        public void PrintHistory()
        {
            Console.WriteLine("History:");
            var fileContent = File.ReadAllLines(pathToFile);
            foreach (var i in fileContent)
            {
                Console.WriteLine(i);
            }            
            Console.WriteLine();
        }

        public void AddHistory(CurrentOperation item)
        {            
            string historyItem = item.fNumber + " " + item.operation + " " + item.sNumber + " = " + item.result;

            sb.AppendLine(historyItem);
            using (var streamWriter = File.CreateText(pathToFile))
            {                
                streamWriter.Write(sb.ToString());
            }            
        }
    }
}
