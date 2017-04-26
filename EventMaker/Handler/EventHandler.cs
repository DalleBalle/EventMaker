using EventMaker.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Handler
{
    class EventHandler
    {
        // reference til eventViewModel'en
        public EventViewModel EventViewModel { get; set; }

        // eventViewModel reference constructor
        public EventHandler (EventViewModel eventViewModel)
        {
            EventViewModel = eventViewModel;
        }


    }
}
