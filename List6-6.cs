using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[] { 65, 54, 78, 96, 81 };
            var total = 0;
            foreach (var p in scores)
            {
                total += p;
            }
            var average = (double)total / scores.Length;
            Console.WriteLine($"平均点： {average}");
        }
    }
}
