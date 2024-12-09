using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.interfaces
{
    public interface IEventRepository
    {
        void AddEvent(string EventId, BookableEvent bookableEvent);

        Dictionary<string, BookableEvent> GetAllEvents();

        BookableEvent GetEventById (string evnetId);

        void UpdateEventById (string eventId);

        void DeleteEventById (string eventId);

    }
}
