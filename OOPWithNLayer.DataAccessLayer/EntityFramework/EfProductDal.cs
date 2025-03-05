using OOPWithNLayer.DataAccessLayer.Abstract;
using OOPWithNLayer.DataAccessLayer.Context;
using OOPWithNLayer.DataAccessLayer.Repositories;
using OOPWithNLayer.Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace OOPWithNLayer.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductsWithCategory()
        {
            var context = new ApplicationContext();
            var values = context.Products
                .Select(x=> new
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock= x.ProductStock,
                    ProductPrice= x.ProductPrice,
                    ProductDescription= x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
