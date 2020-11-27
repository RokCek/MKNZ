using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }
        public DateTime ReservationDate { get; set; }

        public DateTime EventDate { get; set; }

        public Event Event { get; set; }

        public ICollection<User> Users { get; set; }
    }
}