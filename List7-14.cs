using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var bimcalc = new BmiCalculator();
            var h = 162;
            var w = 63;
            var bim = bimcalc.GetBmi(h, w);
            Console.WriteLine("{0:.00}", bim);

        }
    }

    class BmiCalculator
    {
        // 身長はcm単位で、体重はkg単位で渡してもらう
        public double GetBmi(double height, double weight)
        {
            var metersTall = height / 100.0;
            var bmi = weight / (metersTall * metersTall);
            return bmi;
        }
    }
}
