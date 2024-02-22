namespace API.Customer

{
    public class UserLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LoginTime { get; set; }

        public User User { get; set; }
    }
}