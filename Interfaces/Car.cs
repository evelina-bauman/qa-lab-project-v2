using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Car : IDrivable
    {
        public bool IsInMove { get; set; }

        public string TypeName { get; }

        public Car()
        {
            TypeName = "Car";
            IsInMove = false;
        }

        public void Start()
        {
            IsInMove = true;
        }

        public void Stop()
        {
            IsInMove = false;
        }
    }
}
