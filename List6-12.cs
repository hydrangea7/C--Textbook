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
                {4, 5, 6 }
            };
            foreach (var item in array2d)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
