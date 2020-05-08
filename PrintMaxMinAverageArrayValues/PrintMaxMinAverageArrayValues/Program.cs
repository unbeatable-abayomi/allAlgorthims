using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PrintMaxMinAverageArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> PrintMaxMinAverageArrayValues = (arry) =>
            {
                int maxNum = arry.Max();
                int minNum = arry.Min();
                double avgNum = Queryable.Average(arry.AsQueryable());
                Console.Write($"The Max Number in the Array is {maxNum}\n The Min Number in the array is {minNum}\n The Averag of the Array is {avgNum}");
            };
            int[] myArry1 = { 2, 30, 4, 56, 19 };
            PrintMaxMinAverageArrayValues(myArry1);
        }
    }
}
