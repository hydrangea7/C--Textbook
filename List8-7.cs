using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var year = 1868; year <= 2030; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine(year);
                }
            }
        }
    }
}
