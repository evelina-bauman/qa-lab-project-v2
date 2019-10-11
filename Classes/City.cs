using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class City
    {
        public string name;
        public List<Home> homes = new List<Home>();

        public City (string name)
        {
            this.name = name;
        }

        public void ShowAmountOfHomes()
        {
            Console.WriteLine("City " + name + " has " + homes.Count + " homes.");
        }

        public void ShowHomeCityArea()
        {
            double homeCityArea = 0;
            foreach (Home item in homes)
                homeCityArea += item.GetFullHomeArea();
            Console.WriteLine("City " + name + " has " + homeCityArea + " homes city area.");
        }

        public void ShowDoorsInCity()
        {
            int doorsAmount = 0;
            foreach (Home item in homes)
               doorsAmount+= item.doors.Count;
            Console.WriteLine("City " + name + " has " + doorsAmount + " doors.");
        }
    }
}
