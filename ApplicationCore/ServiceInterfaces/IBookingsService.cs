using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IBookingsService
    {

        Task<BookingsResponseModel> AddBookings(BookingsRequestModel requestModel);

        Task<BookingsResponseModel> UpdateBookings(BookingsRequestModel requestModel);

        Task<bool> DeleteBookings(int id);

        Task<IEnumerable<BookingsResponseModel>> ListAllBookings();
    }
}
