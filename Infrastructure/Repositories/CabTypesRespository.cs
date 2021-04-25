using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CabTypesRepository : EfRepository<CabTypes>, ICabTypesRepository
    {

        public CabTypesRepository(CabsBookingDbContext dbContext) : base(dbContext)
        {

        }




        public async Task<CabTypes> GetAllBookingsHistoryById(int id)
        {
            var cabBookingHistory = await _dbContext.CabTypes.Include(c => c.BookingsHistory)
                .FirstOrDefaultAsync(c => c.CabTypeId == id);

            return cabBookingHistory;
        }



        public async Task<CabTypes> GetCurrentBookingsId(int id)
        {
            var cabBooking = await _dbContext.CabTypes.Include(c => c.Bookings)
                .FirstOrDefaultAsync(c => c.CabTypeId == id);

            return cabBooking;
        }



    }
}
