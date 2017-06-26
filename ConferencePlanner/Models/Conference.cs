using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConferencePlanner.Models
{
    public class Conference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string StartDateString { get { return StartDate.ToLongDateString(); } }
        public string Location { get; set; }
        public string Description { get; set; }
        public int AttendeeCount { get; set; } = 0;
    }
}