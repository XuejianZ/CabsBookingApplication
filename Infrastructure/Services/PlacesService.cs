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
    public class PlacesService:IPlacesService
    {
        private readonly IPlacesRepository _placesRepository;

        public PlacesService(IPlacesRepository placesRepository)
        {
            _placesRepository = placesRepository;
        }


        public async Task<PlacesResponseModel> AddPlaces(PlacesRequestModel requestModel)
        {
            //convert the request model to entity
            var place = new Places
            {
                PlaceId = requestModel.PlaceId,
                PlaceName = requestModel.PlaceName

            };

            //call bookinghistoryrespotiry to get the entity
            var addedPlace = await _placesRepository.AddAsync(place);


            //convert the returner entity to model
            var addedPlaceResponseModel = new PlacesResponseModel
            {

                PlaceId = addedPlace.PlaceId,
                PlaceName = addedPlace.PlaceName

            };

            //return  the model to the corresponding controller
            return addedPlaceResponseModel;
        }

        public async Task<PlacesResponseModel> UpdatePlaces(PlacesRequestModel requestModel)
        {
            //convert the request model to entity
            var place = new Places
            {
                PlaceId = requestModel.PlaceId,
                PlaceName = requestModel.PlaceName

            };
            //call bookinghistoryrespotiry to get the entity
            var updatedPlace = await _placesRepository.UpdateAsync(place);

            //convert the returner entity to model
            var updatedPlaceResponseModel = new PlacesResponseModel
            {
                PlaceId = updatedPlace.PlaceId,
                PlaceName = updatedPlace.PlaceName

            };

            //return  the model to the corresponding controller
            return updatedPlaceResponseModel;
        }

        public async Task<bool> DeletePlaces(int id)
        {
            //get the bookinghsitry frist 
            var places = await _placesRepository.GetByIdAsync(id);


            var deletedPlaces = await _placesRepository.DeleteAsync(places);


            //means delete successfully 
            if (deletedPlaces != null)
                return true;


            return false;
        }

        public async Task<IEnumerable<PlacesResponseModel>> ListAllPlaces()
        {
            var places = await _placesRepository.ListAllAsync();

            var result = new List<PlacesResponseModel>();


            foreach (var place in places)
            {
                result.Add(

                    new PlacesResponseModel
                    {
                        PlaceId = place.PlaceId,
                        PlaceName = place.PlaceName

                    }
                );

            }

            return result;
        }
    }
}
