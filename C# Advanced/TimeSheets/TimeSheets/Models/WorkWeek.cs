using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeSheets.Models
{
    public class WorkWeek
    {
        public decimal FixedHours { get; set; }
        public decimal SickHours { get; set; }
        public decimal TimeOffHours { get; set; }
        public decimal VacationHours  { get; set; }
        public decimal OverTimeHours { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}