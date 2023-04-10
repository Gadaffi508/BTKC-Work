// See https://aka.ms/new-console-template for more information
using Ninject;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel =new StandardKernel();
            kernel.Bind<IProductDal>().To<EFProductDal>().InSingletonScope();

            ProductManager productManager = new ProductManager(new EFProductDal());
            productManager.Save();
            Console.ReadLine();
        }
    }
    interface IProductDal
    {
        void Save();
    }
    class EFProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with EF");
        }
    }
    class NHProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with NH");
        }
    }
    class ProductManager
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal= productDal;
        }
        public void Save()
        {

            //Business Code
            
            _productDal.Save();
        }
    }
}
