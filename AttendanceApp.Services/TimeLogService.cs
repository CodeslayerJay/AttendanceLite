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
        private readonly UnitOfWork _unitOfWork;

        public TimeLogService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void SaveTimeLog(TimeLogDto dto)
        {
            var timeLog = new TimeLog
            {
                Type = dto.Type
            };

            _unitOfWork.TimeLogs.Add(timeLog);
            _unitOfWork.SaveChanges();
        }
    }
}
