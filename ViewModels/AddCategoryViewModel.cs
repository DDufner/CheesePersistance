using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; } //not needed?
        public int CategoryID { get; set; } //not needed?  
        public IList<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        public AddCategoryViewModel()
        {
        }

        public AddCategoryViewModel(IEnumerable<CheeseCategory> categories) //Added while trying to show list of categories
        {

            Categories = new List<SelectListItem>();
            foreach (var category in categories)
            {
                Categories.Add(new SelectListItem { Value = category.ID.ToString(), Text = category.Name }); //was category.ToString()
            }
        }




        //public AddCategoryViewModel();

        //CheeseCategory cheeseCategory = CheeseCategory.GetInstance();

        //foreach (Category field in cheeseCategory.Categories.ToList())
        // {
        //  Categories.Add(new SelectListItem{
        // field.ID.ToString(),});

    }
}
