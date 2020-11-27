using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Media
    {
        public int MediaID { get; set; }
        public int EventID { get; set; }
        public DateTime MediaDate { get; set; }
        public Event Event { get; set; }
        public string Url { get; set; }
        public ApplicationUser? Owner { get; set; }


        public string ImageName { get; set; }
    }
}