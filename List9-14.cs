using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "吾輩は猫である,夏目漱石";
            var items = str.Split(',');
            var book = new Book
            {
                Title = items[0],
                Author = items[1],
            };
            Console.WriteLine($"{book.Title}, {book.Author}");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Pages { get; set; }
        public int Rating { get; set; }
    }
}
