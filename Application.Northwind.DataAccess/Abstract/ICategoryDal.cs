using Application.Core.DataAccess;
using Application.Northwind.Entities.Concrete;

namespace Application.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}