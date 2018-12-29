using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<CheeseCategory> categories = context.Categories.ToList();
            return View(categories);
        }

        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

       public IActionResult Add()
        {
           AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
           return View(addCategoryViewModel);
           //Create an Add action within CategoryController that 
           //creates an AddCategoryViewModel and passes it into the view.
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                CheeseCategory newCheeseCategory = new CheeseCategory
                {
                    Name = addCategoryViewModel.Name
                    //ID = addCategoryViewModel.CategoryID, 
                    
                };

                context.Categories.Add(newCheeseCategory);
                    context.SaveChanges();
                return Redirect("/Category");
                 }
                
            return View(addCategoryViewModel);
            

        }
    }
}