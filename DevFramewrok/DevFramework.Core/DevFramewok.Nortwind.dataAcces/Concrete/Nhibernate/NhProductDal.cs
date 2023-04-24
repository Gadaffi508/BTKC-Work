using DevFramewok.Nortwind.dataAcces.Abstract;
using DevFramework.Core.DataAcces.NHihabernate;
using DevFrameWork.Nortwind.Entites.ComplexTypes;
using DevFrameWork.Nortwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramewok.Nortwind.dataAcces.Concrete.Nhibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper= nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryID equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductID = p.ProductID,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName
                             };
                return result.ToList();
            }
        }
    }
}
