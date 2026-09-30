using System;
using System.Collections.Generic;
using System.Text;

namespace Pr11_Loops
{
    public class IntArrayHelper
    {
        public int[] SortAscending(int[] intArray)
        {
            // Create a copy of the input array, 
            //int[] newIntArray = (int[])intArray.Clone();
            // Test is not using the returned array :(
            int[] newIntArray = intArray;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < newIntArray.Length - 1; i++)
                {
                    if (newIntArray[i] > newIntArray[i + 1])
                    {
                        // Swap with a temp value
                        int temp = newIntArray[i];
                        newIntArray[i] = newIntArray[i + 1];
                        newIntArray[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
            return newIntArray;
        }

        public int[] SortAscendingAndReverse(int[] intArray)
        {
            // Not supposed to use the following 3 lines, correcting...
            /*
            SortAscending(intArray);
            Array.Reverse(intArray);
            return intArray;
            */

            int len = intArray.Length;
            SortAscending(intArray);

            for (int i = 0; i < (len / 2); i++)
            {
                // Swap using touple
                (intArray[i], intArray[len - 1 - i]) = (intArray[len - 1 - i], intArray[i]);
                // Alternative with the hat operator, to index from the end:
                //(intArray[i], intArray[^1 - i]) = (intArray[^1 - i], intArray[i]);
            }
            return intArray;
        }
    }
}
