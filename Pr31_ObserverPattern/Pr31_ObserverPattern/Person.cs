using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31_ObserverPattern
{
    public class Person
    {
        public string Name { get; }

        public Person (string name)
        {
            Name = name;
        }
    }
}
