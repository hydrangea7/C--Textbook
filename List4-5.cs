using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lang = Console.ReadLine();
            if (lang == "C#")
            {
                Console.WriteLine("langの値は「C#」です。");
            }
            if (lang != "Java")
            {
                Console.WriteLine("langの値は「Java」ではありません。");
            }
        }
    }
}
