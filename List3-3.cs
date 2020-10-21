using System;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 999;
            var discount = total * 0.1;
            var payment = total - discount;

            Console.WriteLine("割引額： {0}円", discount);
            Console.WriteLine("支払額： {0}円", payment);
        }
    }
}
