using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.Shared.Schedule
{
    public class ScheduleDay
    {
        public DateOnly Date { get; set; }
        public Scheduleltem[]? ItemsInDay { get; set; }
    }
}
