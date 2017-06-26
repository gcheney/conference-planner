using ConferencePlanner.DataAccess;
using ConferencePlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConferencePlanner.Controllers
{
    public class HomeController : Controller
    {
        private ConferenceDataAccess _dataAccess = new ConferenceDataAccess();

        public ActionResult Index()
        {
            var vm = new IndexViewModel();
            vm.Conferences = _dataAccess.GetConferences();
            vm.FlagAttendanceUrl = Url.Action(nameof(ConferenceController.FlagAttendance), "Conference");
            return View(vm);
        }
    }
}