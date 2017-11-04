using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        //This method returns the index view on pageload.
        public IActionResult Index()
        {
            return View();
        }

        //This method takes in the front ends equasion string as an argument.
        //creates an instantiation of DataTable called parser.  
        //The paser computes our equasion string and stores the result in an anonymous variable which then gets converted into-
        //a double data type and stored in tempdata.
        //by using the DataTable class you can avoid making your own string equasion parser.
        [HttpPost]
        public void Calc(string input)
        {
            DataTable parser = new DataTable();
            var v = parser.Compute(input, null);

            double result = Convert.ToDouble(v);

            TempData["answer"] = result;
        }
        //This this return method will convert our TempData answer to a string and send it off the front end JavaScript.
        [HttpGet]
        public string Return()
        {
            string payload = TempData["answer"].ToString();
            return payload;
        }
    }
}
