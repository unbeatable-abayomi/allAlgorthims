using System;

namespace SwapStringforArrayNegativeValues
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Action<string[]> SwapStringforArrayNegativeValues = (arry) =>
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    if (Convert.ToInt32(arry[i]) < 0)
                    {
                        arry[i] = "Codebits";
                    }
                }
                foreach (var item in arry)
                {
                    Console.WriteLine(item);
                }

            };
            string[] myArry2 = { "2", "-30", "-4", "56", "-19", "67" };
            SwapStringforArrayNegativeValues(myArry2);
        }
    }
}
