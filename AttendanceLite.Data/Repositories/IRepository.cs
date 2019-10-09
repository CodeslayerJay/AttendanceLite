using AttendanceLite.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLite.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Remove(int id);
    }
}
