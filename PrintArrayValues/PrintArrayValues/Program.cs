using System;

namespace PrintArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> PrintArrayValues = (arry) =>
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    Console.WriteLine(arry[i]);
                }

            };
            int[] myArry3 = { 2, -30, -4, 56, -19, 67 };
            PrintArrayValues(myArry3);
        }
    }
}
