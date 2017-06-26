using ConferencePlanner.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConferencePlanner.DataAccess
{
    public class ConferenceDataAccess
    {
        /// <summary>
        /// For demo simplicity purposes, we just use a dictionary here. In a real application, 
        /// this would access some sort of database, probably using Entity Framework.
        /// The Dictionary approach used here is not thread-safe and should not be used
        /// in a real application.
        /// </summary>
        private static Dictionary<int, Conference> _attendeesByConferenceId = new Dictionary<int, Conference>();

        static ConferenceDataAccess()
        {
            int id = 1;
            _attendeesByConferenceId.Add(id, new Conference()
            {
                Id = id,
                Name = "Agile Software Development",
                Location = "London",
                Description = "Learn all about Agile processes and how they can help your business. Discuss best practices with other Agile masters.",
                StartDate = new DateTime(2017, 1, 15)
            });
            id++;
            _attendeesByConferenceId.Add(id, new Conference()
            {
                Id = id,
                Name = "ASP.NET Futures",
                Location = "Tokyo",
                Description = "Presentations and discussions about the next version of ASP.NET. Find out what's coming up soon!",
                StartDate = new DateTime(2017, 3, 10)
            });
            id++;
            _attendeesByConferenceId.Add(id, new Conference()
            {
                Id = id,
                Name = "Angular Worldwide",
                Location = "San Francisco",
                Description = "Angular is a really popular tool these days. Find out more about how to use it efficiently and what the team are working on next!",
                StartDate = new DateTime(2017, 2, 8)
            });
            id++;
            _attendeesByConferenceId.Add(id, new Conference()
            {
                Id = id,
                Name = "C# Enthusiasts",
                Location = "Paris",
                Description = "Find out all about the C# language, and how to make the most of the new features in the latest release.",
                StartDate = new DateTime(2017, 2, 28)
            });
        }

        public List<Conference> GetConferences()
        {
            return _attendeesByConferenceId.Values.ToList();
        }

        public int GetAttendees(int conferenceId)
        {
            return _attendeesByConferenceId[conferenceId].AttendeeCount;
        }

        public void AddExtraAttendee(int conferenceId)
        {
            _attendeesByConferenceId[conferenceId].AttendeeCount++;
        }
    }
}