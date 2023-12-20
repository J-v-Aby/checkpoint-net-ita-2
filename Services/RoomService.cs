using net_ita_2_checkpoint.Context;
using net_ita_2_checkpoint.DTOs;
using net_ita_2_checkpoint.Services.Interfaces;

namespace net_ita_2_checkpoint.Services
{
    public class RoomService : IRoomService
    {
        private readonly IDbContext _db;

        public RoomService(IDbContext db)
        {
            _db = db;
        }

        public async Task CreateRoomAsync(CreateRoomDTO dto)
        {
           
              _db.Rooms.Add(new Entities.Room {Id=dto.Id, Name= dto.Name, Type = dto.Type , People=dto.People, Price=dto.Price});
        }

        public  async Task DeleteRoomAsync(Guid id)
        {
            var y = _db.Rooms.FirstOrDefault(f => f.Id == id);
            _db.Rooms.Remove(y);
        }

        public async Task<ICollection<RoomListDTO>> GetAllRoomsAsync()
        {
            return _db.Rooms.Select(s => new RoomListDTO
            {
                Id = s.Id,
                Name = s.Name,
                Type = s.Type,
                People = s.People,
                Price = s.Price
            }).ToList() ;
        }

        public Task<ICollection<RoomListDTO>> GetAvailableRoomsAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomDetailDTO> GetRoomAsync(Guid id)
        {
            //   return  _db.Rooms.Where(f => f.Id == id).FirstOrDefault();

        }

        public async Task UpdateRoomAsync(UpdateRoomDTO dto)
        {
            var y = _db.Rooms.FirstOrDefault( f =>f.Id==dto.Id);
            if (y== null)
            {
                Console.WriteLine("bla bla bla");
            }
            else
            {
                y.Id = dto.Id;
                y.Name = dto.Name;
                y.People = dto.People;
                y.Type = dto.Type;
                y.Price = dto.Price;

            }

        }
    }
}