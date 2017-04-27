using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        // Singleton
        private static EventCatalogSingleton instance;

        // Singleton constructor
        private EventCatalogSingleton()
        {
            Events.Add(new Event(1, "Slipknot", "Koncert", "Parken", new DateTime(2017, 3, 12)));
            Events.Add(new Event(2, "Murderdolls", "Koncert", "Parken", new DateTime(2017, 6, 16)));
        }

        // Rest of the singleton
        public static EventCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventCatalogSingleton();
                }

                return instance;
            }
        }

        // List of events
        public ObservableCollection<Event> Events { get; set; }

        // pass'er et nyt event ind i event listen
        public void AddEventToList(Event nyEvent)
        {
            Events.Add(nyEvent);
        }
    }
}
