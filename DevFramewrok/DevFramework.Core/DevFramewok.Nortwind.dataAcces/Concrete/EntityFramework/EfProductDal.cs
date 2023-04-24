using DevFramewok.Nortwind.dataAcces.Abstract;
using DevFramework.Core.DataAcces.EntityFramework;
using DevFrameWork.Nortwind.Entites.ComplexTypes;
using DevFrameWork.Nortwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramewok.Nortwind.dataAcces.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryID equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductID = p.ProductID,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
