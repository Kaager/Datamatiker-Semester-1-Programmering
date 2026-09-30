using System;
using System.Collections.Generic;
using System.Text;

namespace Pr12_Persistence
{
    public class Person
    {
        // Fields
        private string _name = string.Empty;
        private DateTime _birthDate;
        private double _height;
        private bool _isMarried;
        private int _noOfChildren;

        // Constructors
        public Person (string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }

        // Properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public bool IsMarried
        {
            get => _isMarried;
            set => _isMarried = value;
        }

        public int NoOfChildren
        {
            get => _noOfChildren;
            set => _noOfChildren = value;
        }

        // Methods
        public string MakeTitle()
        {
            return $"{Name};{BirthDate};{Height};{IsMarried};{NoOfChildren}";
        }
    }
}

