namespace API.Customer
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName{ get; set;}
        public DateTime ClientAirtime { get; set; }= DateTime.Now;

    }


}