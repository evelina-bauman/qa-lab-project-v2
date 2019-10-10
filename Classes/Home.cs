using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Home
    {
        public string name;
        public double height, width, depth, floorCount;
        public ArrayList doors = new ArrayList();

        public Home() { }

        public Home(string name, double height, double width, double depth, double floorCount)
        {
            this.name = name;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.floorCount = floorCount;
        }

        public Home(string name, double height, double width, double depth, double floorCount, ArrayList doors)
        {
            this.name = name;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.floorCount = floorCount;
            this.doors = doors;
        }

        public double GetAreaOnOneFloor()
        {
            return width * depth;
        }

        public double GetFullHomeArea()
        {
            return floorCount * GetAreaOnOneFloor();
        }

        public double GetHomeVolume()
        {
            return width * height * depth;
        }

        public void PrintHomeValuesOneLine()
        {
            Console.Write("Home " + name + " has: ");
            Console.Write("width " + width + ", ");
            Console.Write("depth " + depth + ", ");
            Console.Write("height " + height + ", ");
            Console.Write("floor count is " + floorCount + ", ");
            Console.Write("home full area is " + GetFullHomeArea() + ", ");
            Console.Write("home one floor area is " + GetAreaOnOneFloor() + ", ");
            Console.Write("home volume is " + GetHomeVolume() + ", ");
            Console.Write(Environment.NewLine);
        }
    }
}
