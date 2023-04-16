using DevFramework.Core.DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAcces.EntityFramework
{
    public class EfQueryableRepository<T>: IQueryableRepository<T> where T:class ,IEntity,new()
    {
        private DbContext _dbContext;
        private IDbSet<T> _entities;
        public EfQueryableRepository(DbContext context)
        {
            _dbContext = context;
        }
        public IQueryable<T> Table => this._entities;

        protected virtual IDbSet<T> Entities
        {
            get { return _entities ?? (_entities = _dbContext.Set<T>()); }
        }
    }
}
