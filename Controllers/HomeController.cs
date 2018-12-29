using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using CheeseMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        //*private readonly CheeseDbContext context;

        //public CategoryController(CheeseDbContext dbContext)
        //{
          //  context = dbContext;
            //return View(dbContext);
        //}
    }
}
