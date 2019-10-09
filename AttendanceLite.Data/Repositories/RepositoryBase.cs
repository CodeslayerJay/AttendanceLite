using AttendanceLite.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLite.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        private readonly ApplicationDbContext _dbContext;

        public RepositoryBase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual void Add(TEntity entity)
        {
            if (entity != null)
                _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().Where(x => x.Id > 0).ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Where(x => x.Id == id).SingleOrDefault();
        }

        public virtual void Remove(int id)
        {
            var entity = GetById(id);

            if (entity != null)
                _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
