using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IDrivable
    {
        bool IsInMove { get; set; }
        string TypeName { get; }

        void Start();
        void Stop();
    }
}
