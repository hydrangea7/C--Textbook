using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var abs3 = Math.Abs(-5.67M);
            var abs4 = Math.Abs(-1.414);
            Console.WriteLine(abs3);
            Console.WriteLine(abs4);
        }
    }
}
