using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "abcdefg";
            foreach (var ch in str)
            {
                Console.Write($"{ch}");
            }
            Console.WriteLine();
        }
    }
}
