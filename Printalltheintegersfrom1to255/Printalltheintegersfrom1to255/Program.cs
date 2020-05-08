using System;

namespace Printalltheintegersfrom1to255
{
    public delegate void PrintIntsFrom1_225();
    class Program
    {
        static void Main(string[] args)
        {
            PrintIntsFrom1_225 printIntsFrom1_225 = () =>
            {
                for (int i = 1; i <= 225; i++)
                {
                    Console.WriteLine(i);
                }
            };
            printIntsFrom1_225();
        }
    }
}
