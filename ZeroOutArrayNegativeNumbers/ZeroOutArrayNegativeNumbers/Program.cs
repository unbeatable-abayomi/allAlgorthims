using System;

namespace ZeroOutArrayNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> ZeroOutArrayNegativeNumbers = (arry) =>
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    if (arry[i] < 0)
                    {
                        arry[i] = 0;
                    }
                }
                foreach (var item in arry)
                {
                    Console.WriteLine(item);
                }

            };
            int[] myArry7 = { 2, 10, 4, -6, -4, -2 };
            ZeroOutArrayNegativeNumbers(myArry7);
        }
    }
}
