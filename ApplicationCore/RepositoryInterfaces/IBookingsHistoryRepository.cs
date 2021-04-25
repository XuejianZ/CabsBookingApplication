using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IBookingsHistoryRepository :IAsyncRepository<BookingsHistory>
    {

        //public Task<BookingsHistory> GetPlaeNameById(int id);



    }
}
