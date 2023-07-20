using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;

namespace ViewComponents.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository categoryRepository;
        public CategoryMenu(ICategoryRepository repo)
        {
            categoryRepository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(new CategoryViewModel()
            {
                Categories = categoryRepository.Categories.ToList(),
                SelectedCategory = RouteData.Values["id"] as string
            });
        }
    }
}