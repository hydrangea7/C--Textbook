using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var isLeapYear = DateTime.IsLeapYear(2020);
            if (isLeapYear)
            {
                Console.WriteLine("うるう年です");
            }
        }
    }
}
