using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Northwind.Business.Abstract;
using Application.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(IProductService productService, ICartService cartService, ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart,productToBeAdded);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your product {0} was successfully added to the cart!!",productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }
    }
}