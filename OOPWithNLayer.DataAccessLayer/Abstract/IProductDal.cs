using OOPWithNLayer.Entity.Concrete;
using System.Collections.Generic;

namespace OOPWithNLayer.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<object> GetProductsWithCategory();
    }
}
