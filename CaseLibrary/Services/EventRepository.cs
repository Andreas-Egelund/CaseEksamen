using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Services
{
    public class EventRepository : IEventRepository
    {
        private Dictionary <string, BookableEvent> _eventRepository;


        public EventRepository()
        {
            _eventRepository = MockData.GetAllEvents();
        }

        public void AddEvent(string eventId, BookableEvent bookableEvent)
        {
            _eventRepository.Add(eventId, bookableEvent);
        }

        public void DeleteEventById(string eventId)
        {
            if (_eventRepository.ContainsKey(eventId))
            {
                _eventRepository.Remove(eventId);
            }
        }

        public Dictionary<string, BookableEvent> GetAllEvents()
        {
            return _eventRepository;
        }

        public BookableEvent GetEventById(string eventId)
        {
            if (!_eventRepository.ContainsKey(eventId))
            {
                return _eventRepository[eventId];
            }
            return null;
        }

        // Needs implementation
        public void UpdateEventById(string eventId)
        {

        }
    }
}
