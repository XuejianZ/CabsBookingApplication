using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IPlacesService
    {
        Task<PlacesResponseModel> AddPlaces(PlacesRequestModel requestModel);

        Task<PlacesResponseModel> UpdatePlaces(PlacesRequestModel requestModel);

        Task<bool> DeletePlaces(int id);

        Task<IEnumerable<PlacesResponseModel>> ListAllPlaces();


    }
}
