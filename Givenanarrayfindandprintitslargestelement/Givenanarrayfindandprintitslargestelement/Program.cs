using System;

namespace Givenanarrayfindandprintitslargestelement
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> PrintMaxofArray = (arry) =>
            {
                int maxNumber = arry[0];
                for (int i = 1; i < arry.Length; i++)
                {
                    if (arry[i] > maxNumber)
                    {
                        maxNumber = arry[i];
                    }

                }
                return maxNumber;
            };
            int[] allArray = { 23, 45, 167, 89 };
            int maxNumber = PrintMaxofArray(allArray);
            Console.WriteLine(maxNumber);
        }
    }
}
