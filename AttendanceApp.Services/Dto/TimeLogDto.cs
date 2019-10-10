using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceApp.Services.Dto
{
    public class TimeLogDto
    {
        public int Id { get; set; }
        public byte Type { get; set; }
        public DateTime CreatedAt { get; set; }
        
    }
}
