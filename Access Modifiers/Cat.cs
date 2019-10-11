using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    public class Cat
    {
        public string name;
        protected string surname, other;
        int id, age;

        public string Surname { get; set; }

        public int Age
        {
            set { age = value; }
            get
            {
                if(age > 5)
                {
                    return age;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Id
        {
            set { id = value; }
        }

        public void PrintId()
        {
            Console.WriteLine(id);
        }
    }
}
