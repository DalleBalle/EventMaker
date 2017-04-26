using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {
        public EventCatalogSingleton eventCatalogSingleton { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTimeOffset dateTimeOffset { get; set; }
        public TimeSpan Time { get; set; }

        public void EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }
    }
}
