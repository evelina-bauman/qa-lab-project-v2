using System;
using System.IO;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Input the number of lines");
            int num = Convert.ToInt32(Console.ReadLine());
            var fileContent = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "test.txt"));

            for(int i = 0; i < fileContent.Length; i++)
            {
                sb.AppendLine(fileContent[i]);
            }

            for (int i = fileContent.Length; i < fileContent.Length + num; i++)
            {
                sb.AppendLine((i+1).ToString() + " " + Helper.GetRandomNumber());
            }
            
            Helper.AllStringToConsole(sb);

            using (var streamWriter = File.CreateText(Path.Combine(Directory.GetCurrentDirectory(), "test.txt")))
            {
                streamWriter.Write(sb.ToString());                
            }
        }
    }
}
