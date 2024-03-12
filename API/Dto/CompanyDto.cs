namespace API.DTOS
{
public class CompanyDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DisabledAt { get; set; }
    public int MessageOption { get; set; }
    public long TikNikuiim { get; set; }
    public int ClientId { get; set; }
}
}

