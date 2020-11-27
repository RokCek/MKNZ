using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Inter
    {
        public int InterID { get; set; }
        public int EventID { get; set; }
        public Event Event { get; set; }

        public int BandID { get; set; }
        public Band Band { get; set; }

    }
}