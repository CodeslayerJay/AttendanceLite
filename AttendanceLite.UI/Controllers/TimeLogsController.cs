﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AttendanceLite.UI.Controllers
{
    public class TimeLogsController : ApiController
    {
        // GET: api/TimeLogs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TimeLogs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TimeLogs
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TimeLogs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TimeLogs/5
        public void Delete(int id)
        {
        }
    }
}
