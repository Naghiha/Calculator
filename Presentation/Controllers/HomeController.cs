using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentation.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculator _calculator;


        public HomeController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
       public IActionResult Fibonnaci(FibonnaciModel fibonnaci)
        {
            return Ok(_calculator.SumOfEvenTerms(fibonnaci.Range));
        }

       
    }
}
