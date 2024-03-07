namespace API.DTOS
{
    public class UserLoginDto
    {
            public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LoginTime { get; set; }

        public UserDto User { get; set; }
    }

}