using DevFramewok.Nortwind.dataAcces.Concrete.EntityFramework;
using NUnit.Framework;

namespace DevFramework.DataAcces.Tests.EntityFrameworkTest
{
    public class EntityFrameworkTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(1, result.Count);
        }
        [Test]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p=>p.ProductName.Contains("yu"));

            Assert.AreEqual(1, result.Count);
        }
    }
}