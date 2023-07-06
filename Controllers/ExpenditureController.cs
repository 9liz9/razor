using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _07_razor.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _07_razor.Controllers
{
    
    public class ExpenditureController : Controller
    {
        public IActionResult Index()
        {
            List<Expenditure> expenditures = new List<Expenditure>
        {
            new Expenditure("Bonbons", new DateTime(2023, 1, 10), 1.6m),
            new Expenditure("Chocolat", new DateTime(2023, 2, 15), 5.5m),
            new Expenditure("Jus", new DateTime(2023, 3, 20), 12.25m)
        };

            return View(expenditures);
        }
    }

}

