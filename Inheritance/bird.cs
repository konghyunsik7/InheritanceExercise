using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class bird : Animals
    {
        public bool CanFly { get; set; }
        public bool HaveABeak { get; set; }
        public bool  HaveFeathers { get; set; }
        public int NumberOfClaws { get; set; }
    }
}
