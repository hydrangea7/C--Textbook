using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var bimcalc = new BmiCalculator();
            var bim = bimcalc.GetBmi(176, 67);
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
