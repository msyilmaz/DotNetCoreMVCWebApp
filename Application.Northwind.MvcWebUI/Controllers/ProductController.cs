using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Northwind.Business.Abstract;
using Application.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Northwind.MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel()
            {
                ProductlList = products
            };
            return View(model);
        }
    }
}
