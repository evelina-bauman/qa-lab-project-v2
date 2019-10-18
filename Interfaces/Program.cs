using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person human = new Person();
            human.Name = "John";
            Alien someone = new Alien();
            someone.Name = "Ali";
            INameable person2 = new Person();
            person2.Name = "Lucky";

            BusinessCard.Introduce(human);
            BusinessCard.Introduce(someone);
            BusinessCard.Introduce(person2);

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            car2.Start();

            Road road66 = new Road();
            road66.PutOnRoad(car1);
            road66.PutOnRoad(car2);
            road66.PutOnRoad(car3);
            road66.RemoveFromRoad(car1);

            Helper.PrintDriveableThings(road66.obj);
        }
    }
}
