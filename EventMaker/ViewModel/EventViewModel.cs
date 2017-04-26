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
        private DateTimeOffset _date { get; set; }
        private TimeSpan _time { get; set; }

        public DateTimeOffset Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }
        
        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }
    }
}
