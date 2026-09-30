using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Pr10_PropertiesAndGitBasics
{
    public class OrangeTree
    {
        private int age;
        public int Age 
        {
            get => age;
            set
            {
                if (Age < 0)
                    Console.WriteLine("Age kan ikke være negativ!!!");
                else
                    age = value;
            }
        }
        private int height;
        public int Height
        {
            get => height;
            set => height = value;
        }
        private bool treeAlive;
        public bool TreeAlive
        {
            get => treeAlive;
            set => treeAlive = value;
        }
        private int numOranges;
        // Same as "get {return numOranges;}"
        public int NumOranges => numOranges;
        private int orangesEaten;
        public int OrangesEaten => orangesEaten;


        public void OneYearPasses()
        {
            age += 1;

            if (age < 80)
            {
                height += 2;
                treeAlive = true;
                numOranges = (age - 1) * 5;
            }
            else
            {
                treeAlive = false;
                numOranges = 0;
            }

            orangesEaten = 0;
        }

        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                numOranges -= count;
                orangesEaten += count;
            }
        }

    }
}

