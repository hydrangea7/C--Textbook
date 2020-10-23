using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "おはよう。";
            var s2 = "こんにちは。";
            var s3 = "こんばんは。";
            var s4 = "またあした。";
            var str = s1 + s2 + s3 + s3 + s4;
            Console.WriteLine(str);

        }
    }
}
