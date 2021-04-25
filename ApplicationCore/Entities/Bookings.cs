using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Bookings
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public DateTime BookingDate { get; set; }

        public string BookingTime { get; set; }

        public int FromPlace { get; set; }

        public int  ToPlace { get; set; }

        public string PickupAddress { get; set; }

        public string Landmark { get; set; }

        public DateTime PickupDate { get; set; }

        public int CabTypeId { get; set; }

        public string PickupTime { get; set; }

        public string ContactNo { get; set; }

        public string  Status { get; set; }

        public CabTypes CabType { get; set; }


      
        public Places FromPlaces { get; set; }


        //[ForeignKey("ToPlace")]
        //public Places ToPlaces { get; set; }


        //[ForeignKey("CabTypeId")]




        //public CabTypes CabTypes { get; set; }

        //[ForeignKey("FromPlace")]
        //public Places FromPlaces { get; set; }


        //[ForeignKey("ToPlace")]
        //[InverseProperty("Bookings")]
        //public Places ToPlaces { get; set; }


    }
}
