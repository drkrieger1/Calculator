using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Models;
using Calc.Modles;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        private double result;
        
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public void Calc(string numA, string numB, string op)
        {
            Calculate calculate = new Calculate();
            switch (op)
            {
                case "+":
                    result = calculate.Add(numA, numB);
                    break;
                case "-":
                    result = calculate.Sub(numA, numB);
                    break;
                case "*":
                    result = calculate.Add(numA, numB);
                    break;
                case "/":
                    result = calculate.Add(numA, numB);
                    break;
            }
        }
    }
}
