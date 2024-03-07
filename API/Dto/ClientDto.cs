namespace API.DTOS
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Url { get; set; }

        public DateTime? DisabledAt { get; set; }
        public List<CompanyDto> Companies { get; set; } 
    }
}
