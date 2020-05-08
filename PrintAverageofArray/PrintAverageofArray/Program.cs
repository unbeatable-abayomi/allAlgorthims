using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PrintAverageofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> PrintAverageofArray = (arry) =>
            {
                double avgNum = Queryable.Average(arry.AsQueryable());
                Console.WriteLine($"The average of the array is {avgNum}");
            };
            int[] myArry4 = { 2, -30, -4, 56, -19, 67 };
            PrintAverageofArray(myArry4);
        }
    }
}
