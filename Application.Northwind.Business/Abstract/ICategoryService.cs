using System.Collections.Generic;
using Application.Northwind.Entities.Concrete;

namespace Application.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}