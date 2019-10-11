using AttendanceLite.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLite.Data
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        public ITimeLogRepository TimeLogs { get; set; }
        private readonly ApplicationDbContext _context;

        public UnitOfWork()
        {

            _context = new ApplicationDbContext();

            TimeLogs = new TimeLogRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
