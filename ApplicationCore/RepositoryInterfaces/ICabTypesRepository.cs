using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface ICabTypesRepository : IAsyncRepository<CabTypes>
    {
        
        public Task<CabTypes> GetAllBookingsHistoryById(int id);

        public Task<CabTypes> GetCurrentBookingsId(int id);


    }
}
