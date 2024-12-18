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

        public void AddEvent(BookableEvent bookableEvent)
        {
            _eventRepository.Add(bookableEvent.EventId, bookableEvent);
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
            if (_eventRepository.ContainsKey(eventId))
            {
                return _eventRepository[eventId];
            }
            return null;
        }

        public void UpdateEventById(string eventId)
        {


            try
            {



                BookableEvent currentBookableEvent = GetEventById(eventId);


                Console.WriteLine($"You are editing this Event: \n\n {currentBookableEvent}");

                Console.WriteLine("Do you want to edit the Name of the event?\n" +
                    "(Y)es or (N)o?");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new Eventname here: \n");
                    currentBookableEvent.EventName = Console.ReadLine();
                }

                


                Console.WriteLine("Do you want to edit the date of the event?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new date here: dd/m/year\n");
                    currentBookableEvent.Date = Console.ReadLine();
                }

                Console.WriteLine("Do you want to edit the duration of the event?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new duration in hours here: \n");
                    currentBookableEvent.Duration = Console.ReadLine();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }




            




        }
    }
}
