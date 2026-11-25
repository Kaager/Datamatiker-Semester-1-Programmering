using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31_ObserverPattern
{
    internal class Organization
    {
        public string Name { get; }
        public string Address { get; set; }

        public Organization (string name)
        {
            Name = name;
        }
    }
}
