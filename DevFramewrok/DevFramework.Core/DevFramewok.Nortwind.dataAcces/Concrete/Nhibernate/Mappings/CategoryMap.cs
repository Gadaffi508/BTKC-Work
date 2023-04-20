using DevFrameWork.Nortwind.Entites.Concrete;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramewok.Nortwind.dataAcces.Concrete.NHibernate.Mapping
{
    public class CategoryMap : ClassMap<Category>
    { 
        public CategoryMap()
        {
            Table(@"Categories");

            LazyLoad();

            Id(x => x.CategoryId).Column("CategoryId");
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
