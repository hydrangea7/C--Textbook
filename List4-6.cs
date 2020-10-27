using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = 6;
            if (1 <= month && month <= 12)
            {
                Console.WriteLine("1以上、12以下の数値です");
            }
        }
    }
}
