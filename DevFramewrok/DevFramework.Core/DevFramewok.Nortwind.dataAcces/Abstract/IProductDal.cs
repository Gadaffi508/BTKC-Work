using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAcces;
using DevFrameWork.Nortwind.Entites.Concrete;

namespace DevFramewok.Nortwind.dataAcces.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
