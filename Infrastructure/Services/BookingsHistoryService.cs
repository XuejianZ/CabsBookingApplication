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
    public class BookingsHistoryService:IBookingsHistoryService
    {
        private readonly IBookingsHistoryRepository _booKingsHistoryRepository;

        public BookingsHistoryService(IBookingsHistoryRepository booKingsHistoryRepository)
        {
            _booKingsHistoryRepository = booKingsHistoryRepository;
        }


        public async Task<BookingsHistoryResponseModel> AddBookingsHistory(BookingsHistoryRequestModel requestModel)
        {

            //convert the request model to entity
            var bookingsHistory = new BookingsHistory
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
                Status = requestModel.Status,
                comp_time = requestModel.comp_time,
                charge = requestModel.charge,
                Feedback = requestModel.Feedback,
            };

            //call bookinghistoryrespotiry to get the entity
            var addedBookingsHistory = await _booKingsHistoryRepository.AddAsync(bookingsHistory);


            //convert the returner entity to model
            var addedBookingsHistoryResponseModel = new BookingsHistoryResponseModel
            {
                Id = addedBookingsHistory.Id,
                Email = addedBookingsHistory.Email,
                BookingDate = addedBookingsHistory.BookingDate,
                BookingTime = addedBookingsHistory.BookingTime,
                FromPlace = addedBookingsHistory.FromPlace,
                ToPlace = addedBookingsHistory.ToPlace,
                PickupAddress = addedBookingsHistory.PickupAddress,
                Landmark = addedBookingsHistory.Landmark,
                PickupDate = addedBookingsHistory.PickupDate,
                PickupTime = addedBookingsHistory.PickupTime,
                CabTypeId = addedBookingsHistory.CabTypeId,
                ContactNo = addedBookingsHistory.ContactNo,
                Status = addedBookingsHistory.Status,
                comp_time = addedBookingsHistory.comp_time,
                charge = addedBookingsHistory.charge,
                Feedback = addedBookingsHistory.Feedback,
            };

            //return  the model to the corresponding controller
            return addedBookingsHistoryResponseModel;


        }

        public async Task<BookingsHistoryResponseModel> UpdateBookingsHistory(BookingsHistoryRequestModel requestModel)
        {
            //convert the request model to entity
            var bookingsHistory = new BookingsHistory
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
                Status = requestModel.Status,
                comp_time = requestModel.comp_time,
                charge = requestModel.charge,
                Feedback = requestModel.Feedback,
            };

            //call bookinghistoryrespotiry to get the entity
            var updatedBookingsHistory = await _booKingsHistoryRepository.UpdateAsync(bookingsHistory);


            //convert the returner entity to model
            var updatedBookingsHistoryResponseModel = new BookingsHistoryResponseModel
            {
                Id = updatedBookingsHistory.Id,
                Email = updatedBookingsHistory.Email,
                BookingDate = updatedBookingsHistory.BookingDate,
                BookingTime = updatedBookingsHistory.BookingTime,
                FromPlace = updatedBookingsHistory.FromPlace,
                ToPlace = updatedBookingsHistory.ToPlace,
                PickupAddress = updatedBookingsHistory.PickupAddress,
                Landmark = updatedBookingsHistory.Landmark,
                PickupDate = updatedBookingsHistory.PickupDate,
                PickupTime = updatedBookingsHistory.PickupTime,
                CabTypeId = updatedBookingsHistory.CabTypeId,
                ContactNo = updatedBookingsHistory.ContactNo,
                Status = updatedBookingsHistory.Status,
                comp_time = updatedBookingsHistory.comp_time,
                charge = updatedBookingsHistory.charge,
                Feedback = updatedBookingsHistory.Feedback,
            };

            //return  the model to the corresponding controller
            return updatedBookingsHistoryResponseModel;
        }


        public async Task<bool> DeleteBookingsHistory(int id)
        {

            //get the bookinghsitry frist 
            var bookingHistory = await _booKingsHistoryRepository.GetByIdAsync(id);


            var deletedBookingHistory = await _booKingsHistoryRepository.DeleteAsync(bookingHistory);


            //means delete successfully 
            if (deletedBookingHistory != null)
                return true;
               
            
            return false;
        }

        public async Task<IEnumerable<BookingsHistoryResponseModel>> ListAllBookingsHistory()
        {
            var bookingsHistories = await _booKingsHistoryRepository.ListAllAsync();

            var result = new List<BookingsHistoryResponseModel>();


            foreach (var bookingsHistory in bookingsHistories)
            {
                result.Add(

                    new BookingsHistoryResponseModel
                    {
                        Id = bookingsHistory.Id,
                        Email = bookingsHistory.Email,
                        BookingDate = bookingsHistory.BookingDate,
                        BookingTime = bookingsHistory.BookingTime,
                        FromPlace = bookingsHistory.FromPlace,
                        ToPlace = bookingsHistory.ToPlace,
                        PickupAddress = bookingsHistory.PickupAddress,
                        Landmark = bookingsHistory.Landmark,
                        PickupDate = bookingsHistory.PickupDate,
                        PickupTime = bookingsHistory.PickupTime,
                        CabTypeId = bookingsHistory.CabTypeId,
                        ContactNo = bookingsHistory.ContactNo,
                        Status = bookingsHistory.Status,
                        comp_time = bookingsHistory.comp_time,
                        charge = bookingsHistory.charge,
                        Feedback = bookingsHistory.Feedback,
                    }
                );

            }

            return result;
        }

    //    public async Task<IEnumerable<BookingsHistoryResponseModel>> GetAllBhById(int id)
    //    {
    //        await _booKingsHistoryRepository.GetByIdAsync(id);
    //    }
    }
}
