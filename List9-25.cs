using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2019, 4, 3, 19, 8, 53);
            var s1 = date.ToString("d");
            var s2 = date.ToString("D");
            var s3 = date.ToString("f");
            var s4 = date.ToString("F");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
