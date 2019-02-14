using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Northwind.Entities.Concrete;

namespace Application.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> ProductlList { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
    }
}
