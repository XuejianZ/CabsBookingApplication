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
    public class BookingsHistoryController : ControllerBase
    {
        private readonly IBookingsHistoryService _bookingsHistoryService;

        public BookingsHistoryController(IBookingsHistoryService bookingsHistoryService)
        {
            _bookingsHistoryService = bookingsHistoryService;
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddBookingsHistory(BookingsHistoryRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var addedBh = await _bookingsHistoryService.AddBookingsHistory(requestModel);
            return Ok(addedBh);
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateNewBookingsHistory(BookingsHistoryRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please check data");
            }

            var updatedBh = await _bookingsHistoryService.UpdateBookingsHistory(requestModel);
            return Ok(updatedBh);
        }


        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var deleteClient = await _bookingsHistoryService.DeleteBookingsHistory(id);
            return Ok(deleteClient);
        }



        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var allClients = await _bookingsHistoryService.ListAllBookingsHistory();
            return Ok(allClients);
        }


    }
}
