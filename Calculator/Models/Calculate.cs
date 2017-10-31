using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.Modles
{
    public class Calculate
    {
        static double NumA { get; set; }
        static double NumB { get; set; }
        static double Result { get; set; }

        //Addition
        public double Add(string numA, string numB)
        {
            double a = double.Parse(numA);
            double b = double.Parse(numB);
            return a + b;
        }

        //Subtraction
        public double Sub(string numA, string numB)
        {
            double a = Convert.ToDouble(numA);
            double b = Convert.ToDouble(numB);
            return a - b;
        }

        //Devision
        public double Div(string numA, string numB)
        {
            double a = Convert.ToDouble(numA);
            double b = Convert.ToDouble(numB);
            return a / b;
        }
        //Multiplication
        public double Mult(string numA, string numB)
        {
            double a = Convert.ToDouble(numA);
            double b = Convert.ToDouble(numB);
            return a * b;
        }

    }
}
