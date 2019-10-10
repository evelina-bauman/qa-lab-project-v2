using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("John", "Johnson");
            student1.Age = 25;
            student1.ShowFullName();
            Console.WriteLine("I got the fullname: " + student1.GetFullName());
            Console.WriteLine(student1.Age);

            Car car1 = new Car("Renault", 2018);
            car1.GoDown();
            car1.GoDown();
            car1.GoRight();
            car1.GoDown();
            car1.GoRight();
            car1.GoDown();
            car1.GoLeft();
            car1.GoDown();

            Home home1 = new Home("Home1", 3, 12, 15, 3);
            Home home2 = new Home("Home2", 2.5, 13.5, 16, 3);

            Door door1 = new Door();
            Door door2 = new Door("white");
            Door door3 = new Door("yellow");

            home1.doors.Add(door1);
            home1.doors.Add(door2);
            home2.doors.Add(door2);
            home2.doors.Add(door3);

            Home[] bunch = new Home[] { home1, home2 };

            Console.WriteLine(home1.name + home1.height + home1.width + home1.depth + home1.floorCount + home2.name + home2.height + home2.width + home2.depth + home2.floorCount);

            for (int i = 0; i < bunch.Length; i++)
            {
                bunch[i].PrintHomeValuesOneLine();
            }

            City city1 = new City("city1");
            city1.homes.Add(home1);
            city1.homes.Add(home2);
            city1.ShowAmountOfHomes();
            city1.ShowDoorsInCity();
            city1.ShowHomeCityArea();
        }
    }
}
