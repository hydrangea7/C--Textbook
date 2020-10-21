using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 100;
            var line = Console.ReadLine();
            var count = int.Parse(line);
            var num = total / count;
            Console.WriteLine(num);
        }
    }
}
