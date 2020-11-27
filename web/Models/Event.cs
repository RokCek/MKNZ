using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Event
    {
        public int BandID { get; set; }
        public int EventID { get; set; }
        public string EventName { get; set; }

        public DateTime EDate { get; set; }

        public List<Inter> Bands { get; set; }
    }
}