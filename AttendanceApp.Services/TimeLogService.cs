using AttendanceApp.Services.Dto;
using AttendanceLite.Data;
using AttendanceLite.Data.Repositories;
using AttendanceLite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceApp.Services
{
    public class TimeLogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TimeLogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void SaveTimeLog(TimeLogDto dto)
        {
            _unitOfWork.TimeLogs.Add(MapToEntity(dto));
            _unitOfWork.SaveChanges();
        }

        private TimeLog MapToEntity(TimeLogDto dto)
        {
            if (dto == null)
                throw new ArgumentNullException("TimeLogDto cannot be empty or null.");

            return new TimeLog
            {
                Type = dto.Type
            };
        }
    }
}
