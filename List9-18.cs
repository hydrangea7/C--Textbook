using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = 340;
            var value2 = 500;
            var min = Math.Min(value1, value2);
            Console.WriteLine(min);
        }
    }
}
