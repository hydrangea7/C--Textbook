using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num == 10)
            {
                Console.WriteLine("10が入力されました");
            }
        }
    }
}
