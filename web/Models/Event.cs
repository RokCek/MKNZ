using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EDate { get; set; }

        public Band Band { get; set; }

        public string Opis {get;set;}
    }
}