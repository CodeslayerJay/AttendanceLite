using AttendanceLite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLite.Data.Repositories
{
    public class TimeLogRepository : RepositoryBase<TimeLog>, ITimeLogRepository
    {
        public TimeLogRepository(ApplicationDbContext dbContext) : base(dbContext)
        {}
    }
}
