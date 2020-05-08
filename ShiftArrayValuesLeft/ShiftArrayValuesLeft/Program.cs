using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ShiftArrayValuesLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> ShiftArrayValuesLeft = (arry) =>
            {
                var myArray = new List<int>(arry);
                myArray.RemoveAt(0);
                myArray.Add(0);
                int[] newArray = myArray.ToArray();

                foreach (var item in newArray)
                {
                    Console.WriteLine(item);
                }

            };
            int[] myArry8 = { 2, 10, 4, -6, -4, -2 };
            ShiftArrayValuesLeft(myArry8);
        }
    }
}
