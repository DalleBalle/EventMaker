using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;
using System.Windows.Input;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {
        public EventCatalogSingleton eventCatalogSingleton { get; set; }

        public int _id;
        public string _name;
        public string _description;
        public string _place;
        private DateTimeOffset _date;
        private TimeSpan _time;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }

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
        
        // constructor
        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }

        // laver en Icommand property der initialiseres med et RelayCommand objekt hvis action refererer til CreateEvent metoden i EventHandleren
        private ICommand _createEventCommand;

        public ICommand CreateEventCommand
            {
                get
                {
                    if (_createEventCommand == null)
                    {
                    _createEventCommand = new RelayCommand(EventHandler.CreateEvent);
                        return _createEventCommand;
                    }
                }
                set { _createEventCommand = value; }
            }
    }
}
