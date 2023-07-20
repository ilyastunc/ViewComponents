using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using ViewComponents.Models;

namespace ViewComponents.Components
{
    public class ProductSummary : ViewComponent //eğer ProductSummaryViewComponent.cs diye oluştursaydık, ViewComponent'ten türetmeye gerek kalmayacaktı.
    {
        private IProductRepository productRepository;
        public ProductSummary(IProductRepository repo)
        {
            productRepository = repo;
        }

        //view component ile bir string değeri döndürmek için
        // public string Invoke()
        // {
        //     return $"{productRepository.Products.Count()} ürün toplam fiyatı {productRepository.Products.Sum(i=>i.Price)} TL.";
        // }

        //view component'de html içerik döndürme
        // public IViewComponentResult Invoke()
        // {
        //     return new HtmlContentViewComponentResult(new HtmlString($"<strong>{productRepository.Products.Count()}</strong> ürün toplam fiyatı <span class='text-danger'>{productRepository.Products.Sum(i=>i.Price)} TL.</span>"));
        // }

        public IViewComponentResult Invoke(bool isApproved)
        {
            var viewName = "";
            if (isApproved)
                viewName = "GreenCard";
            else
                viewName = "RedCard";
            return View(viewName, new ProductSummaryViewModel() 
            {
                Count = productRepository.Products.Where(i=>i.IsApproved==isApproved).Count(),
                TotalPrice = productRepository.Products.Where(i=>i.IsApproved==isApproved).Sum(i=>i.Price)
            });
        }
    }

}