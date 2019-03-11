using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1;
using DemoDI.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace DemoDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISystemDateTime _dateTime;
        private readonly ISalary _salary;
        public HomeController(ISystemDateTime dateTime, ISalary salary)
        {
            _dateTime = dateTime;
            _salary = salary;            
        }
        public IActionResult Index()
        {
            if(_dateTime.Now().Hour < 12)
            {
                //ViewData["Message"] = "Good Morning!!! using ViewData";
                ViewBag.Message = "Good morning!!! using Viewbag ViewBag";
            } else if(_dateTime.Now().Hour > 12 && _dateTime.Now().Hour < 18) {
                ViewBag.Message = "Good afternoon";
            } else
            {
                ViewBag.Message = "Good night";
            }

            ViewBag.Salary = "Your total Salary: " + _salary.Total(1000000); 
            return View();
        }
      
    }
}
