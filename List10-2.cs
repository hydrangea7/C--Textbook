using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = ArrayUtils.GetArray(5);
            // nums配列内の要素の合計を求める
            var total = 0;
            foreach (var x in nums)
            {
                total += x;
            }
            Console.WriteLine($"合計： {total}");
        }

        static class ArrayUtils
        {
            public static int[] GetArray(int count)
            {
                var array = new int[count];
                for (var i = 0; i < count; i++)
                {
                    var line = Console.ReadLine();
                    array[i] = int.Parse(line);
                }
                return array;
            }
        }
    }
}
