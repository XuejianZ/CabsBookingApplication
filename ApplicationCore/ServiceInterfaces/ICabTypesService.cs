using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICabTypesService
    {

        Task<CabTypesResponseModel> AddCabTypes(CabTypesRequestModel requestModel);

        Task<CabTypesResponseModel> UpdateCabTypes(CabTypesRequestModel requestModel);

        Task<bool> DeleteCabTypes(int id);

        Task<IEnumerable<CabTypesResponseModel>> ListAllCabTypes();

        Task<IEnumerable<BookingsHistoryResponseModel>> GetAllBookingHistory(int id);

        Task<IEnumerable<BookingsResponseModel>> GetAllBookings(int id);



    }
}
