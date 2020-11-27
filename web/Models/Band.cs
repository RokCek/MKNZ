using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Band
    {
        public int BandID { get; set; }
        public string BandName { get; set; }
        public Music Music { get; set; }    }
}