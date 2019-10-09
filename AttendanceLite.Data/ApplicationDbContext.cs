using AttendanceLite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :base("name=AttendanceLiteDB")
        { }

        public DbSet<TimeLog> TimeLogs { get; set; }
    }
}
