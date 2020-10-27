using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 15;
            if (num % 3 == 0 || num % 5 == 0)
            {
                Console.WriteLine("numは3か5で割り切れます");
            }
        }
    }
}
