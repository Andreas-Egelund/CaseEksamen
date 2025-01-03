﻿using CaseLibrary.Data;
using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseLibrary.Models
{
    public class BookableEvent
    {
        private static int _nextId = 100;

        public string EventId {  get; set; }
        public string EventName { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public Dictionary<string, User> AssignedMembers { get; set; }




        public BookableEvent(string eventName, string date, string duration)
        {
            _nextId++;
            EventId = $"BE-Id-{_nextId}";
            EventName = eventName;
            Date = date;
            Duration = duration;
            AssignedMembers = new Dictionary<string, User>();

        }




        public override string ToString()
        {
            return $"---------------------------------------\n" +
            $"EventName: {EventName}\n" +
            $"Date: {Date}\n" +
            $"Duration: {Duration}\n" +
            $"Member signed up for this event:\n{string.Join("\n", AssignedMembers.Values.Select(user => user.Name))}\n";

            
            
        }

    }
}
