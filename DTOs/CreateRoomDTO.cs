namespace net_ita_2_checkpoint.DTOs
{
    public class CreateRoomDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int People { get; set; }
        public decimal Price { get; set; }
    }
}