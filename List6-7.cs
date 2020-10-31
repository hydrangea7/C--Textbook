using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[] { 10.5, 8.3, 4, 5, 9.0 };
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
