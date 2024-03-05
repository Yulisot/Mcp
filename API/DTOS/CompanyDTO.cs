namespace API.DTOS
{
    public class CompanyDTO
    {
        public int ClientId { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public int MessageOption { get; set; }
        public long? TikNikuiim { get; set; }
        
        public ClientDTO Client { get; set; }
        public List<UserDTO> Users { get; set; }

    }
}

