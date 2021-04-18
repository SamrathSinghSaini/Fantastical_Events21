using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantastical_Events_2021.Models
{
    public class Event
    {
        public int EventId { get; set; }

        //public int ActivityId { get; set; }
        public String EventName { get; set; }

        public String EventCategory { get; set; }

        public List<Activity> Activities { get; set; }
    }
}
