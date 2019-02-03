using System;
using System.Collections.Generic;
using System.Text;
using Application.Core.DataAccess;
using Application.Northwind.Entities.Concrete;

namespace Application.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
