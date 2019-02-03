using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Application.Northwind.MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
