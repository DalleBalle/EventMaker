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
            Events.Add(new Event(1, "Slipknot", "Koncert", "Parken", new DateTime(2017, 3, 12)));
            Events.Add(new Event(2, "Murderdolls", "Koncert", "Parken", new DateTime(2017, 6, 16)));
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

        // List of events
        public ObservableCollection<Event> Events { get; set; }

        //public void AddEventToList(int id, string name, string desc, string place, DateTime datetime)
        //{
        //    Events.Add(new Event(
        //        this.Id = id,
        //        "Slipknot",
        //        "Koncert",
        //        "Parken",
        //        new DateTime(2017, 3, 12)));
        //}
    }
}
