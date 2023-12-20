using Microsoft.AspNetCore.Mvc;
using net_ita_2_checkpoint.DTOs;
using net_ita_2_checkpoint.Services.Interfaces;

namespace net_ita_2_checkpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController :ControllerBase
    {
        private IRoomService _roomService { get; set; }

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        [HttpPost]
        public async Task<IActionResult> PostRoomAsync([FromBody] CreateRoomDTO createRoomDTO)
        {
            await _roomService.CreateRoomAsync(createRoomDTO);
            return Ok("bla bla bla");


        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAllRoomsAsync()
        {
            return Ok(await _roomService.GetAllRoomsAsync());
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteRoomAsync(Guid id)
        {
           await _roomService.DeleteRoomAsync(id);
            return Ok("bla bla bla");

        }

        [HttpPut]
        public async Task<IActionResult> PutRoomAsync([FromBody] UpdateRoomDTO updateRoomDTO)
        {
            await _roomService.UpdateRoomAsync(updateRoomDTO);
            return Ok("bla bla bla");
        }



        [HttpGet("Available")]
        public async Task<IActionResult> GetAvailableRoomsAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Detail")]
        public async Task<IActionResult> GetRoomAsync(Guid id)
        {
            throw new NotImplementedException();
        }

    

       

    }
}