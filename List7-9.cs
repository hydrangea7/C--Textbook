using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var book1 = new Book
            {
                Title = "吾輩は猫である",
                Author = "夏目漱石",
                Pages = 610,
                Rating = 4
            };
            var book2 = new Book
            {
                Title = "人間失格",
                Author = "太宰治",
                Pages = 212,
                Rating = 5
            };
            book1.Print();
            book2.Print();
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
