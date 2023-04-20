using DevFramewok.Nortwind.dataAcces.Abstract;
using DevFramework.Core.DataAcces.EntityFramework;
using DevFrameWork.Nortwind.Entites.Concrete;

namespace DevFramewok.Nortwind.dataAcces.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
