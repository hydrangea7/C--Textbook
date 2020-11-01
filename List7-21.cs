using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            PrintEvenOrOdd(6);
            PrintEvenOrOdd(25);
        }
        static void PrintEvenOrOdd(int num)
        {
            string str;
            if (num % 2 == 0)
            {
                str = "偶数";
            }
            else
            {
                str = "奇数";
            }
            Console.WriteLine($"{num}は{str}");
        }
    }
}
