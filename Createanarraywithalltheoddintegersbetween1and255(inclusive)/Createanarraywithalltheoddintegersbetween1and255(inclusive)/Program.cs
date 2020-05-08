using System;

namespace Createanarraywithalltheoddintegersbetween1and255_inclusive_
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintIntsFrom1_225 ReturnOddsArray = () =>
            {
                List<int> oddArray = new List<int>();
                for (int i = 1; i <= 255; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddArray.Add(i);
                    }
                }
                foreach (var item in oddArray)
                {
                    Console.WriteLine(item);
                }
            }; ReturnOddsArray();
        }
    }
}
