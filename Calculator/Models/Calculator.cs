using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Modles
{
    public class Calculator
    {
        public double NumA { get; set; }
        public double NumB { get; set; }
        public double Result { get; set; }

        //Addition
        static double Add(string numA, string numB)
        {
            double a = Convert.ToDouble(numA);
            double b = Convert.ToDouble(numB);
            return a + b;
        }

        //Subtraction
        static double Sub(string numA, string numB)
        {
            double a = Convert.ToDouble(numA);
            double b = Convert.ToDouble(numB);
            return a - b;
        }

        //Devision
        static double Div(string numA, string numB)
        {
            double a = Convert.ToDouble(numA);
            double b = Convert.ToDouble(numB);
            return a / b;
        }
        //Multiplication
        static double Mult(string numA, string numB)
        {
            double a = Convert.ToDouble(numA);
            double b = Convert.ToDouble(numB);
            return a * b;
        }

    }
}
