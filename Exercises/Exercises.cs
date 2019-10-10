using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
    public class Exercises
    {
        public void Exersice1()
        {
            Console.WriteLine("Please, input the value");
            string outLine = Console.ReadLine();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(outLine + " " + (i + 1).ToString());
            Console.WriteLine();
        }

        public void Exercise2()
        {
            double firstNumber, secondNumber;
            Console.WriteLine("Input the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + (firstNumber + secondNumber).ToString());
            Console.WriteLine(firstNumber.ToString() + " - " + secondNumber.ToString() + " = " + (firstNumber - secondNumber).ToString());
            Console.WriteLine(firstNumber.ToString() + " * " + secondNumber.ToString() + " = " + (firstNumber * secondNumber).ToString());
            Console.WriteLine(firstNumber.ToString() + " / " + secondNumber.ToString() + " = " + (firstNumber / secondNumber).ToString());
        }

        public void Exercise3()
        {
            int columns, rows;
            Console.WriteLine("The number of columns:");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number for rows:");
            rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                    Console.Write("* ");
            }
            Console.WriteLine();
        }

        public void Exercise4()
        {
            int number;
            Console.WriteLine("Number for check:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine(number + " is an even number.");
            else
                Console.WriteLine(number + " is an odd number.");
        }

        public void Exercise5()
        {
            int size, min = 0;
            Console.WriteLine("Input amount of numbers to compare:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input numbers one by one:");
            for (int i = 0; i < size; i++)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                    min = temp;
                if (min > temp)
                    min = temp;
            }
            Console.WriteLine("Smallest number was " + min);
        }

        public void Exercise6()
        {
            int option;
            double fNumber, sNumber;
            Console.WriteLine("Options:\r\n 1 Add two numbers \r\n 2 Subtract two numbers \r\n 3 Multiply two numbers \r\n 4 Divide two numbers \r\n 5 Exit \r\n Test Data: ");
            Console.WriteLine("Choose an option:");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 5)
                return;
            Console.WriteLine("Input first number:");
            fNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input second number:");
            sNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Expected output:");
            switch (option)
            {
                case 1:
                    Console.WriteLine("Result: " + (fNumber + sNumber).ToString());
                    break;
                case 2:
                    Console.WriteLine("Result: " + (fNumber - sNumber).ToString());
                    break;
                case 3:
                    Console.WriteLine("Result: " + (fNumber * sNumber).ToString());
                    break;
                case 4:
                    Console.WriteLine("Result: " + (fNumber / sNumber).ToString());
                    break;
            }
        }

        public void Exercise7()
        {
            int year;
            Console.WriteLine("The year to check:");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4) == 0 && (year % 100) == 0 && (year % 400) == 0)
                Console.WriteLine("Year " + year + " is leap");
            else
                Console.WriteLine("Year " + year + " is not leap");
        }

        public void Exercise8()
        {
            double gross, taxPercent, doubleTaxGross, sumNet = 0, sumTax = 0;
            Console.WriteLine("Gross amount is: ");
            gross = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tax amount is:");
            taxPercent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double tax when gross amount is:");
            doubleTaxGross = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Table A");
            Console.WriteLine("M | Net amount | Tax amount");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < 12; i++)
            {
                double tax;
                bool isTaxDouble = false;
                if (i < 9)
                    Console.Write("0");
                if ((i + 1) * gross < doubleTaxGross)
                    tax = (gross / 100) * taxPercent;
                else
                {
                    tax = (gross / 100) * taxPercent * 2;
                    isTaxDouble = true;
                }
                double net = gross - tax;
                sumNet += net;
                sumTax += tax;
                if (isTaxDouble)
                    Console.WriteLine((i + 1) + " | " + net + " | " + tax + " |  * ");
                else
                    Console.WriteLine((i + 1) + " | " + net + " | " + tax);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("SUM | " + sumNet + " | " + sumTax);

            Console.WriteLine("Table B");
            sumNet = 0;
            sumTax = 0;
            Console.WriteLine("M | Net amount | Tax amount");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < 12; i++)
            {
                double tax;
                bool isTaxDouble = false;
                if (i < 9)
                    Console.Write("0");
                if ((i + 1) * gross < doubleTaxGross)
                    tax = (gross / 100) * taxPercent;
                else
                {
                    tax = (gross / 100) * taxPercent * 2;
                    isTaxDouble = true;
                }
                double net = gross - tax;
                sumNet += net;
                sumTax += tax;
                if (isTaxDouble)
                    Console.WriteLine((i + 1) + " | " + sumNet + " | " + sumTax + " |  * ");
                else
                    Console.WriteLine((i + 1) + " | " + sumNet + " | " + sumTax);
            }
        }

        public void Exercise1Arrays()
        {
            int[] array = new int[5];
            Console.WriteLine("Please intut 5 numbers: ");
            for (int i = 0; i < 5; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());

            PrintArrayAsLine(array, array.Length);

            Console.WriteLine();
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public void Exercise2Arrays()
        {
            int[] arrayTest = new int[40];
            int[] odd = new int[40];
            int[] even = new int[40];
            int oddCount = 0, evenCount = 0;

            Random rnd = new Random();
            for (int i = 0; i < arrayTest.Length; i++)
            {
                arrayTest[i] = rnd.Next(1, 100);
                if (arrayTest[i] % 2 == 0)
                {
                    even[evenCount] = arrayTest[i];
                    evenCount++;
                }
                else
                {
                    odd[oddCount] = arrayTest[i];
                    oddCount++;
                }
            }

            Array.Sort(arrayTest);
            PrintArrayAsLine(arrayTest, arrayTest.Length);
            PrintArrayAsLine(even, evenCount);
            PrintArrayAsLine(odd, oddCount);
            Console.WriteLine("\r\nMin value is: " + arrayTest[0]);
            Console.WriteLine("Max value is: " + arrayTest[arrayTest.Length - 1]);
        }

        public void PrintArrayAsLine(int[] array, int Length)
        {
            for (int i = 0; i < Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public void Exercise3Arrays()
        {
            Dictionary<int, string> testDictionary = new Dictionary<int, string>();
            int length;
            Console.WriteLine("The number of elements will be: ");
            length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Provide Key: ");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Provide Value: ");
                string value = Console.ReadLine();
                testDictionary.Add(key, value);
            }
            foreach (KeyValuePair<int, string> keyvalue in testDictionary)
                Console.WriteLine("Key: " + keyvalue.Key.ToString() + ", Value: " + keyvalue.Value);
            Console.WriteLine();

            foreach (KeyValuePair<int, string> keyvalue in testDictionary.OrderBy(i => i.Key))
                Console.WriteLine("Key: " + keyvalue.Key.ToString() + ", Value: " + keyvalue.Value);
            Console.WriteLine();

            foreach (KeyValuePair<int, string> keyvalue in testDictionary.OrderBy(i => i.Value))
                Console.WriteLine("Key: " + keyvalue.Key.ToString() + ", Value: " + keyvalue.Value);
        }

        public void Months()
        {
            Dictionary<int, string> testDictionary = new Dictionary<int, string>();
            testDictionary.Add(1, "January");
            testDictionary.Add(2, "February");
            testDictionary.Add(3, "March");
            testDictionary.Add(4, "April");
            testDictionary.Add(5, "May");
            testDictionary.Add(6, "June");
            testDictionary.Add(7, "July");
            testDictionary.Add(8, "August");
            testDictionary.Add(9, "September");
            testDictionary.Add(10, "October");
            testDictionary.Add(11, "November");
            testDictionary.Add(12, "December");

            Console.WriteLine("Input number of month you want to find: ");
            Console.WriteLine(FindByKey(testDictionary, Convert.ToInt32(Console.ReadLine())));

            Console.WriteLine("Input the name of the month you want to find: ");
            Console.WriteLine(FindByValue(testDictionary, Console.ReadLine()));
        }

        public string FindByKey(Dictionary<int, string> testDictionary, int key)
        {
            string value = "";
            foreach (KeyValuePair<int, string> keyvalue in testDictionary)
                if (keyvalue.Key == key)
                    value = keyvalue.Value;
            return value;
        }

        public int FindByValue(Dictionary<int, string> testDictionary, string value)
        {
            int key = 0;
            foreach (KeyValuePair<int, string> keyvalue in testDictionary)
                if (keyvalue.Value.Equals(value))
                    key = keyvalue.Key;
            return key;
        }
    }
}

