using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animals
    {
        public string TypeOfSkin { get; set; }
        public bool Carnivore { get; set; }
        public string UglyOrNah { get; set; }
        public  bool CanSwim { get; set; }
    }
}
