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
        private static EventCatalogSingleton instance;

        private EventCatalogSingleton()
        {
            Events.Add(new Event{});
        }

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

        public ObservableCollection<Event> Events { get; set; }

        public void AddEventToList()
        {

        }
    }
}
