using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = '夏';
            var temperature = 39;
            var str = $"今年の{season}の最高気温は、{temperature}度でした。";
            Console.WriteLine(str);
        }
    }
}
