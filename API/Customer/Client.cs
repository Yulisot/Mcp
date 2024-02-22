namespace API.Customer

{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public string Url { get; set; }
        public string ParamJsonClient { get; set; }
        public byte[] LastChange { get; set; }
        public List<Company> Companies { get; set; }
    }
}