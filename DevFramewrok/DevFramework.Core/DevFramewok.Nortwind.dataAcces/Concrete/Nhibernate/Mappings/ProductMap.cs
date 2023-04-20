using DevFrameWork.Nortwind.Entites.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramewok.Nortwind.dataAcces.Concrete.NHibernate.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(x => x.ProductID).Column("ProductID");
            Map(x => x.CategoryID).Column("CategoryID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnity).Column("QuantityPerUnity");
            Map(x => x.UnitPrice).Column("UnitPrice");
        }
    }
}
