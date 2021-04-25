using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApplicationCore.Entities
{
    public class BookingsHistory
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public DateTime BookingDate { get; set; }

        public string BookingTime { get; set; }

        public int FromPlace { get; set; }

        public int ToPlace { get; set; }

        public string PickupAddress { get; set; }

        public string Landmark { get; set; }

        public DateTime PickupDate { get; set; }

        public int CabTypeId { get; set; }

        public string PickupTime { get; set; }

        public string ContactNo { get; set; }

        public string Status { get; set; }

        public string comp_time { get; set; }

        [Column(TypeName = "money")]
        public decimal charge{ get; set; }

        public string Feedback { get; set; }

        
        public CabTypes CabType { get; set; }

        //[ForeignKey("FromPlace")]
        //[InverseProperty("BookingsHistory")]
        public Places FromPlaces { get; set; }


        //[ForeignKey("ToPlace")]
        //public Places ToPlaces { get; set; }

        


    }
}
