using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IBookingsRepository : IAsyncRepository<Bookings>
    {

        //public Task<Bookings> GetPlaeNameById(int id);


    }
}
