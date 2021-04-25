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
    public class CabTypesController : ControllerBase
    {

        private readonly ICabTypesService _cabTypesService;


        public CabTypesController(ICabTypesService cabTypesService)
        {
            _cabTypesService = cabTypesService;
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddBookings(CabTypesRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var addedCab = await _cabTypesService.AddCabTypes(requestModel);
            return Ok(addedCab);
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateNewBookings(CabTypesRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var updatedB = await _cabTypesService.UpdateCabTypes(requestModel);
            return Ok(updatedB);
        }


        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var deleteCab = await _cabTypesService.DeleteCabTypes(id);
            return Ok(deleteCab);
        }


        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var allCabs = await _cabTypesService.ListAllCabTypes();
            return Ok(allCabs);
        }

        [HttpGet]
        [Route("GetAllBookingHistory/{id}")]
        public async Task<IActionResult> GetAllBookingHistoryById(int id)
        {
            var allBookingHistory = await _cabTypesService.GetAllBookingHistory(id);
            return Ok(allBookingHistory);
        }


        [HttpGet]
        [Route("GetAllCurrentBookings/{id}")]
        public async Task<IActionResult> GetAllCurrentBookingsById(int id)
        {
            var allBookings = await _cabTypesService.GetAllBookings(id);
            return Ok(allBookings);
        }

    }
}
