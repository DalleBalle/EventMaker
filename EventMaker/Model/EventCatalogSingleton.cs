using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EventMaker.Model
{
    class EventCatalogSingleton : ObservableCollection<Event>
    {
        private static EventCatalogSingleton instance;

        private EventCatalogSingleton()
        {

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
    }
}
