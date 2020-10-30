using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //  10個の数値を配列に格納
            var scores = new int[10];
            for (var i = 0; i < scores.Length; i++)
            {
                var line = Console.ReadLine();
                var number = int.Parse(line);
                scores[i] = number;
            }
            //  配列に格納された10個の数値の合計を求める
            var total = 0;
            for (var i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            Console.WriteLine($"合計： {total}");
        }
    }
}
