namespace  API.DTOS

{
    
    public class UserDTO {

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CompanyId { get; set; }
        public long OvedId { get; set; }
        public long IdNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Leda { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public byte[] LastChange { get; set; }
        public CompanyDTO Company { get; set; }
        public List<UserLoginDTO> Logins { get; set; }
        public List<EmpDTO> Emps { get; set; }
    }

}