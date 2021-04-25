using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Places
    {

        public int PlaceId  { get; set; }

        public string PlaceName { get; set; }

        public ICollection<BookingsHistory> BookingsHistory { get; set; }

        public ICollection<Bookings> Bookings { set; get; }
    }
}
