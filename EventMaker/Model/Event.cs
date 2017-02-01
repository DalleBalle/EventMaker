using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    public class Event
    {
        int Id;
        string Name;
        string Description;
        string Place;
        DateTime DateTime;

        public Event(int id, string name, string desc, string place, DateTime datetime)
        {
            this.Id = id;
            this.Name = name;
            this.Description = desc;
            this.Place = place;
            this.DateTime = datetime;
        }

        //public override string ToString()
        //{
        //    string toString;

        //    toString = Name + " " + Place;

        //    return toString;
        //}
    }
}
