using AttendanceApp.Services;
using AttendanceApp.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceLite.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly TimeLogService _timeLogService;

        public HomeController()
        {
            _timeLogService = new TimeLogService();

        }
        public ActionResult Index()
        {
            var newTimeLog = new TimeLogDto { Type = 0 };
            _timeLogService.SaveTimeLog(newTimeLog);
            return View();
        }

        
    }
}