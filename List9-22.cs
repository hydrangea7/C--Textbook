using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            Console.WriteLine("{0}年", today.Year);
            Console.WriteLine("{0}月", today.Month);
            Console.WriteLine("{0}日", today.Day);
            Console.WriteLine("{0}時", today.Hour);
            Console.WriteLine("{0}分", today.Minute);
            Console.WriteLine("{0}秒", today.Second);
        }
    }
}
