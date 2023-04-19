using DevFramewok.Nortwind.dataAcces.Abstract;
using DevFramework.Core.DataAcces.EntityFramework;
using DevFrameWork.Nortwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramewok.Nortwind.dataAcces.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>,IProductDal
    {
       
    }
}
