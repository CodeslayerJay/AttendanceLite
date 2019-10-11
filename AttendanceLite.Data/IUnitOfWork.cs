using AttendanceLite.Data.Repositories;

namespace AttendanceLite.Data
{
    public interface IUnitOfWork
    {
        ITimeLogRepository TimeLogs { get; set; }

        void Dispose();
        int SaveChanges();
    }
}