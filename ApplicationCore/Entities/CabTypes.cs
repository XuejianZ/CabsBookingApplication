using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    public class CabTypes
    {
        public int CabTypeId { get; set; }

        public string CabTypeName { get; set; }

        public ICollection<Bookings> Bookings { get; set; }

        public ICollection<BookingsHistory> BookingsHistory { get; set; }
    }
}
