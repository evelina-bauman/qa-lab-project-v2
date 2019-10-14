using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class ArrayClass
    {
        int size, nFrom, nTo;

        public ArrayClass()
        {
            size = 5;
            nFrom = 1;
            nTo = 100;
        }

        public ArrayClass(int size, int nFrom, int nTo)
        {
                this.nFrom = nFrom;
                this.nTo = nTo;
                this.size = size;
        }

        public int[] GetArray()
        {
            int[] arr= new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(nFrom, nTo);
            }
            return arr;
        }
    }
}
