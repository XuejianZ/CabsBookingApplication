using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Models.Response
{
    public class CabTypesResponseModel
    {


        public int CabTypeId { get; set; }

        public string CabTypeName { get; set; }

        public List<BookingsHistoryResponseModel> BookingsHistory;

        public List<BookingsResponseModel> Bookings;

        public List<PlacesResponseModel> Places;

    }


}
