using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class Event
    {
        int Id;
        string Name;
        string Description;
        string Place;
        DateTime DateTime;

        Event()
        {
            Id = 0;
            Name = "navn";
            Description = "beskrivelse";
            Place = "sted";
            DateTime = new DateTime(2017, 3, 12);
        }

        public override string ToString()
        {
            string toString;

            toString = Name + " " + Description;

            return toString;
        }
    }
}
