using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IBookingsHistoryService
    {

        Task<BookingsHistoryResponseModel> AddBookingsHistory(BookingsHistoryRequestModel requestModel);

        Task<BookingsHistoryResponseModel> UpdateBookingsHistory(BookingsHistoryRequestModel requestModel);

        Task<bool> DeleteBookingsHistory(int id);

        Task<IEnumerable<BookingsHistoryResponseModel>> ListAllBookingsHistory();

        //Task<IEnumerable<BookingsHistoryResponseModel>> GetAllBhById(int id);

    }
}
