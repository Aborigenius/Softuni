using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TimeSheets.Controllers;

namespace TimeSheets.Models
{
    public class TimeSheetsDBContext : DbContext
    {
        public virtual IDbSet<Employee> Employees { get; set; }

        public TimeSheetsDBContext() : base("PunchClock")
        {

        }
    }
}