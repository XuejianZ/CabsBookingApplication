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
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Infrastructure.Services
{
    public class CabTypesService : ICabTypesService
    {

        private readonly ICabTypesRepository _cabTypesRepository;
        public CabTypesService(ICabTypesRepository cabTypesRepository)
        {
            _cabTypesRepository = cabTypesRepository;
        }

        public async Task<CabTypesResponseModel> AddCabTypes(CabTypesRequestModel requestModel)
        {

            //convert the request model to entity
            var cabTypes = new CabTypes()
            {
                CabTypeId = requestModel.CabTypeId,
                CabTypeName = requestModel.CabTypeName

            };

            //call bookinghistoryrespotiry to get the entity
            var addedCabTypes = await _cabTypesRepository.AddAsync(cabTypes);


            //convert the returner entity to model
            var addedCabTypesResponseModel = new CabTypesResponseModel
            {

                CabTypeId = addedCabTypes.CabTypeId,
                CabTypeName = addedCabTypes.CabTypeName

            };

            //return  the model to the corresponding controller
            return addedCabTypesResponseModel;

        }


        public async Task<CabTypesResponseModel> UpdateCabTypes(CabTypesRequestModel requestModel)
        {
            //convert the request model to entity
            var cabTypes = new CabTypes
            {
                CabTypeId = requestModel.CabTypeId,
                CabTypeName = requestModel.CabTypeName,

            };
            //call bookinghistoryrespotiry to get the entity
            var updatedCabType = await _cabTypesRepository.UpdateAsync(cabTypes);

            //convert the returner entity to model
            var updatedCabTypesResponseModel = new CabTypesResponseModel
            {
                CabTypeId = updatedCabType.CabTypeId,
                CabTypeName = updatedCabType.CabTypeName

            };

            //return  the model to the corresponding controller
            return updatedCabTypesResponseModel;
        }



        public async Task<bool> DeleteCabTypes(int id)
        {


            //get the bookinghsitry frist 
            var cabTypes = await _cabTypesRepository.GetByIdAsync(id);


            var deletedCabTypes = await _cabTypesRepository.DeleteAsync(cabTypes);


            //means delete successfully 
            if (deletedCabTypes != null)
                return true;


            return false;
        }


        public async Task<IEnumerable<CabTypesResponseModel>> ListAllCabTypes()
        {


            var cabTypes = await _cabTypesRepository.ListAllAsync();


            var result = new List<CabTypesResponseModel>();


            foreach (var cab in cabTypes)
            {
                result.Add(

                    new CabTypesResponseModel
                    {
                        CabTypeId = cab.CabTypeId,
                        CabTypeName = cab.CabTypeName

                    }
                );

            }

            return result;


        }



        public async Task<IEnumerable<BookingsHistoryResponseModel>> GetAllBookingHistory(int id)
        {

            var cab = await _cabTypesRepository.GetAllBookingsHistoryById(id);

            //var result = new BookingsHistoryResponseModel();

            //result.CabTypeId = cab.CabTypeId;
            //result.CabTypeName = cab.CabTypeName;

            var result = new List<BookingsHistoryResponseModel>();


            foreach (var bh in cab.BookingsHistory)
            {

                result.Add(
                    new BookingsHistoryResponseModel
                    {
                        Id = bh.Id,
                        Email = bh.Email,
                        BookingDate = bh.BookingDate,
                        BookingTime = bh.BookingTime,
                        FromPlace = bh.FromPlace,
                        ToPlace = bh.ToPlace,
                        PickupAddress = bh.PickupAddress,
                        Landmark = bh.Landmark,
                        PickupDate = bh.PickupDate,
                        PickupTime = bh.PickupTime,
                        CabTypeId = bh.CabTypeId,
                        ContactNo = bh.ContactNo,
                        Status = bh.Status,
                        comp_time = bh.comp_time,
                        charge = bh.charge,
                        Feedback = bh.Feedback,

                    }

                );
            }
            return result;
        }



        public async Task<IEnumerable<BookingsResponseModel>> GetAllBookings(int id)
        {

            var cab = await _cabTypesRepository.GetCurrentBookingsId(id);

            //var result = new BookingsHistoryResponseModel();

            //result.CabTypeId = cab.CabTypeId;
            //result.CabTypeName = cab.CabTypeName;

            var result = new List<BookingsResponseModel>();


            foreach (var bh in cab.Bookings)
            {

                result.Add(
                    new BookingsResponseModel
                    {
                        Id = bh.Id,
                        Email = bh.Email,
                        BookingDate = bh.BookingDate,
                        BookingTime = bh.BookingTime,
                        FromPlace = bh.FromPlace,
                        ToPlace = bh.ToPlace,
                        PickupAddress = bh.PickupAddress,
                        Landmark = bh.Landmark,
                        PickupDate = bh.PickupDate,
                        PickupTime = bh.PickupTime,
                        CabTypeId = bh.CabTypeId,
                        ContactNo = bh.ContactNo,
                        Status = bh.Status,


                    }

                );
            }
            return result;
        }





    }
}
