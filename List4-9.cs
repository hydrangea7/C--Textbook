using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var term = "";


            switch (word)
            {
                case "API":
                    term = "Application Programming Interface";
                    break;
                case "RDB":
                    term = "Relational Database";
                    break;
                case "UI":
                    term = "User Interface";
                    break;
            }

            if (term != "")
            {
                Console.WriteLine("{0}は{1}の略です。", word, term);
            }
        }
    }
}
