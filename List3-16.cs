using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = '夏';
            var temperature = 39;
            var str = String.Format("今年の{0}の最高気温は、{1}度でした。", season, temperature);


            Console.WriteLine(str);

        }
    }
}
