using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Northwind.Entities.Concrete;

namespace Application.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
