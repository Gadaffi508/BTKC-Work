using DevFramewok.Nortwind.dataAcces.Concrete.EntityFramework;
using DevFramewok.Nortwind.dataAcces.Concrete.Helpers;
using DevFramewok.Nortwind.dataAcces.Concrete.Nhibernate;
using NUnit.Framework;

namespace DevFramework.DataAcces.Tests.NhibernateTests
{
    public class NhibernateTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(1, result.Count);
        }
        [Test]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList(p=>p.ProductName.Contains("yu"));

            Assert.AreEqual(1, result.Count);
        }
    }
}