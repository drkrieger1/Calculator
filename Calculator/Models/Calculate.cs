using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.Modles
{
    public class Calculate
    {
        //Addition
        public decimal Add(string numA, string numB)
        {
            decimal a = Convert.ToDecimal(numA);
            decimal b = Convert.ToDecimal(numB);
            decimal answer = a + b;
            return answer;
        }

        //Subtraction
        public decimal Sub(string numA, string numB)
        {
            decimal a = Convert.ToDecimal(numA);
            decimal b = Convert.ToDecimal(numB);
            return a - b;
        }

        //Devision
        public decimal Div(string numA, string numB)
        {
            decimal a = Convert.ToDecimal(numA);
            decimal b = Convert.ToDecimal(numB);
            return a / b;
        }
        //Multiplication
        public decimal Mult(string numA, string numB)
        {
            decimal a = Convert.ToDecimal(numA);
            decimal b = Convert.ToDecimal(numB);
            return a * b;
        }

    }
}
