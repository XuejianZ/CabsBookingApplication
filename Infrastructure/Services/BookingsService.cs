using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class BookingsService:IBookingsService
    {
        private  readonly  IBookingsRepository  _bookingsRepository;

        public BookingsService(IBookingsRepository bookingsRepository)
        {
            _bookingsRepository = bookingsRepository;
        }

        public async Task<BookingsResponseModel> AddBookings(BookingsRequestModel requestModel)
        {
            //convert the request model to entity
            var bookings = new Bookings
            {
                Id = requestModel.Id,
                Email = requestModel.Email,
                BookingDate = requestModel.BookingDate,
                BookingTime = requestModel.BookingTime,
                FromPlace = requestModel.FromPlace,
                ToPlace = requestModel.ToPlace,
                PickupAddress = requestModel.PickupAddress,
                Landmark = requestModel.Landmark,
                PickupDate = requestModel.PickupDate,
                PickupTime = requestModel.PickupTime,
                CabTypeId = requestModel.CabTypeId,
                ContactNo = requestModel.ContactNo,
                Status = requestModel.Status
            
            };

            //call bookinghistoryrespotiry to get the entity
            var addedBookings = await _bookingsRepository.AddAsync(bookings);


            //convert the returner entity to model
            var addedBookingsResponseModel = new BookingsResponseModel
            {
                Id = addedBookings.Id,
                Email = addedBookings.Email,
                BookingDate = addedBookings.BookingDate,
                BookingTime = addedBookings.BookingTime,
                FromPlace = addedBookings.FromPlace,
                ToPlace = addedBookings.ToPlace,
                PickupAddress = addedBookings.PickupAddress,
                Landmark = addedBookings.Landmark,
                PickupDate = addedBookings.PickupDate,
                PickupTime = addedBookings.PickupTime,
                CabTypeId = addedBookings.CabTypeId,
                ContactNo = addedBookings.ContactNo,
                Status = addedBookings.Status,
               
            };

            //return  the model to the corresponding controller
            return addedBookingsResponseModel;
        }

        public async Task<BookingsResponseModel> UpdateBookings(BookingsRequestModel requestModel)
        {
            //convert the request model to entity
            var bookings = new Bookings
            {
                Id = requestModel.Id,
                Email = requestModel.Email,
                BookingDate = requestModel.BookingDate,
                BookingTime = requestModel.BookingTime,
                FromPlace = requestModel.FromPlace,
                ToPlace = requestModel.ToPlace,
                PickupAddress = requestModel.PickupAddress,
                Landmark = requestModel.Landmark,
                PickupDate = requestModel.PickupDate,
                PickupTime = requestModel.PickupTime,
                CabTypeId = requestModel.CabTypeId,
                ContactNo = requestModel.ContactNo,
                Status = requestModel.Status
             
            };

            //call bookingrespotiry to get the entity
            var updatedBookings = await _bookingsRepository.UpdateAsync(bookings);


            //convert the returner entity to model
            var updatedBookingsResponseModel = new BookingsResponseModel
            {
                Id = updatedBookings.Id,
                Email = updatedBookings.Email,
                BookingDate = updatedBookings.BookingDate,
                BookingTime = updatedBookings.BookingTime,
                FromPlace = updatedBookings.FromPlace,
                ToPlace = updatedBookings.ToPlace,
                PickupAddress = updatedBookings.PickupAddress,
                Landmark = updatedBookings.Landmark,
                PickupDate = updatedBookings.PickupDate,
                PickupTime = updatedBookings.PickupTime,
                CabTypeId = updatedBookings.CabTypeId,
                ContactNo = updatedBookings.ContactNo,
                Status = updatedBookings.Status,
            
            };

            //return  the model to the corresponding controller
            return updatedBookingsResponseModel;

    }

        public async Task<bool> DeleteBookings(int id)
        {
            //get the bookinghsitry frist 
            var booking = await _bookingsRepository.GetByIdAsync(id);


            var deletedBooking = await _bookingsRepository.DeleteAsync(booking);


            //means delete successfully 
            if (deletedBooking != null)
                return true;


            return false;
        }

        public async Task<IEnumerable<BookingsResponseModel>> ListAllBookings()
        {
            var bookings = await _bookingsRepository.ListAllAsync();

            var result = new List<BookingsResponseModel>();


            foreach (var booking in bookings)
            {
                result.Add(

                    new BookingsResponseModel
                    {
                        Id = booking.Id,
                        Email = booking.Email,
                        BookingDate = booking.BookingDate,
                        BookingTime = booking.BookingTime,
                        FromPlace = booking.FromPlace,
                        ToPlace = booking.ToPlace,
                        PickupAddress = booking.PickupAddress,
                        Landmark = booking.Landmark,
                        PickupDate = booking.PickupDate,
                        PickupTime = booking.PickupTime,
                        CabTypeId = booking.CabTypeId,
                        ContactNo = booking.ContactNo,
                        Status = booking.Status,
                      
                    }
                );

            }

            return result;
        }



    }
}
