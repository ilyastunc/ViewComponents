using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;

namespace ViewComponents.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;

        public HomeController(ICategoryRepository categoryRepo, IProductRepository productRepo)
        {
            categoryRepository = categoryRepo;
            productRepository = productRepo;            
        }
        public IActionResult Index()
        {
            return View(productRepository.Products);
        }
    }
}