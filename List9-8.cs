using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "　オブジェクト指向　";
            var str2 = str.Trim();
            Console.WriteLine($"【{str}】");
            Console.WriteLine($"【{str2}】");
        }
    }   
}
