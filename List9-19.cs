using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 3.7;
            var floor = Math.Floor(n);
            var ceiling = Math.Ceiling(n);
            Console.WriteLine($"{floor}, {ceiling}");
        }
    }
}
