using System.Collections.Generic;
using Application.Northwind.Entities.Concrete;

namespace Application.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
