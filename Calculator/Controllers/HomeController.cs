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
                    TempData["answer"] = calculate.Add(numA, numB);
                    break;
                case "-":
                    TempData["answer"] = calculate.Sub(numA, numB);
                    break;
                case "*":
                    TempData["answer"] = calculate.Add(numA, numB);
                    break;
                case "/":
                    TempData["answer"] = calculate.Add(numA, numB);
                    break;
            }      
        }
        [HttpGet]
        public string Return()
        {
            string payload = TempData["answer"].ToString();
            return payload;
        }
    }
}
