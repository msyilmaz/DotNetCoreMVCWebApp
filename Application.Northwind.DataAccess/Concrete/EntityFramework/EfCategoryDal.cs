using System;
using System.Collections.Generic;
using System.Text;
using Application.Core.DataAccess.EntityFramework;
using Application.Northwind.DataAccess.Abstract;
using Application.Northwind.Entities.Concrete;

namespace Application.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
