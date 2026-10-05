using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Pr13_Persistence_2
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
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }

        public Person(string name, DateTime birtDate, double height, bool isMarried) : 
            this(name, birtDate, height, isMarried, 0)
        {
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
            return $"{Name};{BirthDate.ToString("dd-MM-yyyy HH:mm:ss",CultureInfo.InvariantCulture)};{Height};{IsMarried};{NoOfChildren}";
        }
    }
}

