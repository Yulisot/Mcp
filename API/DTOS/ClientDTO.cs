namespace API.DTOS
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public List<CompanyDTO> Companies { get; set; }
    }

    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public int MessageOption { get; set; }
    }
}

//not in use//