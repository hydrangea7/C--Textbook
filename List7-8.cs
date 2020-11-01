using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var book = new Book
            {
                Title = "吾輩は猫である",
                Author = "夏目漱石",
                Pages = 610,
                Rating = 4
            };
            Console.WriteLine("Printメソッドを呼び出します");
            book.Print();
            Console.WriteLine("Printメソッドの処理が終わりました");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public void Print()
        {
            Console.WriteLine($" {Title}");
            Console.WriteLine($" {Author} {Pages}ページ 評価： {Rating}");
        }
    }
}
