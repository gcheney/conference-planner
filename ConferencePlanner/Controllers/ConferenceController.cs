using ConferencePlanner.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConferencePlanner.Controllers
{
    public class ConferenceController : Controller
    {
        private ConferenceDataAccess _dataAccess = new ConferenceDataAccess();

        [HttpPost]
        public ActionResult FlagAttendance(int conferenceId)
        {
            _dataAccess.AddExtraAttendee(conferenceId);
            return Json(new { newAttendeeCount = _dataAccess.GetAttendees(conferenceId) });
        }
    }
}