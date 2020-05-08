using System;

namespace PrintOdds1fromto255
{
    public delegate void PrintIntsFrom1_225();
    class Program
    {
        static void Main(string[] args)
        {
            PrintIntsFrom1_225 PrintOddsfrom1_255 = () =>
            {
                for (int i = 0; i <= 255; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            };
            PrintOddsfrom1_255();
        }
    }
}
