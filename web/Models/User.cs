using System;
using System.Collections.Generic;

namespace web.Models
{

    public enum Music{
        rock, metal, punk, pop, indie, hiphop, alternative, blues, jazz 
    }
    public class User
    {
        public int UserID { get; set; }
        public string Nick { get; set; }
        public string UserSurname { get; set; }
        public string UserName { get; set; }

        public Boolean Member { get; set; }

        public ApplicationUser? Owner { get; set; }


        ICollection<Reservation> Reservations { get; set; }
        public Music Music { get; set; }
    }
}