using System;

namespace Printintegersfrom0to255andwitheachintegerprintthesumsofar
{
    public delegate void PrintIntsFrom1_225();
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> printIntsFrom1_225andSum = () =>
            {
                int sum = 0;
                for (int i = 1; i <= 225; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };
            int sumOfall = printIntsFrom1_225andSum();
            Console.WriteLine($"The total sum of numbers 0-225 is:{sumOfall}");
        }
    }
}
