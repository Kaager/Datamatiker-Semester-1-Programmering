using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetHeight()
        {
            return height;
        }

        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }

        public bool GetTreeAlive()
        {
            return treeAlive;
        }

        public int GetNumOranges()
        {
            return numOranges;
        }

        public int GetOrangesEaten()
        {
            return orangesEaten;
        }

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
