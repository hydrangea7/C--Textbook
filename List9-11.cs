using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "インスタンスを生成せずに利用できるメソッドをstaticメソッドと言います。";
            var str2 = str.Replace("staticメソッド", "静的メソッド");
            Console.WriteLine(str2);
        }
    }   
}
