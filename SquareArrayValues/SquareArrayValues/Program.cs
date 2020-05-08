using System;

namespace SquareArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> SquareArrayValues = (arry) =>
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    arry[i] *= 2;
                    Console.WriteLine(arry[i]);
                };

            };
            int[] myArry5 = { 2, 10, 4, 6, 4, 2 };
            SquareArrayValues(myArry5);
        }
    }
}
