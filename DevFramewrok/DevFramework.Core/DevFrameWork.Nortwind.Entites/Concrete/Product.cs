using DevFramework.Core.DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFrameWork.Nortwind.Entites.Concrete
{
    public class Product : IEntity
    {
        public virtual int ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string QuantityPerUnity { get; set; }
        public virtual Decimal UnitPrice { get; set; }
    }
}
