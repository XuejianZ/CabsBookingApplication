using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class BookingsHistoryResponseModel
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

        public string PickupTime { get; set; }

        public string ContactNo { get; set; }

        public string Status { get; set; }

        public string comp_time { get; set; }

        public decimal charge { get; set; }

        public string Feedback { get; set; }

        public int CabTypeId { get; set; }

        public PlacesResponseModel FPlace { get; set; }

        public PlacesResponseModel TPlace { get; set; }


    }
}
