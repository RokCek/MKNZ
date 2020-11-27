using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string UserNick { get; set; }
        public string EventName { get; set; }
        public DateTime ReservationDate { get; set; }

        public DateTime EventDate { get; set; }

        public Event Event { get; set; }

        public User User { get; set; }
    }
}