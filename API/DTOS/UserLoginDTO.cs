namespace API.DTOS
{
    public class UserLoginDTO
    {
            public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LoginTime { get; set; }

        public UserDTO User { get; set; }
    }

}