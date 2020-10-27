using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num >= 10)
            {
                Console.WriteLine("num >= 10が成り立ちました。");
                Console.WriteLine($"numの値は {num} です。");
            }
        }
    }
}
