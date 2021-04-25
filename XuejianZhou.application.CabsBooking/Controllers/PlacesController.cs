using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.ServiceInterfaces;

namespace XuejianZhou.application.CabsBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {

        private readonly IPlacesService _placesService;
        public PlacesController(IPlacesService placesService)
        {
            _placesService = placesService;

        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddBookings(PlacesRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var addedPlace = await _placesService.AddPlaces(requestModel);
            return Ok(addedPlace);
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateNewBookings(PlacesRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var updatePlace = await _placesService.UpdatePlaces(requestModel);
            return Ok(updatePlace);
        }


        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var deletePlace = await _placesService.DeletePlaces(id);
            return Ok(deletePlace);
        }



        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var allPlaces = await _placesService.ListAllPlaces();
            return Ok(allPlaces);
        }


    }
}
