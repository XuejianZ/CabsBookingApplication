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
    public class BookingsController : ControllerBase
    {
        private IBookingsService  _bookingsService;
        public BookingsController(IBookingsService bookingsService)
        {
            _bookingsService = bookingsService;
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddBookings(BookingsRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var addedBh = await _bookingsService.AddBookings(requestModel);
            return Ok(addedBh);
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateNewBookings(BookingsRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var updatedB = await _bookingsService.UpdateBookings(requestModel);
            return Ok(updatedB);
        }


        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var deleteBooking = await _bookingsService.DeleteBookings(id);
            return Ok(deleteBooking);
        }



        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var allBookings = await _bookingsService.ListAllBookings();
            return Ok(allBookings);
        }

    }
}
