using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConferencePlanner.Models
{
    public class IndexViewModel
    {
        public List<Conference> Conferences { get; set; }
        public string FlagAttendanceUrl { get; set; }
    }
}