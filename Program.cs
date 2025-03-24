using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructures
{
    public static class MaxMinElementsInArray
    {
        //1. Find the maximum and minimum elements in an array.


        static void Main()
        {
            int[] arrayData = { 3, 33, 0, 333 };
            FindMaxAndMinValuesInArray(arrayData, out int min, out int max);
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");

            static void FindMaxAndMinValuesInArray(int[] arrayData, out int min, out int max)
            {

                if (arrayData == null || arrayData.Length == 0)
                {
                    throw new ArgumentException("The Araray data cannotbe empty");
                }
                min = max = arrayData[0];

                foreach (int num in arrayData)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                    if (num > max)
                    {
                        max = num;
                    }
                }

            }
        }
    }
}
