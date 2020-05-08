using System;

namespace ReturnArrayCountGreaterthanY
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<int[], int> ReturnArrayCountGreaterthanY = (arry, y) =>
            {
                int count = 0;
                for (int i = 0; i < arry.Length; i++)
                {
                    if (arry[i] > y)
                    {
                        Console.WriteLine($"{arry[i]}\t is greater than {y}");
                        count++;
                    }
                }
                Console.WriteLine($"Only {count} numbers are greater than {y}");

            };
            int[] myArry = { 2, 30, 4, 56, 19 }; int num = 12;
            ReturnArrayCountGreaterthanY(myArry, num);
        }
    }
}
