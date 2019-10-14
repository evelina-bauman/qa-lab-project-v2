using System;
using System.IO;
using System.Linq;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Result does not fit byte.");
            }
 
            //Exercise 2
            Exception ex1 = new FileNotFoundException("Custom file now found message");
            try
            {
                throw ex1;                
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
            }

            //Exercise 4
            int[] myArr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            var resultArr = from num in myArr where num > 44 select num;
            PrintArr(resultArr.ToArray());

            //Exercise 4.1
            var methodArr = myArr.Where(num12 => num12 > 44);
            PrintArr(methodArr.ToArray());

            //Exercise 5
            ArrayClass ac = new ArrayClass();
            int[] methodArray = ac.GetArray();
            PrintArr(methodArray);

            PrintArr(methodArray.OrderBy(w => w).ToArray());

            PrintArr(methodArray.OrderByDescending(w => w).ToArray());

            PrintArr(methodArray.Where(w => w > 30).OrderBy(w => w).ToArray());

            Console.WriteLine("Provide values divided by ;");
            string[] valuesToCreate = Console.ReadLine().Split(";");
            ArrayClass nextArr = new ArrayClass();

            try
            {
                int size = Convert.ToInt32(valuesToCreate[0]);
                int nFrom = Convert.ToInt32(valuesToCreate[1]);
                int nTo = Convert.ToInt32(valuesToCreate[2]);
                nextArr = new ArrayClass(size, nFrom, nTo);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            PrintArr(nextArr.GetArray());
        }

        public static void PrintArr(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
