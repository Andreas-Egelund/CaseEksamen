using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models
{
    public class BookableEvent
    {


        public string EventId {  get; set; }
        public string EventName { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public Dictionary<string, User> AssignedMembers { get; set; }



        public BookableEvent(string eventId, string eventName, string date, string duration)
        {
            EventId = eventId;
            EventName = eventName;
            Date = date;
            Duration = duration;
            AssignedMembers = new Dictionary<string, User>();
        }









    }
}
