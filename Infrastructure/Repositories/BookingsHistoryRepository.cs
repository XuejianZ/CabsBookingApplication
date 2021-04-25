using System;
using System.Collections;
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
    public class BookingsHistoryRepository:EfRepository<BookingsHistory>,IBookingsHistoryRepository
    {
        public BookingsHistoryRepository(CabsBookingDbContext dbContext) : base(dbContext)
        {

        }


    }
}
