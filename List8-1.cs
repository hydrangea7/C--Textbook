using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2019, 10, 8);
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;
            Console.WriteLine($"{year}年{month}月{day}");
        }
    }
}
