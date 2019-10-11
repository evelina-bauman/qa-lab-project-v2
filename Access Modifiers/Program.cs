using System;
using System.Collections.Generic;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListUsage try1 = new ListUsage();
            Cat cat1 = new Cat();
            string abc = "String abc";
            KeyValuePair<int, string> myPair = new KeyValuePair<int, string>(12, "second pair");


            try1.catsList.Add(cat1);
            try1.catsList.Add(new Cat());

            try1.stringList.Add("This is a srting");
            try1.stringList.Add(abc);

            try1.keyValueList.Add(1, "first value");
            try1.keyValueList.Add(myPair.Key, myPair.Value);

            try1.keyValuePairList.Add(myPair);
            try1.keyValuePairList.Add(new KeyValuePair<int, string>(12, "some string"));
        }
    }
}
