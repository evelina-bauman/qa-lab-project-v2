using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Student
    {
        string firstName, lastName;
        int age;

        public Student (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Age
        {
            set { age = Convert.ToInt32(value); }
            get { return age; }
        }

        public void ShowFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public string GetFullName()
        {
            return String.Concat(firstName, " ", lastName);
        }                    
    }
}
