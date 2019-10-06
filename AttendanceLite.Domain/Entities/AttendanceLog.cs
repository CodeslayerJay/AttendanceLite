using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceLite.Domain.Entities
{
    public class AttendanceLog
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public byte LogType { get; set; }
    }
}
