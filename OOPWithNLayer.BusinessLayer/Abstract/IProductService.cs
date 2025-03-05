using OOPWithNLayer.Entity.Concrete;
using System.Collections.Generic;

namespace OOPWithNLayer.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();

    }
}
