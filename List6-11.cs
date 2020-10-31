using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var array2d = new int[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 },
                {10, 11, 12 }
            };
            for (var row = 0; row < array2d.GetLength(0); row++)
            {
                for (var col = 0; col < array2d.GetLength(1); col++)
                {
                    Console.Write($"{array2d[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
